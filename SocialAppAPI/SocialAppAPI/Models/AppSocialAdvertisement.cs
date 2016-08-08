using System;
using System.Collections.Generic;

namespace SocialAppAPI
{
    public partial class AppSocialAdvertisement
    {
        public AppSocialAdvertisement()
        {
            AppSocialAdvertisementDetail = new HashSet<AppSocialAdvertisementDetail>();
            AppSocialAdvertisementResponse = new HashSet<AppSocialAdvertisementResponse>();
        }

        public int AdvertisementId { get; set; }

        public string Category { get; set; }
        
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? CategoryId { get; set; }
        public decimal? PostedBy { get; set; }
        public DateTime? PostedOn { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<AppSocialAdvertisementDetail> AppSocialAdvertisementDetail { get; set; }
        public virtual ICollection<AppSocialAdvertisementResponse> AppSocialAdvertisementResponse { get; set; }
      //  public virtual AppSocialAdvertisementCategory Category { get; set; }
        public virtual AppSocialUsers PostedByNavigation { get; set; }
    }
}
