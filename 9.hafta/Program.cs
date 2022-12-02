using _9.hafta;

class A
{
    public int x;
   public int y;
    protected int z;
    public A(int x)
    {
        x = 1;
        y = 2;
        z = 3;
        Console.WriteLine("a yapıcısı çalıştı");

    }
    public void Listele()
    {
        Console.WriteLine("x={0};y={1};z={3};",x,y,z);
    }
}
class T : A
{
    public string s;
    public T()
    {
        s = "türemiş sınıf";
        Console.WriteLine("t yapıcısı çalıştı");
    }
 public void yaz() { Console.WriteLine("x={0};y={1};z={3};", x, y, z); }

}

  
    
  

