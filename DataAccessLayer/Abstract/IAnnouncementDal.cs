using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementDal:IGenericDal<Announcement>//IAnnouncementDal'da yapacağınız işleme ait imzayı atacaksınız
    {
        public void AnnouncementStatusToTrue(int id);//güncelleme için
        public void AnnouncementStatusToFalse(int id);
    }
}
