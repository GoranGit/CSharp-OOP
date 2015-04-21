
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;
    public class AdjustableChair : Chair, IAdjustableChair,IChair,IFurniture
    {
        
        public AdjustableChair(string model, decimal price, decimal height, string material, int numberOfLegs):base(model, price, height, material, numberOfLegs)
        {       
        }
       
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
