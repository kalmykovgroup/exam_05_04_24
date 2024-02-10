using exam_05_04_24.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.viewModel
{
    internal class LoginViewModel
    {
        public Login Login { get; set; }

        public LoginViewModel(Login login)
        {
            Login = login;
        }
    }
}
