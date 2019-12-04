using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SpaceFire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        int mesafe = 20;
        int sayac = 0;
        double gidilenMesafe = 0;

        int kalanCan = 2;
        string[] yildizlar;
        int skor = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            YildizYap();
            timer1.Start();
            dusman_olustur();
        }

        void YildizYap()
        {
            StreamReader oku = new StreamReader(@"dat//yildiz.txt");
            string read = oku.ReadToEnd();
            string[] nesneler = read.Split('/');
            yildizlar = nesneler;

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Yukari_Git();
            }

            else if (e.KeyCode == Keys.Down)
            {
                Asagi_Git();
            }

            if (e.KeyCode == Keys.Space)
            {
                mermi_olustur();
            }
        }

        void Yukari_Git()
        {
            if (pBGemi.Location.Y - mesafe > 0)
            {
                pBGemi.Location = new Point(pBGemi.Location.X, pBGemi.Location.Y - mesafe);
            }
        }

        void Asagi_Git()
        {
            if (pBGemi.Location.Y + mesafe + pBGemi.Height < panel1.Height)
            {
                pBGemi.Location = new Point(pBGemi.Location.X, pBGemi.Location.Y + mesafe);
            }

        }

        void dusman_olustur()
        {
            PictureBox enemy = new PictureBox();
            enemy.Width = 133;
            enemy.Height = 62;
            Random rnd = new Random();
            int x = rnd.Next(0, panel1.Height - enemy.Height);

            enemy.ImageLocation = "enemy.png";
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.Location = new Point(panel1.Width - enemy.Width, x);
            enemy.Tag = "dusman";
            panel1.Controls.Add(enemy);
        }
        void mermi_olustur()
        {
            PictureBox mermi = new PictureBox();
            mermi.Width = 30;
            mermi.Height = 10;
            mermi.Location = new Point(pBGemi.Location.X + pBGemi.Width, pBGemi.Location.Y + pBGemi.Height / 2);
            mermi.BackColor = Color.Red;
            mermi.Tag = "mermi";
            panel1.Controls.Add(mermi);


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            gidilenMesafe += 0.1;
            sayac++;
            label1.Text = $"Gidilen Mesafe : {gidilenMesafe.ToString().Split(',')[0]} m";
     


            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                PictureBox pb = (PictureBox)panel1.Controls[i];
                if (panel1.Controls[i].Tag == "mermi")
                {
                    if (pb.Location.X + pb.Width > panel1.Width)
                    {
                        panel1.Controls.RemoveAt(i);
                    }

                    else
                    {
                        pb.Location = new Point(pb.Location.X + 5, pb.Location.Y);
                    }

                    for (int a = 0; a < panel1.Controls.Count; a++)
                    {
                        if (panel1.Controls[a].Tag == "dusman")
                        {
                            if (pb.Location.X + pb.Width > panel1.Controls[a].Location.X && pb.Location.X + pb.Width < panel1.Controls[a].Location.X + panel1.Controls[a].Width)
                            {
                                if (pb.Location.Y + pb.Height > panel1.Controls[a].Location.Y && pb.Location.Y + pb.Height < panel1.Controls[a].Location.Y + panel1.Controls[a].Height)
                                {
                                    panel1.Controls.RemoveAt(a);
                                    panel1.Controls.Remove(pb);
                                    skor += 10;
                                    lblSkor.Text = $"Skor : {skor}";
                                 

                                }
                            }
                        }
                    }

                }

                else if (panel1.Controls[i].Tag == "dusman")
                {
                    if (pb.Location.X < 0)
                    {
                        panel1.Controls.RemoveAt(i);
                    }

                    else
                    {
                        pb.Location = new Point(pb.Location.X - 6, pb.Location.Y);
                        if (pb.Location.X > pBGemi.Location.X && pb.Location.X < pBGemi.Location.X + pBGemi.Width)
                        {
                            if (pb.Location.Y >= pBGemi.Location.Y && pb.Location.Y < pBGemi.Location.Y + pBGemi.Height || pBGemi.Location.Y >= pb.Location.Y && pBGemi.Location.Y < pb.Location.Y + pb.Height)
                            {
                                panel1.Controls.RemoveAt(i);
                                this.Controls.Remove(pBCan2);
                                kalanCan--;
                                if (kalanCan == 0)
                                {

                                    this.Controls.Remove(pBCan1);
                                    timer1.Stop();
                                    DialogResult cevap = MessageBox.Show($" Gidilen mesafe: {gidilenMesafe.ToString().Split(',')[0]} m \n Skorunuz: {skor}\n Yeniden Oynamak İster Misiniz? ", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                    if (cevap==DialogResult.Yes)
                                    {
                                        Application.Restart();
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                }
                            }
                        }
                    }
                }
            }


            if (sayac == 60)
            {
                sayac = 0;

                dusman_olustur();
            }

            for (int i = 0; i < yildizlar.Length; i++)
            {
                int x = Convert.ToInt32(yildizlar[i].Split(',')[0]);
                int y = Convert.ToInt32(yildizlar[i].Split(',')[1]);

                if (x < 0)
                {
                    x = panel1.Width;

                }

                else
                {
                    x--;
                }

                yildizlar[i] = x.ToString() + "," + y.ToString();

            }
            panel1.Refresh();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < yildizlar.Length; i++)
            {
                int x = Convert.ToInt32(yildizlar[i].Split(',')[0]);
                int y = Convert.ToInt32(yildizlar[i].Split(',')[1]);
                SolidBrush firca = new SolidBrush(Color.White);
                e.Graphics.FillEllipse(firca, new Rectangle(x, y, 5, 5));
            }
        }

 
    }
}
