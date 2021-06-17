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
using System.IO;

namespace ShopSimAndresKarl
{
    /// <summary>
    /// Lógica de interacción para pagosControler.xaml
    /// </summary>
    public partial class pagosControler : UserControl
    {
        ORMtiendaDataContext dataContext = new ORMtiendaDataContext();

        /**public pagosControler()
        {
            InitializeComponent();
        }**/

        public pagosControler()
        {
            InitializeComponent();

            var convImg = new ImageSourceConverter();

            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            imgPago.Source = (ImageSource)convImg.ConvertFromString(dir + "/imagenes/button1.Image.png");

            imgMasterCard.Source = (ImageSource)convImg.ConvertFromString(dir + "/imagenes/radioButton3.Image.png");
            imgVisa.Source = (ImageSource)convImg.ConvertFromString(dir + "/imagenes/radioButton1.Image.png");
            imgPaypal.Source = (ImageSource)convImg.ConvertFromString(dir + "/imagenes/radioButton2.Image.png");


            dtgFactura.ItemsSource = Form2.lista;

        }

        private void borrarTxb(Object sender, RoutedEventArgs e)
        {
            txbCardNum.Text = "";
        }

        public double suma = 0;
        public double totalfinal = 0;
        public Boolean terminado = false;

        private void pago_Handler(Object sender, RoutedEventArgs e)
        {

            foreach (var value in Form2.lista)
            {
                suma += Convert.ToDouble(value.subtotal);
            }

            Orders orden = new Orders();
            orden.orderID = logInOLoQueSea.usuario.orderID;
            orden.userID = logInOLoQueSea.usuario.userID;
            orden.total = suma;

            dataContext.Orders.InsertOnSubmit(orden);

            foreach (var value in Form2.lista)
            {
                dataContext.Orders_Details.InsertOnSubmit(value);
                dataContext.SubmitChanges();
            }

            MessageBox.Show("El pago se ha llevado a cabo de forma exitosa ", "Pago Exitoso");
            terminado = true;
        }
    }
}
