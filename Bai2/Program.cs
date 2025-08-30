using Bai2;

class Program
{
    static void Main(string[] args)
    {
        Student hs = new Student();
        hs.setName("Quynh");
        hs.setAge(20);
        Console.WriteLine(hs.toString());
    }
}