using System.Web.Mvc;

namespace Celular73A.Web.Areas.Aparelhos
{
    public class AparelhosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Aparelhos";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Aparelhos_default",
                "Aparelhos/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}