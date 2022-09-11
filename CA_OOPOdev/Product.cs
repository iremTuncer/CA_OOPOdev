using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOPOdev
{
    internal class Product
    {
        ArrayList productList = new ArrayList();

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }

        public decimal KDVDahil
        {
            get
            {
                return UnitPrice + (UnitPrice * 0.18m);
            }
        }

        public ArrayList GetProductList()
        {
            return productList;
        }

        public Product GetProductById(int id)
        {
            Product product = new Product();
            foreach (Product item in productList)
            {
                if (item.Id == id)
                {
                    product = item;
                    break;
                }
            }
            return product;
        }

        public string AddProduct(Product product)
        {
            product.Id = productList.Count + 1;
            productList.Add(product);
            return $"{product.ProductName} eklendi!";
        }

        public string UpdateProduct(Product updated)
        {
            Product guncellenecek = GetProductById(updated.Id);
            guncellenecek.ProductName = updated.ProductName;
            guncellenecek.UnitPrice = updated.UnitPrice;
            guncellenecek.UnitsInStock = updated.UnitsInStock;
            guncellenecek.CategoryName = updated.CategoryName;
            guncellenecek.SupplierName = updated.SupplierName;

            return "Ürün güncellendi!";

        }

        public string RemoveProduct(int id)
        {
            Product deleted = GetProductById(id);

            productList.Remove(deleted);
            return "Ürün silindi!";
        }
    }
}
