using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialAppAPI
{
    [Route("api/advertisements")]
    public class AdController : ApiController
    {
        static List<AppSocialAdvertisement> AdMock = GetAds();

        // GET api/values
        [HttpGet]
        public IEnumerable<AppSocialAdvertisement> Get()
        {
            return AdMock;
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/advertisements/{id?}")]
        public AppSocialAdvertisement Get(int id)
        {
            return  AdMock[id];
        }

        //[Route("/Categories")]
        //public IEnumerable<AppSocialAdvertisementCategory> GetCategories()
        //{
        //    return GetCats();
        //}

        //public AppSocialAdvertisementCategory GetCategory(int id)
        //{
        //    return GetAd(id);
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //    mock_data.Add(value);
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //    mock_data[id] = value;
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //    mock_data.RemoveAt(id);
        //}


        private static List<AppSocialAdvertisementCategory> GetCats()
        {
            return new List<AppSocialAdvertisementCategory>
            {
                new AppSocialAdvertisementCategory {
                    CategoryName = "Tablets"
                },
                new AppSocialAdvertisementCategory {
                    CategoryName = "Laptops"
                },
                new AppSocialAdvertisementCategory {
                    CategoryName = "Mobiles"
                }
            };
        }

        //private static AppSocialAdvertisement GetAd(int id)
        //{
        //    return AdMock[id];
        //}
        private static List<AppSocialAdvertisement> GetAds()
        {
            return new List<AppSocialAdvertisement>
            {
                new AppSocialAdvertisement {
                    AdvertisementId=0,
                    Category  = "Tablets",
                    Description ="",
                    Title = "Android 4.4 KitKat Tablet PC, Cortex A8 1.2 GHz Dual Core Processor,512MB / 4GB,Dual Camera,G-Sensor (Black)",
                    CategoryId = 1,
                    Price = 46.99m,
                    Image = "http://lorempixel.com/200/200/technics/1/Tablets/",
                    PostedBy=1,
                    PostedOn=DateTime.Now,
                    Status =true


                 },
                new AppSocialAdvertisement {
                        AdvertisementId=1,
                    Category  = "Tablets",
                    Description = "Android 4.4 Kit Kat OS, 1.2 GHz quad-core processor",
                    CategoryId = 2,
                    Price = 120.95m,
                     Image = "http://lorempixel.com/200/200/technics/1/Laptops/",
                    PostedBy=1,
                    PostedOn=DateTime.Now,
                    Status =true
                },

                new AppSocialAdvertisement {
                    AdvertisementId=2,
                    Category  = "Tablets",
                    Description = "NeuTab N7 Pro tablet features the amazing powerful, Quad Core processor performs approximately Double multitasking running speed, and is more reliable than ever",
                    CategoryId = 3,
                    Price = 59.99m,
                    Image = "http://lorempixel.com/200/200/technics/1/Mobiles/",
                    PostedBy=1,
                    PostedOn=DateTime.Now,
                    Status =true
                },
                new AppSocialAdvertisement {
                    AdvertisementId=3,
                    Category  = "Tablets",
                    Description = "Dragon Touch Y88X tablet featuring the incredible powerful Allwinner Quad Core A33, up to four times faster CPU, ensures faster multitasking speed than ever. With the super-portable size, you get a robust power in a device that can be taken everywhere",
                    CategoryId = 1,
                    Price = 54.99m,
                    Image = "http://lorempixel.com/200/200/technics/1/Mobiles/",
                    PostedBy=1,
                    PostedOn=DateTime.Now,
                    Status =true
                },
                new AppSocialAdvertisement {
                    AdvertisementId=4,
                    Category  = "Tablets",
                    Description = "This Alldaymall tablet featuring the incredible powerful Allwinner Quad Core A33, up to four times faster CPU, ensures faster multitasking speed than ever. With the super-portable size, you get a robust power in a device that can be taken everywhere",
                    CategoryId = 2,
                    Price = 47.99m,
                    Image = "http://lorempixel.com/200/200/technics/1/SmartWathes/",
                    PostedBy=1,
                    PostedOn=DateTime.Now,
                    Status =true
                },
                new AppSocialAdvertisement {
                    AdvertisementId=5,
                    Category  = "Tablets",
                    Description = "Pad 7 ME170CX-A1-BK 7-Inch 16GB Tablet. Dual-Core Intel Atom Z2520 1.2GHz CPU",
                    CategoryId = 3,
                    Price = 94.99m,
                    Image = "http://lorempixel.com/200/200/technics/1/Desktops/",
                    PostedBy=1,
                    PostedOn=DateTime.Now,
                    Status =true
                },
                // Code ommitted 
            };
        }
    }





}
