using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemasProject
{
    public static class Session
    {
        public static int UserId { get; set; }

        public static string Nama { get; set; }

        public static string Username { get; set; }

        public static string Role { get; set; }

        public static string Status { get; set; }

        public static bool IsLoggedIn
        {
            get
            {
                return UserId > 0;
            }
        }

        public static void StartSession(
            int userId,
            string nama,
            string username,
            string role,
            string status)
        {
            UserId = userId;
            Nama = nama;
            Username = username;
            Role = role;
            Status = status;
        }

        public static void ClearSession()
        {
            UserId = 0;
            Nama = null;
            Username = null;
            Role = null;
            Status = null;
        }
    }
}
