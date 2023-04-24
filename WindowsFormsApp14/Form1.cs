using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //bool isBlack = false;
            //Pen pen = new Pen(Color.Black);
            //Brush brush = new SolidBrush(Color.Black);
            //Rectangle rect = new Rectangle();
            Graphics gfx = e.Graphics;
            //for (int i = 1; i <= 8; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        if (isBlack)
            //        {
            //            rect = new Rectangle(i * 40, j * 40, 40, 40);
            //            gfx.DrawRectangle(pen, rect);
            //            gfx.FillRectangle(brush, rect);
            //            isBlack = false;
            //        }
            //        else
            //        {
            //            isBlack = true;
            //        }
            //    }
            //    isBlack = !isBlack;
            //}
            Rectangle rectangle = new Rectangle(0, 0, 224, 224);
            TextureBrush texture = new TextureBrush(Image.FromFile(@"C:\Users\Hadjar\source\repos\WindowsFormsApp14\WindowsFormsApp14\Без названия.png"));
            gfx.FillRectangle(texture, rectangle);
            gfx.Dispose();
        }
    }
}
