using Budweg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Repositories
{
    public class AdminRepository
    {
        private List<Admin> admins = new List<Admin>();
        private List<Admin> displayAdmins = new List<Admin>();

        public void Save()
        {

        }
        public void Delete() 
        {
            
        }
        public Admin CreateAdmin(string name, string email, string password)
        {
            Admin admin = new Admin(name, email, password);
            AddAdmin(admin);
            return admin;
        }
        public void AddAdmin(Admin admin)
        {
            displayAdmins.Add(admin);
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
            List<Admin> result = new List<Admin>();
            foreach (Admin admin in admins)
            {
                    result.Add(admin);
            }
            return result;
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
