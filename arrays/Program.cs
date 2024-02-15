string[] courseName = ".NET 8 Programming Lessons".Split(" ");

System.Console.WriteLine("Course name : " + courseName[0]);

string[] nameArray = { "John", "Doe", "Jane", "Dane" };

string[] courseNameArray = new string[] {};


for (int i = 0; i < courseName.Length; i++){
    courseNameArray.Append(courseName[i]);
}

int[] studentNumbers = {0,1,2,3};

for (int i = 0; i < studentNumbers.Length; i++){
    System.Console.WriteLine($"The number of student {nameArray[i]} is {studentNumbers[i]}");
}
