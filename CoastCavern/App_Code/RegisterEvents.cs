using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.Persistence;

namespace CoastCavern
{
    public class RegisterEvents : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var ctx = applicationContext.DatabaseContext;
            var db = new DatabaseSchemaHelper(ctx.Database, LoggerResolver.Current.Logger, ctx.SqlSyntax);

        
            if (!db.TableExist("Zeit"))
            {
                db.CreateTable<TimeDB>(false);
            }
        }
    }
}