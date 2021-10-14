using System;
using System.Linq;


namespace BABoostAssignment3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;
            int number6;

            int result1;
            int result2;
            int result3;
            int result4;
            int result5;
            int result6;

            bool match1=false;
            bool match2=false;
            bool match3=false;
            bool match4=false;
            bool match5=false;
            bool match6=false;

            string gameresultwin = "Lotoyu tutturdunuz!!!!!";
            string gameresultloss = "Üzgünüz kaybettiniz:(";
            

            Console.WriteLine("Lütfen 6 adet sayı giriniz:");
            Console.WriteLine("1.sayı:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3.sayı:");
            number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("4.sayı:");
            number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("5.sayı:");
            number5 = int.Parse(Console.ReadLine());
            Console.WriteLine("6.sayı:");
            number6 = int.Parse(Console.ReadLine());
            int[] numbers = { number1, number2, number3, number4, number5, number6 };
            for(int i=0; i<6; i++)
            {
                if (numbers[i] > 50 || numbers[i] < 0) {
                    Console.WriteLine("Lütfen 49 ile 0 arasında bir sayı seçiniz - Uygulamayı yeniden başlatın");
                    return;
                }
            }

            result1 = rnd.Next(1, 50);
            result2 = rnd.Next(1, 50);
            result3 = rnd.Next(1, 50);
            result4 = rnd.Next(1, 50);
            result5 = rnd.Next(1, 50);
            result6 = rnd.Next(1, 50);

            int[] results = { result1, result2, result3, result4, result5, result6 };
            
            bool[] matches = { match1, match2, match3, match4, match5, match6};
            bool[] key1 = { true, true, true, true, true, true }; 
            for (int i = 0; i < 6; i++) {
                if (results[i] == numbers[i])
                {
                    matches.SetValue(true, i);
                    
                }
                
            }

            Console.WriteLine("Seçtikleriniz {0}  ", string.Join("-",numbers));
            Console.WriteLine("Sonuç         {0}  ",string.Join("-",results));
            if (key1.SequenceEqual(matches))
            {
                Console.WriteLine(gameresultwin);
            }
            else {
                Console.WriteLine(gameresultloss);
            }
            Console.WriteLine("Çıkmak için bir tuşa basınız....");
            Console.ReadKey();



        }
    }
}
