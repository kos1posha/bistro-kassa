using System;
using System.Collections.Generic;

namespace s3_pr_cw
{
    [Serializable()]
    public class Restaurant
    {
        public string Name;
        public string Organization;
        public string Address;
        public Cashbox ThisCashbox;

        public List<Menu> MenuList { get; set; } = new List<Menu>();
        public List<Employee> EmployeeList { get; set; } = new List<Employee>();

        public Restaurant()
            : this("", "", "")
        {

        }
        public Restaurant(string restaurantName, string organizationName, string address)
        {
            Name = restaurantName;
            Organization = organizationName;
            Address = address;
        }
        public Restaurant(string restaurantName, string organizationName, string address, List<Menu> menusList, Cashbox currentCashbox, List<Employee> employeesList)
            : this(restaurantName, organizationName, address)
        {
            MenuList = menusList;
            ThisCashbox = currentCashbox;
            EmployeeList = employeesList;
        }

        public string GetChequeStatement()
            => $"Организация: {Organization}\nРесторан: {Name}\nАдрес: {Address}";
    }
}
