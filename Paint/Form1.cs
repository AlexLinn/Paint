using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Paint
{
    public partial class frmPaint : Form
    {
        public frmPaint()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Program created .....", "About", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "Что бы выбрать цвет пера надо: ......"; // Строковая переменная с описание помощи
            MessageBox.Show(str, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            label1.Text = "Moving";
            pictureBox1.Cursor = Cursors.Cross;
            btnDraw.Enabled = false;
            pictureBox1.Focus();
            Cursor.Clip= new Rectangle(pictureBox1.Location, pictureBox1.Size);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void KeyPressed(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 37: //left
                    Cursor.Position = new Point ( Cursor.Position.X -1, Cursor.Position.Y);
                    
                    break;
                case 38: //up
                    Cursor.Position = new Point(Cursor.Position.X , Cursor.Position.Y-1);
                    break;
                case 39: //right
                    Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
                    break;
                case 40: //down
                    Cursor.Position = new Point(Cursor.Position.X , Cursor.Position.Y +1 );
                    break; 
                case 49:  //1
                    CursorDraw.CursorColor = Color.Red;
                    CursorDraw.Draw = true;
                    label1.Text = "Drawing";
                    label1.ForeColor = Color.Red;
                    break;
                case 50:  //2
                    CursorDraw.CursorColor = Color.Green;
                    CursorDraw.Draw = true;
                    label1.Text = "Drawing";
                    label1.ForeColor = Color.Green;
                    break;
                case 51:  //3
                    CursorDraw.CursorColor = Color.Blue;
                    CursorDraw.Draw = true;
                    label1.Text = "Drawing";
                    label1.ForeColor = Color.Blue;
                    break;
                case 48:  //0
                    CursorDraw.CursorColor = Color.Transparent;
                    CursorDraw.Draw = false;
                    label1.Text = "Moving";
                    label1.ForeColor = Color.Black;
                    
                    break;
                case 69:  //E
                    CursorDraw.CursorColor = Color.White;
                    CursorDraw.Draw = true;
                    label1.Text = "Erasing";
                    label1.ForeColor = Color.Black;

                    break;
                case 27: //Esc
                    pictureBox1.Cursor = Cursors.Default;
                    label1.Text = "Waiting";
                    label1.ForeColor = Color.Black;
                    btnDraw.Enabled = true;
                    Cursor.Clip = new Rectangle();
                    break; 
            }
            
            //MessageBox.Show("Pressed" + e.KeyValue, "Key pressed");
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MouseMovePictureBox(object sender, MouseEventArgs e)
        {
            label2.Text = "Koord. X: "+ Cursor.Position.X + " Y: " + Cursor.Position.Y;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Form: " + frmPaint.ActiveForm.Location.X +", " + frmPaint.ActiveForm.Location.Y + ". PictureBox: " + pictureBox1.Left + ", "+ pictureBox1.Top + ". " );
        }
    }
}
