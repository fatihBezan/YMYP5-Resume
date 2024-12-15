using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Business.Abstract;
using YMYP5_Resume.DataAccess.Abstract;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.Business.Concrete;
public class BlogManager : IBlogService
{
	private readonly IBlogDal _blogDal;

	public BlogManager(IBlogDal blogDal)
	{
		_blogDal = blogDal;
	}

	public List<Blog> GetAll()
	{
		return _blogDal.GetAll(b => b.IsDeleted == false);
	}

	public IQueryable<Blog> GetAllQueryable()
	{
		return _blogDal.GetAllQueryable();
	}

	public Blog GetByID(Guid id)
	{
		return _blogDal.Get(blog => blog.Id == id);
	}

	public List<Blog> GetByTitle(string title)
	{
		return _blogDal.GetAll(b => b.Title == title);
	}

	public void Insert(Blog entity)
	{
		entity.IsDeleted = false;
		entity.IsActive = true;
		entity.CreateAt = DateTime.Now;
		_blogDal.Add(entity);
	}

	public void Modify(Blog entity)
	{
		entity.UpdateAt = DateTime.Now;
		_blogDal.Update(entity);
	}

	public void Remove(Blog entity)
	{
		entity.IsActive = false;
		entity.IsDeleted = true;
		entity.UpdateAt = DateTime.Now;
		_blogDal.Update(entity);
	}
}
