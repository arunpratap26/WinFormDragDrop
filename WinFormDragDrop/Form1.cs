using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FirstPicBox.AllowDrop = true;
            SecondPicBox.AllowDrop = true;
        }
        private void FirstPicBox_DragDrop(object sender, DragEventArgs e)
        {
            var pic = e.Data.GetData(DataFormats.FileDrop);
            if (pic != null)
            {
                var ImgName = pic as string[];
                if (ImgName.Length > 0)
                {
                    FirstPicBox.Image = Image.FromFile(ImgName[0]);
                }
            }
        }
        private void FirstPicBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void SecondPicBox_DragDrop(object sender, DragEventArgs e)
        {
            SecondPicBox.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap , true);
        }
        private void SecondPicBox_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Bitmap)&&(e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FirstPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left);
            {
                FirstPicBox.DoDragDrop(FirstPicBox.Image, DragDropEffects.Copy);
            }
        }
    }
}
