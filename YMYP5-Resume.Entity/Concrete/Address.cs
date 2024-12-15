using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Abstract;

namespace YMYP5_Resume.Entity.Concrete
{
    public class Address : BaseEntity
    {
        public string Location { get; set; }
        public string Information { get; set; }
        public List<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
