using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafyRysowanie
{
    public partial class Form1 : Form
    {
        private const int r = 10;
        private Graphics g;
        private Pen pWierzcholek;
        private Pen pWierzcholekAktywny;
        private Pen pKrawedz;
        private Wierzchlek MouseDownWierzcholek;

        private List<Wierzchlek> wierzcholki = new List<Wierzchlek>();
        private BFS bfs;
        private DFS dfs;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(500,500);

            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            pWierzcholek = new Pen(Color.Orange);
            pWierzcholek.Width = 3;
            pWierzcholekAktywny = new Pen(Color.Red);
            pWierzcholekAktywny.Width = 3;

            pKrawedz= new Pen(Color.Blue);
            pKrawedz.Width = 10;
            pKrawedz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            richTextBox = new RichTextBox();
            bfs = new BFS(richTextBox);
            dfs = new DFS(richTextBox);
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownWierzcholek = null;
                foreach (Wierzchlek w in wierzcholki)
                {
                    if (w.Odleglosc(e.Location) < r)
                    {
                        MouseDownWierzcholek = w;
                    }
                }
                odrysujGraf();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseDownWierzcholek!=null)
            {
                foreach (Wierzchlek w in wierzcholki)
                {
                    if (w.Odleglosc(e.Location) < r)
                    {
                        MouseDownWierzcholek.Nastpniki.Add(w);
                        w.Nastpniki.Add(MouseDownWierzcholek);
                    }
                }
                MouseDownWierzcholek = null;
                odrysujGraf();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                wierzcholki.Add(new Wierzchlek(e.Location));
                odrysujGraf();
            }
        }

        private void odrysujGraf()
        {
            g.Dispose();

            g = Graphics.FromImage(pictureBox1.Image);


            g.Clear(Color.White);
            foreach (Wierzchlek w in wierzcholki)
            { 
                g.DrawEllipse(pWierzcholek, w.Polozenie.X-r, w.Polozenie.Y-r, 2*r, 2*r);
                g.DrawString(w.Id.ToString(),
                             new System.Drawing.Font("Microsoft Sans Serif", r),
                             new SolidBrush(Color.Red), 
                             w.Polozenie.X+r, 
                             w.Polozenie.Y+r);
                if (w==MouseDownWierzcholek)
                {
                    g.DrawEllipse(pWierzcholekAktywny, w.Polozenie.X-r, w.Polozenie.Y-r, 2*r, 2*r);
                }
                foreach (Wierzchlek wn in w.Nastpniki)
                {
                    if (w.Id < wn.Id) // Rysuj krawędź tylko raz dla każdego połączenia
                        g.DrawLine(pKrawedz, w.Polozenie, wn.Polozenie);
                }

            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseDownWierzcholek!=null)
            {
                odrysujGraf();
                g.DrawLine(pKrawedz, MouseDownWierzcholek.Polozenie, e.Location);
                pictureBox1.Refresh();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Przeszukiwanie_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            if (BFS.Checked)
            {
                if (wierzcholki.Count > 0)
                {
                    // Przykładowe użycie BFS, zaczynając od pierwszego wierzchołka wierzcholki[0]
                    bfs.PrzeszukajGraf(wierzcholki[0]);
                }
                else
                {
                    MessageBox.Show("Graf jest pusty. Dodaj wierzchołki przed rozpoczęciem BFS.");
                }
            }
            else if (DFS.Checked)
            {
                if (wierzcholki.Count > 0)
                {
                    // Przykładowe użycie DFS, zaczynając od pierwszego wierzchołka wierzcholki[0]
                    dfs.PrzeszukajGraf(wierzcholki[0]);
                }
                else
                {
                    MessageBox.Show("Graf jest pusty. Dodaj wierzchołki przed rozpoczęciem DFS.");
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć algorytm (BFS lub DFS) do wykonania.");
            }
        }
        private void DFS_CheckedChanged(object sender, EventArgs e)
        {
            if (DFS.Checked)
            {
                BFS.Checked = false;
            }
        }

        private void BFS_CheckedChanged(object sender, EventArgs e)
        {
            if (BFS.Checked)
            {
                DFS.Checked = false;
            }
        }

        private void Wyczysc_Click(object sender, EventArgs e)
        {
            wierzcholki.Clear();
            Bitmap newBitmap = new Bitmap(500, 500);

            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = newBitmap;
            MouseDownWierzcholek = null;
            Wierzchlek.ResetLicznikId();
            richTextBox.Clear();
            BFS.Checked = false;
            DFS.Checked = false;
        }
    }
}
