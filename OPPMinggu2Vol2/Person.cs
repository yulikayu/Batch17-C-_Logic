using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPMinggu2Vol2
{
    internal abstract class Person //klik ctrl + (.) untuk memunculkan *satu
    {
        //instanvariabel
        private int socialNumber;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime brithday;
        private decimal totalRevenue;

        //satu //construktor
        protected Person( string firstName, string lastName, string email, DateTime brithday)
        {
        
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.brithday = brithday;
        }


        //Untuk mendapatkan get set, blok pada semua instan variable dan klik kanan, pilih encaptulation field ke dua
        public int SocialNumber { get => socialNumber; set => socialNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Brithday { get => brithday; set => brithday = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }

        //klik ctrl +(.) disini untuk memunculkan *dua

        //dua
        public override string? ToString()
        {
            return $"SocialNumber : {this.socialNumber} | FullName :{this.firstName}  {this.lastName} |Email :{this.email} | Birthday :{this.brithday} Revenue :{this.totalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }

        public abstract decimal TotalIncome(Dictionary<string, decimal> data);
    }
}
