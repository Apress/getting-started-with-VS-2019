using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioUnitTesting
{
    public enum ContainerClass : int { TwentyFoot = 20, FourtyFoot = 40 }
    public enum FeeExempt : int { No = 0, Yes = 1, Variable = 3 }

    public class ContainerShip
    {
        private const double MIN_WEIGHT = 25.50;
        public string ShipNumber { get; set; } = "DEFAULT_TEMP_1";
        public double MaxWeight { get; private set; }
        public List<Container> Containers { get; set; }

        public ContainerShip(double maxWeight = 0.0)
        {
            MaxWeight = maxWeight == 0.0 ? MIN_WEIGHT : maxWeight;
            Containers = new List<Container>();
        }
        public bool ShipOverweight()
        {
            var totalContainerWeight = Containers.Sum(container => container.Weight);
            return totalContainerWeight > MaxWeight;
        }

        public List<Container> RemoveHeaviestContainer()
        {
            return Containers.Where(container
                => container.Weight != Containers.Max(y
                => y.Weight)).ToList();
        }

        public List<Container> ReturnHeaviestContainer()
        {
            return Containers.Where(container
                => container.Weight == Containers.Max(y
                => y.Weight)).ToList();
        }

        public double CalculateHarborFee(ContainerClass containerClass, FeeExempt exempt)
        {
            var container = ReturnHeaviestContainer();
            var weight = container.FirstOrDefault().Weight;
            var harborFee = 0.0;

            if (exempt != FeeExempt.Yes)
            {
                switch (containerClass)
                {
                    case ContainerClass.TwentyFoot:
                        harborFee = weight / (int)containerClass;
                        break;
                    case ContainerClass.FourtyFoot:
                        harborFee = (weight / (int)containerClass) * 45750;
                        if (exempt == FeeExempt.Variable)
                        {
                            if (harborFee > 150000) { harborFee = harborFee / 2; }
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                harborFee = weight * 1000;
            }

            return harborFee;
        }

        //public bool ShipOverweight(double maxweightOverride)
        //{
        //    MaxWeight = maxweightOverride;            
        //    return ShipOverweight();
        //}

        //public bool ShipOverweight(double[] containerWeights)
        //{
        //    var totalContainerWeight = containerWeights.Sum();
        //    return totalContainerWeight > MaxWeight;
        //}
    }


    public class Calculate
    {
        public enum ShippingType { Overnight = 0, Priority = 1, Standard = 2 }

        private const double VOLUME_FACTOR = 0.75;
        //private const double MIN_WIDTH = 1.5;
        //private const double MIN_LENGTH = 2.5;
        //private const double MIN_HEIGHT = 0.5;
                
        public double ShippingCost(double length, double width, double height, ShippingType type)
        {
            //if (length <= 0.0) length = MIN_LENGTH;
            //if (width <= 0.0) width = MIN_WIDTH;
            //if (height <= 0.0) height = MIN_HEIGHT;
            var volume = length * width * height;
            var cost = volume * VOLUME_FACTOR;

            switch (type)
            {
                case ShippingType.Overnight:
                    cost = cost * 2.25;
                    break;
                case ShippingType.Priority:
                    cost = cost * 1.75;
                    break;
                case ShippingType.Standard:
                    cost = cost * 1.05;
                    break;
                default:
                    break;
            }
                        
            return cost;
        }
    }




    public class ShipFreight
    {
        public void CalculateFreightCosts(IShippable box)
        {

        }
    }

    class Crate : IShippable
    {
        public bool CustomsCleared { get; }
    }

    class Package : IShippable
    {
        public bool CustomsCleared { get; }
    }

    public interface IShippable
    {
        bool CustomsCleared { get; }
    }

    
}
