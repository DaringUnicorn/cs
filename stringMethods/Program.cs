using System;


string sentence = "  The quick brown fox jumps over the lazy dog  ";

int index = sentence.IndexOf("fox");
Console.WriteLine("Index of fox word : " + index);

int length = sentence.Length;
Console.WriteLine("Length of sentence : " + length);

string lowerCaseSentence = sentence.ToLower();
Console.WriteLine("Lower case sentence : " + lowerCaseSentence);

string upperCaseSentence = sentence.ToUpper();
Console.WriteLine("Upper case sentence : " + upperCaseSentence);

string trimmedSentence = sentence.Trim();
Console.WriteLine("Trimmed sentence : " + trimmedSentence);

string replacedSentence = sentence.Replace("fox","coyote");
Console.WriteLine("Replaced sentence : " + replacedSentence);

var splittedSentence = sentence.Split(" ");
for (int i = 0; i < splittedSentence.Length; i++){
    Console.WriteLine(splittedSentence[i]);
}

bool startsWith = sentence.StartsWith("The");
Console.WriteLine("Starts with The : " + startsWith);

bool endsWith = sentence.EndsWith("dog");
Console.WriteLine("Ends with dog : " + endsWith);

bool contains = sentence.Contains("fox");
Console.WriteLine("Contains fox : " + contains);

string substring = sentence.Substring(4, 10);
Console.WriteLine("Substring : " + substring);
