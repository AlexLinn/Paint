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
            string str = "Клавиши управления: \n 1 - Красный цвет \n 2 - Зеленый цвет \n 3- Синий цыет \n 0 - Перемещение курсора \n Е - Режим стирания \n Esc - Выход из режима рисования"; 

            MessageBox.Show(str, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int dX, dY, sizeX, sizeY;
            
            pictureBox1.Cursor = Cursors.Cross;
            btnDraw.Enabled = false;
            pictureBox1.Focus();
            dX = Cursor.Position.X - pictureBox1.PointToClient(Control.MousePosition).X;
            dY = Cursor.Position.Y - pictureBox1.PointToClient(Control.MousePosition).Y;
            Point PBStart = new Point();
            PBStart.X = dX;
            PBStart.Y = dY;
            sizeX = pictureBox1.Size.Width - 2;
            sizeY= pictureBox1.Size.Height - 2;
            Cursor.Clip= new Rectangle(dX, dY, sizeX, sizeY);

            
            
    }

        
        private void KeyPressed(object sender, PreviewKeyDownEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            switch (e.KeyValue)
            {
                case 37: //left
                    Cursor.Position = new Point ( Cursor.Position.X -1, Cursor.Position.Y);
                    
                    g.DrawLine(new Pen(CursorDraw.CursorColor, 1), new Point(pictureBox1.PointToClient(Control.MousePosition).X+1, pictureBox1.PointToClient(Control.MousePosition).Y), new Point(pictureBox1.PointToClient(Control.MousePosition).X, pictureBox1.PointToClient(Control.MousePosition).Y));
                    break;
                case 38: //up
                    Cursor.Position = new Point(Cursor.Position.X , Cursor.Position.Y-1);
                    g.DrawLine(new Pen(CursorDraw.CursorColor, 1), new Point(pictureBox1.PointToClient(Control.MousePosition).X, pictureBox1.PointToClient(Control.MousePosition).Y+1), new Point(pictureBox1.PointToClient(Control.MousePosition).X, pictureBox1.PointToClient(Control.MousePosition).Y));
                    break;
                case 39: //right
                    Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
                    g.DrawLine(new Pen(CursorDraw.CursorColor, 1), new Point(pictureBox1.PointToClient(Control.MousePosition).X-1, pictureBox1.PointToClient(Control.MousePosition).Y), new Point(pictureBox1.PointToClient(Control.MousePosition).X, pictureBox1.PointToClient(Control.MousePosition).Y));
                    break;
                case 40: //down
                    Cursor.Position = new Point(Cursor.Position.X , Cursor.Position.Y +1 );
                    g.DrawLine(new Pen(CursorDraw.CursorColor, 1), new Point(pictureBox1.PointToClient(Control.MousePosition).X, pictureBox1.PointToClient(Control.MousePosition).Y), new Point(pictureBox1.PointToClient(Control.MousePosition).X, pictureBox1.PointToClient(Control.MousePosition).Y -1));
                    break; 
                case 49:  //1
                    CursorDraw.CursorColor = Color.Red;
                    CursorDraw.Draw = true;
                    label1.Text = "Красный цвет пера";
                    label1.ForeColor = Color.Red;
                    break;
                case 50:  //2
                    CursorDraw.CursorColor = Color.Green;
                    CursorDraw.Draw = true;
                    label1.Text = "Зеленый цвет пера";
                    label1.ForeColor = Color.Green;
                    break;
                case 51:  //3
                    CursorDraw.CursorColor = Color.Blue;
                    CursorDraw.Draw = true;
                    label1.Text = "Синий  цвет пера";
                    label1.ForeColor = Color.Blue;
                    break;
                case 48:  //0
                    CursorDraw.CursorColor = Color.Transparent;
                    CursorDraw.Draw = false;
                    label1.Text = "Перемещение";
                    label1.ForeColor = Color.Black;
                    
                    break;
                case 69:  //E
                    CursorDraw.CursorColor = Color.White;
                    CursorDraw.Draw = true;
                    label1.Text = "Стирание";
                    label1.ForeColor = Color.Black;

                    break;
                case 27: //Esc
                    pictureBox1.Cursor = Cursors.Default;
                    CursorDraw.Draw = false;
                    btnDraw.Enabled = true;
                    Cursor.Clip = new Rectangle();
                    break; 
            }
            g.Dispose();
            
            
                
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
            
        }

        private void FormLoad(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
