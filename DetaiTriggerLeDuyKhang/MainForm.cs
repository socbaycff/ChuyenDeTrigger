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
        bool isInsertVT = false;
        bool isInsertPN = false;
        bool isInsertCTPN = false;
        bool isInsertPX = false;
        bool isInsertCTPX = false;

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
            sP_MaVTChuaNhapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

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
        private void viewUIVT()
        {
            checkUpdateDeleteBtnEnable();
            canChangeTab = true;
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
        private void editUIVT()
        {
            canChangeTab = false;
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
            
            canChangeTab = false;
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
            isInsertVT = true;

        }

        private void luuVtBtn_Click(object sender, EventArgs e)
        {
            if (tENVTTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextBox.Focus();
                return;
            }
            if (dVTTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextBox.Focus();
                return;
            }
            if (sOLUONGTONTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng tồn không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mAVTTextBox.Focus();
                return;
            }


            if (isInsertVT)
            {
                if (mAVTTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Ma vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mAVTTextBox.Focus();
                    return;
                }

                if (vatTuBindingSource.Find("MAVT", mAVTTextBox.Text.Trim()) != -1)
                {
                    MessageBox.Show("Mã VT đã tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mAVTTextBox.Focus();
                    return;
                }

            }


            vatTuBindingSource.EndEdit();
            vatTuBindingSource.ResetCurrentItem();
            this.vatTuTableAdapter.Update(this.qLVTDataSet.VatTu); // xuong db
            viewUIVT();
        }

        private void suaVTBtn_Click(object sender, EventArgs e)
        {
            editUIVT();
            isInsertVT = false;
        }

        private void xoaVTBtn_Click(object sender, EventArgs e)
        {
            if (cT_PHATSINHBindingSource1.Count > 0)
            {
                MessageBox.Show($"Vật tư {mAVTTextBox.Text} {tENVTTextBox.Text} đã tạo phiếu nên không thể xóa :3", "Lỗi xóa vật tư", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string delMaNV = "";
                    try
                    {
                        delMaNV = ((DataRowView)vatTuBindingSource[vatTuBindingSource.Position])["MAVT"].ToString();
                        vatTuBindingSource.RemoveCurrent();
                        this.vatTuTableAdapter.Update(this.qLVTDataSet.VatTu);
                        checkUpdateDeleteBtnEnable();
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

        private void checkUpdateDeleteBtnEnable()
        {
            // kiem tra bat tat delete, update btn
            if (vatTuBindingSource.Count == 0)
            {
                suaVTBtn.Enabled = false;
                xoaVTBtn.Enabled = false;
            }
            else
            {
                suaVTBtn.Enabled = true;
                xoaVTBtn.Enabled = true;
            }
        }

        private void checkPN1UpdateDeleteBtnEnable()
        {
            // kiem tra bat tat delete, update btn
            if (pHATSINHBindingSource.Count == 0)
            {
                suaPNBtn.Enabled = false;
                xoaPNBtn.Enabled = false;
            }
            else
            {
                suaPNBtn.Enabled = true;
                xoaPNBtn.Enabled = true;
            }
        }
        private void checkPXUpdateDeleteBtnEnable()
        {
            // kiem tra bat tat delete, update btn
            if (pHATSINHBindingSource.Count == 0)
            {
                suaPXBtn.Enabled = false;
                xoaPXBtn.Enabled = false;
            }
            else
            {
                suaPXBtn.Enabled = true;
                xoaPXBtn.Enabled = true;
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
            checkPN1UpdateDeleteBtnEnable();
            canChangeTab = true;
            huyPNBth.Enabled = false;
            refreshPNBtn.Enabled = true;
            PNActionPanel.Enabled = true;
            luuPNBtn.Enabled = false;
            pHIEUTextBox.Enabled = true;
            inputPNPanel.Enabled = false;
            ctpnActionPanel.Enabled = true;
        }

        private void editUIPN()
        { // chua tao them update va add khac cho id cho sua
            canChangeTab = false;
            huyPNBth.Enabled = true;
            refreshPNBtn.Enabled = false;
            PNActionPanel.Enabled = false;
            luuPNBtn.Enabled = true;
            inputPNPanel.Enabled = true;
            pHIEUTextBox.Enabled = false;
            ctpnActionPanel.Enabled = false;

        }

        private void addUIPN()
        { // chua tao them update va add khac cho id cho sua
            canChangeTab = false;
            huyPNBth.Enabled = true;
            refreshPNBtn.Enabled = false;
            PNActionPanel.Enabled = false;
            luuPNBtn.Enabled = true;
            inputPNPanel.Enabled = true;
            pHIEUTextBox.Enabled = true;
            ctpnActionPanel.Enabled = false;
        }

        private void themPNBtn_Click(object sender, EventArgs e)
        {
            addUIPN();
            pHATSINHBindingSource.AddNew();
            ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["LOAI"] = "N";
            nGAYDateTimePicker.Value = DateTime.Now;
            isInsertPN = true;
        }

        private void luuPNBtn_Click(object sender, EventArgs e)
        {
            if (nGAYDateTimePicker.Text.Trim() == "")
            {
                MessageBox.Show("Ngày không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nGAYDateTimePicker.Focus();
                return;
            }
            if (hOTENKHTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên khách không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hOTENKHTextBox.Focus();
                return;
            }
            if (mANVTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mANVTextBox.Focus();
                return;
            }

            if (isInsertPN)
            {
                if (pHIEUTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phiếu không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pHIEUTextBox.Focus();
                    return;
                }

                if (pHATSINHBindingSource.Find("PHIEU", pHIEUTextBox.Text.Trim()) != -1)
                {
                    MessageBox.Show("Mã phiếu đã tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pHIEUTextBox.Focus();
                    return;
                }
            }
            else
            {
                if (cT_PHATSINHBindingSource.Count > 0) // chi kt khi da co ct
                {
                    if (sOLUONGTextBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Số lượng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sOLUONGTextBox.Focus();
                        return;
                    }
                    if (dONGIATextBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dONGIATextBox.Focus();
                        return;
                    }
                }

            }


            try
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
            catch
            {
                MessageBox.Show("So luong vat tu nhap sai");
                return;
            }





        }

        private void suaPNBtn_Click(object sender, EventArgs e)
        {
            editUIPN();
            isInsertPN = false;
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
                        checkPN1UpdateDeleteBtnEnable();
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
            checkCTPNDeleteUpdateBtnEnable();
            canChangeTab = true;
            refreshPNBtn.Enabled = true;
            ctpnActionPanel.Enabled = true;
            luuPNBtn.Enabled = false;
            pHIEUTextBox1.Enabled = true;
            mAVTTextBox1.Enabled = true;
            InputCTPNPanel.Enabled = false;
            sP_MaVTChuaNhapComboBox.Enabled = false;
        }

        private void checkCTPNDeleteUpdateBtnEnable()
        {
            // kiem tra bat tat delete, update btn
            if (cT_PHATSINHBindingSource.Count == 0)
            {
                xoaCTPNBtn.Enabled = false;
                suaCTPNBtn.Enabled = false;
            }
            else
            {
                xoaCTPNBtn.Enabled = true;
                suaCTPNBtn.Enabled = true;
            }
        }

        private void editUICTPN()
        {
            canChangeTab = false;
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
            canChangeTab = false;
            huyPNBth.Enabled = true;
            luuPNBtn.Enabled = true;
            refreshPNBtn.Enabled = false;
            ctpnActionPanel.Enabled = false;
            PNActionPanel.Enabled = false;
            InputCTPNPanel.Enabled = true;
            pHIEUTextBox1.Enabled = false;
            mAVTTextBox1.Enabled = false;
            sP_MaVTChuaNhapComboBox.Enabled = true;
        }

        private void themCTPNBtn_Click(object sender, EventArgs e)
        {
            
            String phieu = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
            this.sP_MaVTChuaNhapTableAdapter.Fill(this.qLVTDataSet.SP_MaVTChuaNhap, phieu);
            // kiem tra con vat tu trong cho phieu hay k
            //khong thi return
            // con thi di tiep
            if (sP_MaVTChuaNhapBindingSource.Count <= 0)
            {
                MessageBox.Show("Khong con vat tu nao chua tao cho phieu nay");
                return;
            }
            addUICTPN();
            cT_PHATSINHBindingSource.AddNew();
            sP_MaVTChuaNhapComboBox.SelectedIndex = 0;
            ((DataRowView)cT_PHATSINHBindingSource[cT_PHATSINHBindingSource.Position])["PHIEU"] = phieu;
            isInsertCTPN = true;
            checkCountPN();

        }

        private void suaCTPNBtn_Click(object sender, EventArgs e)
        {
            editUICTPN();
            isInsertCTPN = false;
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
                    checkCountPN();

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
            checkPXTabDeleteUpdateBtnEnable();
            canChangeTab = true;
            huyPXBtn.Enabled = false;
            refreshPXBtn.Enabled = true;
            PXActionPanel.Enabled = true;
            luuPXBtn.Enabled = false;
            pHIEUTextBox2.Enabled = true;
            pxInputPanel.Enabled = false;
            PXActionPanel.Enabled = true;
        }
        private void editUIPX()
        { // chua tao them update va add khac cho id cho sua
            canChangeTab = false;
            huyPXBtn.Enabled = true;
            refreshPXBtn.Enabled = false;
            PXActionPanel.Enabled = false;
            luuPXBtn.Enabled = true;
            pxInputPanel.Enabled = true;
            pHIEUTextBox2.Enabled = false;
            PXActionPanel.Enabled = false;
        }

        private void addUIPX()
        { // chua tao them update va add khac cho id cho sua
            canChangeTab = false;
            huyPXBtn.Enabled = true;
            refreshPXBtn.Enabled = false;
            PXActionPanel.Enabled = false;
            luuPXBtn.Enabled = true;
            pxInputPanel.Enabled = true;
            pHIEUTextBox2.Enabled = true;
            PXActionPanel.Enabled = false;
        }

        private void refreshPXBtn_Click(object sender, EventArgs e)
        {
            checkPXTabDeleteUpdateBtnEnable();
            this.pHATSINHTableAdapter.XuatQuerry(this.qLVTDataSet.PHATSINH);
            this.cT_PHATSINHTableAdapter.Fill(this.qLVTDataSet.CT_PHATSINH);
        }

        private void checkPXTabDeleteUpdateBtnEnable()
        {

        }

        private void themPXBtn_Click(object sender, EventArgs e)
        {
            addUIPX();
            pHATSINHBindingSource.AddNew();
            ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["LOAI"] = "X";
            isInsertPX = true;
            nGAYDateTimePicker1.Value = DateTime.Now;
        }

        private void luuPXBtn_Click(object sender, EventArgs e)
        {
            if (nGAYDateTimePicker1.Text.Trim() == "")
            {
                MessageBox.Show("Ngày không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nGAYDateTimePicker.Focus();
                return;
            }
            if (hOTENKHTextBox1.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên khách không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hOTENKHTextBox.Focus();
                return;
            }
            if (mANVTextBox1.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mANVTextBox.Focus();
                return;
            }

            if (isInsertPX)
            {
                if (pHIEUTextBox2.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phiếu không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pHIEUTextBox2.Focus();
                    return;
                }

                if (pHATSINHBindingSource.Find("PHIEU", pHIEUTextBox2.Text.Trim()) != -1)
                {
                    MessageBox.Show("Mã phiếu đã tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pHIEUTextBox2.Focus();
                    return;
                }
            }
            else
            {
                if (cT_PHATSINHBindingSource.Count > 0)
                {
                    if (sOLUONGTextBox1.Text.Trim() == "")
                    {
                        MessageBox.Show("Số lượng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sOLUONGTextBox1.Focus();
                        return;
                    }
                    if (dONGIATextBox1.Text.Trim() == "")
                    {
                        MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dONGIATextBox1.Focus();
                        return;
                    }
                }

            }
            try
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
            catch
            {
                MessageBox.Show("So luong vat tu nhap sai");
                return;
            }

        }

        private void huyPXBtn_Click(object sender, EventArgs e)
        {

            pHATSINHBindingSource.CancelEdit();
            refreshPXBtn.PerformClick();
            viewUIPX();

            cT_PHATSINHBindingSource.CancelEdit();
            viewUICTPX();
            refreshPXBtn.PerformClick();
        }


        private void suaPXBtn_Click(object sender, EventArgs e)
        {
            editUIPX();
            isInsertPX = false;
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
                        checkPXTabDeleteUpdateBtnEnable();
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
            checkCountPX();
            canChangeTab = true;
            huyPXBtn.Enabled = false;
            refreshPXBtn.Enabled = true;
            ctpxActionPanel.Enabled = true;
            luuPXBtn.Enabled = false;
            pHIEUTextBox3.Enabled = true;
            mAVTTextBox2.Enabled = true;
            ctpxInputPanel.Enabled = false;
            comboBox1.Enabled = false;
        }
        private void editUICTPX()
        {
            canChangeTab = false;
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
            canChangeTab = false;
            huyPXBtn.Enabled = true;
            luuPXBtn.Enabled = true;
            refreshPXBtn.Enabled = false;
            ctpxActionPanel.Enabled = false;
            PXActionPanel.Enabled = false;
            ctpxInputPanel.Enabled = true;
            pHIEUTextBox3.Enabled = false;
            mAVTTextBox2.Enabled = false;
            comboBox1.Enabled = true;
        }

        private void themCTPXBtn_Click(object sender, EventArgs e)
        {
            String phieu = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
            this.sP_MaVTChuaNhapTableAdapter.Fill(this.qLVTDataSet.SP_MaVTChuaNhap, phieu);
            // kiem tra con vat tu trong cho phieu hay k
            //khong thi return
            // con thi di tiep
            if (sP_MaVTChuaNhapBindingSource.Count <= 0)
            {
                MessageBox.Show("Khong con vat tu nao chua tao cho phieu nay");
                return;
            }
            addUICTPX();
            cT_PHATSINHBindingSource.AddNew();
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
                    checkCountPX();
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
            String phieu = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();
            this.sP_MaVTChuaNhapTableAdapter.Fill(qLVTDataSet.SP_MaVTChuaNhap, phieu);
        }

        private void sOLUONGTONTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(sOLUONGTONTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                sOLUONGTONTextBox.Text = sOLUONGTONTextBox.Text.Remove(sOLUONGTONTextBox.Text.Length - 1);
            }
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.sP_MaVTChuaNhapTableAdapter.Fill(this.qLVTDataSet.SP_MaVTChuaNhap, pNToolStripTextBox.Text);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void sP_MaVTChuaNhapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    mAVTTextBox1.Text = sP_MaVTChuaNhapComboBox.SelectedValue.ToString();
        //}

        private void sP_MaVTChuaNhapComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            try
            {
                mAVTTextBox1.Text = sP_MaVTChuaNhapComboBox.SelectedValue.ToString();
            }
            catch (Exception nullRef)
            {
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String a = comboBox1.SelectedValue.ToString();
                mAVTTextBox2.Text = a;
            }
            catch (Exception nullRef)
            {
                return;
            }
        }

        private void nGAYDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pHATSINHDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkCountPN();
        }
        private void checkCountPN()
        {
            // lay phieu hien tai
            String phieu = ((DataRowView)pHATSINHBindingSource[pHATSINHBindingSource.Position])["PHIEU"].ToString();

            if (cT_PHATSINHBindingSource.Count >0)
            {
                suaCTPNBtn.Enabled = true;
                xoaCTPNBtn.Enabled = true;
            }
            else
            {
                suaCTPNBtn.Enabled = false;
                xoaCTPNBtn.Enabled = false;
            }
        }

        private void pHATSINHDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkCountPX();
        }
        private void checkCountPX()
        {

            if (cT_PHATSINHBindingSource.Count > 0)
            {
                suaCTPXBtn.Enabled = true;
                xoaCTPXBtn.Enabled = true;
            }
            else
            {
                suaCTPXBtn.Enabled = false;
                xoaCTPXBtn.Enabled = false;
            }
        }
        private bool canChangeTab = true;
        private void VatTuTab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!canChangeTab)
            {
                e.Cancel = true;
            }
        }


        private void pHATSINHDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // kiem tra bat tat delete, update btn
            if (cT_PHATSINHBindingSource.Count == 0)
            {
                suaCTPNBtn.Enabled = false;
                xoaCTPNBtn.Enabled = false;
            }
            else
            {
                suaCTPNBtn.Enabled = true;
                xoaCTPNBtn.Enabled = true;
            }
        }

        private void pHATSINHDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // kiem tra bat tat delete, update btn
            if (cT_PHATSINHBindingSource.Count == 0)
            {
                suaCTPXBtn.Enabled = false;
                xoaCTPXBtn.Enabled = false;
            }
            else
            {
                suaCTPXBtn.Enabled = true;
                xoaCTPXBtn.Enabled = true;
            }
        }
    }
}
