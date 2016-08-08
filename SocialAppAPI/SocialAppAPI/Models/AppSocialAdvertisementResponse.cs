using System;
using System.Collections.Generic;

namespace SocialAppAPI
{ 
    public partial class AppSocialAdvertisementResponse
    {
        public int ResponseId { get; set; }
        public int? AdvertisementId { get; set; }
        public string Comments { get; set; }
        public int? Ratting { get; set; }
        public bool? IsMarkedAsSpam { get; set; }
        public decimal? CommentedBy { get; set; }
        public DateTime? CommentedOn { get; set; }

        public virtual AppSocialAdvertisement Advertisement { get; set; }
        public virtual AppSocialUsers CommentedByNavigation { get; set; }
    }
}
