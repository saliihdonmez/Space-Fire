namespace SpaceFire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBGemi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pBCan1 = new System.Windows.Forms.PictureBox();
            this.pBCan2 = new System.Windows.Forms.PictureBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBGemi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCan2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pBGemi);
            this.panel1.Location = new System.Drawing.Point(1, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 601);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pBGemi
            // 
            this.pBGemi.Image = ((System.Drawing.Image)(resources.GetObject("pBGemi.Image")));
            this.pBGemi.Location = new System.Drawing.Point(15, 208);
            this.pBGemi.Margin = new System.Windows.Forms.Padding(4);
            this.pBGemi.Name = "pBGemi";
            this.pBGemi.Size = new System.Drawing.Size(133, 62);
            this.pBGemi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBGemi.TabIndex = 0;
            this.pBGemi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1124, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gidilen Mesafe : 0";
            // 
            // pBCan1
            // 
            this.pBCan1.Image = ((System.Drawing.Image)(resources.GetObject("pBCan1.Image")));
            this.pBCan1.Location = new System.Drawing.Point(45, 35);
            this.pBCan1.Name = "pBCan1";
            this.pBCan1.Size = new System.Drawing.Size(25, 24);
            this.pBCan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCan1.TabIndex = 2;
            this.pBCan1.TabStop = false;
            // 
            // pBCan2
            // 
            this.pBCan2.Image = ((System.Drawing.Image)(resources.GetObject("pBCan2.Image")));
            this.pBCan2.Location = new System.Drawing.Point(86, 35);
            this.pBCan2.Name = "pBCan2";
            this.pBCan2.Size = new System.Drawing.Size(25, 24);
            this.pBCan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCan2.TabIndex = 3;
            this.pBCan2.TabStop = false;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(797, 35);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(75, 24);
            this.lblSkor.TabIndex = 4;
            this.lblSkor.Text = "Skor: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 671);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.pBCan2);
            this.Controls.Add(this.pBCan1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Space Fire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBGemi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCan2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBGemi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBCan1;
        private System.Windows.Forms.PictureBox pBCan2;
        private System.Windows.Forms.Label lblSkor;
    }
}

