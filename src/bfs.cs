using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_altha
{
    public partial class bfs : Component
    {
        public bfs()
        {
            InitializeComponent();
        }

        public bfs(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
