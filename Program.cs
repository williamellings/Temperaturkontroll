namespace Temperaturkontroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Här kan vi kolla in tempen mata in tempen så får du ett svar: ");
            string input = Console.ReadLine();

            Thermometer thermometer = new Thermometer();
            thermometer.CheckTempretaure();

            
        }
    }
}
