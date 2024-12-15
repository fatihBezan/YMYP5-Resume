using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Abstract;

namespace YMYP5_Resume.Entity.Concrete;
public class PersonalInfo : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdentityNumber { get; set; }
	public DateTime BirthDate { get; set; }
    public string Appellation { get; set; }
    public string ImageUrl { get; set; }
    public string Martial { get; set; }
    public string National { get; set; }
}


//class Program
//{
//	static void Main()
//	{
//		PersonalInfo personalInfo = new PersonalInfo();
//		personalInfo.Id = new Guid();
//		personalInfo.IsDeleted = false;
//	}
//}
