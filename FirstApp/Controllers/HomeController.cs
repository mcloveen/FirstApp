using Microsoft.AspNetCore.Mvc;


namespace FirstApp.Controllers
{
    public class HomeController:Controller
    {

        public ContentResult Index()
        {
            return new ContentResult { Content = "Home page" };
        }
        public ContentResult About()
        {
            return new ContentResult { Content = "About page" };
        }
        public ContentResult Contact()
        {
            return new ContentResult { Content = "Contact page" };
        }


    }
}
