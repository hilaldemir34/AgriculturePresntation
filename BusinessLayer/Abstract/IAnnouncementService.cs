using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnnouncementService:IGenericService<Announcement>
    {
        public void AnnouncementStatusToTrue(int id);//güncelleme için
        public void AnnouncementStatusToFalse(int id);//Burda manager daki imzaları attık.
    }
}
