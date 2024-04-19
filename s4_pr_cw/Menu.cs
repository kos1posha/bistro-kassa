using System;
using System.Collections.Generic;

namespace s3_pr_cw
{
    [Serializable()]
    public class Menu
    {
        public string Name;
        public Product[] Products = new Product[25];
        public bool IsFull
        {
            get
            {
                foreach (Product product in Products)
                    if (product.IsEmpty)
                        return false;
                return true;
            }
        }

        public Menu()
        {
            for (int i = 0; i < 25; i++)
                Products[i] = new Product();
        }
        public Menu(string name)
            : this()
        {
            Name = name;
        }
        public Menu(string name, Dictionary<int, Product> products)
        {
            Name = name;
            for (int i = 0; i < 25; i++)
                if (products.ContainsKey(i))
                    Add(products[i], i);
                else
                    Add(new Product(), i);
        }

        public void Add(Product product, int i)
            => Products[i] = product;
        public void Remove(Product product)
        {
            for (int i = 0; i < 25; i++)
                if (product.Equals(Products[i]))
                    Products[i] = new Product();
        }

        public void CountToOne()
        {
            foreach (Product product in Products)
                product.CountInOrder = 1;
        }

        public override string ToString()
            => Name;
    }
}
