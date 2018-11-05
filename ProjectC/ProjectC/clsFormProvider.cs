using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectC
{
    class clsFormProvider
    {
        public static LoginForm loginF
        {
            get
            {
                if (_login == null)
                {
                    _login = new LoginForm();
                }
                return _login;
            }
        }
        private static LoginForm _login;

        public static MainForm mainF
        {
            get
            {
                if (_mainF == null)
                {
                    _mainF = new MainForm();
                }
                return _mainF;
            }
        }
        private static MainForm _mainF;
    }
}
