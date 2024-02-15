System.Console.WriteLine("enter your name");
string? name = System.Console.ReadLine();

System.Console.WriteLine("enter your surname"); 
string? surname = System.Console.ReadLine();

System.Console.WriteLine("enter your age");
string? age = System.Console.ReadLine();

string sentence = "Hello my name is " + name + " " + surname + " and I am " + age + " years old";
System.Console.WriteLine(sentence);

string sentence2 = string.Format("Hello my name is {0} {1} and I am {2} years old.", name, surname, age);

System.Console.WriteLine(sentence2);

string sentence3 = $"Hello my name is {name} {surname} and I am {age} yeras old.";

System.Console.WriteLine(sentence3);