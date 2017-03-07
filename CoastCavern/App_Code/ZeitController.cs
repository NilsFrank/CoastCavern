using System.Collections.Generic;
using System.Web.Http;
using Umbraco.Core.Persistence;
using Umbraco.Web.WebApi;
using Umbraco.Core;

namespace CoastCavern
{
    public class ZeitController : UmbracoApiController
    {
        [HttpGet]
        public void SetTime(string day, string timeFrom, string timeTo)
        {
            var db = ApplicationContext.Current.DatabaseContext.Database;

            var sql = new Sql()
                .Select("*")
                .From("Zeit")
                .Where("Day=@0", day)
                .OrderBy("Id");

            var zeit = db.SingleOrDefault<TimeDB>(sql);

            if (zeit == null)
            {
                zeit = new TimeDB
                {
                    Day = day,
                    TimeTo = timeTo,
                    TimeFrom = timeFrom
                };

                db.Insert(zeit);
            }
            else
            {
                zeit.TimeFrom = timeFrom;
                zeit.TimeTo = timeTo;

                db.Update(zeit);
            }
        }

        [HttpGet]
        public List<string> GetTime(string day)
        {
            var db = ApplicationContext.Current.DatabaseContext.Database;

            var sql = new Sql()
                .Select("*")
                .From("Zeit")
                .Where("Day=@0", day)
                .OrderBy("Id");

            var zeit = db.SingleOrDefault<TimeDB>(sql);
            if (zeit != null)
            {
                List<string> test = new List<string> { zeit.TimeFrom, zeit.TimeTo };
                return test;

            }
            return null;
        }
    }
}