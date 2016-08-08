using System;
using System.Collections.Generic;

namespace SocialAppAPI
{
    public partial class AppSocialAdvertisementCategory
    {
        public AppSocialAdvertisementCategory()
        {
            AppSocialAdvertisement = new HashSet<AppSocialAdvertisement>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<AppSocialAdvertisement> AppSocialAdvertisement { get; set; }
    }
}
