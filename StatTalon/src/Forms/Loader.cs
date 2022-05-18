using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatTalon.src.Forms
{
    public partial class Loader : Form
    {
        private void InitializeProgressBar(int maxCount)
        {
            progressBarLoader.Minimum = 0;
            progressBarLoader.Maximum = maxCount;
            progressBarLoader.Value = 0;
            progressBarLoader.Step = 1;
        }
        public Loader(int maxCount)
        {
            InitializeComponent();

            InitializeProgressBar(maxCount);
        }

        public void PerformStep()
        {
            progressBarLoader.PerformStep();
        }
    }
}
