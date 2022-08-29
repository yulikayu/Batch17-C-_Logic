using static System.Console;
using Day02;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Day02.ArrayCases.IntroArray();
//Call Method function

int[] n = { 10, 20, 30 };
var myArray = ArrayCases.IntArrayInt(n);
//rrayCases.TamppilArray(myArray);

var myRandom = ArrayCases.InitialArrayRandom(20);
ArrayCases.TamppilArray(myRandom);

WriteLine($"Total Sum Array = {ArrayCases.SumNumber(myRandom)}");

Console.WriteLine($"MaX Number Dari Array={ArrayCases.FindLargesElement(myRandom)}");

int[] newArray = new int[myRandom.Length];

for (int i = 0; i < myRandom.Length; i++)
{
    newArray[i] = myRandom[i];
}

Console.WriteLine();
ArrayCases.TamppilArray(newArray);

var RandomArray = new int[myRandom.Length];

Array.Copy(RandomArray, 0, RandomArray, 0, myRandom.Length);
Array.Reverse(RandomArray);

Console.WriteLine();
Console.WriteLine("ini My New Array");
ArrayCases.TamppilArray(newArray);