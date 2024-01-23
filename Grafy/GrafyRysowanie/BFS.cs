using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafyRysowanie
{
    public class BFS
    {
        private List<Wierzchlek> odwiedzone = new List<Wierzchlek>();
        private RichTextBox richTextBox;

        public BFS(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }

        public void PrzeszukajGraf(Wierzchlek startowyWierzcholek)
        {
            Queue<Wierzchlek> kolejka = new Queue<Wierzchlek>();

            odwiedzone.Clear();
            kolejka.Enqueue(startowyWierzcholek);

            while (kolejka.Count > 0)
            {
                Wierzchlek wierzcholek = kolejka.Dequeue();

                richTextBox.AppendText($"Odwiedzono wierzchołek: {wierzcholek.Id}\n");
                richTextBox.ScrollToCaret();
                Application.DoEvents(); // Umożliwia natychmiastowe odświeżanie RichTextBox

                odwiedzone.Add(wierzcholek);

                foreach (Wierzchlek nastepnik in wierzcholek.Nastpniki)
                {
                    if (!odwiedzone.Contains(nastepnik))
                    {
                        odwiedzone.Add(nastepnik);
                        kolejka.Enqueue(nastepnik);
                    }
                }
            }
        }
    }
}
