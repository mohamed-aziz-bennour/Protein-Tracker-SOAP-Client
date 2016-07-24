using ProteinTrackerClient.ProteinTrackerService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProteinTrackerClient
{
    public partial class ProteinTrackerForm : Form
    {
        private ProteinTrackingServiceSoapClient service = new ProteinTrackingServiceSoapClient() ;
        private User[] users;

        public ProteinTrackerForm()
        {
            InitializeComponent();
        }

    
        private void onLoad(object sender, EventArgs e)
        {
            users = service.ListUsers();
            cboSelectUser.DataSource = users;
            cboSelectUser.DisplayMember = "Name";
            cboSelectUser.ValueMember = "UserId";

        }

       

        private void OnAddNewUser(object sender, EventArgs e)
        {
            service.AddUser(TxtName.Text, int.Parse(TxtGoal.Text));
            users = service.ListUsers();
            cboSelectUser.DataSource = users;
            cboSelectUser.DisplayMember = "Name";
            cboSelectUser.ValueMember = "UserId";
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            var index = cboSelectUser.SelectedIndex; 
            IblTotal.Text = users[index].Total.ToString() ;
            IblGoal.Text = users[index].Goal.ToString();
        }

        async private void OnAddProtein(object sender, EventArgs e)
        {
            var userId = users[cboSelectUser.SelectedIndex].UserId;
            var newTotal = await service.AddProteinAsync(int.Parse(TxtAmount.Text),userId);
            users[cboSelectUser.SelectedIndex].Total = newTotal;
            IblTotal.Text = newTotal.ToString();  
        }
    }
}
