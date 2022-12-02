        int a = 2; int b = 3; int c = 6; int d = 1;
        Console.WriteLine("(a<b)&&(c<d) -->" + ((a < b) && (c < d)));
        Console.WriteLine("(a<b)||(c<d) -->" + ((a < b) || (c < d)));
        Console.WriteLine("! (a<b) -->" + (!(a < b)));
        Console.WriteLine("(a<b)&(c<d) -->" + ((a < b) & (c < d)));
        Console.WriteLine("(a<b)|(c<d) -->" + ((a < b) | (c < d)));
        Console.WriteLine("(a<b)^(c<d) -->" + ((a < b) ^ (c < d)));
    
    Console.WriteLine("----------------------------------------");
    a = 2; b = 3; c = 6;
    Console.WriteLine(" (a & b) --> " + (a & b));
    Console.WriteLine(" (a | b) --> " + (a | b));
    Console.WriteLine(" (a ^ b) --> " + (a ^ b));
    Console.WriteLine(" ( ~a ) --> " + (~a));
    Console.WriteLine(" ( ~b ) --> " + (~b));
    Console.WriteLine(" ( ~c ) --> " + (~c));
    Console.WriteLine("----------------------------------------");
    int i = 0;
    while (i < 5)
    {
        Console.WriteLine("i = " + i);
        i++;
    }
    Console.WriteLine("----------------------------------------");
    i = 0;
    do
    {
        Console.WriteLine("i = " + i);
        i++;
    } while (i < 0);
    Console.WriteLine("----------------------------------------");
    int secim;
    do
    {
        Console.WriteLine("işlemler\n========");
        Console.WriteLine("1 - Toplama");
        Console.WriteLine("2 - çıkarma");
        Console.WriteLine("3 - çarpma");
        Console.WriteLine("4 - bölme");
        Console.WriteLine("0 - çıkış\n");
        Console.WriteLine("işleminizi seçin:");
        secim = int.Parse(Console.ReadLine());
        switch (secim)
        {
            case 1: Console.WriteLine("toplama"); break;
            case 2: Console.WriteLine("çıkarma"); break;
            case 3: Console.WriteLine("çarpma"); break;
            case 4: Console.WriteLine("bölme"); break;
            case 0: Console.WriteLine("çıkış"); break;
            default: Console.WriteLine("yanlış seçim"); break;
        }
    }
    while (secim != 0);
    Console.WriteLine("----------------------------------------");
    i = 0;
    for (int j = 0; i < 20; i++, j++)
    {
        i *= j;
        Console.WriteLine("i = " + i + " j = " + j);
    }
}