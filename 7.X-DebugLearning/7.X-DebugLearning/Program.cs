using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _7.X_DebugLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Debug.WriteLine(String.Format("Hello{0}", 1));
                throw new System.IndexOutOfRangeException();
            }
            catch (System.OutOfMemoryException e)
            {
                Console.WriteLine("Nice Job!");
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine("{0}", e.Data);
            }
            finally
            {
                Console.WriteLine("hehe");
            }
            Console.ReadKey();
        }
    }
}
