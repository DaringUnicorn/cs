string[] cities = {"istanbul", "ankara", "izmir", "bursa", "adana"};

var sliced = cities[0..3];

foreach(var city in sliced){

    Console.WriteLine(city);

}
System.Console.WriteLine(".......................");
foreach(var city in cities[1..^1]){

    Console.WriteLine(city);

}