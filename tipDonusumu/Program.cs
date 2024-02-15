using System;
using System.Security.Cryptography.X509Certificates;

Console.Write("Enter number 1 : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());  

var toplam = number1 + number2;

Console.WriteLine("Total : " + toplam);


int a = 10;
long b = a;


long d = 20;
int e = (int)d;

double f = 20.5;
float g = (float)f;


double h = 10.5;
int i = (int)h;


System.Console.WriteLine("integer : " + i);

int x = 10;
string z = x.ToString();

System.Console.WriteLine("string : " + z);


// nullable

int? maas = null;

System.Console.WriteLine(maas.HasValue);
System.Console.WriteLine(maas.GetValueOrDefault());