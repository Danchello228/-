using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace RegistrationAndLogin
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
        
    }
}