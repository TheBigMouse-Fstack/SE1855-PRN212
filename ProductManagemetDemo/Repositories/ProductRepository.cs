﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void SaveProduct(Product product) => ProductDAO.SaveProduct(product);
        public void DeleteProduct(Product product) => ProductDAO.DeleteProduct(product);
        public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);
        public List<Product> GetProducts() => ProductDAO.GetProducts();
        public Product GetProductById(int productId) => ProductDAO.GetProductById(productId);
    }
}
