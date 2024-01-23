using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafyRysowanie
{
    public class DFS
    {
        private List<Wierzchlek> odwiedzone = new List<Wierzchlek>();
        private RichTextBox richTextBox;

        public DFS(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }

        public void PrzeszukajGraf(Wierzchlek startowyWierzcholek)
        {
            odwiedzone.Clear();
            WyszukajWGlabe(startowyWierzcholek);
        }

        private void WyszukajWGlabe(Wierzchlek wierzcholek)
        {
            if (!odwiedzone.Contains(wierzcholek))
            {
                odwiedzone.Add(wierzcholek);
               
                richTextBox.AppendText($"Odwiedzono wierzchołek: {wierzcholek.Id}\n");
                richTextBox.ScrollToCaret();
                Application.DoEvents();


                foreach (Wierzchlek nastepnik in wierzcholek.Nastpniki)
                {
                    WyszukajWGlabe(nastepnik);
                }
            }
        }
    }
}
