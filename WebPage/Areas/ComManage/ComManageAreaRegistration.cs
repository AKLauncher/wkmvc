using System.Web.Mvc;

namespace WebPage.Area.ComManage
{
    public class ComManageAreaRegistration:AreaRegistration
    {
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ComManage_default",
                "Com/{controller}/{action}/{id}",
                new {action = "Index", id = UrlParameter.Optional},
                new[] {"WebPage.Areas.ComManage.Controllers"}
            );
        }

        public override string AreaName => "ComManage";
    }
}