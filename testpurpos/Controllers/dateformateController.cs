using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testpurpos.Models;

namespace testpurpos.Controllers
{
    public class dateformateController : ApiController
    {
        public IEnumerable<Date> Get()
        {
            using(WebDateDBEntities entity = new WebDateDBEntities())
            {
                return entity.Dates.ToList();
            }
        }


        public void Post([FromBody] Date Date)
        {
            using(WebDateDBEntities entity = new WebDateDBEntities())
            {
                entity.Dates.Add(Date);
                entity.SaveChanges();
            }
        }
    }
}
