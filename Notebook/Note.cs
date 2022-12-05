using System.Web;

namespace Notebook {
    public class Note {
        public string Name { get; set; }
        public string Importance { get; set; }
        public string Text { get; set; }

        public Note(string name, string importance, string text) {
            Name = name;
            Importance = importance;
            Text = text;
        }
    }
}
