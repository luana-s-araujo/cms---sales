using CMS.project.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.project.VIEWS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string senha = txtsenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            if (dao.EfetuarLogin(email, senha))
            {
                this.Hide();
            }


        }


    }
}
