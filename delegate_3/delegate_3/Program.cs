using System;

namespace delegate_3
{
    class Program
    {
        delegate int Rnd();
        delegate double Avarage(Rnd[] r);
        static int MyRandom()
        {
            Random rand = new Random();
            return rand.Next(1000);
        }
        static void Main(string[] args)
        {
            Avarage av = delegate (Rnd[] r)
            {
                int sum = 0;
                for (int i = 0; i < r.Length; i++)
                    sum += r[i].Invoke();
                return sum / r.Length;
            };
            Console.Write(av(new Rnd[3] { new Rnd(MyRandom), new Rnd(MyRandom), new Rnd(MyRandom) }));
            Console.ReadKey();
        }
    }
}
