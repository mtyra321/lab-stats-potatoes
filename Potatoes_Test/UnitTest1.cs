using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labstats_potato;
using System;
namespace Potatoes_Tests
{
    [TestClass]
    public class Potatoes_Tests
    { 
        public Labstats Tester = new Labstats();

        [TestMethod]
        public void Test_6_bags()
        {
            Console.WriteLine("Testing 6 bags:");
            int logic_result = Labstats.potatoLogic(6);
            Console.WriteLine("The expected output for 6 bags is: 21");
            Console.WriteLine("The actual output for 6 bags is: " + logic_result);
        }

        [TestMethod]
        public void Test_3_bags()
        {
            Console.WriteLine("Testing 3 bags:");
            int logic_result = Labstats.potatoLogic(3);
            Console.WriteLine("The expected output for 3 bags is: 6");
            Console.WriteLine("The actual output for 3 bags is: " + logic_result);
        }
        [TestMethod]
        public void Test_10_bags()
        {
            Console.WriteLine("Testing 10 bags:");
            int logic_result = Labstats.potatoLogic(10);
            Console.WriteLine("The expected output for 10 bags is: 55");
            Console.WriteLine("The actual output for 10 bags is: " + logic_result);
        }
        [TestMethod]
        public void Test_20_bags()
        {
            Console.WriteLine("Testing 20 bags:");
            int logic_result = Labstats.potatoLogic(20);
            Console.WriteLine("The expected output for 20 bags is: 210");
            Console.WriteLine("The actual output for 20 bags is: " + logic_result);
        }
        [TestMethod]
        public void Test_37_bags()
        {
            Console.WriteLine("Testing 37 bags:");
            int logic_result = Labstats.potatoLogic(37);
            Console.WriteLine("The expected output for 37 bags is: 703");
            Console.WriteLine("The actual output for 37 bags is: " + logic_result);
        }
        [TestMethod]
        public void Test_40_bags()
        {
            Console.WriteLine("Testing 40 bags:");
            int logic_result = Labstats.potatoLogic(40);
            Console.WriteLine("The expected output for 40 bags is: 820");
            Console.WriteLine("The actual output for 40 bags is: " + logic_result);
        }
        [TestMethod]
        public void Test_1_bag()
        {
            Console.WriteLine("Testing 1 bag:");
            int logic_result = Labstats.potatoLogic(1);
            Console.WriteLine("The expected output for 1 bag is: 1");
            Console.WriteLine("The actual output for 1 bag is: " + logic_result);
        }
    }
}
