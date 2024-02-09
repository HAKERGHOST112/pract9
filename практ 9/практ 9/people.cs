using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практ_9
{
    internal class people
    {
        public string FIO {  get; set; }
        public int Age { get; set; }
        public int Probeg { get; set; }
        public people(string fIO, int age, int probeg)
        {
            FIO = fIO;
            Age = age;
            Probeg = probeg;
        }
        public people() 
        {
            FIO = "";
            Age = 0;
            Probeg = 0;
        }
        public override string ToString()
        {
            return FIO+" "+ Age.ToString()+" "+ Probeg.ToString();
        }

    }
}
