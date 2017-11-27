using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharpExam70_483
{
    public class Section10
    {
    }

    public class HashClient
    {
        public string MakeHash(string input)
        {
            var algorithm = SHA256.Create();
            var hashed = algorithm.ComputeHash(Encoding.Default.GetBytes(input));
            return Convert.ToBase64String(hashed);

        }
    }
}
