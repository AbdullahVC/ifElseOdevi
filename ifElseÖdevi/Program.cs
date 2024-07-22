Console.WriteLine("Lütfen bir sayı gürünüz: ");
string input = Console.ReadLine();

// Sayısal işlem yapılacağı için string bir veriyi int'e çevirdik.
int number = Convert.ToInt32(input);

// Girilen Sayının 10'dan büyük mü, küçük mü veya eşitmi olduğunu bildiren döngü.
if (number == 10)
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}
else if (number > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}
else
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}

// Burada ise Sayının çift mi tek mi olduğu belirlenir.

if(number % 2 == 0)
{
    Console.WriteLine("Girilen sayı çiftir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}