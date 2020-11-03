using System;
using System.Collections.Generic;
using System.Text;

namespace pra.streams05.CORE
{
    public class PresidentInfo
    {
        public int ID { get; set; }
        public int President { get; set; }
        public string FullName { get; set; }
        public string Party { get; set; }
        public string Terms { get; set; }

        public override string ToString()
        {
            return FullName + " " + Party + " " + Terms;
        }
    }
}
