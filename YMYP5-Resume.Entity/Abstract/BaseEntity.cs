using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP5_Resume.Entity.Abstract;
public abstract class BaseEntity : IEntity
{
    public Guid Id { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
	public DateTime UpdateAt { get; set; }
    public bool IsActive { get; set; } = true;
	public bool IsDeleted { get; set; } = false;

	//BaseEntity entity = new BaseEntity();
	//ID => 1
	//CreateAt => 2021-08-01 00:00:00
	//UpdateAt => 2021-08-01 00:00:00
	//IsActive => true
	//IsDeleted => false
}
