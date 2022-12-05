namespace Notebook {
    public partial class NoteEditForm : Form {
        Note note;
        bool newNote = false;

        public NoteEditForm(Note? note = null) {
            InitializeComponent();

            if (note == null) {
                this.note = new Note();
            }
            else {
                this.note = note;
                newNote = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            Hide();
            try {
                Common.GetFormByName("MainForm").Show();
            }
            catch { }
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            Hide();
            Program.mainForm.Show();
        }

        private void NoteEditForm_FormClosed(object sender, FormClosedEventArgs e) {
            Hide();
            Program.mainForm.Show();
        }

        private void Show(Note? note = null) {
            if (note == null) {
                this.note = new Note();
            }
            else {
                this.note = note;
                newNote = true;
            }

            Show();
        }
    }
}
