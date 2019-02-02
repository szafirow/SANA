using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            string connectionString ="Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Patryk\\Source\\Repos\\szafirow\\HakerRank\\MySite\\MySite\\App_Data\\Database1.mdf;Integrated Security=True";

            string query = "SELECT nazwa, email FROM KontaktyADO where id = @id";
            int id = 2;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                var nazwa = reader[0];
                var email = reader[1];

                ViewBag.Nazwa = nazwa;
                ViewBag.Email = email;

            }
            


            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}