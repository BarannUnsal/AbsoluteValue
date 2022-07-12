Console.WriteLine("Lütfen sayılar giriniz(boşluk bırakarak):");
Console.WriteLine("*********************");
Console.WriteLine("Sayılar 67'den küçükse farkı, büyükse mutlak karelerinin toplamı!!");
string[] sayilar = Console.ReadLine().Split();
List<int> less = new List<int>();
List<int> greater = new List<int>();
foreach (string s in sayilar)
{
    int sayi = int.Parse(s);
    if (sayi < 67)    
        less.Add(67 - sayi);
    
    else    
        greater.Add(sayi - 67);
    
}
int lessPlus = 0, greaterPlus = 0;
foreach (var item in less)
    lessPlus += item;
foreach (var item in greater)
    greaterPlus += item * item;
Console.WriteLine(lessPlus + " " + greaterPlus);