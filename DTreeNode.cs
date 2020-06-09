using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    public class DTreeNode          // Класс «Узел дихотомического дерева» 
    {
        public char Info { get; set; }  // информационное поле 
        public int Key { get; set; }    // поле ключа 
        public DTreeNode Left { get; set; } // ссылка на левое поддерево 
        public DTreeNode Right { get; set; } // ссылка на левое поддерево 
        public DTreeNode() { }  // конструкторы 
        public DTreeNode(int key,char info)
        {
            Info = info;
            Key = key;
        }
        public DTreeNode(int key, char info, DTreeNode left, DTreeNode right) : this(key, info)
        {
            Left = left;
            Right = right;
        }
    }
}
