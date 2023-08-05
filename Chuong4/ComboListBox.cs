using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4
{
    public partial class ComboListBox : Form
    {
        
        public ComboListBox()
        {
            InitializeComponent();
            initColor();
        }

        private void initColor()
        {
            //Lấy tất cả property của color và lọc property nào type = color
            //và sau đó lấy giá trị của nó(vì property của Color là tĩnh nên GetValue truyền vào 1 tham số null)
            comboBoxColor.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color clr = (Color)comboBoxColor.SelectedItem;

            // Nếu màu được chọn là trong suốt(Transparent), sử dụng màu trắng thay thế
            listBoxRight.BackColor = (clr == Color.Transparent ? Color.White : clr);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text == "")
                    return;
                listBoxLeft.Items.Add(txtInput.Text);
                txtInput.Clear();
            }
            catch (FormatException ex) { MessageBox.Show(ex.Message); }
            catch (Exception) { MessageBox.Show("Lỗi"); }
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            if (listBoxLeft.Items.Count == 0)
                return;
            listBoxLeft.SelectionMode = SelectionMode.MultiSimple;
            for(int i = listBoxLeft.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBoxRight.Items.Add(listBoxLeft.SelectedItem);
                listBoxLeft.Items.RemoveAt(listBoxLeft.SelectedIndex);
            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            if (listBoxRight.Items.Count == 0)
                return;
            listBoxRight.SelectionMode = SelectionMode.MultiSimple;
            for (int i = listBoxRight.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBoxLeft.Items.Add(listBoxRight.SelectedItem);
                listBoxRight.Items.RemoveAt(listBoxRight.SelectedIndex);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //xóa các phần tử được chỉ định ở list box trái
            if(listBoxLeft.SelectedItems.Count != 0)
                for(int i = listBoxLeft.SelectedItems.Count - 1; i >= 0; i--)
                    listBoxLeft.Items.RemoveAt(listBoxLeft.SelectedIndex);

            //xóa các phần tử được chỉ định ở list box phải
            if (listBoxRight.SelectedItems.Count != 0)
                for(int i = listBoxRight.SelectedItems.Count - 1; i >= 0; i--)
                    listBoxRight.Items.RemoveAt(listBoxRight.SelectedIndex);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //xóa toàn bộ list box trái
            listBoxLeft.DataSource = null;
            listBoxLeft.Items.Clear();

            //xóa toàn bộ list box phải
            listBoxRight.DataSource = null;
            listBoxRight.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
