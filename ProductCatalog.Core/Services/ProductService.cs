﻿using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Core.Contracts;
using ProgramCatalog.Infrastructure.Data.Common;
using ProgramCatalog.Infrastructure.Data.Model;
using System.Linq;
namespace ProductCatalog.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repo;

        public ProductService(IRepository _repo)
        {
            repo = _repo;
        }
        public IEnumerable<Product> GetProducts()
        {
            return repo.All<Product>().AsEnumerable();
        }

        public void Save(Product product)
        {
            if (product.Id == 0)
            {
                repo.Add(product);
            }
            else
            {
                repo.Update(product);
            }

            repo.SaveChanges();
        }
    }
}
