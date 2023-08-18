using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLconstructor.Classes
{
    public class FieldDataGeneratorIntegers : FieldDataGenerator
    {
        public int randomStart;
        public int randomEnd;
        public FieldDataGeneratorIntegers(GenerationType type) : base(type) 
        {

        }

        protected override string ForEachGenerate()
        {
            return base.ForEachGenerate();
        }
        protected override string ForLoopGenerate()
        {
            return base.ForLoopGenerate();
        }
    }
}
