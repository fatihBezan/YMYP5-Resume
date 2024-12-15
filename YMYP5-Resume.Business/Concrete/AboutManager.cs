using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Business.Abstract;
using YMYP5_Resume.DataAccess.Abstract;
using YMYP5_Resume.DataAccess.Concrete.AdoNet;
using YMYP5_Resume.DataAccess.Concrete.EntityFramework;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.Business.Concrete;
public class AboutManager : IAboutService
{
	private readonly IAboutDal _aboutDal;
	public AboutManager(IAboutDal aboutDal)
	{
		_aboutDal = aboutDal;
	}
	public List<About> GetAll()
	{
		return _aboutDal.GetAll(a => a.IsDeleted == false);
	}

	public IQueryable<About> GetAllQueryable()
	{
		return _aboutDal.GetAllQueryable(a => a.IsActive);
	}

	public About GetByID(Guid id)
	{
		return _aboutDal.Get(a => a.Id == id);
	}

	public void Insert(About entity)
	{
		_aboutDal.Add(entity);
	}

	public void Modify(About entity)
	{
		_aboutDal.Update(entity);
	}

	public void Remove(About entity)
	{
		_aboutDal.Delete(entity);
	}
}
