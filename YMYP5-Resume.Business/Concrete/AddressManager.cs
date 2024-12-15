using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Business.Abstract;
using YMYP5_Resume.DataAccess.Abstract;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.Business.Concrete;
public class AddressManager : IAddressService
{
	private readonly IAddressDal _addressDal;

	public AddressManager(IAddressDal addressDal)
	{
		_addressDal = addressDal;
	}

	public List<Address> GetAll()
	{
		return _addressDal.GetAll(a => a.IsDeleted == false);
	}

	public IQueryable<Address> GetAllQueryable()
	{
		return _addressDal.GetAllQueryable(x => x.IsDeleted == false).Include(x => x.Experiences);
	}

	public Address GetByID(Guid id)
	{
		return _addressDal.Get(a => a.Id == id);
	}

	public List<Address> GetByLocation(string location)
	{
		return _addressDal.GetAll(a => a.Location.Equals(location));
	}

	public void Insert(Address entity)
	{
		entity.CreateAt = DateTime.Now;
		entity.IsActive = true;
		entity.IsDeleted = false;
		_addressDal.Add(entity);
	}

	public void Modify(Address entity)
	{
		entity.UpdateAt = DateTime.Now;
		_addressDal.Update(entity);
	}

	public void Remove(Address entity)
	{
		entity.IsActive = false;
		entity.IsDeleted = true;
		_addressDal.Update(entity);
		//_addressDal.Delete(entity);
	}
}
