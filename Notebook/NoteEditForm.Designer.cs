namespace Notebook {
    partial class NoteEditForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.RichTextBox();
            this.importanceBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1076, 751);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(181, 79);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(903, 757);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(155, 65);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.DetectUrls = false;
            this.nameBox.Location = new System.Drawing.Point(29, 28);
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(612, 35);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "Name:";
            this.nameBox.WordWrap = false;
            // 
            // importanceBox
            // 
            this.importanceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.importanceBox.FormattingEnabled = true;
            this.importanceBox.Items.AddRange(new object[] {
            "less imortant",
            "important",
            "very important",
            "extremely important"});
            this.importanceBox.Location = new System.Drawing.Point(37, 112);
            this.importanceBox.Name = "importanceBox";
            this.importanceBox.Size = new System.Drawing.Size(606, 33);
            this.importanceBox.TabIndex = 2;
            // 
            // NoteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 844);
            this.Controls.Add(this.importanceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "NoteEditForm";
            this.Text = "NoteEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NoteEditForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Button saveBtn;
        private Button cancelBtn;
        private RichTextBox nameBox;
        private ComboBox importanceBox;
    }
}