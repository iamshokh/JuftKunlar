using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Magazin.Models
{
    [Table("User")]
    internal class User
    {
        static DataContext context = new DataContext();
        public int Id { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }

        public static string SignIn(string login, string password)
        {
            var paket = context.Users.FirstOrDefault(a => a.Login == login && a.Password == password);

            if (paket == null)
            {
                return null;
            }
            else return paket.Role;
        }

        public static bool SignUp(string login, string password, string phoneNumber) 
        {
            User user = new User();

            if (login.Length < 5 || context.Users.Where(a => a.Login == login).Any())
            {
                MessageBox.Show("Login 5 ta dan kam yoki tizimda mavjud");
                return false;
            }
            else user.Login = login;

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Qiyinroq parol quying");
                return false;
            }
            else user.Password = password;

            if (!phoneNumber.StartsWith("+998"))
            {
                MessageBox.Show("Telefon raqam hato kiritilgan");
                return false;
            }
            else user.PhoneNumber = phoneNumber;

            user.Role = "Client";
            context.Users.Add(user);
            context.SaveChanges();
            return true;
        }

        private static bool IsValidPassword(string password)
        {
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            var regex = new Regex(passwordPattern);
            return regex.IsMatch(password);
        }
    }

    enum Role
    {
        Client,
        Admin
    }
}
