using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "Pear";

            Fruit? someFruit = null;

            try
            {
                someFruit = someString.ConvertToEnum2<Fruit>();
            }
            catch {}

            Console.WriteLine("somefruit: " + someFruit);

            Console.ReadLine();
        }
    }

    public enum Fruit
    {
        Apple,
        Pear,
        Orange
    }

    static class Extensions
    {
        public static T ConvertToEnum2<T>(this string myString)
        {
            T f = (T)Enum.Parse(typeof(T), myString.ToString());

            return f;
        }
    }
}
