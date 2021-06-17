using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShopSimAndresKarl {
    public partial class Form2 : Form
    {
        ORMtiendaDataContext dataContext = new ORMtiendaDataContext();

        public static List<Orders_Details> lista = new List<Orders_Details>();

        Random rnd;
        //Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
       // Form2 f2;
        public Form2()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point p = new Point(m.LParam.ToInt32());
                p = this.PointToClient(p);
                if (p.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (p.X >= this.ClientSize.Width - cGrip && p.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e) {
            try
            {
                f4.ShowDialog();
            }
            catch
            {
                int cont = 0;
                cont += 1;
            }
            //f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            f3.ShowDialog();
        }

        private void selection_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            var datos = from Products in dataContext.GetTable<Products>()
                        where boton.Name == Products.productID
                        select Products;

            foreach (var value in datos)
            {
                lista.Add(new Orders_Details(logInOLoQueSea.usuario.orderID,value.productID,1,Convert.ToDouble(value.unitPrice)));
            }

            MessageBox.Show("El producto: " + lista[lista.Count() - 1].productID.ToString() + "\n" + "se ha agregado a la orden numero: " + lista[lista.Count() - 1].orderID.ToString());
        }

        private void error_Click(object sender, EventArgs e) {
            MessageBox.Show("FUNCIONALIDAD EN DESARROLLO");
        }
        private void button17_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
