namespace DataAccessLayer.Concrete.EntityFramework
{
    public interface IEfAnnouncementDal
    {
        void AnnouncementStatusToFalse(int id);
        void AnnouncementStatusToTrue(int id);
    }
}