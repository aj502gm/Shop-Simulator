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

namespace ShopSimAndresKarl
{
    /// <summary>
    /// Lógica de interacción para logInOLoQueSea.xaml
    /// </summary>
    public partial class logInOLoQueSea : UserControl
    {
        ORMtiendaDataContext dataContext = new ORMtiendaDataContext();
        public static user usuario;
        public logInOLoQueSea()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean ac = false;

            var numGen = from Orders_Details in dataContext.GetTable<Orders_Details>()
                         select Orders_Details.orderID;

            Boolean numNuevo = false;
            Random rnd = new Random();
            int orderID = rnd.Next(1000);
            /**while (numNuevo == false)
            {
                foreach(var value in numGen)
                {
                    if (orderID == Convert.ToInt32(value))
                    {
                        rnd = new Random();
                        orderID = rnd.Next(1000);
                    }
                    else
                    {
                        numNuevo = true;
                    }
                }
            }**/

            string name = txbUser.Text;
            string pass = txbPass.Password;

            var credentials = from user in dataContext.GetTable<Users>() select user;
            foreach (var datos in credentials)
            {
                if (datos.userName == name && datos.personalPassword == pass)
                {
                    usuario = new user(datos.userID, name, pass, orderID);
                    ac = true;
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
            }

            if (ac == false)
            {
                MessageBox.Show("Las credenciales ingresadas no son correctas ", "Acceso Denegado");
            }
        }
    }
}
