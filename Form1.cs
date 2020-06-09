using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabThree
{
    public partial class Form1 : Form
    {
        DichotomyTree Tree = new DichotomyTree();
        SingleLinkedList List = new SingleLinkedList();
        private int VScrollValue { get; set ;}
        private int HScrollValue { get; set; }
        public Form1()
        {
            InitializeComponent();
            Size = new Size(445, 470);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Tree.Root = Tree.Add(int.Parse(textBox1.Text),char.Parse(textBox2.Text),Tree.Root);
            TextCheckTree.Visible = false;
            CreateGraphics().Clear(SystemColors.Control);
            vScrollBar1.Visible = true;
            hScrollBar1.Visible = true;
            VScrollValue = vScrollBar1.Value * 100 - 450;
            HScrollValue = hScrollBar1.Value * 100 + 150;
            Tree.Print(this,Tree.Root,HScrollValue - 200, HScrollValue + 310, VScrollValue,1);
        } 

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Об программе":
                    Size = new Size(445,470);
                    break;
                case "Обработка":
                    Size = new Size(975, 485);
                    break;
                case "Выход":
                    Size = new Size(445, 470);
                    break;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Add.Visible = true;
            Clear.Visible = true;
            label3.Visible = false;
            AddTask.Visible = false;
            label1.Location = new Point(41,64);
            textBox1.Location = new Point(221, 64);
            textBox1.Text = "";
            textBox2.Text = "";
            RemoveList.Visible = false;
        }

        private void Task_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            Add.Visible = false;
            label3.Visible = true;
            AddTask.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Location = new Point(81, 80);
            textBox1.Location = new Point(221, 77);
            RemoveList.Visible = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Tree.Root != null)
            {
                Tree.Root = null;
                TextCheckTree.Visible = true;
                CreateGraphics().Clear(SystemColors.Control);
                vScrollBar1.Visible = false;
                hScrollBar1.Visible = false;
                vScrollBar1.Value = 5;
                hScrollBar1.Value = 5;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text,out int result) && char.TryParse(textBox2.Text, out char result1))
            {
                Add.Enabled = true;
            }
            else if (int.TryParse(textBox1.Text, out int result2))
            {
                AddTask.Enabled = true;
            }
            else
            {
                Add.Enabled = false;
                AddTask.Enabled = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (char.TryParse(textBox2.Text, out char result) && int.TryParse(textBox1.Text, out int result1))
            {
                Add.Enabled = true;
            }
            else
            {
                Add.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            Tree.Task(int.Parse(textBox1.Text), List);
            List.Print(listBox1);
        }

        private void RemoveList_Click(object sender, EventArgs e)
        {
            List.Destroy(listBox1);
        }


        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            CreateGraphics().Clear(SystemColors.Control);
            VScrollValue = vScrollBar1.Value * 100 - 450;
            HScrollValue = hScrollBar1.Value * 100 + 150;
            Tree.Print(this, Tree.Root, HScrollValue - 200, HScrollValue + 310, VScrollValue, 1);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            CreateGraphics().Clear(SystemColors.Control);
            VScrollValue = vScrollBar1.Value * 100 - 450;
            HScrollValue = hScrollBar1.Value * 100 + 150;
            Tree.Print(this, Tree.Root, HScrollValue - 200, HScrollValue + 310, VScrollValue, 1);
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.IndianRed;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.SeaShell;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
