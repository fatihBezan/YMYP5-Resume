using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Business.Abstract;
using YMYP5_Resume.DataAccess.Abstract;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.Business.Concrete;
public class ContactManager : IContactService
{
	private readonly IContactDal _contactDal;

	public ContactManager(IContactDal contactDal)
	{
		_contactDal = contactDal;
	}

	public List<Contact> GetAll()
	{
		return _contactDal.GetAll(c => c.IsDeleted == false);
	}

	public IQueryable<Contact> GetAllQueryable()
	{
		return _contactDal.GetAllQueryable(c => c.IsDeleted == false && c.IsActive == true);
	}

	public Contact GetByEmail(string email)
	{
		return _contactDal.Get(c => c.Email.Equals(email));
	}

	public Contact GetByID(Guid id)
	{
		return _contactDal.Get(c => c.Id == id);
	}

	public Contact GetByPhone(string phoneNumber)
	{
		return _contactDal.Get(c => c.Phone.Equals(phoneNumber));
	}

	public void Insert(Contact entity)
	{
		entity.IsActive = true;
		entity.IsDeleted = false;
		entity.CreateAt = DateTime.Now;
		_contactDal.Add(entity);
	}

	public void Modify(Contact entity)
	{
		entity.UpdateAt = DateTime.Now;
		_contactDal.Update(entity);
	}

	public void Remove(Contact entity)
	{
		entity.IsDeleted = true;
		entity.IsActive = false;
		entity.UpdateAt = DateTime.Now;
		_contactDal.Update(entity);
	}
}
