using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabThree
{
    public class SingleLinkedList // Класс «Односвязные списки»
    {
        public Node First { get; set; } // ссылка на первый узел списка
        public SingleLinkedList() // конструктор: создание пустого списка
        {
            First = null;
        }
        public void Print(ListBox listbox)
        {
            listbox.Items.Clear();
            Node p = First;
            while (p != null)
            {
                listbox.Items.Add(p.Info);
                p = p.Link;
            }
        }
        public void Destroy(ListBox listbox)
        {
            First = null;
            listbox.Items.Clear();
        }
        public void Create(char a)
        {
            if (First != null)
            {
                Node p = First;
                while(p.Link != null)
                {
                    p = p.Link;
                }
                p.Link = new Node(a,null);
            }
            else
            {
                First = new Node(a,null);
            }
        }
    }
}
