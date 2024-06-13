using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFTest
{
    public class LoginVM:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private readonly LoginMdel _LoginMdel = new LoginMdel();

        public string UserName
        {
            get{ return _LoginMdel.UserName; }
            set 
            { 
                _LoginMdel.UserName = value;
                RaisePropertyChanged("UserName");
            } 
        }


        public string Password
        {
            get { return _LoginMdel.Password; }
            set
            {
                _LoginMdel.Password = value;
                RaisePropertyChanged("Password");
            }
        }


        public async Task Login()
        {
            if (UserName == "admin" && Password == "123")
            {
                MessageBox.Show("登录成功");
            }
            else
            {
                MessageBox.Show("账号密码错误，请重试！");
                UserName = "";
                Password = "";

            }
        }

        bool CanLoginExecyte()
        {
            return true;
        }

        public ICommand LoginAction
        {
            get {
                return 
                new AsyncRelayCommand(Login, CanLoginExecyte);
            }
            
        }
    }
}
