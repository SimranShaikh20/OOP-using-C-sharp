using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymerphism
{
    public class EmployeeBonus
    {
        public class Bonus
        {
            public double CalculateBonus(int baseSalary)
            {
                return baseSalary * 0.10; // 10% bonus
            }
            public double CalculateBonus(int baseSalary, double percentage)
            {
                return baseSalary * (percentage / 100); 
            }
            public double CalculateBonus(int baseSalary, int yearsOfService)
            {
                double extraPercentage = yearsOfService * 0.02; 
                return baseSalary * (0.10 + extraPercentage); 
            }
        }
    }
}
