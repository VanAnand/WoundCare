using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WoundCare.API.Models;
using WoundCare.Data;
using WoundCare.Data.Models;

namespace WoundCare.API.Controllers
{
    [RoutePrefix("api/wound")]
    public class WoundController : ApiController
    {

        private GMIContext gmiContext = new GMIContext();

        [Route("saveWoundData")]
        [HttpPost]
        public void SaveWoundData(WoundCareMobileData woundCareMobileData)
        {
            try
            {
                MobileWoundData mobileWoundData = new MobileWoundData();
                mobileWoundData.Data = Newtonsoft.Json.JsonConvert.SerializeObject(woundCareMobileData); 
                gmiContext.MobileWoundData.Add(mobileWoundData);
                gmiContext.SaveChanges();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
