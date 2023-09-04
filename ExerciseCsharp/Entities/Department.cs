using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCsharp.Entities {
    internal class Department {

        public String Name { get; set; }
        public Department() { }

        public Department(String name) {
            Name = name;
        }
    }
}
