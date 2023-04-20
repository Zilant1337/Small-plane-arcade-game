using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Semes_3
{
    public partial class Form1 : Form
    {
        Player plane;
        Bullet missile;
        Enemy enemy1;
        Enemy enemy2;
        Enemy enemy3;
        Enemy enemy4;
        Enemy enemy5;
        Enemy enemy6;

        public Random rng = new Random();
        public int enemyCount=1;

        public int enemySpeed=3;
        public int playerSpeed = 10 ;
        public int missileSpeed =20 ;
        
        public Image playerSprite = Image.FromFile(Directory.GetCurrentDirectory() + "\\Plane.png");
        public Image enemySprite = Image.FromFile(Directory.GetCurrentDirectory() + "\\Enemy.png");
        public Image missileSprite = Image.FromFile(Directory.GetCurrentDirectory() + "\\Bullet.png");

        SoundPlayer gunShot = new SoundPlayer("blastershot.wav");
        SoundPlayer explosion = new SoundPlayer("explosion.wav");

        public Form1()
        {
            InitializeComponent();
            Form2 menu = new Form2(this);
            menu.ShowDialog();
            FPS.Start();
            FPS.Interval = 1;
            FPS.Tick += new EventHandler(refresh);
            Init();
            Invalidate();


        }


        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FPS_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Init()
        {
            plane = new Player(249, 300);
            missile = new Bullet(1000,1000,false);
            switch (enemyCount)
            {
                case 1:
                    { enemy1 = new Enemy(50, 10);}
                    break;
                case 2:
                    {
                        enemy1 = new Enemy(50, 10);
                        enemy2 = new Enemy(100, 10);
                      
                    }
                    break;
                case 3:
                    {
                        enemy1 = new Enemy(50, 10);
                        enemy2 = new Enemy(100, 10);
                        enemy3 = new Enemy(150, 10);
                        
                    }
                    break;
                case 4:
                    {
                        enemy1 = new Enemy(50, 10);
                        enemy2 = new Enemy(100, 10);
                        enemy3 = new Enemy(150, 10);
                        enemy4 = new Enemy(200, 10);
                       
                    }
                    break;
                case 5:
                    {
                        enemy1 = new Enemy(50, 10);
                        enemy2 = new Enemy(100, 10);
                        enemy3 = new Enemy(150, 10);
                        enemy4 = new Enemy(200, 10);
                        enemy4 = new Enemy(250, 10);
                        enemy5 = new Enemy(300, 10);
                        
                    }
                    break;
                case 6:
                    {
                        enemy1 = new Enemy(50, 10);
                        enemy2 = new Enemy(100, 10);
                        enemy3 = new Enemy(150, 10);
                        enemy4 = new Enemy(200, 10);
                        enemy4 = new Enemy(250, 10);
                        enemy5 = new Enemy(300, 10);
                        enemy6 = new Enemy(350, 10);
                        
                    }
                    break;
            }

        }


    public void refresh(object sender, EventArgs e)
    {

        if (plane.x >= (530 - 32)|| plane.x <= 0)
            {
                explosion.Play();
                plane.isNotHit = false;
                FPS.Stop();
                Init();               
            }
            
            if (missile.present && missile.y >= 0)
            {
                missile.y -=missileSpeed;
            }
            if (missile.present && missile.y <= 0)
            {
                missile.present = false;
                missile.x = 1000;
            }

            switch (enemyCount)
            {
                case 1:
                    {
                        if (Collide1(missile, enemy1))
                        {
                            plane.score++;
                            missile.present = false;
                            missile.x = 1000;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy1))
                        {
                            missile.x = 1000;
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                        }
                    }
                    break;
                case 2:
                    {
                        if (Collide1(missile, enemy1))
                        {
                            plane.score++;
                            missile.present = false;
                            missile.x = 1000;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy1))
                        {
                            missile.x = 1000;
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide1(missile, enemy2))
                        {
                            plane.score++;
                            missile.x = 1000;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy2))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;

                        }
                    }
                    break;
                case 3:
                    {
                        if (Collide1(missile, enemy1))
                        {
                            plane.score++;
                            missile.present = false;
                            missile.x = 1000;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy1))
                        {
                            missile.x = 1000;
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide1(missile, enemy2))
                        {
                            plane.score++;
                            missile.x = 1000;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy2))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy3))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy3))
                        {
                            missile.present = false;
                            plane.score++;
                            explosion.Play();
                            missile.x = 1000;
                        }

                    }
                    break;
                case 4:
                    {
                        if (Collide1(missile, enemy1))
                        {
                            plane.score++;
                            missile.present = false;
                            missile.x = 1000;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy1))
                        {
                            missile.x = 1000;
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide1(missile, enemy2))
                        {
                            plane.score++;
                            missile.x = 1000;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy2))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy3))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy3))
                        {
                            missile.present = false;
                            plane.score++;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy4))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy4))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }

                    }
                    break;
                case 5:
                    {
                        if (Collide1(missile, enemy1))
                        {
                            plane.score++;
                            missile.present = false;
                            missile.x = 1000;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy1))
                        {
                            missile.x = 1000;
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide1(missile, enemy2))
                        {
                            plane.score++;
                            missile.x = 1000;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy2))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy3))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy3))
                        {
                            missile.present = false;
                            plane.score++;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy4))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy4))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy5))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy5))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }

                    }
                    break;
                case 6:
                    {
                        if (Collide1(missile, enemy1))
                        {
                            plane.score++;
                            missile.present = false;
                            missile.x = 1000;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy1))
                        {
                            missile.x = 1000;
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide1(missile, enemy2))
                        {
                            plane.score++;
                            missile.x = 1000;
                            missile.present = false;
                            explosion.Play();
                        }
                        if (Collide2(missile, enemy2))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy3))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy3))
                        {
                            missile.present = false;
                            plane.score++;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy4))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy4))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy5))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy5))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide1(missile, enemy6))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }
                        if (Collide2(missile, enemy6))
                        {
                            plane.score++;
                            missile.present = false;
                            explosion.Play();
                            missile.x = 1000;
                        }

                    }
                    break;
            }

            
            if (plane.score != 0) { this.Text = "Score: " + plane.score.ToString(); }
            switch (enemyCount)
            {
                case 1:
                    {
                        if (enemy1.x >= 530 - 30)
                        {
                            enemy1.movingSide = 'l';
                        }
                        if (enemy1.x <= 0)
                        {
                            enemy1.movingSide = 'r';
                        }
                    }
                    break;
                case 2:
                    {
                        if (enemy1.x >= 530 - 30)
                        {
                            enemy1.movingSide = 'l';
                        }
                        if (enemy1.x <= 0)
                        {
                            enemy1.movingSide = 'r';
                        }

                        if (enemy2.x >= 530 - 30)
                        {
                            enemy2.movingSide = 'l';
                        }
                        if (enemy2.x <= 0)
                        {
                            enemy2.movingSide = 'r';
                        }

                    }
                    break;
                case 3:
                    {
                        if (enemy1.x >= 530 - 30)
                        {
                            enemy1.movingSide = 'l';
                        }
                        if (enemy1.x <= 0)
                        {
                            enemy1.movingSide = 'r';
                        }

                        if (enemy2.x >= 530 - 30)
                        {
                            enemy2.movingSide = 'l';
                        }
                        if (enemy2.x <= 0)
                        {
                            enemy2.movingSide = 'r';
                        }
                        if (enemy3.x >= 530 - 30)
                        {
                            enemy3.movingSide = 'l';
                        }
                        if (enemy3.x <= 0)
                        {
                            enemy3.movingSide = 'r';
                        }

                    }
                    break;
                case 4:
                    {
                        if (enemy1.x >= 530 - 30)
                        {
                            enemy1.movingSide = 'l';
                        }
                        if (enemy1.x <= 0)
                        {
                            enemy1.movingSide = 'r';
                        }

                        if (enemy2.x >= 530 - 30)
                        {
                            enemy2.movingSide = 'l';
                        }
                        if (enemy2.x <= 0)
                        {
                            enemy2.movingSide = 'r';
                        }
                        if (enemy3.x >= 530 - 30)
                        {
                            enemy3.movingSide = 'l';
                        }
                        if (enemy3.x <= 0)
                        {
                            enemy3.movingSide = 'r';
                        }
                        if (enemy4.x >= 530 - 30)
                        {
                            enemy4.movingSide = 'l';
                        }
                        if (enemy4.x <= 0)
                        {
                            enemy4.movingSide = 'r';
                        }

                    }
                    break;
                case 5:
                    {
                        if (enemy1.x >= 530 - 30)
                        {
                            enemy1.movingSide = 'l';
                        }
                        if (enemy1.x <= 0)
                        {
                            enemy1.movingSide = 'r';
                        }

                        if (enemy2.x >= 530 - 30)
                        {
                            enemy2.movingSide = 'l';
                        }
                        if (enemy2.x <= 0)
                        {
                            enemy2.movingSide = 'r';
                        }
                        if (enemy3.x >= 530 - 30)
                        {
                            enemy3.movingSide = 'l';
                        }
                        if (enemy3.x <= 0)
                        {
                            enemy3.movingSide = 'r';
                        }
                        if (enemy4.x >= 530 - 30)
                        {
                            enemy4.movingSide = 'l';
                        }
                        if (enemy4.x <= 0)
                        {
                            enemy4.movingSide = 'r';
                        }
                        if (enemy5.x >= 530 - 30)
                        {
                            enemy5.movingSide = 'l';
                        }
                        if (enemy5.x <= 0)
                        {
                            enemy5.movingSide = 'r';
                        }

                    }
                    break;
                case 6:
                    {
                        if(enemy1.x >= 530 - 30)
                        {
                            enemy1.movingSide = 'l';
                        }
                        if (enemy1.x <= 0)
                        {
                            enemy1.movingSide = 'r';
                        }

                        if (enemy2.x >= 530 - 30)
                        {
                            enemy2.movingSide = 'l';
                        }
                        if (enemy2.x <= 0)
                        {
                            enemy2.movingSide = 'r';
                        }
                        if (enemy3.x >= 530 - 30)
                        {
                            enemy3.movingSide = 'l';
                        }
                        if (enemy3.x <= 0)
                        {
                            enemy3.movingSide = 'r';
                        }
                        if (enemy4.x >= 530 - 30)
                        {
                            enemy4.movingSide = 'l';
                        }
                        if (enemy4.x <= 0)
                        {
                            enemy4.movingSide = 'r';
                        }
                        if (enemy5.x >= 530 - 30)
                        {
                            enemy5.movingSide = 'l';
                        }
                        if (enemy5.x <= 0)
                        {
                            enemy5.movingSide = 'r';
                        }
                        if (enemy6.x >= 530 - 30)
                        {
                            enemy6.movingSide = 'l';
                        }
                        if (enemy6.x <= 0)
                        {
                            enemy6.movingSide = 'r';
                        }
                    }
                    break;
            }
            
            
            if (plane.isNotHit)
            {
                MoveEnemies();
            }
            Invalidate();

        }


        

        private bool Collide1(Bullet bullet, Enemy enemy)
        {
            PointF delta = new PointF();
            delta.X = (bullet.x + bullet.size / 2) - (enemy.x + enemy.size / 2);
            delta.Y = (bullet.y + bullet.size / 2) - (enemy.y + enemy.size / 2);



            if (Math.Abs(delta.X) <= bullet.size / 2 + enemy.size / 2)
            {
                if (Math.Abs(delta.Y) <= bullet.size / 2 + enemy.size / 2)
                {

                    return true;

                }
            }



            return false;
        }

        private bool Collide2(Bullet bullet, Enemy enemy)
        {
            PointF delta = new PointF();

            delta.X = (bullet.x + bullet.size / 2) - (enemy.x + enemy.size / 2);
            delta.Y = (bullet.y + bullet.size / 2) - (enemy.y + enemy.size / 2);

            if (Math.Abs(delta.X) <= bullet.size / 2 + enemy.size / 2)
            {
                if (Math.Abs(delta.Y) <= bullet.size / 2 + enemy.size / 2)
                {
                    return true;
                }
            }


            return false;
        }
        private void MoveEnemies()
        {
            if (plane.score < 5)
            {
                switch (enemyCount)
                {
                    case 1:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed + rng.Next(1, 2); ;
                            }
                        }
                        break;
                    case 2:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed + rng.Next(1, 2); ;
                            }
                        }
                        break;
                    case 3:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'l')
                            {
                                enemy3.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'r')
                            {
                                enemy3.x += enemySpeed + rng.Next(1, 2); ;
                            }

                        }
                        break;
                    case 4:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'l')
                            {
                                enemy3.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'r')
                            {
                                enemy3.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'l')
                            {
                                enemy4.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'r')
                            {
                                enemy4.x += enemySpeed + rng.Next(1, 2); ;
                            }

                        }
                        break;
                    case 5:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'l')
                            {
                                enemy3.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'r')
                            {
                                enemy3.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'l')
                            {
                                enemy4.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'r')
                            {
                                enemy4.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy5.movingSide == 'l')
                            {
                                enemy5.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy5.movingSide == 'r')
                            {
                                enemy5.x += enemySpeed + rng.Next(1, 2); ;
                            }

                        }
                        break;
                    case 6:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'l')
                            {
                                enemy3.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'r')
                            {
                                enemy3.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'l')
                            {
                                enemy4.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'r')
                            {
                                enemy4.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy5.movingSide == 'l')
                            {
                                enemy5.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy5.movingSide == 'r')
                            {
                                enemy5.x += enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy6.movingSide == 'l')
                            {
                                enemy6.x -= enemySpeed + rng.Next(1, 2); ;
                            }
                            if (enemy6.movingSide == 'r')
                            {
                                enemy6.x += enemySpeed + rng.Next(1, 2); ;
                            }

                        }
                        break;
                }
                

                }
            if (plane.score >= 5)
            {
                switch (enemyCount)
                {
                    case 1:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed * 2 + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                        }
                        break;
                    case 2:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed * 2 + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                        }
                        break;
                    case 3:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed * 2 + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'l')
                            {
                                enemy3.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'r')
                            {
                                enemy3.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }

                        }
                        break;
                    case 4:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed * 2 + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'l')
                            {
                                enemy3.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'r')
                            {
                                enemy3.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'l')
                            {
                                enemy4.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'r')
                            {
                                enemy4.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }

                        }
                        break;
                    case 5:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed * 2 + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'l')
                            {
                                enemy3.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'r')
                            {
                                enemy3.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'l')
                            {
                                enemy4.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'r')
                            {
                                enemy4.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy5.movingSide == 'l')
                            {
                                enemy5.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy5.movingSide == 'r')
                            {
                                enemy5.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }

                        }
                        break;
                    case 6:
                        {
                            if (enemy1.movingSide == 'l')
                            {
                                enemy1.x -= enemySpeed * 2 + rng.Next(1, 2);
                            }
                            if (enemy1.movingSide == 'r')
                            {
                                enemy1.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'l')
                            {
                                enemy2.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy2.movingSide == 'r')
                            {
                                enemy2.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'l')
                            {
                                enemy3.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy3.movingSide == 'r')
                            {
                                enemy3.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'l')
                            {
                                enemy4.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy4.movingSide == 'r')
                            {
                                enemy4.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy5.movingSide == 'l')
                            {
                                enemy5.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy5.movingSide == 'r')
                            {
                                enemy5.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy6.movingSide == 'l')
                            {
                                enemy6.x -= enemySpeed * 2 + rng.Next(1, 2); ;
                            }
                            if (enemy6.movingSide == 'r')
                            {
                                enemy6.x += enemySpeed * 2 + rng.Next(1, 2); ;
                            }

                        }
                        break;
                }


            }
        }

        public void changeEnemyCount(int enCnt)
        {
            enemyCount = enCnt;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            plane.x -= playerSpeed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plane.x += playerSpeed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!missile.present)
            {
                missile = new Bullet(plane.x,(plane.y-32),true);
                gunShot.Play();
            }
        }
       

        private void Form1_Paint(object sender, PaintEventArgs e)

        {
            
            
            Graphics graphics = e.Graphics;

            switch (enemyCount)
            {
                case 1:
                    {
                        graphics.DrawImage(plane.sprite, plane.x, plane.y, plane.size, plane.size);

                        graphics.DrawImage(missile.sprite, missile.x, missile.y, missile.size, missile.size);

                        graphics.DrawImage(enemy1.sprite, enemy1.x, enemy1.y, enemy1.size, enemy1.size);
                    }
                    break;
                case 2:
                    {
                        graphics.DrawImage(plane.sprite, plane.x, plane.y, plane.size, plane.size);

                        graphics.DrawImage(missile.sprite, missile.x, missile.y, missile.size, missile.size);

                        graphics.DrawImage(enemy1.sprite, enemy1.x, enemy1.y, enemy1.size, enemy1.size);

                        graphics.DrawImage(enemy2.sprite, enemy2.x, enemy2.y, enemy2.size, enemy2.size);

                    }
                    break;
                case 3:
                    {
                        graphics.DrawImage(plane.sprite, plane.x, plane.y, plane.size, plane.size);

                        graphics.DrawImage(missile.sprite, missile.x, missile.y, missile.size, missile.size);

                        graphics.DrawImage(enemy1.sprite, enemy1.x, enemy1.y, enemy1.size, enemy1.size);

                        graphics.DrawImage(enemy2.sprite, enemy2.x, enemy2.y, enemy2.size, enemy2.size);

                        graphics.DrawImage(enemy3.sprite, enemy3.x, enemy3.y, enemy3.size, enemy3.size);

                    }
                    break;
                case 4:
                    {
                        graphics.DrawImage(plane.sprite, plane.x, plane.y, plane.size, plane.size);

                        graphics.DrawImage(missile.sprite, missile.x, missile.y, missile.size, missile.size);

                        graphics.DrawImage(enemy1.sprite, enemy1.x, enemy1.y, enemy1.size, enemy1.size);

                        graphics.DrawImage(enemy2.sprite, enemy2.x, enemy2.y, enemy2.size, enemy2.size);

                        graphics.DrawImage(enemy3.sprite, enemy3.x, enemy3.y, enemy3.size, enemy3.size);

                        graphics.DrawImage(enemy4.sprite, enemy4.x, enemy4.y, enemy4.size, enemy4.size);

                    }
                    break;
                case 5:
                    {
                        graphics.DrawImage(plane.sprite, plane.x, plane.y, plane.size, plane.size);

                        graphics.DrawImage(missile.sprite, missile.x, missile.y, missile.size, missile.size);

                        graphics.DrawImage(enemy1.sprite, enemy1.x, enemy1.y, enemy1.size, enemy1.size);

                        graphics.DrawImage(enemy2.sprite, enemy2.x, enemy2.y, enemy2.size, enemy2.size);

                        graphics.DrawImage(enemy3.sprite, enemy3.x, enemy3.y, enemy3.size, enemy3.size);

                        graphics.DrawImage(enemy4.sprite, enemy4.x, enemy4.y, enemy4.size, enemy4.size);

                        graphics.DrawImage(enemy5.sprite, enemy5.x, enemy5.y, enemy5.size, enemy5.size);

                    }
                    break;
                case 6:
                    {
                        graphics.DrawImage(plane.sprite, plane.x, plane.y, plane.size, plane.size);

                        graphics.DrawImage(missile.sprite, missile.x, missile.y, missile.size, missile.size);

                        graphics.DrawImage(enemy1.sprite, enemy1.x, enemy1.y, enemy1.size, enemy1.size);

                        graphics.DrawImage(enemy2.sprite, enemy2.x, enemy2.y, enemy2.size, enemy2.size);

                        graphics.DrawImage(enemy3.sprite, enemy3.x, enemy3.y, enemy3.size, enemy3.size);

                        graphics.DrawImage(enemy4.sprite, enemy4.x, enemy4.y, enemy4.size, enemy4.size);

                        graphics.DrawImage(enemy5.sprite, enemy5.x, enemy5.y, enemy5.size, enemy5.size);

                        graphics.DrawImage(enemy6.sprite, enemy6.x, enemy6.y, enemy6.size, enemy6.size);

                    }
                    break;
            }

            
        }
    }

}
