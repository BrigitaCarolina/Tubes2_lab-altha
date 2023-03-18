using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_altha
{
    public partial class dfs : Component
    {
        public dfs()
        {
            InitializeComponent();
        }

        public dfs(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
