using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba_4
{
    public class Outfit
    {
        public Jacket Jacket { get; set; }
        public Shirt Shirt { get; set; }
        public Pants Pants { get; set; }
        public Footwear Footwear { get; set; }

        public void AddToOutfit(object obj)
        {
            if (obj is Jacket)
            {
                this.Jacket = (Jacket)obj;
            }
            else if (obj is Shirt)
            {
                Shirt = (Shirt)obj;
            }
            else if (obj is Pants)
            {
                Pants = (Pants)obj;
            }
            else if (obj is Footwear)
            {
                Footwear = (Footwear)obj;
            }
            else
            {
                throw new Exception("This is not a clothes");
            }
        }
        public void WearOutfit()
        {
            Console.WriteLine($"You are wearing:");
            if (Jacket != null) Console.WriteLine("\t" + Jacket.ToString());
            if (Shirt != null) Console.WriteLine("\t" + Shirt.ToString());
            if (Pants != null) Console.WriteLine("\t" + Pants.ToString());
            if (Footwear != null) Console.WriteLine("\t" + Footwear.ToString());

        }
    }
    public class Clothes
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"Brand == {Brand} && Color == {Color} && Price == {Price}" ;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Clothes clothes)
            {
                return Brand == clothes.Brand && Color == clothes.Color && Price == clothes.Price;
            }
            return false;
        }

        

    }
    public class Jacket : Clothes
    {
        public string Size { get; set; }
        public override string ToString()
        {
            return $"Jacket Brand == {Brand} && Color == {Color} && Price == {Price} && Size == {Size}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Jacket jacket)
            {
                return Brand == jacket.Brand && Color == jacket.Color && Price == jacket.Price && Size ==jacket.Size;
            }
            return false;
        }
    }
   
    public class Shirt : Clothes
    {
        public string Material { get; set; }
        public override string ToString()
        {
            return $"Shirt Brand == {Brand} && Color == {Color} && Price == {Price} && Material == {Material}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Shirt shirt)
            {
                return Brand == shirt.Brand && Color == shirt.Color && Price == shirt.Price && Material == shirt.Material;
            }
            return false;
        }
    }
    public class Pants : Clothes
    {
        public string Kind { get; set; }
        public override string ToString()
        {
            return $"Pants Brand == {Brand} && Color == {Color} && Price == {Price} && Kind == {Kind}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Pants trousers)
            {
                return Brand == trousers.Brand && Color == trousers.Color && Price == trousers.Price && Kind == trousers.Kind;
            }
            return false;
        }

    }
    public class Footwear : Clothes
    {
        public string Material { get; set; }
        public double Size { get; set; }
        public override string ToString()
        {
            return $"Footwear Brand == {Brand} && Color == {Color} && Price == {Price} && Material == {Material} && Size =={Size}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Footwear footwear)
            {
                return Brand == footwear.Brand && Color == footwear.Color && Price == footwear.Price && Material == footwear.Material;
            }
            return false;
        }

    }
}
