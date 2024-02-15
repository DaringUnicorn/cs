// Dizi Uygulana
// ogrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle
//doldurunuz. (3 öğrenci)
// ogrenciler dizisi kaç elemanlıdır, yazdırınız.
// ilk 2 öğrencinin ad ve not bilgisini yazdırınız.
// tün öğrencilerin not ortalanası nedir?

string[] students = new string[3];

int[] grades = new int[3];


for(int i = 0; i < students.Length; i++){

    System.Console.WriteLine("enter a student name: ");
    string? student = System.Console.ReadLine();
    System.Console.WriteLine("enter a student grade: ");
    int grade = Convert.ToInt32(System.Console.ReadLine());
    students[i] = student;
    grades[i] = grade;  
}

for(int i = 0; i < students.Length; i++){
    System.Console.WriteLine($"student name : {students[i]}, student grade : {grades[i]}");
}





