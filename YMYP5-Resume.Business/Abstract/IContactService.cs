﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.Business.Abstract;
public interface IContactService : IGenericService<Contact>
{
	Contact GetByPhone(string phoneNumber);
	Contact GetByEmail(string email);
}