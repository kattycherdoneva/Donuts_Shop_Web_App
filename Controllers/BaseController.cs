namespace DonutsShopApp.Controllers
{
    using Data;
    using Microsoft.AspNetCore.Mvc;

    public abstract class BaseController : Controller
    {
        protected BaseController(ApplicationDbContext context)
        {
            this.Context = context;
        }

        protected ApplicationDbContext Context { get; }
    }
}