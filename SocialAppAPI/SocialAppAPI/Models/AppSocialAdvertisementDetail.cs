using System;
using System.Collections.Generic;

namespace SocialAppAPI
{ 
    public partial class AppSocialAdvertisementDetail
    {
        public int DetailId { get; set; }
        public int? AdvertisementId { get; set; }
        public byte[] Picture { get; set; }
        public decimal? PostedBy { get; set; }
        public DateTime? PostedOn { get; set; }

        public virtual AppSocialAdvertisement Advertisement { get; set; }
        public virtual AppSocialUsers PostedByNavigation { get; set; }
    }
}
