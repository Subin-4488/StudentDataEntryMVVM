using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataEntry
{
    public enum GenderTypes
    {
        Male,
        Female
    }

    public enum BranchNames
    {
        None,
        ComputerScience,
        MechanicalEngineering,
        CivilEngineering
    }

    public class Student
    {
        public string Name { get; set; }
        public BranchNames Branch { get; set; }
        public GenderTypes Gender { get; set; }
        public int Age { get; set; }
    }
}
