using laba_4;
using System.IO;
class Program
{
    static void Main()
    {
        Clothes outfit1 = new Clothes();
        Jacket bomber = new Jacket();
        Outfit summer = new Outfit();
        bomber.Brand = "Adidas";
        bomber.Size = "M";
        bomber.Color = "Brown";
        bomber.Price = 1200;
        summer.AddToOutfit(bomber);
        summer.WearOutfit();
    }
}