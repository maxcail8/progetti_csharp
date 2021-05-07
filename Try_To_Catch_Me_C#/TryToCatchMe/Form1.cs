using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TryToCatchMe
{
    public partial class formPrendimi : Form
    {
        public formPrendimi()
        {
            InitializeComponent();
        }

        private void btnPrendimi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulation!!!");
        }

        private void btnPrendimi_MouseMove(object sender, MouseEventArgs e)
        {
            Random gen = new Random();

            if (ClientSize.Width >= btnPrendimi.Width && ClientSize.Height >= btnPrendimi.Height)
            {
                do
                {
                    btnPrendimi.Left = gen.Next(0, ClientSize.Width - btnPrendimi.Width);
                    btnPrendimi.Top = gen.Next(0, ClientSize.Height - btnPrendimi.Height);
                } while (Cursor.Position.X > btnPrendimi.Left && Cursor.Position.X < btnPrendimi.Left + btnPrendimi.Width || Cursor.Position.Y > btnPrendimi.Top && Cursor.Position.Y < btnPrendimi.Top + btnPrendimi.Height);
            }
        }

        private void formPrendimi_Resize(object sender, EventArgs e)
        {
            if(btnPrendimi.Top > 0)
            {
                if (btnPrendimi.Left > 0)
                {
                    if (btnPrendimi.Left + btnPrendimi.Width > ClientSize.Width)
                        btnPrendimi.Left = ClientSize.Width - btnPrendimi.Width;
                    if (btnPrendimi.Top + btnPrendimi.Height > ClientSize.Height)
                        btnPrendimi.Top = ClientSize.Height - btnPrendimi.Height;
                }
                else
                    if (btnPrendimi.Top + btnPrendimi.Height > ClientSize.Height)
                    btnPrendimi.Top = ClientSize.Height - btnPrendimi.Height;
            }
            else
                if (btnPrendimi.Left + btnPrendimi.Width > ClientSize.Width)
                btnPrendimi.Left = ClientSize.Width - btnPrendimi.Width;
        }

        Stopwatch orologio = new Stopwatch();

        private void formPrendimi_Load(object sender, EventArgs e)
        {
            orologio.Start();
            ActiveControl = lbl;
        }

        private void formPrendimi_MouseMove(object sender, MouseEventArgs e)
        {
            if (orologio.Elapsed.Seconds >= 1.5)
            {
                Width -= 5;
                Height -= 5;
                orologio.Restart();
            }
        }
    }
}
