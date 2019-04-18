using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGameZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Left)
            {
                goright = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Left)
            {
                goup = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Left)
            {
                godown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                shoot(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
        }

        private void gameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                progressBar1.Value = Convert.ToInt32(playerHealth);
            }

            else
            {
                player.Image = Properties.Resources.dead;
                timer1.Stop();
                gameOver = true;
            }

            label1.Text = " Ammo: " + ammo;
            label2.Text = "Kills: " + score;

            if (player.Health < 20)
            {
                progressBar1.ForeColor = System.Drawing.Color.Red;
            }

            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goright && player.Left + player.Width < 930)
            {
                player.Left += speed;
            }

            if (group && player.Top > 60)
            {
                player.Top -= speed;
            }

            if (godown && player.Top + player.Hight < 700)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)

            if (x is PictureBox && x.Tag == "ammo")
            {
                if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                {
                        this.Controls.Remove(((PictureBox)x));
                        ((PicutureBox)x).Dispose();
                        ammo += 5;
                }
            }

            if (x is PictureBox && x.Tag == "bullet")
            {
                if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left < 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                {
                    this.Controls.Remove(((PictureBox)x));
                    ((PictureBox)x).Dispose();
                }
            }

            if (x is PictureBox && x.Tag == "zombie")
            {
                if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                {
                    playerHealth -= 1;
                }

                if (((PictureBox)x).Left > player.Left)
                {
                    ((PictureBox)x).Left -= zombieSpeed;
                    ((PictureBox)x).Image = Properties.Resources.zleft;
                }

                if (((PictureBox)x).Top > player.Top)
                {
                    ((PictureBox)x).Top -= zombieSpeed;
                    ((PictureBox)x).Image = Properties.Resources.zup;
                }

                if (((PictureBox)x).Right > player.Right)
                {
                    ((PictureBox)x).Right -= zombieSpeed;
                    ((PictureBox)x).Image = Properties.Resources.zright;
                }

                if (((PictureBox)x).Down > player.Down)
                {
                    ((PictureBox)x).Down -= zombieSpeed;
                    ((PictureBox)x).Image = Properties.Resources.zdown;
                }
            }

            foreach (Control j in this.Controls)
            {
                if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "zombie"))
                {
                    if (x.Bounds.IntersectsWith (j.Bounds))
                    {
                        score++;
                        this.Controls.Remove(j);
                        j.Dispose();
                        this.Controls.Remove(x);
                        x.Dispose();
                        makeZombies();
                    }
                }
            }


            }

        }

        private void DropAmmo()
        {
        PictureBox ammo = new PictureBox();
        ammo.Image = Properties.Resources.ammo_Image;
        ammo.SizeMode = PictureBoxSizeMode.AutoSize;
        ammo.Left

        }

        private void shoot (string direct)
        {

        }

        private void makeZombies ()
        {

        }

    }
}
