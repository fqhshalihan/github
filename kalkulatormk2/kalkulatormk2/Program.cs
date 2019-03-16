using System;


namespace Calculator
{
    class Operasi
    {
        public void Tambah()
        {

            int loop = 0;
            int result = 0;
            int stop = 1;
            stop = stop + loop;




            Console.Write("Berapa angka yang akan dijumlahkan : ");
            loop = Convert.ToInt32(Console.ReadLine());

            int[] tampung = new int[loop + 1];


            for (int i = 0; i < loop; i++)
            {
                int angka;
                Console.Write(" Masukan angka ke-{0} : ", (i + 1));
                angka = Convert.ToInt32(Console.ReadLine());
                result += angka;
                tampung[i] = angka;

            }
            Console.Write("\nHASIL DARI : ");

            for (int i = 0; i <= loop; i++)
            {
                if (i != loop)
                {
                    Console.Write(tampung[i]);
                }
                if (i != (loop - 1))
                {
                    if (i != loop) { Console.Write(" + "); }
                }
                else
                {
                    Console.Write(" = ");
                }
            }
            Console.Write(result + "\n\n");

            Run a = new Run();
            a.Exit();

        }


        public void Kurang()
        {

            int loop = 0;
            int result = 0;
            int stop = 1;
            stop = stop + loop;




            Console.Write("Berapa angka yang akan dikurangi : ");
            loop = Convert.ToInt32(Console.ReadLine());

            int[] tampung = new int[loop + 1];


            for (int i = 0; i < loop; i++)
            {
                int angka;
                Console.Write(" Masukan angka ke-{0} : ", (i + 1));
                angka = Convert.ToInt32(Console.ReadLine());
                if (i == 0) { result = angka; } else { result -= angka; }
                tampung[i] = angka;

            }

            Console.Write("\nHASIL DARI : ");

            for (int i = 0; i <= loop; i++)
            {
                if (i != loop)
                {
                    Console.Write(tampung[i]);
                }
                if (i != (loop - 1))
                {
                    if (i != loop) { Console.Write(" - "); }
                }
                else
                {
                    Console.Write(" = ");
                }
            }
            Console.Write(result + "\n\n");


            Run a = new Run();
            a.Exit();
        }


        public void Kali()
        {

            int loop = 0;
            int result = 0;
            int stop = 1;
            stop = stop + loop;




            Console.Write("Berapa angka yang akan dikalikan : ");
            loop = Convert.ToInt32(Console.ReadLine());

            int[] tampung = new int[loop + 1];


            for (int i = 0; i < loop; i++)
            {
                int angka;
                Console.Write(" Masukan angka ke-{0} : ", (i + 1));
                angka = Convert.ToInt32(Console.ReadLine());
                if (i == 0) { result = angka; } else { result *= angka; }
                tampung[i] = angka;

            }

            Console.Write("\nHASIL DARI : ");

            for (int i = 0; i <= loop; i++)
            {
                if (i != loop)
                {
                    Console.Write(tampung[i]);
                }
                if (i != (loop - 1))
                {
                    if (i != loop) { Console.Write(" x "); }
                }
                else
                {
                    Console.Write(" = ");
                }
            }
            Console.Write(result + "\n\n");

            Run a = new Run();
            a.Exit();
        }


        public void Bagi()
        {

            int loop = 0;
            int result = 0;
            int stop = 1;
            stop = stop + loop;




            Console.Write("Berapa angka yang akan dibagi : ");
            loop = Convert.ToInt32(Console.ReadLine());

            int[] tampung = new int[loop + 1];


            for (int i = 0; i < loop; i++)
            {
                int angka;
                Console.Write(" Masukan angka ke-{0} : ", (i + 1));
                angka = Convert.ToInt32(Console.ReadLine());
                if (i == 0) { result = angka; } else { result /= angka; }
                tampung[i] = angka;

            }

            Console.Write("\nHASIL DARI : ");

            for (int i = 0; i <= loop; i++)
            {
                if (i != loop)
                {
                    Console.Write(tampung[i]);
                }
                if (i != (loop - 1))
                {
                    if (i != loop) { Console.Write(" : "); }
                }
                else
                {
                    Console.Write(" = ");
                }
            }
            Console.Write(result + "\n\n");

            Run a = new Run();
            a.Exit();
        }


    }
    class Run
    {
        public void Exit()
        {
            char pul;
            Console.Write("Mulai lagi (y/n) : ");
            pul = Convert.ToChar(Console.ReadLine());

            if (pul == 'y') { Menu(); }
            else
            {
                Console.WriteLine("Tekan ENTER");
                Console.ReadKey();
            }


        }
        public void Menu()
        {
            int chois;

            Console.WriteLine("\n1. Penjumlahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian");
            Console.Write("Masukan Pilihan (angka) : ");

            chois = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            Pilihan(chois);

        }
        public void Pilihan(int pil)
        {
            switch (pil)
            {
                case 1:
                    Operasi p = new Operasi();
                    p.Tambah();
                    break;
                case 2:
                    Operasi r = new Operasi();
                    r.Kurang();
                    break;
                case 3:
                    Operasi s = new Operasi();
                    s.Kali();
                    break;
                case 4:
                    Operasi t = new Operasi();
                    t.Bagi();
                    break;
                default:
                    Console.WriteLine("Pilihan yang anda masukan salah !!!");
                    Console.Write("Masukan Pilihan (angka) : ");
                    pil = Convert.ToInt32(Console.ReadLine());
                    Pilihan(pil);
                    break;



            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("          APLIKASI KALKULATOR              ");
            Console.WriteLine("       Created by: faqih shalihan            ");
            Console.WriteLine("-------------------------------------------");


            Run q = new Run();
            q.Menu();
        }
    }
}
