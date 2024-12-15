using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Abstract;

namespace YMYP5_Resume.Entity.Concrete;
public class SkillAndLanguage : BaseEntity
{
	public string Name { get; set; }
	public int Level { get; set; }
    public bool IsSkill { get; set; }

}



