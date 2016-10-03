using System;

namespace _11_Files
{
    internal class SavingsAccount
    {
        private string v1;

        public SavingsAccount(string v1, double v2, double v3)
        {
            this.v1 = v1;
            value = v2;
            interestRate = v3;
        }
        private double interestRate;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public double value { get; set; }



        public override string ToString()
        {
            return "SavingsAccount[value=" + value.ToString("F1").Replace(',','.') + ",interestRate=" + interestRate.ToString().Replace(',', '.') + "]";
        }

        public double GetValue()
        {
            return value ;
        }

        internal void ApplyInterest()
        {
          value = value * (interestRate / 100 + 1);
        }

    }
}