using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Person("Eduardo", 38));
            Node n2 = new Node(new Person("El gemelo malvado de Eduardo", 38));
            Node n3 = new Node(new Person("Riki", 21));
            Node n4 = new Node(new Person("Ana", 71));
            Node n5 = new Node(new Person("Fernando", 56));
            Node n6 = new Node(new Person("Estefan", 49));
            Node n7 = new Node(new Person("Alec", 18));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            Console.WriteLine(Convert.ToString(n1.GetAgeSum()));
            Console.WriteLine(n1.GetLongestName());
            Console.WriteLine(Convert.ToString(n1.GetOldestSonAge()));
        }
    }
}
