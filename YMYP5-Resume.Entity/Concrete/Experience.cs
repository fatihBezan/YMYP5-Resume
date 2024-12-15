using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Abstract;

namespace YMYP5_Resume.Entity.Concrete;
public class Experience : BaseEntity
{
	public string Title { get; set; }
	public string Company { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public string Description { get; set; }
    public Guid AddressId { get; set; }
    public Address Address { get; set; }
}
