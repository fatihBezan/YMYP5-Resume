using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Abstract;

namespace YMYP5_Resume.Entity.Concrete;
public class Contact : BaseEntity
{
    public string Phone { get; set; }
    public string Email { get; set; }
}
