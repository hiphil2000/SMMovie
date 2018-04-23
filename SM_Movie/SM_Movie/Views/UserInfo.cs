using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Movie.Views
{
    public partial class SearchCinema : UserControl
    {

        bool isEdit;
        public SearchCinema()
        {
            InitializeComponent();
            Changinginformation_Click(null, new EventArgs());
        }

        private void Changinginformation_Click(object sender, EventArgs e)
        {
            if(isEdit)
            {
                userName.Enabled = false;
                userBirthday.Enabled = false;
                id.Enabled = false;
                userPassword.Enabled = false;
                userNickname.Enabled = false;
                userEmail.Enabled = false;
                userPhone.Enabled = false; 
                userAddress.Enabled = false;
                genreSeq.Enabled = false;
                memberShipSeq.Enabled = false;
                Changinginformation.Text = "수정";
            }
            else
            {
                userName.Enabled = true;
                userBirthday.Enabled = true;
                id.Enabled = true;
                userPassword.Enabled = true;
                userNickname.Enabled = true;
                userEmail.Enabled = true;
                userPhone.Enabled = true;
                userAddress.Enabled = true;
                genreSeq.Enabled = true;
                memberShipSeq.Enabled = true;
                Changinginformation.Text = "완료";

            }

            isEdit = !isEdit;
        }
    }
}
