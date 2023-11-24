using Microsoft.AspNetCore.Mvc;
using Sierra.Models;
using System.Data.SqlClient;

namespace Sierra.Controllers
{
    public class EmployeeSystemController : Controller
    {
        private string connectionString = "Data Source=MURAT\\MURATSQLSERVER;Initial Catalog=BME;Integrated Security=True;";

        public IActionResult Index()
        {
            List<BMEmployee> employees = GetEmployees();
            return View(employees);
        }

        private List<BMEmployee> GetEmployees()
        {
            List<BMEmployee> employees = new List<BMEmployee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BMEmployee employee = new BMEmployee
                        {
                            ID = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),
                            PassWord = reader["PassWord"].ToString(),
                            Sector = reader["Sector"].ToString(),
                            Level = reader["Level"].ToString()
                        };

                        employees.Add(employee);
                    }
                }
            }
            return employees;
        }
    }
}