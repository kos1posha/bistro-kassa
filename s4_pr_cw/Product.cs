using System;
using System.Drawing;

namespace s3_pr_cw
{
    [Serializable()]
    public class Product
    {
        public int CountInOrder;
        public string Name;
        public int Weight;
        public int VAX;
        public decimal Price;
        public Color Color;
        public Image Image;
        public decimal TotalPrice => Price * (1 + VAX / 100m);
        public bool IsEmpty => Equals(null) || Equals(new Product()) || Name == "";


        public Product()
        {
            CountInOrder = 1;
            Name = "";
            Weight = 0;
            VAX = 20;
            Price = 0;
            Color = Color.LightGray;
        }
        public Product(string name, int weight, decimal price)
            : this()
        {
            Name = name;
            Weight = weight;
            Price = price;
        }
        public Product(string name, int weight, int vax, decimal price, Color color, Image image)
            : this(name, weight, price)
        {
            VAX = vax;
            Color = color;
            Image = image;
        }

        public string GetChequeStatement(int count)
            => $"{Name}".PadLeft(20) + $"{TotalPrice} руб".PadLeft(15) + $"{count}".PadLeft(12) + $"{TotalPrice * count} руб".PadLeft(15) + $"{VAX}%".PadLeft(5) + "\n";

        public override string ToString()
        {
            int count = CountInOrder;
            return $"{Name}\n{count} шт\n{count * TotalPrice} руб";
        }
    }
}
