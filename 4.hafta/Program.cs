class hafta4{
    public void ornek1()
    {
        Random r = new Random();
        int[] dizi = new int[20];
        char[] chr = new char[20];
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = r.Next(1, 51);
            chr[i] = (char)r.Next(20, 126);

        }
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write("{0.2}. değer {1,2} -> ", i, dizi[i]);
            for (int j = 0; j < dizi[i]; j++)
            {
                Console.Write(chr[i]);
                Console.WriteLine();
            }
        }
    }

    public void ornek2()
    {
        int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(dizi[i, j]);
            }
    }
    public void ornek3()
    {
        int[][] dizi = new int[3][];
        dizi[0] = new int[] { 1, 2 };
        dizi[1] = new int[] { 3, 4,5,6,7 };
        dizi[2] = new int[] { 8, 9, 0 };
        foreach (int[] boyut in dizi)
        {
            foreach (int eleman in boyut)
                Console.WriteLine("{0,3}", eleman);

            Console.WriteLine();

        }
        
    }
    public void ornek4()
    {
        int[,] d = { { 2, 3 }, { 4, 5 }, { 6, 7 } }; 
        d[2, 1] = 33; 
        Console.WriteLine(d.GetValue(2, 1)); 
        int[][] dd = new int[2][]; 
        dd[0] = new int[2]; 
        dd[1] = new int[1]; 
        dd[0][0] = 23;
        dd[0][1] = 234;
        dd[1][0] = 44;
        Random rnd = new Random();
        int[] dizi = new int[3];
        dizi[0] = rnd.Next(2, 10); 
        dizi[1] = rnd.Next(50); 
        dizi[2] = rnd.Next(); 
        Console.WriteLine(dizi.GetValue(2));
        Console.WriteLine(dd[1][0]);
    }
    public void Ornek5(string aranan)
    {
        string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" };
        foreach (string ss in isimler)
        {
            if (aranan.Equals(isimler[0]))
                Console.WriteLine("aranan isim bulundu...");
            else Console.WriteLine("isim yok");
        }

    }


}
