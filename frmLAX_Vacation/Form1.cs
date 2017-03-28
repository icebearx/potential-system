//Designed and developed by Noah Schrayter
//Vacation scheduling system for Los Angeles Union Station
//Ver 1.0
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLAX_Vacation
{
    public partial class frmLAX_VacationPlanner : Form
    {
        public frmLAX_VacationPlanner()
        {
            InitializeComponent();
        }

        private void frmLAX_VacationPlanner_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User_Login win = new User_Login();
            win.ShowDialog();
           // this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }//end of frmLAX_VacationPlanner : Form 
}
