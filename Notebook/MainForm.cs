using System.Runtime.CompilerServices;

namespace Notebook {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void OnClose(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void newNoteBtn_Click(object sender, EventArgs e) {
            this.Hide();
            NoteEditForm noteEditForm = new NoteEditForm();
            noteEditForm.Show();
            this.Close();
        }
    }
}