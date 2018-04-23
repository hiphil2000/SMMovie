using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM_Movie.Model;
using System.Text.RegularExpressions;

namespace SM_Movie
{
    public partial class signup : UserControl
    {
		login login;
        Utils.DBUtil db;
        Dictionary<string, ButtonInfo> buttonDictionary = new Dictionary<string, ButtonInfo>();
        User registerUser;

		public signup()
        {
            InitializeComponent();
			buttonDictionary.Add("closeButton", new ButtonInfo(closeButtonIcon, closeButtonPane));
        }

		private void buttonFocus(object sender, EventArgs e)
		{
			Color color = Color.FromArgb(125, 255, 0, 0);
			Control con = (Control)sender;
			string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
			buttonDictionary[name].Get_buttonPanel().BackColor = color;

		}

        internal void setColor(Color themeColor)
        {
            leftPanel.BackColor = themeColor;
        }

        private void buttonLostFocus(object sender, EventArgs e)
		{
			Color color = Color.FromArgb(0, 0, 0, 0);
			Control con = (Control)sender;
			string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
			buttonDictionary[name].Get_buttonPanel().BackColor = color;
		}

		private void genreSeq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		public void setLogin(login login)
		{
			this.login = login;
            db = login.getDBUtil();

            Genre gen = new Genre();
            DataTable genDt = gen.getGenreList();
            int i = 0;
            foreach (DataRow dr in genDt.Rows)
            {
                genreSeq.Items.Add(dr[i++]);
            }

            MemberShip mem = new MemberShip();
        }

		private void closeButtonIcon_Click(object sender, EventArgs e)
		{
			login.Dispose();
		}

        private void BackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.openPage("login");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validateInputs())
            {
                registerUser = new User(0, userName.Text, userBirthday.Value, userId.Text, userPassword.Text, userNickname.Text, userEmail.Text, userPhone.Text, userAddress.Text,
                    new Genre().getGenreSeq(genreSeq.SelectedItem.ToString()), new MemberShip().getMemberShipSeq("B등급 회원"));
                if(db.register(registerUser))
                {
                    MessageBox.Show("회원가입에 성공했습니다.\n환영합니다 [" + registerUser._userName + "]님.", "가입 성공");
                    login.Dispose();
                }
                else
                {
                    MessageBox.Show("가입에 실패했습니다. 잘못된 데이터를 넣진 않았는지 확인해주십시오.", "가입실패");
                }
            }
        }

        private bool validateInputs()
        {
            bool isValidated = true;
            //검증코드


            return isValidated;
        }
    }
}
