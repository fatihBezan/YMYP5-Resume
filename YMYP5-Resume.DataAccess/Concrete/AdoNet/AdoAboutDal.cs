using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.DataAccess.Abstract;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.DataAccess.Concrete.AdoNet;
public class AdoAboutDal : IAboutDal
{
	public void Add(About entity)
	{
		throw new NotImplementedException();
	}

	public void Delete(About entity)
	{
		throw new NotImplementedException();
	}

	public About Get(Expression<Func<About, bool>> filter)
	{
		throw new NotImplementedException();
	}

	public List<About> GetAll(Expression<Func<About, bool>> filter = null)
	{
		throw new NotImplementedException();
	}

	public IQueryable<About> GetAllQueryable(Expression<Func<About, bool>> filter = null)
	{
		throw new NotImplementedException();
	}

	public void Update(About entity)
	{
		throw new NotImplementedException();
	}
}
