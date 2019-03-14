namespace WinformDragDrop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstPicBox = new System.Windows.Forms.PictureBox();
            this.SecondPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstPicBox
            // 
            this.FirstPicBox.BackColor = System.Drawing.Color.White;
            this.FirstPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FirstPicBox.Location = new System.Drawing.Point(2, 12);
            this.FirstPicBox.Name = "FirstPicBox";
            this.FirstPicBox.Size = new System.Drawing.Size(375, 316);
            this.FirstPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FirstPicBox.TabIndex = 0;
            this.FirstPicBox.TabStop = false;
            this.FirstPicBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FirstPicBox_DragDrop);
            this.FirstPicBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FirstPicBox_DragEnter);
            this.FirstPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirstPicBox_MouseDown);
            // 
            // SecondPicBox
            // 
            this.SecondPicBox.BackColor = System.Drawing.Color.White;
            this.SecondPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondPicBox.Location = new System.Drawing.Point(385, 12);
            this.SecondPicBox.Name = "SecondPicBox";
            this.SecondPicBox.Size = new System.Drawing.Size(375, 316);
            this.SecondPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecondPicBox.TabIndex = 1;
            this.SecondPicBox.TabStop = false;
            this.SecondPicBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SecondPicBox_DragDrop);
            this.SecondPicBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.SecondPicBox_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 354);
            this.Controls.Add(this.SecondPicBox);
            this.Controls.Add(this.FirstPicBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arun Drag And Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FirstPicBox;
        private System.Windows.Forms.PictureBox SecondPicBox;
    }
}

