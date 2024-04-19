using System;

namespace s3_pr_cw
{
    [Serializable()]
    public class Cashbox
    {
        public string KKT;
        public Employee CurrentEmployee;

        public Cashbox(string kkt)
        {
            KKT = kkt;
        }

        public string GetChequeStatement()
            => $"Кассир: {CurrentEmployee.Name}\nКод ККТ: {KKT}";
    }
}
