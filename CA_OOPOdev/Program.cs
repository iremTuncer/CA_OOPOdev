using System;

namespace CA_OOPOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product newProduct = new Product();
            Console.WriteLine("Ürün Adı:");
            newProduct.ProductName = Console.ReadLine();
            Console.WriteLine("Ürün fiyat:");
            newProduct.UnitPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ürün stok:");
            newProduct.UnitsInStock = short.Parse(Console.ReadLine());
            Console.WriteLine("Kategori:");
            newProduct.CategoryName = Console.ReadLine();
            Console.WriteLine("Tedarikçi:");
            newProduct.SupplierName = Console.ReadLine();

            Console.WriteLine($"Ürün adı:{newProduct.ProductName } Fiyatı:{newProduct.KDVDahil}");






        }
    }
}
