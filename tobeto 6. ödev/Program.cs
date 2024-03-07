using System;


//Length: Bir dizenin karakter sayısını döndürür.
string str = "Merhaba";
int length = str.Length; // length değeri 7 olacak
Console.WriteLine("String uzunluğu: " + length);

//ToUpper: Bir dizenin tüm karakterlerini büyük harfe dönüştürür.
string original = "hello";
string upperCase = original.ToUpper();
Console.WriteLine(upperCase); // Çıktı: HELLO


//ToLower: Bir dizenin tüm karakterlerini küçük harfe dönüştürür.
string deger = "HELLO";
string lowerCase = deger.ToLower();
Console.WriteLine(lowerCase); // Çıktı: hello


//Trim: Bir dizenin başındaki ve sonundaki boşlukları kaldırır.
string metin = "   Hello World   ";
string trimmed = metin.Trim();
Console.WriteLine(trimmed); // Çıktı: Hello World


//Substring: Belirtilen konumdan başlayarak belirtilen uzunluktaki bir alt dizeyi döndürür.
string text = "Merhaba dünya";
string sub = text.Substring(8, 5); // 8. indeksten başlayarak 5 karakter al
Console.WriteLine(sub); // Çıktı: dünya


//IndexOf: Belirli bir alt dizenin başlangıç konumunu döndürür.

int index = text.IndexOf("dünya");
Console.WriteLine(index); // Çıktı: 8


//Replace: Belirli bir karakter dizisiyle eşleşen tüm alt dizeleri başka bir dizeyle değiştirir.

string replaced = text.Replace("Merhaba", "Hello");
Console.WriteLine(replaced); // Çıktı: Hello dünya


//Split: Belirli bir ayırıcıyı kullanarak bir dizenin parçalarına böler ve bir dizi döndürür.
string metin2 = "Apple,Orange,Banana,Grape";
char[] separators = { ',' };
string[] fruits = metin2.Split(separators);
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}
