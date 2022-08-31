using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPMinggu2Vol2
{
    internal class Owner : Person
    {
        private int hasCompany;

        public Owner(string firstName, string lastName, string email, DateTime brithday, int hasCompany ) : base(firstName, lastName, email, brithday)
        {
            SocialNumber = new Random().Next(2000, 2200);
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Brithday = brithday;
            this.HasCompany = hasCompany;
        }

        public int HasCompany { get => hasCompany; set => hasCompany = value; }

        public override string? ToString()
        {
            return $"{base.ToString() }| HasCompany : { this.hasCompany}";
        }

        public override decimal TotalIncome(Dictionary<string, decimal> data)
        {
            var totalIncome = 0m;
            foreach (var item in data)
            {
                totalIncome += item.Value;
            }

            return totalIncome;
        }
    }
}
