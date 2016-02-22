using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.X_Test
{
    /*
    public abstract class test
    {
        public abstract void DoSomeThing()
        {
            //Some Code here...
        }
    } 

    public class second:test
    {
        public override void DoSomeThing()
        {
            //Some Code Here...
        }
    }
    */
    public class Property
    {
        private int i;
        public int hehe;

        public int SetI
        {
            get
            {
                return i - 1;
            }
            set
            {
                i = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myProerty = new Property();
            myProerty.SetI = 1;
            Console.WriteLine("{0}", myProerty.SetI);
            Console.ReadKey();

        }
    }

    public class bushiba
    {
    }
}
