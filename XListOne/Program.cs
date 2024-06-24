namespace XListOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XList a = new XList(10);

            for (int i = 0; i < 100; i++)
            {
                a.Insert(i);
            }

            a.Print();
        }
    }
}
