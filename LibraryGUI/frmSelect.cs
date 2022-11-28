using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LibraryGUI
{
    public partial class frmSelect : Form
    {
        private IEnumerable<object> _items;
        private Action<object> _callback;
        //private ProcessSelection _callback;
        public frmSelect(string title, IEnumerable<object> items, Action<object> callback)
        {
            InitializeComponent();
            _items = items;
            _callback = callback;
            this.Text = title;
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {
            foreach(object item in _items)
                lstItems.Items.Add(item);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать элемент");
                return;
            }
            
            _callback(lstItems.SelectedItem);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
