using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week08_TQC5OX.Abstractions;

namespace Week08_TQC5OX.Entities
{
    public class IToyFactory : Abstractions.IToyFactory
    {
        public Abstractions.Toy CreateNew()
        {
            return new Toy();
        }
    }
}
