using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.fiyati = 80;
            product2.Aciklama = "Edirne karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)

            {

                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.fiyati);

            }


            Console.WriteLine("............Metotlar.........");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("Armut", "Güzel armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);

            sepetManager.Ekle2("Karpuz", "Edirne Karpuzu", 12);















        }
    }
}
