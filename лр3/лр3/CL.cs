using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр3
{
    public partial class CL : Component
    {
        public CL()
        {
            InitializeComponent();
        }

        public CL(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
