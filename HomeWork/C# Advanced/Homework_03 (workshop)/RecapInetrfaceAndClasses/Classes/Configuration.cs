using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using RecapInetrfaceAndClasses.Interfaces;
using static RecapInetrfaceAndClasses.Enums.Enums;

namespace RecapInetrfaceAndClasses
{     
    public abstract class Item 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }  
    }

    public class Part : Item, IPrice
    { 
        public double GetPrice()
        {
            return Price;
        } 
    }

    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>(); 

        public Module()
        {

        }

        public Module(string name)
        {
            Name = name;
        }

        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part); 
        } 
        
        public double GetPrice()
        {
            
            double sum = 0;
            foreach (var item in _parts)
            {
                double fullSum = item.Price * item.Quantity;
                sum += fullSum;
            }
            return sum; 
        }

        public void SetDiscount(double discount)
        {
            if (discount > 100 && discount < 0)
            {
                Console.WriteLine("Please insert value from 0 to 100");
                this.Discount = 0.0;
            }
            else
            {
                this.Discount = discount / 100;
            }
        }

        public double GetPriceWithDiscount()
        { 
            return GetPrice() * (1 - Discount);
        }

        public void RemovePartFromModule(Part partToRemove)
        {
            _parts.Remove(partToRemove);
        }
    }

    public class Configuration : Item, IPrice, IDiscont
    {
        public Colors BoxColor { get; set; }
        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();

        public Configuration()
        {

        }
        public Configuration(Colors boxColor)
        { 
            BoxColor = boxColor;
        }

        public void AddPartToProduct(Part part, int quantity = 1)
        {
           
            part.Quantity = quantity;
            _parts.Add(part);

        }

        public void AddModuleToProduct(Module module, int quantity = 1)
        {
            
            module.Quantity = quantity;
            _modules.Add(module);
        }
         
        public double GetPrice()
        {
            double sum = 0;

            foreach (var item in _parts)
            {
                double fullPartSum = item.Price * item.Quantity;
                sum += fullPartSum;
            }

            foreach (var item in _modules)
            {
                double fullModuleSum = item.GetPrice() * item.Quantity;
                sum += fullModuleSum;
            }

            return sum;    
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }

        public void SetDiscount(double discount)
        {
            if (discount > 100 && discount < 0)
            {
                Console.WriteLine("Please insert value from 0 to 100");
                this.Discount = 0.0;
            }
            else
            {
                this.Discount = discount / 100;
            }
        }
    }
}
