using Budweg2._1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg2._1.Repositories
{
    public class EmployeeRepository
    {
        private List<Employee> displayEmployees = new List<Employee>(); //ONLY FOR LOAD METHOD, WPF AND UPDATE METHODS
        private List<Employee> newEmployees = new List<Employee>(); // List for new entrys
        private string connectionString = "Server=10.56.8.36; database=DB_2023_62; user id=STUDENT_62; password=OPENDB_62";

        public void Save()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                foreach (Employee emp in newEmployees)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.EMPLOYEE (Name, Email, Password, Role) VALUES(@Name, @Email, @Password, @Role);", con);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Password", emp.Password);
                    cmd.Parameters.AddWithValue("@Role", emp.EmployeeRole.ToString());
                    cmd.ExecuteNonQuery();
                }
                newEmployees.Clear();
            }
        }

        public void Load()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmployeeID, Name, Email, Password, Role  FROM EMPLOYEE", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee owner = new Employee(reader["Name"].ToString(), reader["Email"].ToString(), reader["Password"].ToString(), (Role)Enum.Parse(typeof(Role), reader["Role"].ToString()));
                        owner.EmployeeId = int.Parse(reader["EmployeeID"].ToString());
                        displayEmployees.Add(owner);
                    }
                }
            }
        }

        public Employee CreateEmployee(string name, string email, string password, Role role)
        {
            Employee employee = new Employee(name, email, password, role);
            AddEmployee(employee);
            return employee;
        }

        public void AddEmployee(Employee employee)
        {
            newEmployees.Add(employee);
        }

        public void UpdateEmployee(int id, int choice, string newData) // Updates from display list
        {
            try
            {
                foreach (Employee emp in displayEmployees)
                {
                    if (choice > 0 && choice < 4)
                    {
                        switch (choice)
                        {
                            case 1:
                                GetUserById(id).Name = newData;
                                break;
                            case 2:
                                GetUserById(id).Email = newData;
                                break;
                            case 3:
                                GetUserById(id).Password = newData;
                                break;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void DeleteEmployee(int id) // Delets from database directly
        {
            for (int i = 0; i < newEmployees.Count; i++)
            {
                if (newEmployees[i].EmployeeId == id)
                {
                    newEmployees.Remove(newEmployees[i]);
                }
            }
        }

        public void SetRole(int choice, int id)
        {
            try
            {
                if (choice > 0 && choice < 4)
                {
                    switch (choice)
                    {
                        case 1:
                            GetUserById(id).EmployeeRole = Role.Foreman;
                            break;
                        case 2:
                            GetUserById(id).EmployeeRole = Role.AssemblyWorker;
                            break;
                        case 3:
                            GetUserById(id).EmployeeRole = Role.QualityManager;
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public bool ValidateEmployee(string email, string password)
        {
            for (int i = 0; i < displayEmployees.Count; i++)
            {
                if (displayEmployees[i].Email.Equals(email) && displayEmployees[i].Password.Equals(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public Employee GetUserById(int id)
        {
            if (id > 0)
                for (int i = id; i < displayEmployees.Count(); i++)
                {
                    if (displayEmployees[i].EmployeeId == id)
                    {
                        return displayEmployees[i];
                    }
                }
            return null;
        }

        public List<Employee> GetAllEmployees()
        {
            return displayEmployees;
        }
    }
}
