using static System.Console;
using OPPMinggu2Vol2;

/*Person yuli = new Customer("Yuli", "Ayu", "Ayuyuli028@gmail.com", new DateTime(1998, 07, 24),"131-001");
Customer rini = new Customer("Rini", "Sabyan", "Dios@gmail.com", new DateTime(1999, 03, 14), "131-003");
Customer widi = new Customer("Widi", "Amalia", "Widi@gmail.com", new DateTime(1999, 09, 30), "131-002");

var listCustomer = new List<Person> { yuli, widi, rini};


var incomeYuli = new Dictionary<string, decimal> {
    {"Kontrakan ", 10_000_000 },
    {"Toko",100_000_000 }
};
//yuli.TotalIncome(incomeYuli);
yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);

var incomeWidi = new Dictionary<string, decimal> {
    {"Kosan ", 20_000_000 },
    {"Jual Online ",6_000_000 }
};
widi.TotalRevenue = widi.TotalIncome(incomeWidi);

var incomeWRini= new Dictionary<string, decimal> {
    {"Supermarket ", 50_000_000 },
    {"Rental Mobil ",40_000_000 }
};
rini.TotalRevenue = rini.TotalIncome(incomeWRini);
//yuli.TotalIncome();

foreach (var item in listCustomer)
{
    WriteLine(item.ToString());
}

WriteLine("---------------------------Revenue Highest--------------------------------------------");
var listHigthest = listCustomer.Where(c => c.TotalRevenue >= 50_000_000).ToList();
foreach (var item in listHigthest)
{
    WriteLine(item.ToString());
}

WriteLine("---------------------------Revenue Max and Min Revenue----------------------------------");
var ListMax = listCustomer.Max(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue :{ListMax}");

var listMin = listCustomer.Min(x => x.TotalRevenue);
WriteLine($"Cust Max Revenue :{listMin}");
WriteLine("---------------------------lOWER THAN MAX-----------------------------------------");

var listLessThanMax = listCustomer.Where(x => x.TotalRevenue < ListMax);
foreach (var item in listLessThanMax)
{
    WriteLine(item.ToString());
}


WriteLine("---------Select----------------");
var query = listCustomer.Select(cust =>
    new // MEMBUAT OBJECT BARU
    {
        FullName = cust.FirstName+" "+cust.LastName,
        Email = cust.Email,
        TotalRevenue = cust.TotalRevenue
    }
);
foreach (var item in query)
{
    WriteLine(item);
}
*/

/*WriteLine("---------------------------LinQ--------------------------------------------");
LinQ.IntroLinq();
*/


WriteLine("============================================List Of Ower===============================================");
Person own1 = new Owner("Yuli","Cantik","Ayuyuli028@gmail.com",new DateTime(1998,07,24),7);
Owner Owner1 = new Owner("Thalia", "Indah", "ThaliaIndah@gmail.com", new DateTime(1998, 09, 14), 90);
/*Owner Owner2 = new Owner("Heru", "Ardiansyah", "HeruHero@gmail.com", new DateTime(1998, 01, 14), 100);
Owner Owner3 = new Owner("Nicolas", "Saputra", "NicolaSaputra@gmail.com", new DateTime(1993, 07, 24), 90);
Owner Owner4 = new Owner("Michael", "Wiliam", "MichaelWiliam@gmail.com", new DateTime(1997,09 , 20), 90);*/

var ListOfOwner = new List<Person> { own1,Owner1 };



var incomewn1= new Dictionary<string, decimal> {
    {"Toko Baju Bekas ", 10_000_000 },
    {"Toko Kelingking cicak",100_000_000 }
};
//yuli.TotalIncome(incomeYuli);
own1.TotalRevenue = own1.TotalIncome(incomewn1);

var incomeOwner1 = new Dictionary<string, decimal> {
    {"Kosan Biasa ", 20_000_000 },
    {"Admin Slot ",6_000_000 }
};
Owner1.TotalRevenue = Owner1.TotalIncome(incomeOwner1);


foreach (var item in ListOfOwner)
{
    Console.WriteLine(item.ToString());
}

