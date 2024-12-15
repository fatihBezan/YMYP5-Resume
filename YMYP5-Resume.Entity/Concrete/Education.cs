using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Abstract;

namespace YMYP5_Resume.Entity.Concrete;
public class Education :BaseEntity
{
	public string School { get; set; }
	public string Department { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public string Description { get; set; }
    public decimal Grade { get; set; }
}
