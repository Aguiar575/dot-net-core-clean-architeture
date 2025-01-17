﻿using System;
using System.Collections.Generic;
using Shop.Domain.Entities;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Context;

namespace Shop.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
