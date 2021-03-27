using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetaiTriggerLeDuyKhang
{
    public partial class PhieuNhapForm : Form
    {
        public PhieuNhapForm()
        {
            InitializeComponent();
        }

        private void pHATSINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHATSINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.CT_PHATSINH' table. You can move, or remove it, as needed.
            this.cT_PHATSINHTableAdapter.Fill(this.qLVTDataSet.CT_PHATSINH);
            // TODO: This line of code loads data into the 'qLVTDataSet.PHATSINH' table. You can move, or remove it, as needed.
            this.pHATSINHTableAdapter.Fill(this.qLVTDataSet.PHATSINH);

        }
    }
}
