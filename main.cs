class Test
{
    public int Prop1 {get; set;}

    public Test()
    {
        this.Prop1 = 10;   
    }

    public void Mostrar()
    {
        Console.WriteLine(this.Prop1);
    }
}
class program
{
    static void Main()
    {
        var p = new Test();
        p.Mostrar();
        Console.WriteLine("Exito!!!");
    }
}