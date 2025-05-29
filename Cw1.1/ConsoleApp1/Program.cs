namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            
            PoleTrapezu poleTrapezu = new PoleTrapezu();

            poleTrapezu.read_data();
            poleTrapezu.process_data();
            poleTrapezu.show_results();



        }
    }
}
