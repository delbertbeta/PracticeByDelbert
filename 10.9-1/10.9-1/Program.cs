using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._9_1
{
    public class MyClass
    {
        protected string myString;
        public string ContainedString
        {
            set
            {
                myString = value;
            }
        }
        public virtual string GetString()
        {
            return myString;
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string ToString()
        {
            return base.ToString() + "(output from dervied class)";
        }
    }

    public class MyCopyableClass
    {
        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)base.MemberwiseClone();
        }
        protected string myString;
        public string MyString
        {
            get
            {
                return myString;
            }
            set
            {
                myString = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyCopyableClass();
            myClass.MyString = "hello world";
            var myNewClass = myClass.GetCopy();
            Console.WriteLine("{0}", myNewClass.MyString);
            Console.ReadKey();
        }
    }
}
