/*
Uygulama 1: bir öğrencinin aşağıdaki bilgileri için gerekli değişkenleri oluşturunuz

    öğrenci adı 
    öğrenci soyadı
    öğrenci ad ve soyad
    öğrenci numarası
    öğrenci cinsiyet
    öğrenci tc kimlik
    öğrenci doğum yılı
    öğrenci adres bilgisi
    öğrenci yaşı

Uygulama 2: aşağıdaki ürünlerin toplam bilgisini hesaplayınız

    Ürün 1 = 50
    Ürün 2 = 60.5
    Ürün 3 = 356.45

*/


var name = "Ali";
var surname = "Veli";
var fullName = name + " " + surname;
var number = "1025";
var tc = "111111";
var dogumYili = 2004;
var yas = 2024 - dogumYili;

Console.WriteLine("Öğrenci Adı: " + name);
Console.WriteLine("Öğrenci Soyadı: " + surname);
Console.WriteLine("Öğrenci Tam Adı: " + fullName);
Console.WriteLine("Öğrenci Numarası: " + number);
Console.WriteLine("Öğrenci TC: " + tc);
Console.WriteLine("Öğrenci Doğum Yılı: " + dogumYili);
Console.WriteLine("Öğrenci Yaşı: " + yas);

var fiyatUrun1 = 50;
var fiyatUrun2 = 60.5;
var fiyatUrun3 = 356.45;
var toplam = fiyatUrun1 + fiyatUrun2 + fiyatUrun3;
Console.WriteLine("Toplam Fiyat: " + (fiyatUrun1 + fiyatUrun2 + fiyatUrun3));
Console.WriteLine("Toplam Fiyat: " + toplam);



