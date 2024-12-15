using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using YMYP5_Resume.DataAccess.Abstract;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.DataAccess.Concrete.EntityFramework;
public class EfBlogDal : EfGenericRepository<Blog>, IBlogDal
{
	public EfBlogDal(ResumeDbContext context) : base(context)
	{
	}
}
