using System.Net.Http.Headers;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        public static Form GetFormByName(string formName) {
            foreach (Form frm in Application.OpenForms) {
                if (frm.Name == formName) {
                    return frm;
                }
            }
            //return null;
            throw new NullReferenceException();
        }

        // Code copied from https://markheath.net/post/list-and-download-github-repo-cs
        public static async void DownloadFileFromGitHubRepo(string repoURL, string UserName, string token = "") {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.Add(
                new ProductInfoHeaderValue(UserName, "1"));
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(token);
            string contentsURL = $"https://api.github.com/repos/{repoURL}/contents";
            string contentsJson = await httpClient.GetStringAsync(contentsURL);
            JArray contents = (JArray)JsonConvert.DeserializeObject(contentsJson);
            
            if (contents != null && contents.Count > 0) {
                int i = 1;
                foreach (JToken file in contents) {
                    i++;
                    string fileType = (string)file["type"];
                    if (fileType == "dir") {
                        string directoryContentsUrl = (string)file["url"];
                        // use this URL to list the contents of the folder
                        //Console.WriteLine($"DIR: {directoryContentsUrl}");
                        try {
                            File.WriteAllText("C:/Users/Paul/source/repos/Notebook/Notebook/TextFile1", directoryContentsUrl);
                        }
                        catch {

                        }
                    }
                    else if (fileType == "file") {
                        string downloadUrl = (string)file["download_url"];
                        // use this URL to download the contents of the file
                        //Console.WriteLine($"DOWNLOAD: {downloadUrl}");
                        try {
                            File.WriteAllText("C:/Users/Paul/source/repos/Notebook/Notebook/TextFile1", downloadUrl + file["content"]);
                        }
                        catch {

                        }
                    }
                }
                try {

                    File.WriteAllText("C:/Users/Paul/source/repos/Notebook/Notebook/TextFile1", i.ToString());
                }
                catch {

                }
                //File.WriteAllText("C:/Users/Paul/source/repos/Notebook/Notebook/TextFile1", "Hello World4");

            }
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
