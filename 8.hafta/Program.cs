﻿class program
{
    public void ornek1()
    {
        if (BitConverter.IsLittleEndian) Console.WriteLine("little endian");
        else
            Console.WriteLine("big endian");
        int a = 46513;
        byte[] b=BitConverter.GetBytes(a);
        foreach(byte x in b)
            Console.WriteLine(x);
    }
    public void ornek2()
    {
        byte[] kaynak = { 1, 2, 0, 1 };
        short[] hedef = new short[5];
        Buffer.BlockCopy(kaynak, 0, hedef, 0, 4);
        foreach (short s in hedef)
        {
            Console.Write(s+" ");

        }
        Console.WriteLine("\n" + Buffer.GetByte(hedef, 0));
        Buffer.SetByte(hedef, 5, 3);
        foreach (short s in hedef)
        {
            Console.Write(s + " ");

        }
        Console.WriteLine();
        Console.WriteLine(Buffer.ByteLength(kaynak));
        Console.WriteLine(Buffer.ByteLength(hedef));
    }
}
