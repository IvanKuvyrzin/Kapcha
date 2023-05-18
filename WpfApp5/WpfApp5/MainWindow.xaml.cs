using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            String aa = "";
            aa = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            aa += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            aa += "1,2,3,4,5,6,7,8,9,0";
            aa += "!,@,#,№,*,$";
            char[] a = { ',' };
            String[] ar = aa.Split(a);
            String pwd = "";
            string temp = "";
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }
            TextBox1.Text = pwd;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            int n = TextBox1.Text.CompareTo(TextBox2.Text);
            if (n == 0)
                MessageBox.Show("Верно");
            else
                MessageBox.Show("Не верно");
        }
    }
}
