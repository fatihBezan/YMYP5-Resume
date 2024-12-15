using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Business.Abstract;
using YMYP5_Resume.Business.Concrete;
using YMYP5_Resume.DataAccess.Abstract;
using YMYP5_Resume.DataAccess.Concrete.EntityFramework;

namespace YMYP5_Resume.Business.DependencyInjection.AutoFac;
public class AutofacBusinessModule : Module
{
	protected override void Load(ContainerBuilder builder)
	{
		builder.RegisterType<ResumeDbContext>().AsSelf().SingleInstance();
		builder.RegisterType<AboutManager>().As<IAboutService>();
		builder.RegisterType<EfAboutDal>().As<IAboutDal>();
		builder.RegisterType<AddressManager>().As<IAddressService>();
		builder.RegisterType<EfAddressDal>().As<IAddressDal>();
		builder.RegisterType<BlogManager>().As<IBlogService>();
		builder.RegisterType<EfBlogDal>().As<IBlogDal>();
		builder.RegisterType<ContactManager>().As<IContactService>();
		builder.RegisterType<EfContactDal>().As<IContactDal>();
	}
}
