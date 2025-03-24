using BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class ShowUserInfo : UserControl
    {
        clsUser _User = new clsUser();
        
        public ShowUserInfo()
        {
            InitializeComponent();
        }

      
        public void LoadUserInfo(int userID)
        {
            _User = clsGlobalUser.GlobalUser;
            if (_User != null )
                SetUserInfo(_User);

        }

        private void SetUserInfo(clsUser user)
        {
            showPersonInfo1.LoadInfo(user.UPerson.ID);
            LB_UN.Text = user.UserName;
            LB_UID.Text = user.ID.ToString();
            LB_IsActive.Text = user.IsActive.ToString();

        }
    }
}
