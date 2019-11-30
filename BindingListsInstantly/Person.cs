using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingListsInstantly
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}", Name, SurName);
        }
    }
}
