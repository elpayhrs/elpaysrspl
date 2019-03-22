using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapidateformate.Models;

namespace webapidateformate.Controllers
{
    public class dateformateController : ApiController
    {
        public IEnumerable<Date> Get()
        {
            using(WebDateDBEntities entities = new WebDateDBEntities())
            {
                return entities.Dates.ToList();
            }
        }

        public void Post([FromBody] Date Date)
        {
            using(WebDateDBEntities entities = new WebDateDBEntities())
            {
                entities.Dates.Add(Date);
                entities.SaveChanges();
            }
        }
    }
}
