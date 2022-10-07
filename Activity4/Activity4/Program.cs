using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    interface IMyInterface
    {
        // property = set & query object state data
        string Name { get; set; }   // read-write 

        int Age { get; }        // read-only

        string ID { set; }        // write-only

        // indexer
        int this[int index] { get; set; }

        // instance method
        void ReadFile();
    }

    class MyClass : IMyInterface
    {
        // define this string as a property, not an instance
        public string Name { get; set; }
        public int Age { get; }
        public string ID { get; set; }
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        private int[] arr = new int[100];
        public int this[int index] // indexer declaration
        {
            get => arr[index];
            set => arr[index] = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass test = new MyClass();
        }
    }
}