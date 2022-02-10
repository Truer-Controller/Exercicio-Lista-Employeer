using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TreinoLista
{
    class Employees
    {
        public int IdEmployee { get; set; }
        public string NameEmployee { get; set; }
        public double SalaryEmployee { get; private set; }

        public Employees(int idEmployee, string nameEmployee, double salaryEmployee)
        {
            IdEmployee = idEmployee;
            NameEmployee = nameEmployee;
            SalaryEmployee = salaryEmployee;
        }
        public void IncreaseSalary(double percentage)
        {
            SalaryEmployee += SalaryEmployee * percentage / 100.0;
        }
        public override string ToString()
        {
            return IdEmployee
                + ", "
                + NameEmployee
                + ", "
                + SalaryEmployee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
