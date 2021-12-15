using System;

namespace WordOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Cümle giriniz");

            string sentence = Console.ReadLine();

            string[] kelimeler = sentence.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);
            foreach(string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            string liste =  "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           +"abcçdefgğhiıjklmnoöprsştuüvyz";

            int sayac = 0;

            for (int i =0; i<sentence.Length;i++)
            {
                if(liste.Contains(sentence[i])){
                    sayac++;
                }
            }

            Console.WriteLine("Girilen Cümlede {0} tane harf vardır",sayac);
        }
    }
}
