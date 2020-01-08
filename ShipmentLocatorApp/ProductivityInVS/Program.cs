using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityInVS
{
    class Program
    {
        
        public string itemName { get; set; } //varchar] (50) NOT NULL, 
        public string category { get; set; } //varchar] (50) NOT NULL,  
        public string description { get; set; } //varchar] (50) NOT NULL,
        
        static void Main(string[] args)
        {
            var a = "The cat is lazy but the cat is awake";
            var b = "The cat is lazy but the cat is awake";
            var c = "The cat is lazy but the cat is awake";


            try
            {

            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);                
            }
        }


        
    }

    public static class Logger
    {
        public static void Log(string message)
        {

        }
    }
}
