using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
//using TBDT.Manager;

namespace TBDT_2D.Forms
{
    public partial class VS_GiaoVuAddEdit : Form
    {
        //VS_GiaoVu currentEditUserData;

        //public VS_GiaoVuAddEdit()
        //{
        //    InitializeComponent();
        //}

        //public VS_GiaoVuAddEdit(VS_GiaoVu data)
        //{
        //    InitializeComponent();
        //    InitData(data);
        //}

        //void InitData(VS_GiaoVu data)
        //{
        //    //Change form text
        //    this.Text = data.Id == 0 ? "THÊM NGƯỜI DÙNG" : "CHỈNH SỬA THÔNG TIN NGƯỜI DÙNG";

        //    //Binding cbo data
        //    var bindingLst = new List<VS_QuanHam>();
        //    bindingLst.Add(new VS_QuanHam
        //    {
        //        Id = 0,
        //        QuanHam = ""
        //    });

        //    var lstQH = VS_DBManager.LoadAllQuanHams();
        //    bindingLst.AddRange(lstQH);
            
        //    cboQuanHam.ValueMember = "Id";
        //    cboQuanHam.DisplayMember = "QuanHam";
        //    cboQuanHam.DataSource = bindingLst;

        //    //Populate data
        //    currentEditUserData = VS_Helper.Clone<VS_GiaoVu>(data);

        //    tbTen.Text = data.HoTen;
        //    cboQuanHam.SelectedValue = data.QuanHamId;
        //    tbNamSinh.Text = data.NamSinh.ToString();

        //}

        //void CloseForm()
        //{
        //    currentEditUserData = null;
        //    this.Close();
        //}

        //private void btnOK_Click(object sender, EventArgs e)
        //{
        //    //Data validation
        //    if (string.IsNullOrWhiteSpace(tbTen.Text))
        //    {
        //        MessageBox.Show("Chưa nhập tên!");
        //        return;
        //    }

        //    if (((VS_QuanHam)cboQuanHam.SelectedItem).Id == 0)
        //    {
        //        MessageBox.Show("Chưa nhập quân hàm!");
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(tbNamSinh.Text) || !int.TryParse(tbNamSinh.Text.Trim(), out int namSinh))
        //    {
        //        MessageBox.Show("Năm sinh không hợp lệ!");
        //        return;
        //    }

        //    //Update data to DB
        //    currentEditUserData.HoTen = tbTen.Text.Trim();
        //    currentEditUserData.QuanHamId = ((VS_QuanHam)cboQuanHam.SelectedItem).Id;
        //    currentEditUserData.NamSinh = namSinh;

        //    if (VS_DBManager.AddEditGiaoVu(currentEditUserData))
        //        CloseForm();
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    CloseForm();
        //}
    }
}
