using System;

namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.gameTimerr = new System.Windows.Forms.Timer(this.components);
            this.altDirek = new System.Windows.Forms.PictureBox();
            this.ustDirek = new System.Windows.Forms.PictureBox();
            this.salihkafa = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.altDirek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustDirek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salihkafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.77358F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(0, 9);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(104, 39);
            this.scoreLbl.TabIndex = 3;
            this.scoreLbl.Text = "Skor:";
            // 
            // gameTimerr
            // 
            this.gameTimerr.Enabled = true;
            this.gameTimerr.Interval = 20;
            this.gameTimerr.Tick += new System.EventHandler(this.gameTimerevent);
            // 
            // altDirek
            // 
            this.altDirek.Image = global::WindowsFormsApp4.Properties.Resources.kaleyy;
            this.altDirek.Location = new System.Drawing.Point(396, 399);
            this.altDirek.Name = "altDirek";
            this.altDirek.Size = new System.Drawing.Size(150, 384);
            this.altDirek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altDirek.TabIndex = 2;
            this.altDirek.TabStop = false;
            // 
            // ustDirek
            // 
            this.ustDirek.Image = global::WindowsFormsApp4.Properties.Resources.kaleyy;
            this.ustDirek.Location = new System.Drawing.Point(597, -155);
            this.ustDirek.Name = "ustDirek";
            this.ustDirek.Size = new System.Drawing.Size(150, 382);
            this.ustDirek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustDirek.TabIndex = 1;
            this.ustDirek.TabStop = false;
            this.ustDirek.Click += new System.EventHandler(this. ustDirek_Click);
            // 
            // salihkafa
            // 
            this.salihkafa.Image = global::WindowsFormsApp4.Properties.Resources.salih2;
            this.salihkafa.Location = new System.Drawing.Point(59, 255);
            this.salihkafa.Name = "salihkafa";
            this.salihkafa.Size = new System.Drawing.Size(104, 95);
            this.salihkafa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salihkafa.TabIndex = 0;
            this.salihkafa.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.halısahaarkaplan;
            this.pictureBox1.Location = new System.Drawing.Point(-73, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1053, 736);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 658);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.altDirek);
            this.Controls.Add(this.ustDirek);
            this.Controls.Add(this.salihkafa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.altDirek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustDirek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salihkafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ustDirek_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox salihkafa;
        private System.Windows.Forms.PictureBox ustDirek;
        private System.Windows.Forms.PictureBox altDirek;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimerr;
    }
}

