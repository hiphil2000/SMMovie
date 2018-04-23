using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Movie
{
    public partial class SettingPanel : UserControl
    {
        Dictionary<string, Color> ColorDic = new Dictionary<string, Color>();
        Main main;

        public SettingPanel()
        {
            InitializeComponent();
            ColorDic.Add("Color1", Color1.BackColor);
            ColorDic.Add("Color2", Color2.BackColor);
            ColorDic.Add("Color3", Color3.BackColor);
            ColorDic.Add("Color4", Color4.BackColor);
            ColorDic.Add("Color5", Color5.BackColor);
            ColorDic.Add("Color6", Color6.BackColor);
            ColorDic.Add("Color7", Color7.BackColor);
            ColorDic.Add("Color8", Color8.BackColor);
            ColorDic.Add("Color9", Color9.BackColor);
            ColorDic.Add("Color10", Color10.BackColor);
            ColorDic.Add("Color11", Color11.BackColor);
            ColorDic.Add("Color12", Color12.BackColor);
            ColorDic.Add("Color13", Color13.BackColor);
            ColorDic.Add("Color14", Color14.BackColor);
            ColorDic.Add("Color15", Color15.BackColor);
            ColorDic.Add("Color16", Color16.BackColor);
            ColorDic.Add("Color17", Color17.BackColor);
            ColorDic.Add("Color18", Color18.BackColor);
            ColorDic.Add("Color19", Color19.BackColor);
            ColorDic.Add("Color20", Color20.BackColor);
            ColorDic.Add("Color21", Color21.BackColor);
            ColorDic.Add("Color22", Color22.BackColor);
            ColorDic.Add("Color23", Color23.BackColor);
            ColorDic.Add("Color24", Color24.BackColor);
            ColorDic.Add("Color25", Color25.BackColor);
            ColorDic.Add("Color26", Color26.BackColor);
            ColorDic.Add("Color27", Color27.BackColor);
            ColorDic.Add("Color28", Color28.BackColor);
            ColorDic.Add("Color29", Color29.BackColor);
            ColorDic.Add("Color30", Color30.BackColor);
            ColorDic.Add("Color31", Color31.BackColor);
            ColorDic.Add("Color32", Color32.BackColor);
            Color1.Click += setThemeColor;
            Color2.Click += setThemeColor;
            Color3.Click += setThemeColor;
            Color4.Click += setThemeColor;
            Color5.Click += setThemeColor;
            Color6.Click += setThemeColor;
            Color7.Click += setThemeColor;
            Color8.Click += setThemeColor;
            Color9.Click += setThemeColor;
            Color10.Click += setThemeColor;
            Color11.Click += setThemeColor;
            Color12.Click += setThemeColor;
            Color13.Click += setThemeColor;
            Color14.Click += setThemeColor;
            Color15.Click += setThemeColor;
            Color16.Click += setThemeColor;
            Color17.Click += setThemeColor;
            Color18.Click += setThemeColor;
            Color19.Click += setThemeColor;
            Color20.Click += setThemeColor;
            Color21.Click += setThemeColor;
            Color22.Click += setThemeColor;
            Color23.Click += setThemeColor;
            Color24.Click += setThemeColor;
            Color25.Click += setThemeColor;
            Color26.Click += setThemeColor;
            Color27.Click += setThemeColor;
            Color28.Click += setThemeColor;
            Color29.Click += setThemeColor;
            Color30.Click += setThemeColor;
            Color31.Click += setThemeColor;
            Color32.Click += setThemeColor;

        }

        private void setThemeColor(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            main.setThemeColor(ColorDic[control.Name]);
        }

        public void setMain(Main main)
        {
            this.main = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void argbSetting_Click(object sender, EventArgs e)
        {
            string colorCode = InputColorCode.Text;
            int a = int.Parse(colorCode.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            int r = int.Parse(colorCode.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            int g = int.Parse(colorCode.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
            int b = int.Parse(colorCode.Substring(7, 2), System.Globalization.NumberStyles.HexNumber);
            main.setThemeColor(Color.FromArgb(a, r, g, b));
        }
    }
}
