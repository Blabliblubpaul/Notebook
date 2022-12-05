using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook {
    public static class Common {

        public static bool FormExists(string formName) {
            foreach (Form frm in Application.OpenForms) {
                if (frm.Name == formName) {
                    return true;
                }
            }
            return false;
        }

        public static Form? GetFormByName(string formName) {
            foreach (Form frm in Application.OpenForms) {
                if (frm.Name == formName) {
                    return frm;
                }
            }
            return null;
        }

        //public static Form? ShowForm<T>(string formName) {
        //    if (FormExists(formName)) {
        //        Form frm = GetFormByName(formName);
        //        frm.Show();
        //        return frm;
        //    }
        //    else {
        //        if (formName == "MainForm") {
        //            Form frm = new MainForm();
        //            frm.Show();
        //            return frm;
        //        }
        //        else if (formName == "NoteEditForm") {

        //        }
        //    }
        //    return null;
        //}
    }
}
