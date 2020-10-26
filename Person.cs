using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261027_w07
{
    class Person
    {
        private string name;
        private string lastname;
        private int salary;
        private int workedYear;
        private int intentYearlyActivity;
        private double assessedFromAdmin;

        public Person() { }

        public Person(string n, string ln, int s, int w, int i, double a)
        {
            this.Name = n;
            this.Lastname = ln;
            this.Salary = s;
            this.WorkedYear = w;
            this.IntentYearlyActivity = i;
            this.AssessedFromAdmin = a;
        }

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Salary { get => salary; set => salary = value; }
        public int WorkedYear { get => workedYear; set => workedYear = value; }
        public int IntentYearlyActivity { get => intentYearlyActivity; set => intentYearlyActivity = value; }
        public double AssessedFromAdmin { get => assessedFromAdmin; set => assessedFromAdmin = value; }
        protected double assessMark()
        {
            double assessMark = 0;
            return assessMark;
        }

        public override string ToString()
        {
            return this.Name + " " +
                this.Lastname + " " + "Salary " +
                this.Salary + " ";
        }
    }
}
