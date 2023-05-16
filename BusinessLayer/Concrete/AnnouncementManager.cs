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
    public class AnnouncementManager : IAnnouncementService
    {//burada servisteki imzayı gerçekleştirdik
        private readonly IAnnouncementDal _anneouncementDal;

        public AnnouncementManager(IAnnouncementDal anneouncementDal)
        {
            _anneouncementDal = anneouncementDal;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _anneouncementDal.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _anneouncementDal.AnnouncementStatusToTrue(id);
        }

        public void Delete(Announcement t)
        {
            _anneouncementDal.Delete(t);
        }

        public Announcement GetById(int id)
        {
            return _anneouncementDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _anneouncementDal.GetListAll();
        }

        public void Insert(Announcement t)
        {
            _anneouncementDal.Insert(t);
        }

        public void Update(Announcement t)
        {
            _anneouncementDal.Update(t);
        }
    }
}
