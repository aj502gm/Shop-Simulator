using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;

namespace ShopSimAndresKarl {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, false);
        }
        /*PERMITIR QUE SE PUEDA ARRASTRAR LA VENTANA SIN HACER SIZABLE*/
        Form2 f2 = new Form2();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x84) {
                Point p = new Point(m.LParam.ToInt32());
                p = this.PointToClient(p);
                if (p.Y < cCaption) {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (p.X >= this.ClientSize.Width - cGrip && p.Y >= this.ClientSize.Height - cGrip) {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void Form1_Load(object sender, EventArgs e) {

            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //imgCerrar.Source = (ImageSource)convImg.ConvertFromString(dir + "/imagenes/button17.Image.png");

            btnSalir.Image = Image.FromFile(dir + "/imagenes/button17.Image.png");

            
        }

        /**private void panel1_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e) {
            f2.ShowDialog();
            
        }

        private void button17_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e) {
            MessageBox.Show("FUNCIONALIDAD EN DESARROLLO");
        }**/

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
