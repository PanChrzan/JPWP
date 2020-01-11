using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ShapeHunt
{
    public partial class Menu : Form
    {

        Rectangle[] rt = new Rectangle[1000];
        Rectangle[] el = new Rectangle[1000];
        int a = 1;
        int i = 0;
        int i_el = 0;
        int moveSpeed = 8;
        int drawSpeed = 700;
        bool work = false;
        string time = "";
        int min = 0;
        int sec = 0;
        int ms = 0;
        System.Timers.Timer clock = new System.Timers.Timer();

        int hit = 0;
        int miss = 0;
        //int buf = 0;
        //System.Timers.Timer DrawTimer = new System.Timers.Timer();      //inicjalizacja DrawTimera
        //System.Timers.Timer MoveTimer = new System.Timers.Timer();      //inicjalizacja MoveTimera
        ////Initializer init = new Initializer();

        Square rectangle = new Square();
        Ellipse ellipse = new Ellipse();

        public Point GetStartLocation()
        {
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            int x = 0;
            byte[] rnd = new byte[1];//Next(0, 446);
            rand.GetBytes(rnd);
            int y = (rnd[0]) * (446) / 255;

            Point p = new Point(x, y);

            return p;
        }
        
        public Size GetSize()
        {
            Size s = new Size(rectangle.Width/a, rectangle.Height/a);
            return s;
        }

        public Menu()
        {
            InitializeComponent();
            rectangle.Height = 90;
            rectangle.Width = 90;
            rectangle.Color = new SolidBrush(Color.DarkOrange);
            clock.Elapsed += new ElapsedEventHandler(clock_Tick);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            i = 0;
            i_el = 0;
            clock.Interval = 100;
            work = true;
            clock.Start();
            MoveWorker.RunWorkerAsync();
            DrawWorker.RunWorkerAsync();
            panel1.Visible = false;
            panel2.Visible = true;
            label2.Text = Convert.ToString(hit);
            label3.Text = Convert.ToString(miss);

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            ms++;

            if (ms > 9)
            {
                ms = 0;
                sec++;
                if(sec>59)
                {
                    ms = 0;
                    sec = 0;
                    min++;
                }
            }
            time = "";

            if (min < 10)
            {
                time += "0" + min;
            }
            else
            {
                time += min;
            }
            time += ":";

            if (sec < 10)
            {
                time += "0" + sec;
            }
            else
            {
                time += sec;
            }
            time += ":";

            if (ms < 10)
            {
                time += "0" + ms;
            }
            else
            {
                time += ms;
            }

            //time
            
            label1.Invoke(new Action(delegate ()
            {
                label1.Text = time;
            }));
            //label1.Text = time;
        }
        

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

            for (int j = 0; j < i; j++)
            {
                e.Graphics.FillRectangle(rectangle.Color, rt[j]);
            }
            for (int j = 0; j < i_el; j++)
            {
                e.Graphics.FillEllipse(rectangle.Color, el[j]);
            }

        }

        private void BackToMenu(object sender, EventArgs e)
        {
            
            clock.Stop();
            work = false;
            panel1.Visible = true;
            panel2.Visible = false;
            DrawWorker.CancelAsync();
            DrawWorker.Dispose();
            MoveWorker.CancelAsync();
            MoveWorker.Dispose();
            i = 0;
            i_el = 0;
            min = 0;
            sec = 0;
            ms = 0;
            miss = 0;
            hit = 0;
        }

        private void BackToMenu()
        {
            
            clock.Stop();
            work = false;
            panel1.Visible = true;
            panel2.Visible = false;
            
            DrawWorker.CancelAsync();
            DrawWorker.Dispose();
            MoveWorker.CancelAsync();
            MoveWorker.Dispose();
            
            using (StreamWriter sw = File.AppendText("wynik.txt"))
            {
                sw.WriteLine(time +  " | -  " + hit + "  - | - " + miss + " - |" + label4.Text);
            }
            MessageBox.Show("Znalazłeś wszystkie kształty!" + Environment.NewLine + "Twój czas to: " + time);
            i = 0;
            i_el = 0;
            min = 0;
            sec = 0;
            ms = 0;
            miss = 0;
            hit = 0;
        }

        private void Difficulty1_Checked(object sender, EventArgs e)
        {
            a = radioDifficulty1.TabIndex + 1;
            label4.Text = "Poziom: łatwy";
        }

        private void Difficulty2_Checked(object sender, EventArgs e)
        {
            a = radioDifficulty2.TabIndex + 1;
            label4.Text = "Poziom: średni";
        }

        private void Difficulty3_Checked(object sender, EventArgs e)
        {
            a = radioDifficulty3.TabIndex + 1;
            label4.Text = "Poziom: trudny";
        }

        private void Menu_MouseClick(object sender, MouseEventArgs e)
        {
            bool tf = true;
            if (work)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    if (e.X >= rt[j].X && e.X <= rt[j].X + rectangle.Width/a && e.Y >= rt[j].Y && e.Y <= rt[j].Y + rectangle.Height/a)
                    {
                        rt[j].Location = new Point(1280, 0);
                        hit++;
                        label2.Text = Convert.ToString(hit);
                        tf = false;
                        if (hit == 10 * a)
                            BackToMenu();
                        break;
                    }
                }
                for (int j = 0; j <= i_el; j++)
                {
                    int r = rectangle.Width / 2 /a;
                    Point S = new Point(el[j].X + r, el[j].Y + r);
                    Point A = new Point(Math.Abs(S.X - e.X), Math.Abs(S.Y - e.Y));
                    float a_r = (float)Math.Sqrt(Math.Pow(A.X, 2) + Math.Pow(A.Y, 2));
                    if(a_r<=r)
                    {
                        el[j].Location = new Point(1280, 0);
                        tf = false;
                        miss++;
                        label3.Text = Convert.ToString(miss);
                        break;
                    }
                }

                //for(int j = )

                if (tf)
                {
                    miss++;
                    label3.Text = Convert.ToString(miss);
                }
            }
        }

        private void MoveWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (work)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (rt[j].X < 1280)
                        {
                            rt[j].X = rt[j].X + 4;
                        }
                    }
                    for (int j = 0; j < i_el; j++)
                    {
                        if (el[j].X < 1280)
                        {
                            el[j].X = el[j].X + 4;
                        }
                    }
                    System.Threading.Thread.Sleep((int)(moveSpeed/a));

                this.Invoke(new Action(() => Refresh()));
                }
            }
            catch { }
        }

        private void DrawWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (work)
                {
                    Random rand = new Random();
                    int shape = rand.Next(0, 10);
                    Graphics gs = CreateGraphics();

                    if (shape < 7)
                    {
                        rt[i] = new Rectangle(GetStartLocation(), GetSize());
                        i++;
                    }
                    else
                    {
                        el[i_el] = new Rectangle(GetStartLocation(), GetSize());
                        i_el++;
                    }

                    System.Threading.Thread.Sleep((int)(drawSpeed / a));
                    this.Invoke(new Action(() => Refresh()));
                    
                }
            }
            catch { }
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            var list = new List<string>();
            string line;
            string[] wynik;
            
            using (var readtext = new StreamReader("wynik.txt"))
            {
                while ((line = readtext.ReadLine()) != null)
                {
                    list.Add(line);
                }
                wynik = list.ToArray();
                for(int i=0; i<wynik.Length; i++)
                {
                    line += wynik[i] + Environment.NewLine;
                }
                    MessageBox.Show(line);
                
            }
        }
    }
}
