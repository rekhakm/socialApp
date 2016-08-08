using System;
using System.Collections.Generic;

namespace SocialAppAPI
{
    public partial class AppSocialUsers
    {
        public AppSocialUsers()
        {
            AppSocialAdvertisement = new HashSet<AppSocialAdvertisement>();
            AppSocialAdvertisementDetail = new HashSet<AppSocialAdvertisementDetail>();
            AppSocialAdvertisementResponse = new HashSet<AppSocialAdvertisementResponse>();
        }

        public decimal UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public DateTime? RegisteredOn { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<AppSocialAdvertisement> AppSocialAdvertisement { get; set; }
        public virtual ICollection<AppSocialAdvertisementDetail> AppSocialAdvertisementDetail { get; set; }
        public virtual ICollection<AppSocialAdvertisementResponse> AppSocialAdvertisementResponse { get; set; }
    }
}
