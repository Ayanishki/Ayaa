using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_1
{
    public partial class ReportPrinting : Form
    {
        public ReportPrinting(object report)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = report;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
