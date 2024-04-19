using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace s3_pr_cw
{
    [Serializable()]
    public class Order
    {
        public Dictionary<Product, int> Products = new Dictionary<Product, int>();
        static int _counter = 1;
        public int Number;
        public int NapkinsCount;
        public bool Issue;
        public string Time;
        public string EndTime;
        public string Note;
        public OrderStatus Status;
        public PaymentMethod Payment;
        public decimal СontributedFunds;
        public decimal Cost
        {
            get
            {
                decimal value = 0;
                foreach (Product product in Products.Keys)
                    value += product.TotalPrice * Products[product];
                value += (NapkinsCount * 10);
                if (Payment == PaymentMethod.Cash)
                    return Math.Floor(value);
                else
                    return value;
            }
        }
        public decimal Change => Math.Floor(СontributedFunds - Cost);

        public Order()
        {
            EndTime = "-";
            Note = "Примечание отсутствует";
            Status = OrderStatus.Preparing;
            Payment = PaymentMethod.Noncash;
            Issue = false;
            NapkinsCount = 0;
            Number = _counter++;
        }

        public bool Add(Product product)
        {
            if (product.IsEmpty) return false;
            if (Products.ContainsKey(product))
            {
                product.CountInOrder = ++Products[product];
                return false;
            }
            else
            {
                Products.Add(product, 1);
                return true;
            }
        }
        public string GetNapkinsCount()
        {
            if (NapkinsCount != 0)
                return NapkinsCount.ToString();
            return "Нет";
        }
        public string GetIssue()
        {
            if (Issue)
                return "С собой";
            else
                return "В заведении";
        }
        public string GetStatus()
        {
            switch (Status)
            {
                case OrderStatus.Preparing: return "Готовится";
                case OrderStatus.Done: return "Готов";
                case OrderStatus.Cancelled: return "Отменен";
                case OrderStatus.Delete: return "Удален";
            }
            return "-";
        }
        public string GetPaymentMethod()
        {
            switch (Payment)
            {
                case PaymentMethod.Cash: return "Наличная оплата";
                case PaymentMethod.Noncash: return "Безналичная оплата";
            }
            return "-";
        }
        public string GetCheque()
        {
            string cheque = $"Кассовый чек №{Number}\nВремя: {Time}\n" +
                            $"{BistroKassa.ThisRestaurant.GetChequeStatement()}\n" +
                            $"{new string('*', 72)}\n" +
                             "Товар".PadLeft(20) + "Цена".PadLeft(15) + "Количество".PadLeft(12) + "Стоимость".PadLeft(15) + "НДС".PadLeft(5) + "\n";

            foreach (Product product in Products.Keys)
                cheque += product.GetChequeStatement(Products[product]);

            cheque += $"{new string('*', 72)}\n" +
                      $"{BistroKassa.ThisCashbox.GetChequeStatement()}\n" +
                      $"Способ оплаты: {GetPaymentMethod()}\nВнесенные средства: {СontributedFunds}\nСдача: {Change} руб\n";

            return cheque;
        }
        public void PrintCheque()
        {
            using (StreamWriter writer = new StreamWriter($"Чеки\\кассовый чек №{Number}.txt", false, Encoding.Default))
                writer.Write(GetCheque());
        }

        public override string ToString()
            => $"Заказ №{Number}";
    }
}