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
    /// Lógica de interacción para bugReport.xaml
    /// </summary>
    public partial class bugReport : UserControl
    {
        ORMtiendaDataContext dataContext = new ORMtiendaDataContext();
        bugsReport bug = new bugsReport();

        public bugReport()
        {
            InitializeComponent();
        }

        private void btnEnvio_Click(object sender, RoutedEventArgs e)
        {
            String problema = txbReport.Text;

            bug.userID = logInOLoQueSea.usuario.userID;
            bug.problemDescription = txbReport.Text;
            bug.isFixed = 0;
            
            dataContext.bugsReport.InsertOnSubmit(bug);
            dataContext.SubmitChanges();

            MessageBox.Show("El reporte ha sido enviado exitosamente", "Reporte enviado");
        }

        private void ingTexto(Object sender, RoutedEventArgs e)
        {
            txbReport.Text = "";
        }
    }
}
