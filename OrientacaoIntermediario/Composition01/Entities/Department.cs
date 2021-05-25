using System;
using System.Collections.Generic;
using System.Text;

namespace Composition01.Entities
{
    class Department
    {
        public String Name { get; set; }

        public Department()
        {

        }

        public Department (String name)
        {
            Name = name;

        }
    }


}
