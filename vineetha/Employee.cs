using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Employee
    {
        
        public int Eid { get; set; }
        
        public string EmpName { get; set; }
        
        public string EAddress { get; set; }
        
        public string ECity { get; set; }
        
        public string EDept { get; set; }
        
        public double ESalary { get; set; }

        

    }

    public class ContractEmployee : Employee
    {
        private int perks;
        public void GetSalary(double ESalary, int perks)
        {
            ESalary = ESalary + perks;
            Console.WriteLine("Employee Salary- " + ESalary);
        }

        


         
    }

    public class PermanentEmployee : Employee
    {
        public int NoOFLeaves { get; set; }
        public int ProvidentFund { get; set; }

        public void GetSalary(double ESalary, double ProvidentFund)
        {
            
            Console.WriteLine("Employee Salary- " + (ESalary - ProvidentFund));

        }
    }
}
