using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Abstract;

namespace YMYP5_Resume.Business.Abstract;
public interface IGenericService<T> where T : class, IEntity, new()
{
	void Insert(T entity);
	void Modify(T entity);
	void Remove(T entity);
	List<T> GetAll();
	T GetByID(Guid id);
	IQueryable<T> GetAllQueryable();
}
