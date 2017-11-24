using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharpExam70_483
{
    public static class Section6
    {
        public static void Do()
        {
            var client = new ClientClass();
            client.Main();
        }
    }


    #region delegates

    public class ClientClass
    {
        delegate void Do(int x);
        public void Main()
        {
            var doer = new Doer();
            //compile error
            //var d1 = doer.Do1;
            Do d = doer.Do1;
            //d += doer.Do2;
            d += doer.Do3;

            //if not exist no exception
            d -= doer.Do2;

            d(1);
        }
    }

    public class Doer
    {
        public void Do1(int x)
        {
            Console.WriteLine(x.ToString());
        }

        public void Do2(int x)
        {
            Console.WriteLine(x.ToString());
        }

        public void Do3(int x)
        {
            Console.WriteLine(x.ToString());
        }
    }
    

    #endregion
}
