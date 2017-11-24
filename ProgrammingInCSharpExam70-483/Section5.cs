using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharpExam70_483
{
    public class Section5
    {
        public class Parent
        {
            public int DoIt(int x)
            {
                return 0;
            }

            //compile error
            //public int DoIt(int y)
            //{
            //    return 0;
            //}
        }

      
    }
    public static class IntExtension
    {
        public static void IntExt(this int input)
        {

        }
    }


    /////////////IEnumerable
    /// 
    /// 
    public class Client
    {
        public void Do()
        {
            var cars = new Car();
            foreach (var car in cars)
            {
                var ss = car;
            }
        }
    }

    public class Car : IEnumerable
    {
        private string[] _cars = new string[4];

        public string this[int carNum]
        {
            get { return _cars[carNum]; }
            set { _cars[carNum] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _cars)
            {
                ///It creates Ienumerator!!!!
                yield return item;
            }
        }
    }
}
