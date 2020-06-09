using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
        public class Node // Класс «Узел односвязного списка»
        {
            public char Info { get; set; }
            public Node Link { get; set; }

            public Node(char info)
            {
                Info = info;
            }
            public Node(char info, Node link) : this(info)
            {
                Link = link;
            }
        }
}
