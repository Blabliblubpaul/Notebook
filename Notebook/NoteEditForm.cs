using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace Notebook {
    public partial class NoteEditForm : Form {
        public NoteEditForm() {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            this.Hide();
            try {
                Common.GetFormByName("MainForm").Show();
            }
            catch { }
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Hide();
            try {
                Common.GetFormByName("MainForm").Show();
            }
            catch { }
        }

        private void NoteEditForm_FormClosed(object sender, FormClosedEventArgs e) {
            this.Hide();
            try {
                Common.GetFormByName("MainForm").Show();
            }
            catch { }
        }
    }
}
