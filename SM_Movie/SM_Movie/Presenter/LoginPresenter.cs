using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using SM_Movie.Model;
using SM_Movie.View;

namespace SM_Movie.Presenter
{
    class LoginPresenter
    {
        ILogin loginView;
        
        public LoginPresenter(ILogin view)
        {
            loginView = view;
        }

        public bool LoginAttempt()
        {
            Utils.DBUtil db = new Utils.DBUtil();
            if (db.LoginAttempt(loginView.userId, loginView.userPassword))
            {
                return true;

            }
            return false;
        }

    }
}
