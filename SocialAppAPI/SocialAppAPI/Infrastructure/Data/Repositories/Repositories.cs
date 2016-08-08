using CoreWebApp_API_.netframework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialAppAPI
{
    public class Repositories
    {
        public class AdvertisementRepository : Repository<AppSocialAdvertisement>, IAdvertisementRepository
        {
            public AdvertisementRepository(MercerSocialAppContext context)
                : base(context)
            {
            }

            public IEnumerable<AppSocialAdvertisement> LoadAll()
            {
                IQueryable<AppSocialAdvertisement> query = this._dbSet;

                //   query = query.Include(a => a.Title);

                return query.ToList();
            }

            public AppSocialAdvertisement Load(int adId)
            {
                IQueryable<AppSocialAdvertisement> query = this._dbSet;

                query = query.Include(a => a.Title);

                return query.FirstOrDefault(a => a.AdvertisementId == adId);
            }
        }
    }
}