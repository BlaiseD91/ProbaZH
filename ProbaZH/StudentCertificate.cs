using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaZH
{
    internal class StudentCertificate : Document
    {

        public StudentCertificate(Student st):base($"Igazolás: {st.Name} ({st.Neptun})")
        {
        }
        public override void Print()
        {
            Console.WriteLine(Title);
        }
    }
}
