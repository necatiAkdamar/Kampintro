using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();//tanımladığımız metodu çağırdık.
            
            int res = Add2(25, 35);//metoda 2 parametre gönderdik ve dönen sonucu res e atadık.
            Console.WriteLine(res);

            Console.WriteLine(Multiply(3,5));
            Console.WriteLine(Multiply(3, 5, 8));

            Console.WriteLine("Değişken Sayıda Parametre İşlemi Params : "+ Add3(1, 2, 3, 4, 5, 6, 100));
        }

        static void Add()//Add isminde bir metot tanımladık
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int num1, int num2=100)//2 parametre isteyen bir metot tanımladık. 
         //Void yerine integer bir değer döndüreceğimiz için int yazdık. 
         //Eğer num2 ye değer girilmezse varsayılan değeri 100 kabul eder. Default değer sonda belirtilir.
        {
            var result = num1 + num2;
            return result;//sonucu dönder
        }

        static int Multiply(int number1, int number2)//Metotların imzası aynı isimli 2 metot
        {
            return number1 * number2; 
        }
        static int Multiply(int number1, int number2, int number3)//aynı isimle 2.metot tanımlayıp 3 sayıyı çarptık.
            //gönderilen parametler aynı isimli metotlardan hangisine uygunsa onu çalıştırır. Metotların imzası denir.
        {
            return number1 * number2 * number3;
        }

        static int Add3(params int[] numbers)//parametre sayısı değişen metotlarda params özelliği ile bir dizi içerisine gönderilen parametreler alınabilir.
        {
            int toplam = 0;
            foreach (var i in numbers)
            {
                toplam += i;
            }
            return toplam;
        }
    }
}
