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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void vatTuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vatTuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.CT_PHATSINH' table. You can move, or remove it, as needed.
            this.cT_PHATSINHTableAdapter.Fill(this.qLVTDataSet.CT_PHATSINH);
            // TODO: This line of code loads data into the 'qLVTDataSet.PHATSINH' table. You can move, or remove it, as needed.
            this.pHATSINHTableAdapter.Fill(this.qLVTDataSet.PHATSINH);
            // TODO: This line of code loads data into the 'qLVTDataSet.VatTu' table. You can move, or remove it, as needed.
            this.vatTuTableAdapter.Fill(this.qLVTDataSet.VatTu);

            viewUIVT();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.FillBy(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.FillBy1(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.FillBy2(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.FillBy3(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void nhapQuerryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.NhapQuerry(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void xuatQuerryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.XuatQuerry(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void xuatQuerryToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.XuatQuerry(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void xuatQuerryToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.XuatQuerry(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void nhapQuerryToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pHATSINHTableAdapter.NhapQuerry(this.qLVTDataSet.PHATSINH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void nhapQuerryToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    viewUIVT();
                    this.vatTuTableAdapter.Fill(this.qLVTDataSet.VatTu);
                    break;
                case 1:
                    viewUIPN();
                    viewUICTPN();
                    this.pHATSINHTableAdapter.NhapQuerry(this.qLVTDataSet.PHATSINH);
                    break;
                case 2:
                    viewUIPX();
                    viewUICTPX();
                    this.pHATSINHTableAdapter.XuatQuerry(this.qLVTDataSet.PHATSINH);
                    break;
            }
        }
        private void viewUIVT() {
            themVTBtn.Enabled = true;
            xoaVTBtn.Enabled = true;
            suaVTBtn.Enabled = true;
            luuVtBtn.Enabled = false;
            huyVTBtn.Enabled = false;
            refreshVTBtn.Enabled = true;
            vatTuDataGridView.Enabled = true;
            mAVTTextBox.Enabled = false;
            tENVTTextBox.Enabled = false;
            dVTTextBox.Enabled = false;
            sOLUONGTONTextBox.Enabled = false;
        }
        private void editUIVT() {
            themVTBtn.Enabled = false;
            xoaVTBtn.Enabled = false;
            suaVTBtn.Enabled = false;
            luuVtBtn.Enabled = true;
            huyVTBtn.Enabled = true;
            refreshVTBtn.Enabled = false;
            vatTuDataGridView.Enabled = false;
            mAVTTextBox.Enabled = false;
            tENVTTextBox.Enabled = true;
            dVTTextBox.Enabled = true;
            sOLUONGTONTextBox.Enabled = true;
        }

        private void addUIVT()
        { // chua tao them update va add khac cho id cho sua
            themVTBtn.Enabled = false;
            xoaVTBtn.Enabled = false;
            suaVTBtn.Enabled = false;
            luuVtBtn.Enabled = true;
            huyVTBtn.Enabled = true;
            refreshVTBtn.Enabled = false;
            vatTuDataGridView.Enabled = false;
            mAVTTextBox.Enabled = true;
            tENVTTextBox.Enabled = true;
            dVTTextBox.Enabled = true;
            sOLUONGTONTextBox.Enabled = true;
        }
        private void themVTBtn_Click(object sender, EventArgs e)
        {
            addUIVT();
            vatTuBindingSource.AddNew();

        }

        private void luuVtBtn_Click(object sender, EventArgs e)
        {
            vatTuBindingSource.EndEdit();
            vatTuBindingSource.ResetCurrentItem();
            this.vatTuTableAdapter.Update(this.qLVTDataSet.VatTu); // xuong db
            viewUIVT();
        }

        private void suaVTBtn_Click(object sender, EventArgs e)
        {
            editUIVT();
        }

        private void xoaVTBtn_Click(object sender, EventArgs e)
        {
            if (cT_PHATSINHBindingSource1.Count > 0)
            {
                MessageBox.Show($"Vật tư {mAVTTextBox.Text} {tENVTTextBox.Text} đã tạo phiếu nên không thể xóa :3", "Lỗi xóa vật tư", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    string delMaNV = "";
                    try
                    {                
                        delMaNV = ((DataRowView)vatTuBindingSource[vatTuBindingSource.Position])["MAVT"].ToString();
                        vatTuBindingSource.RemoveCurrent();
                        this.vatTuTableAdapter.Update(this.qLVTDataSet.VatTu);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.vatTuTableAdapter.Fill(this.qLVTDataSet.VatTu);
                        vatTuBindingSource.Position = vatTuBindingSource.Find("MAVT", delMaNV);
                    }
                    
                }
                    
            }
            
        }

        private void refreshVTBtn_Click(object sender, EventArgs e)
        {
            this.vatTuTableAdapter.Fill(this.qLVTDataSet.VatTu);
        }

        private void huyVTBtn_Click(object sender, EventArgs e)
        {
            vatTuBindingSource.CancelEdit();
            refreshVTBtn.PerformClick();
            viewUIVT();
        }


        private void viewUIPN()
        {
            huyPNBth.Enabled = false;
            refreshPNBtn.Enabled = true;
            PNActionPanel.Enabled = true;
            luuPNBtn.Enabled = false;
            pHIEUTextBox.Enabled = true;
            inputPNPanel.Enabled = false;
            
        }
        private void editUIPN()
        { // chua tao them update va add khac cho id cho sua
            huyPNBth.Enabled = true;
            refreshPNBtn.Enabled = false;
            PNActionPanel.Enabled = false;
            luuPNBtn.Enabled = true;
            inputPNPanel.Enabled = true;
            pHIEUTextBox.Enabled = false;  
        }

        private void addUIPN()
        { // chua tao them update va add khac cho id cho sua
            huyPNBth.Enabled = true;
            refreshPNBtn.Enabled = false;
            PNActionPanel.Enabled = false;
            luuPNBtn.Enabled = true;
            inputPNPanel.Enabled = true;
            pHIEUTextBox.Enabled = true;
        }

        private void themPNBtn_Click(object sender, EventArgs e)
        {
            addUIPN();
            pHATSINHBindingSource.AddNew();
            ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["LOAI"] = "N";
        }

        private void luuPNBtn_Click(object sender, EventArgs e)
        {

            cT_PHATSINHBindingSource.EndEdit();
            cT_PHATSINHBindingSource.ResetCurrentItem();
            this.cT_PHATSINHTableAdapter.Update(this.qLVTDataSet.CT_PHATSINH); // xuong db
            viewUICTPN();

            pHATSINHBindingSource.EndEdit();
            pHATSINHBindingSource.ResetCurrentItem();
            this.pHATSINHTableAdapter.Update(this.qLVTDataSet.PHATSINH); // xuong db
            viewUIPN();

            

        }

        private void suaPNBtn_Click(object sender, EventArgs e)
        {
            editUIPN();
        }

        private void xoaPNBtn_Click(object sender, EventArgs e)
        {
            if (cT_PHATSINHBindingSource.Count > 0)
            {
                MessageBox.Show($"Phiếu nhập {pHIEUTextBox.Text} đã tạo phiếu nên không thể xóa :3", "Lỗi xóa vật tư", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu nhập này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string delMaNV = "";
                    try
                    {
                        delMaNV = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
                        pHATSINHBindingSource.RemoveCurrent();
                        this.pHATSINHTableAdapter.Update(this.qLVTDataSet.PHATSINH);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pHATSINHTableAdapter.NhapQuerry(this.qLVTDataSet.PHATSINH);
                        pHATSINHBindingSource.Position = pHATSINHBindingSource.Find("PHIEU", delMaNV);
                    }

                }
            }
        }

        private void vatTuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void huyPNBth_Click(object sender, EventArgs e)
        {
            pHATSINHBindingSource.CancelEdit();
            refreshPNBtn.PerformClick();
            viewUIPN();

            cT_PHATSINHBindingSource.CancelEdit();
            viewUICTPN();
        }

        private void refreshPNBtn_Click(object sender, EventArgs e)
        {
            this.pHATSINHTableAdapter.NhapQuerry(this.qLVTDataSet.PHATSINH);
            this.cT_PHATSINHTableAdapter.Fill(this.qLVTDataSet.CT_PHATSINH);
        }

        private void viewUICTPN()
        {
            refreshPNBtn.Enabled = true;
            ctpnActionPanel.Enabled = true;
            luuPNBtn.Enabled = false;
            pHIEUTextBox1.Enabled = true;
            mAVTTextBox1.Enabled = true;
            InputCTPNPanel.Enabled = false;
        }
        private void editUICTPN()
        {
            huyPNBth.Enabled = true;
            refreshPNBtn.Enabled = false;
            ctpnActionPanel.Enabled = false;
            PNActionPanel.Enabled = false;
            luuPNBtn.Enabled = true;
            InputCTPNPanel.Enabled = true;
            pHIEUTextBox1.Enabled = false;
            mAVTTextBox1.Enabled = false;
            
        }

        private void addUICTPN()
        { // chua tao them update va add khac cho id cho sua
            huyPNBth.Enabled = true;
            luuPNBtn.Enabled = true;
            refreshPNBtn.Enabled = false;
            ctpnActionPanel.Enabled = false;
            PNActionPanel.Enabled = false;
            InputCTPNPanel.Enabled = true;
            pHIEUTextBox1.Enabled = false;
        }

        private void themCTPNBtn_Click(object sender, EventArgs e)
        {
            addUICTPN();
            cT_PHATSINHBindingSource.AddNew();
            String phieu = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
            ((DataRowView)cT_PHATSINHBindingSource[cT_PHATSINHBindingSource.Position])["PHIEU"] = phieu;
        }

        private void suaCTPNBtn_Click(object sender, EventArgs e)
        {
            editUICTPN();
        }

        private void xoaCTPNBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết phiếu nhập này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string delMaNV = "";
                try
                {
                    delMaNV = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
                    cT_PHATSINHBindingSource.RemoveCurrent();
                    this.cT_PHATSINHTableAdapter.Update(this.qLVTDataSet.CT_PHATSINH);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshPNBtn.PerformClick();
                   // cT_PHATSINHBindingSource.Position = cT_PHATSINHBindingSource.Find("PHIEU", delMaNV);
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void viewUIPX()
        {
            huyPXBtn.Enabled = false;
            refreshPXBtn.Enabled = true;
            PXActionPanel.Enabled = true;
            luuPXBtn.Enabled = false;
            pHIEUTextBox2.Enabled = true;
            pxInputPanel.Enabled = false;

        }
        private void editUIPX()
        { // chua tao them update va add khac cho id cho sua
            huyPXBtn.Enabled = true;
            refreshPXBtn.Enabled = false;
            PXActionPanel.Enabled = false;
            luuPXBtn.Enabled = true;
            pxInputPanel.Enabled = true;
            pHIEUTextBox2.Enabled = false;
        }

        private void addUIPX()
        { // chua tao them update va add khac cho id cho sua
            huyPXBtn.Enabled = true;
            refreshPXBtn.Enabled = false;
            PXActionPanel.Enabled = false;
            luuPXBtn.Enabled = true;
            pxInputPanel.Enabled = true;
            pHIEUTextBox2.Enabled = true;
        }

        private void refreshPXBtn_Click(object sender, EventArgs e)
        {
            this.pHATSINHTableAdapter.XuatQuerry(this.qLVTDataSet.PHATSINH);
            this.cT_PHATSINHTableAdapter.Fill(this.qLVTDataSet.CT_PHATSINH);
        }

        private void themPXBtn_Click(object sender, EventArgs e)
        {
            addUIPX();
            pHATSINHBindingSource.AddNew();
            ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["LOAI"] = "X";
        }

        private void luuPXBtn_Click(object sender, EventArgs e)
        {
            cT_PHATSINHBindingSource.EndEdit();
            cT_PHATSINHBindingSource.ResetCurrentItem();
            this.cT_PHATSINHTableAdapter.Update(this.qLVTDataSet.CT_PHATSINH); // xuong db
            viewUICTPX();

            pHATSINHBindingSource.EndEdit();
            pHATSINHBindingSource.ResetCurrentItem();
            this.pHATSINHTableAdapter.Update(this.qLVTDataSet.PHATSINH); // xuong db
            viewUIPX();
        }

        private void huyPXBtn_Click(object sender, EventArgs e)
        {
            pHATSINHBindingSource.CancelEdit();
            refreshPXBtn.PerformClick();
            viewUIPX();

            cT_PHATSINHBindingSource.CancelEdit();
            viewUICTPX();
        }

     
        private void suaPXBtn_Click(object sender, EventArgs e)
        {
            editUIPX();
        }

        private void xoaPXBtn_Click(object sender, EventArgs e)
        {
            if (cT_PHATSINHBindingSource.Count > 0)
            {
                MessageBox.Show($"Phiếu XUẤT {pHIEUTextBox2.Text} đã tạo phiếu nên không thể xóa :3", "Lỗi xóa vật tư", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu nhập này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string delMaNV = "";
                    try
                    {
                        delMaNV = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
                        pHATSINHBindingSource.RemoveCurrent();
                        this.pHATSINHTableAdapter.Update(this.qLVTDataSet.PHATSINH);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pHATSINHTableAdapter.XuatQuerry(this.qLVTDataSet.PHATSINH);
                        pHATSINHBindingSource.Position = pHATSINHBindingSource.Find("PHIEU", delMaNV);
                    }

                }
            }
        }

        private void viewUICTPX()
        {
            huyPXBtn.Enabled = false;
            refreshPXBtn.Enabled = true;
            ctpxActionPanel.Enabled = true;
            luuPXBtn.Enabled = false;
            pHIEUTextBox3.Enabled = true;
            mAVTTextBox2.Enabled = true;
            ctpxInputPanel.Enabled = false;
        }
        private void editUICTPX()
        {
            huyPXBtn.Enabled = true;
            refreshPXBtn.Enabled = false;
            ctpxActionPanel.Enabled = false;
            PXActionPanel.Enabled = false;
            luuPXBtn.Enabled = true;
            ctpxInputPanel.Enabled = true;
            pHIEUTextBox3.Enabled = false;
            mAVTTextBox2.Enabled = false;

        }

        private void addUICTPX()
        { // chua tao them update va add khac cho id cho sua
            huyPXBtn.Enabled = true;
            luuPXBtn.Enabled = true;
            refreshPXBtn.Enabled = false;
            ctpxActionPanel.Enabled = false;
            PXActionPanel.Enabled = false;
            ctpxInputPanel.Enabled = true;
            pHIEUTextBox3.Enabled = false;
        }

        private void themCTPXBtn_Click(object sender, EventArgs e)
        {
            addUICTPX();
            cT_PHATSINHBindingSource.AddNew();
            String phieu = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
            ((DataRowView)cT_PHATSINHBindingSource[cT_PHATSINHBindingSource.Position])["PHIEU"] = phieu;
        }

        private void xoaCTPXBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết phiếu xuất này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string delMaNV = "";
                try
                {
                    delMaNV = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
                    cT_PHATSINHBindingSource.RemoveCurrent();
                    this.cT_PHATSINHTableAdapter.Update(this.qLVTDataSet.CT_PHATSINH);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshPNBtn.PerformClick();
                    // cT_PHATSINHBindingSource.Position = cT_PHATSINHBindingSource.Find("PHIEU", delMaNV);
                }

            }
        }

        private void suaCTPXBtn_Click(object sender, EventArgs e)
        {
            editUICTPX();
        }
    }
}
