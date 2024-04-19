using System;
using System.Drawing;

namespace s3_pr_cw
{
    [Serializable()]
    public class Employee
    {
        public string Name;
        public string Type;
        public string Id;
        public Image Photo;

        public Employee()
            : this("", "", "")
        {

        }
        public Employee(string name, string type, string id)
        {
            Name = name;
            Type = type;
            Id = id;
        }

        public override string ToString()
            => $"{Id} {Type}";
    }
}
