using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Abstract;

namespace YMYP5_Resume.Entity.Concrete
{
    public class Reccomendation : BaseEntity
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
    }
}
