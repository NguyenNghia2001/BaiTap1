using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap01_THietKeForm_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Chào Bạn Đến Với Ẩm Thức Quê Tôi . Trước Khi Vào Mời Bạn Chuyển Khoản Cho Tôi 10$", " Thông Báo Dành Cho RickKid ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstThucDon.SelectionMode = SelectionMode.MultiExtended;
            lstMonAn.SelectionMode = SelectionMode.MultiExtended;
            lstThucDon.Sorted = true;
            lstMonAn.Sorted = true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lstThucDon.Items.Add(txtNhapMonAn.Text);
            txtNhapMonAn.Focus();
            txtNhapMonAn.Clear();
          //  lstThucDon.SelectedIndex = lstThucDon.Items.Count - 1;
        }

        private void btnSangPhai_n_Click(object sender, EventArgs e)
        {
            // di chuyển tất cả các phàn tử được chọn từ trái sang phải ==> Thêm các phần tử vào listbox phải và xóa các phần tử trong listbox
            //1. Thêm Các Phần Tử Dudocj chọn trong Listbox Trái (ListBox) Vào ListBox Phait (latMonAn)
             for(int i= 0; i<lstThucDon.SelectedItems.Count;i++)
            {
                lstMonAn.Items.Add(lstThucDon.SelectedItems[i].ToString());
            }
             //2. Xóa các Phần Tử Được Chọn Trong ListBox Trai
             while(lstThucDon.SelectedItems.Count > 0)
            {
                lstThucDon.Items.Remove(lstThucDon.SelectedItems[0]);
            } 
        }

        private void btnSangPhai_All_Click(object sender, EventArgs e)
        {
            //lstMonAn.Items.AddRange(lstThucDon.Items);
            //lstThucDon.Items.Clear();
            // Chuyển tất Cả cAcacs Phần tử Ở ListBox Trái  sang ListBox Phải
            for (int i = 0; i < lstThucDon.Items.Count; i++)
                lstMonAn.Items.Add(lstThucDon.Items[i].ToString());
            // Xóa tất cả Các Phần Tử TRong LIstBox Trái 
            lstThucDon.Items.Clear();
        }

        private void btnSangTrai_n_Click(object sender, EventArgs e)
        {
            //1. Thêm Các Phần Tử Được chọn trong Listbox Phải (LstMonAn) Vào ListBox Trái (latthucDon)
            for (int i = 0; i < lstMonAn.SelectedItems.Count; i++)
            {
               lstThucDon.Items.Add(lstMonAn.SelectedItems[i].ToString());
            }
            //2. Xóa các Phần Tử Được Chọn Trong ListBox Phải
            while (lstMonAn.SelectedItems.Count > 0)
            {
                lstMonAn.Items.Remove(lstMonAn.SelectedItems[0]);
            }
        }

        private void btnSangTrai_All_Click(object sender, EventArgs e)
        {
            // Chuyển tất Cả các Phần tử Ở ListBox Phải  sang ListBox Trái
            for (int i = 0; i < lstMonAn.Items.Count; i++)
                lstThucDon.Items.Add(lstMonAn.Items[i].ToString());
            // Xóa tất cả Các Phần Tử TRong LIstBox Trái 
            lstMonAn.Items.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Có Muốn Thoát Khỏi Ứng Dụng Không!. Nhớ Chuyển Khoản Bạn Nhé!" ," Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
