﻿using System;
using System.Collections.Generic;
using System.Text;
using ProgramCatalog.Infrastructure.Data.Model;

namespace ProductCatalog.Core.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        void Save(Product product);



    }
}
