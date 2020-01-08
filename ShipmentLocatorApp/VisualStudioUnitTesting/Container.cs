using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioUnitTesting
{
    public class Container : ICloneable
    {
        public string ContainerNumber { get; set; }
        public string ShipNumber { get; set; }
        public double Weight { get; set; }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }    
}
