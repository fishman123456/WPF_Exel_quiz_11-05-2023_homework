using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Exel_quiz_11_05_2023_homework
{
    public class LoginParol
    {
        public string Login { get; set; }
        public string Parol { get;set; }

        public LoginParol() {
            Login = "55";
            Parol = "56";
                }
       public LoginParol (string login, string parol)
        {
            Login = login;
            Parol = parol;
        }
    }
}
