using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] isimler ; int n; float yas = 0;
            Console.Write("lutfen calisanlarin sayisi giriniz: ");
            n = int.Parse(Console.ReadLine());
            isimler = new int[n];
            for (int i=0; i<n; i++)
            {
                Console.Write("Lutfen {0}.calisanin yasini giriniz: ", i+1);
                isimler[i] = int.Parse(Console.ReadLine());
            }
            foreach (var j in isimler)
            {
                yas += j;
            }
            Console.WriteLine("calisanlarin yaslarinin ortalamasi " + yas/n);
        }
    }
}