string courseName = ".NET 8 ile C# Programming Language";
// 1- kaç karaktere sahiptir
// 2- hepsini kğçük harfe çevirin
// 3- büyük harfe çevirin
// 4- '.' ile mi başlıyor?
// 5- C# bilgisi hangi index'te bulunmaktadır?
// 6- String C# içeriyor mu?
// 7- 'Language' yerine "Lessons" yazınız


int length = courseName.Length;
System.Console.WriteLine("Length of the sentence : " + length);

string lowerCaseSentence = courseName.ToLower();
System.Console.WriteLine("Lower case sentence : " + lowerCaseSentence);

string upperCaseSentence = courseName.ToUpper();
System.Console.WriteLine("Upper case sentence : " + upperCaseSentence);

bool isStartingWithDot = courseName.StartsWith(".");
System.Console.WriteLine("Is starting with dot : " + isStartingWithDot);

int indexOfCSharp = courseName.IndexOf("C#");
System.Console.WriteLine("Index of C# is " + indexOfCSharp);

bool isContainingCSharp = courseName.Contains("C#");
System.Console.WriteLine("Is containing C# : " + isContainingCSharp);

string replacedSentence = courseName.Replace("Language", "Lessons");
System.Console.WriteLine("Replaced sentence : " + replacedSentence);




