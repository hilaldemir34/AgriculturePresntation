using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDal _abutDal;

		public AboutManager(IAboutDal abutDal)
		{
			_abutDal = abutDal;
		}

		public void Delete(About t)
		{
			throw new NotImplementedException();
		}

		public About GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<About> GetListAll()
		{
			return _abutDal.GetListAll();
		}

		public void Insert(About t)
		{
			throw new NotImplementedException();
		}

		public void Update(About t)
		{
			throw new NotImplementedException();
		}
	}
}
