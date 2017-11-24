using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharpExam70_483
{
    public class Section4
    {
        private static string Type { get; set; }
    }


    public class PrivateContructor
    {
        private PrivateContructor()
        {
            
        }

        public class NestedPrivateContructor
        {
            public NestedPrivateContructor()
            {
                //No Errors!!!!! calling private contructor
                var temp = new PrivateContructor();
            }
        }

        public class StructExamples
        {
            public void Main()
            {
                var stru = new TestStruct(2, 3);
            }

            public struct TestStruct
            {
                public int X; //= 0; // gives you error
                public int Y; //= 9;

                public TestStruct(int x, int y)
                {
                    X = x;
                    Y = y;
                }

                public void Do()
                {
                    var ss = X * Y;
                }
            }
        }
    }
}
