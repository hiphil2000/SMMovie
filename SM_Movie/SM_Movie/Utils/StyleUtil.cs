using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Utils
{
    class StyleUtil
    {

        public static Color getWindowsThemeColor()
        {
            try {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\DWM"))
                {
                    if(key != null)
                    {
                        int value = Convert.ToInt32(key.GetValue("ColorizationColor"));
                        return Color.FromArgb(value);
                    }
                }
                return Color.FromArgb(255, 0, 0);
            } catch(Exception e)
            {
                return Color.FromArgb(255, 0, 0);
            }
        }
    }
}
