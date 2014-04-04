using System.Linq;

namespace PersonMobilePortal.Models
{
    public class ProfileRepository
    {
        private static readonly ProfileStoreEntities db = new ProfileStoreEntities();

        public static Profile MyProfile
        {
            get { return db.Profiles.First(); }
        }
    }
}