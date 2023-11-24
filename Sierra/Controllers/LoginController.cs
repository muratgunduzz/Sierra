using Microsoft.AspNetCore.Mvc;
using Sierra.Models;
using System.Data.SqlClient;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(BMEmployee user)
    {
        string connectionString = "Data Source=MURAT\\MURATSQLSERVER;Initial Catalog=BME;Integrated Security=True;";
        string query = "SELECT * FROM Employee WHERE ID = @ID AND PassWord = @Password";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", user.ID);
                command.Parameters.AddWithValue("@Password", user.PassWord);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string level = reader["Level"].ToString();
                            if (level == "lvl5") 
                            {
                                return RedirectToAction("Index","HQ");
                            }
                        }
                        return RedirectToAction("Index", "EmployeeSystem");
                    }
                    else
                    {
                        return Json(new { message = "Giriş başarısız.Kullanıcı adı veya şifre yanlış.", status = "error" });
                    }
                }
            }
        }
    }
}