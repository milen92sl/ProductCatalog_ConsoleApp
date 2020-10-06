using System;
using System.Collections.Generic;
using System.Text;
using ConsoleTables;
using ProductCatalog.Core.Contracts;
using ProductCatalog.Utils;
using ProgramCatalog.Infrastructure.Data.Model;

namespace ProductCatalog.Pages
{
    public class ProductPage
    {
        private readonly IProductService productService;

        public ProductPage(IProductService _productService)
        {
            productService = _productService;
        }

        public void Show(Menu menu)
        {
            bool running = true;

            while (running)
            {
                running = menu.ProductMenu();
            }
        }

        public void List()
        {
            var products = productService.GetProducts();

            ConsoleTable.From(products)
                .Configure(o => o.NumberAlignment = Alignment.Right)
                .Write();
        }

        public void Add()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            string quantity = Console.ReadLine();
            Console.Write("Price");
            string price = Console.ReadLine();

            try
            {
                Product product = new Product()
                {
                    Name = name,
                    Price = int.Parse(price),
                    Quantity = int.Parse(quantity)
                };
                productService.Save(product);

                Console.WriteLine("Product added successfully.");
            }
            catch (Exception )
            {
                Console.WriteLine("Product not added.");
            }
        }
    }
}
