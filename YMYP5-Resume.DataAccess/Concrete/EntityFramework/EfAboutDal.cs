﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.DataAccess.Abstract;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.DataAccess.Concrete.EntityFramework;
public class EfAboutDal : EfGenericRepository<About>, IAboutDal
{
	public EfAboutDal(ResumeDbContext context) : base(context)
	{

	}
}
