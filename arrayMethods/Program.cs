string[] cities = {"istanbul", "ankara", "izmir", "bursa", "adana"};
int[] numbers = {1,4,6,83,4,7,648,9,54,8,846,64};
cities[0] = "sakarya";
cities.SetValue("konya", 2);


System.Console.WriteLine(cities[0]);
System.Console.WriteLine(cities[2]);
System.Console.WriteLine(cities.GetValue(2));
System.Console.WriteLine("the number of elements in cities array : " + cities.Length);
System.Console.WriteLine("index of bursa : " + Array.IndexOf(cities, "bursa"));

string[] sortedArray = (string[])cities.Clone();

Array.Sort(sortedArray);

foreach(string city in sortedArray){
    System.Console.WriteLine(city);
}

Array.Reverse(numbers);

foreach(int number in numbers){
    System.Console.WriteLine(number);
}