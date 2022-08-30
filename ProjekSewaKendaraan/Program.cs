using static System.Console;
using System.Globalization;
//call class CAR
using ProjekSewaKendaraan.Kendaraan;

//CAR cr = new CAR("D 1001 UM", new DateTime(2015), "SUV", 0M);

//WriteLine(cr.ToString());
//CAR cr1 = new CAR("D 1001 UK",new DateTime(2016),300_000;

Console.WriteLine("=======================================List Kendaraan===================================================");
ICar carInterface = new CARlmpl();
var ListOfKendaraan = carInterface.InitDataCAR();
carInterface.showList(ref ListOfKendaraan);
Console.WriteLine();
Console.WriteLine("=======================================FIND CAR BY NOPOLISI===================================================");
var carr = carInterface.findCarByID(ListOfKendaraan, "D 1001 UM");
WriteLine($" KENDARAAN {carr}");
Console.WriteLine("=======================================Get Total Revenue===================================================");
var Total = carInterface.GetTotalRevenue(ListOfKendaraan);
carInterface.ShowTotalRevnue(Total);

Console.WriteLine("=======================================Total Kendaraan By type===================================================");
var ByType = carInterface.TotalcarByType(ListOfKendaraan);
carInterface.ShowTotalRevnueTy(ByType);




