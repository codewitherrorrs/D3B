namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(String[] args)
        {
            /*Construct c1 = new Construct();
            Construct c2 = new Construct("Sagar Shahu");
            c2.display();*/

            InterfaceExample inter = new Child();
            Interface interOne = new Child();
            inter.add(54, 5);
            interOne.Add(54, 56);
        }
    }
}