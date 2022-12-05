namespace Notebook {
    public partial class MainForm : Form {
        NoteEditForm noteEditForm = new NoteEditForm();
        public MainForm() {
            InitializeComponent();
        }

        private void OnClose(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void newNoteBtn_Click(object sender, EventArgs e) {
            this.Hide();
            try {
                Common.GetFormByName("NoteEditForm").Show();
            }
            catch {
                noteEditForm = new NoteEditForm();
                noteEditForm.Show();
            }
        }
    }
}