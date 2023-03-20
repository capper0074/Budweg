using Budweg2._1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Budweg2._1.Repositories
{
    public class AdminRepository
    {
        private List<Admin> admins = new List<Admin>();
        private List<Admin> displayAdmins = new List<Admin>();
        private string connectionString = "Server=10.56.8.36; database=DB_2023_62; user id=STUDENT_62; password=OPENDB_62";

        public void Save()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                foreach (Admin admin in admins)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO ADMIN (Name, AdminEmail, Password) VALUES(@Name, @AdminEmail, @Password);", con);
                    cmd.Parameters.AddWithValue("@Name", admin.Name);
                    cmd.Parameters.AddWithValue("@AdminEmail", admin.Email);
                    cmd.Parameters.AddWithValue("@Password", admin.Password);
                    cmd.ExecuteNonQuery();
                }
                admins.Clear();
            }
        }
        public void Load()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name, AdminEmail, Password FROM [ADMIN]", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Admin adm = new Admin(reader["Name"].ToString(), reader["AdminEmail"].ToString(), reader["Password"].ToString());
                        displayAdmins.Add(adm);
                    }
                }
            }
        }
        public Admin CreateAdmin(string name, string email, string password)
        {
            Admin admin = new Admin(name, email, password);
            AddAdmin(admin);
            return admin;
        }
        public void AddAdmin(Admin admin)
        {
            admins.Add(admin);
        }
        public void UpdateAdmin(string email, int choice, string newData)
        {
            try
            {
                if (choice > 0 && choice < 4)
                {
                    switch (choice)
                    {
                        case 1:
                            GetAdmin(email).Email = email;
                            break;
                        case 2:
                            GetAdmin(email).Password = newData;
                            break;
                        case 3:
                            GetAdmin(email).Name = newData;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Admin GetAdmin(string email)
        {
            foreach (Admin admin in admins)
            {
                if (admin.Email == email)
                    return admin;
            }
            return null;
        }

        public List<Admin> GetAdmins()
        {
            return displayAdmins;
        }

        public void DeleteAdmin(string email)
        {
            foreach (Admin admin in admins)
            {
                if (admin.Email == email)
                    admins.Remove(admin);
            }
        }
    }
}
