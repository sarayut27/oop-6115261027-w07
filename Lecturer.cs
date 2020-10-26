using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261027_w07
{
    class Lecturer : Person
    {
        private double quality;
        private double numProject;
        private double numResearch;

        public double Quality { get => quality; set => quality = value; }
        public double NumProject { get => numProject; set => numProject = value; }
        public double NumResearch { get => numResearch; set => numResearch = value; }

        public Lecturer(string n, string ln, int s, int w, int i, double a, double q, double np, double nr)
        {
            this.Name = n;
            this.Lastname = ln;
            this.Salary = s;
            this.WorkedYear = w;
            this.IntentYearlyActivity = i;
            this.AssessedFromAdmin = a;
            this.quality = q;
            this.numProject = np;
            this.numResearch = nr;
        }

        public double calculateSalaryRaise()
        {
            double score = this.IntentYearlyActivity + this.Quality + this.NumProject + this.NumResearch + this.AssessedFromAdmin;
            double salaryRaise = 0;

            if (score < 70)
            {
                return 0;
            }
            else if (score <= 80)
            {
                salaryRaise = Salary * 0.01;
            }
            else if (score <= 85)
            {
                salaryRaise = Salary * 0.02;
            }
            else if (score <= 90)
            {
                salaryRaise = Salary * 0.025;
            }
            else if (score > 90)
            {
                salaryRaise = Salary * 0.03;
            }
            return salaryRaise;
        }

        public override string ToString()
        {
            return base.ToString() + "Salary Raise for Lecturer : " +
                this.calculateSalaryRaise();
        }
    }
}
