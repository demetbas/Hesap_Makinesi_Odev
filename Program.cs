// See https://aka.ms/new-console-template for more information

double sayi1, sayi2, sonuc;

char islem;

Console.WriteLine("Birinci Sayıyı Giriniz");

sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci Sayıyı Giriniz");

sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İşlem Seçiniz");

islem = Convert.ToChar(Console.ReadLine());

switch (islem)
{ 
	case '+':
	sonuc = sayi1 + sayi2;
    Console.WriteLine("İşlem sonucu:" + sonuc);
    break;

	case '-':
    sonuc = sayi1 - sayi2;
    Console.WriteLine("İşlem sonucu:" + sonuc);
    break;

    case '*':
    sonuc = sayi1 * sayi2;
    Console.WriteLine("İşlem sonucu:" + sonuc);
    break;

    case '/':
    sonuc = sayi1 / sayi2;
    Console.WriteLine("İşlem sonucu:" + sonuc);
    break;
    
   
}

