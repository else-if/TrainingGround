using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace ImageEditor
{
    public partial class MainForm : Form
    {
        Point[] Aarray = new Point[10000];
        Point[] Barray = new Point[10000];

        const int pixelSize = 4; // 32 bits per pixel

        public MainForm()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(MainImage.Width, MainImage.Height);
            MainImage.Image = (Image)b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Graphics gr = MainImage.CreateGraphics();
            gr.Clear(Color.White);
            Bitmap b = new Bitmap(MainImage.Width, MainImage.Height);
            MainImage.Image = (Image)b;
            MainImage.Refresh();

            Stopwatch sw = new Stopwatch();

            Bitmap bmp = (Bitmap)MainImage.Image;
            Graphics g = Graphics.FromImage(bmp);
            sw.Start();
            for (int i = 0; i < Aarray.Length; i++)
            {
                LineTo(g, Aarray[i], Barray[i]);
            }
            sw.Stop();

            MainImage.Refresh();

            TimeSpan ts = sw.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            label5.Text = elapsedTime;

            /*
            Point A = new Point();
            Point B = new Point();

            A.X = Convert.ToInt16(tbx1.Text);
            A.Y = Convert.ToInt16(tby1.Text);
            B.X = Convert.ToInt16(tbx2.Text);
            B.Y = Convert.ToInt16(tby2.Text);
            

            MyLineTo(A, B);
            MainImage.Refresh();

            LineTo(new Point(A.X, A.Y + 25), new Point(B.X, B.Y + 25));
             */
        }

        private void LineTo(Graphics g, Point A, Point B)
        {
            g.DrawLine(Pens.Black, A, B);
        }

        private void MyLineTo(Bitmap bmp, Point A, Point B)
        {
            //Bitmap bmp = (Bitmap)MainImage.Image;

            int dx = Math.Abs(A.X - B.X);
            int dy = Math.Abs(A.Y - B.Y);

            int ind = 0;
            int inc = 0;

            Color col = Color.Black;

            Point PLast;
            Point PFirst;

            //int stride = data.Stride;

            BitmapData data = null;

            unsafe
            {
                //byte* ptr = (byte*)data.Scan0;
                int x, y;

                if (dx >= dy)
                {
                    //by X ord
                    float diff = dx / 2f;

                    if (A.X >= B.X)
                    {
                        PLast = A;
                        PFirst = B;
                    }
                    else
                    {
                        PLast = B;
                        PFirst = A;
                    }

                    int k = (PLast.Y >= PFirst.Y) ? -1 : 1;

                    do
                    {
                        if ((dy * ind) >= diff)
                        {
                            inc++;
                            diff = diff + dx;
                        }
                        //bmp.SetPixel(PLast.X - ind, PLast.Y + k * inc, col);
                        x = PLast.X - ind;
                        y = PLast.Y + k * inc;

                        data = bmp.LockBits(new Rectangle(x, y, 1, 1), ImageLockMode.WriteOnly, PixelFormat.Format1bppIndexed);
                        bmp.UnlockBits(data);

                        if (PLast.X - ind > PFirst.X + ind)
                        //bmp.SetPixel(PFirst.X + ind, PFirst.Y - k * inc, col);
                        {
                            x = PFirst.X + ind;
                            y = PFirst.Y - k * inc;

                            data = bmp.LockBits(new Rectangle(x, y, 1, 1), ImageLockMode.WriteOnly, PixelFormat.Format1bppIndexed);
                            bmp.UnlockBits(data);
                        }

                        ind++;

                    } while (PLast.X - ind >= PFirst.X + ind);

                }
                else
                {
                    //by Y ord
                    float diff = dy / 2f;

                    if (A.Y >= B.Y)
                    {
                        PLast = A;
                        PFirst = B;
                    }
                    else
                    {
                        PLast = B;
                        PFirst = A;
                    }

                    int k = (PLast.X >= PFirst.X) ? -1 : 1;

                    do
                    {
                        if ((dx * ind) >= diff)
                        {
                            inc++;
                            diff = diff + dy;
                        }
                        //bmp.SetPixel(PLast.X + k * inc, PLast.Y - ind, col);
                        x = PLast.X + k * inc;
                        y = PLast.Y - ind;

                        /*ptr[(x * 3) + y * stride] = 115;
                        ptr[(x * 3) + y * stride + 1] = 115;
                        ptr[(x * 3) + y * stride + 2] = 115;*/

                        data = bmp.LockBits(new Rectangle(x, y, 1, 1), ImageLockMode.WriteOnly, PixelFormat.Format1bppIndexed);
                        bmp.UnlockBits(data);

                        if (PLast.Y - ind > PFirst.Y + ind)
                        //bmp.SetPixel(PFirst.X - k * inc, PFirst.Y + ind, col);
                        {
                            x = PFirst.X - k * inc;
                            y = PFirst.Y + ind;

                            /*ptr[(x * 3) + y * stride] = 115;
                            ptr[(x * 3) + y * stride + 1] = 115;
                            ptr[(x * 3) + y * stride + 2] = 115;*/
                            data = bmp.LockBits(new Rectangle(x, y, 1, 1), ImageLockMode.WriteOnly, PixelFormat.Format1bppIndexed);
                            bmp.UnlockBits(data);
                        }

                        ind++;

                    } while (PLast.Y - ind >= PFirst.Y + ind);
                }
            }

            //bmp.UnlockBits(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int minX = 0;
            int maxX = MainImage.Width - 1;
            int minY = 0;
            int maxY = MainImage.Height - 1;

            Random r = new Random();
            for (int i = 0; i < Aarray.Length; i++)
            {
                Aarray[i] = new Point(r.Next(minX, maxX), r.Next(minY, maxY));
                Barray[i] = new Point(r.Next(minX, maxX), r.Next(minY, maxY));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics gr = MainImage.CreateGraphics();
            gr.Clear(Color.White);
            Bitmap b = new Bitmap(MainImage.Width, MainImage.Height);
            MainImage.Image = (Image)b;
            MainImage.Refresh();

            Stopwatch sw = new Stopwatch();

            //Graphics g = MainImage.CreateGraphics();
            Bitmap bmp = (Bitmap)MainImage.Image;
            
            sw.Start();
            for (int i = 0; i < Aarray.Length; i++)
            {
                MyLineTo(bmp, Aarray[i], Barray[i]);
                //MainImage.Refresh();
            }
            sw.Stop();

            MainImage.Refresh();

            TimeSpan ts = sw.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            label6.Text = elapsedTime;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics gr = MainImage.CreateGraphics();
            gr.Clear(Color.White);
            Bitmap b = new Bitmap(MainImage.Width, MainImage.Height);
            MainImage.Image = (Image)b;
            MainImage.Refresh();
            
            Point A = new Point();
            Point B = new Point();

            A.X = Convert.ToInt16(tbx1.Text);
            A.Y = Convert.ToInt16(tby1.Text);
            B.X = Convert.ToInt16(tbx2.Text);
            B.Y = Convert.ToInt16(tby2.Text);


            MyLineTo((Bitmap)MainImage.Image, A, B);
            MainImage.Refresh();
        }
    }
}
