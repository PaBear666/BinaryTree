using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LabThree
{
    public class DichotomyTree
    {
        public DTreeNode Root { get; set; }
        public DichotomyTree()  // создание пустого дерева 
        {
            Root = null;
        }
        public DichotomyTree(int key, char info)  // создание пустого дерева 
        {
            Root = new DTreeNode(key,info, null, null);
        }
        public DTreeNode FindNeedNode(int key, DTreeNode root)
        {
            DTreeNode p = null;
            if (root != null)
            {
                if (root.Key < key)
                {
                    p = FindNeedNode(key, root.Right);
                }
                else if (root.Key > key)
                {
                    p = FindNeedNode(key, root.Left);
                }
                else
                {
                    p = root;
                }
            }
            return p;

        }
        public DTreeNode Add(int key,char info, DTreeNode root)
        {
            if (root == null)
            {
                root = new DTreeNode(key, info);
            }
            else
            {
                if (root.Key > key)
                {
                    root.Left = Add(key,info, root.Left);
                }
                else if (root.Key < key)
                {
                    root.Right = Add(key,info, root.Right);
                }
            }
            return root;
        }
        public void Print(Form form,DTreeNode root, int p1, int p2, int y,int i)
        { 
            if (root != null)
            {
                int p = (i >= 3) ? 30*i : 0;
                string str = "Key:" + root.Key.ToString() + " " + "Info:" + root.Info.ToString();
                form.CreateGraphics().DrawString(str, new Font("Times New Roman", 12, FontStyle.Regular), new SolidBrush(Color.Black), new Point((p2 + p1) / 2 + 15, i * 80 + 5 + y));
                form.CreateGraphics().DrawEllipse(Pens.Coral, (p2 + p1) / 2, i * 80 + y, 115, 35);
                i += 1;
                if (root.Left != null)
                    Print(form,root.Left, p1 - p, (p2 + p1) / 2 , y,i);
                if (root.Right != null)
                    Print(form,root.Right, (p2 + p1) / 2  + p, p2, y,i);
            } 
        }
        public void Task(int key,SingleLinkedList Q)
        {
            try
            {
                Q.Create(FindNeedNode(key, Root).Info);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Такого ключа в дереве нет");
            }
        }

    }
}
