namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Auto audi = new Auto();
            audi.Ruote = new Ruote();
            audi.Ruote.diametro = 10;
            audi.Ruote.Pressione = 10;
            audi.Porte = 4;
            Console.WriteLine(audi.Ruote.diametro);

        }
    }

    public class Auto
    {
        public int Porte {  get; set; }
        public Ruote Ruote { get; set; }


    }
    public class Ruote
    {
        public int Pressione { get; set; }
        public int diametro { get; set; }

    }
}
