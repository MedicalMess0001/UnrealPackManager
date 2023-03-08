using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Text.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace UnrealPackManager
{
    public partial class UnrealPackManager : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );

        List<Paths> paths = new List<Paths>();
        string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string command = "";
        string command2 = "";
        public string newPath = "";
        public string JSONloc = "";
        public string curfolder = "";
        public string searcher = "";
        public string output = "";
        public string aeskey = "";
        public string name = "";
        public string path = "";
        public string path0 = "";
        public string orginal = "";
        public string pathfix = "";
        public string pathrnm = ""; 
        public UInt64 chunkided; 
        public string chunkid1 = "";
        public string chunkid2 = "";
        public string[] drop;
        public JObject json;
        string dropinfo = "";

        //json stuff
        public class FileItem
        {
            public string Path { get; set; }
            public string ChunkId { get; set; }
        }
        public class DependenciesObject
        {
            public long packageID { get; set; }
            public Dictionary<string, JObject> ChunkIDToDependencies { get; set; }
        }
        public class Assets
        {
            public List<FileItem> Files { get; set; }
            public DependenciesObject Dependencies { get; set; }
        }
        class Paths
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }
        private void addtojson()
        {

            if (File.Exists(JSONloc))
            {
                if (File.ReadAllText(JSONloc).Length == 0)
                {
                    paths.Clear();
                }
                if (File.ReadAllText(JSONloc).Length != 0)
                {
                    List<Paths> paths = System.Text.Json.JsonSerializer.Deserialize<List<Paths>>(File.ReadAllText(JSONloc));
                    Paths pathcheck = paths.FirstOrDefault(p => p.Name == name);
                    if (pathcheck != null)
                    {
                        pathcheck.Path = path;
                        JsonSerializerOptions options1 = new JsonSerializerOptions
                        {
                            WriteIndented = true
                        };
                        using (StreamWriter sw = new StreamWriter(JSONloc))
                        {
                            sw.Write(System.Text.Json.JsonSerializer.Serialize(paths, options1));
                            sw.Flush();
                        }
                        return;
                    }
                }
            }
            paths.Add(new Paths { Name = name, Path = path });
            JsonSerializerOptions options3 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            using (StreamWriter sw = new StreamWriter(JSONloc))
            {
                sw.Write(System.Text.Json.JsonSerializer.Serialize(paths, options3));
                sw.Flush();
            }
            return;
        }
        private void jsonsearch()
        {
            logger.Clear();
            if (File.Exists(JSONloc))
            {
                if (File.ReadAllText(JSONloc).Length != 0)
                {
                    List<Paths> paths = System.Text.Json.JsonSerializer.Deserialize<List<Paths>>(File.ReadAllText(JSONloc));
                    Paths myPath = paths.FirstOrDefault(p => p.Name == searcher);
                    if (myPath != null)
                    {
                        path0 = myPath.Path;
                        if (searcher.Contains("exe"))
                        {
                            if (!File.Exists(path0 + searcher))
                            {
                                logger.Visible = true;
                                logger.AppendText(searcher + " can not be found!");
                                logger.AppendText(Environment.NewLine);
                                logger.AppendText("Click To Close");
                                return;
                            }
                        }
                    }
                    else
                    {
                        logger.Visible = true;
                        logger.AppendText("Path not set for " + searcher);
                        logger.AppendText(Environment.NewLine);
                        logger.AppendText("Click To Close");
                        return;
                    }
                }
            }
            else
            {
                logger.Visible = true;
                logger.AppendText("No JSON Created");
                logger.AppendText(Environment.NewLine);
                logger.AppendText("Setup in Settings");
                logger.AppendText(Environment.NewLine);
                logger.AppendText("Click To Close");
                return;
            }
        }
        public void manifestfix()
        {
            searcher = "output";
            jsonsearch();
            output = path0;
            searcher = "orginal";
            jsonsearch();
            orginal = path0;
            string[] files = Directory.GetFiles(output, "*", SearchOption.AllDirectories);
            if (File.Exists(output + "manifest.json"))
            {
                string jsonString = File.ReadAllText(output + "manifest.json");
                List<FileItem> files1 = JObject.Parse(jsonString)["Files"].ToObject<List<FileItem>>();
                foreach (string file in files)
                {
                    string[] subDirectories = Directory.GetDirectories(output + "\\z_mod_P");
                    string fileName = Path.GetFileName(file);

                    if (fileName != "manifest.json")
                    {
                        string filePath = file.Substring(output.Length).Replace(@"\", "/");
                        string[] pathParts = filePath.Split('/');
                        if (customnam.Text != "" && cstmnam.Checked == true)
                        {
                            newPath = string.Join("/", pathParts.Skip(2));
                        }
                        if (cstmnam.Checked == false)
                        {
                            newPath = string.Join("/", pathParts.Skip(2));
                        }
                        foreach (FileItem file1 in files1)
                        {
                            if (file1.Path.Contains(fileName))
                            {
                                if (customnam.Text != "" && cstmnam.Checked == true)
                                {
                                    file1.Path = "/" + customnam.Text + "/" + newPath;
                                }
                                else
                                {
                                    file1.Path = "/" + orginal + "/" + newPath;
                                }
                                json = JObject.Parse(jsonString);
                                json["Files"] = JArray.FromObject(files1);
                            }
                        }
                    }
                }
            }
            string modifiedJsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
            File.WriteAllText(output + "manifest.json", modifiedJsonString.ToString());
            filerename();
        }
        private void JSONOPEN_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", JSONloc);
        }
        //start and utils
        public UnrealPackManager()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Start();
        }
        private void Start()
        {
            UECastocP.Visible = true;
            JSONloc = roamingPath + "\\UnrealTool\\settings.json";
            searcher = "custom_name";
            jsonsearch();
            customnam.Text = path0;
            if (!Directory.Exists(roamingPath + "\\UnrealTool"))
            {
                Directory.CreateDirectory(roamingPath + "\\UnrealTool");
            }

        }
        private void logger_Click(object sender, EventArgs e)
        {
            logger.Visible = false;
            logger.Clear();
            return;
        }
        private void UnrealPackManager_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void UnrealPackManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //menu stuff
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
        private void Settings_Click(object sender, EventArgs e)
        {
            UECastocP.Visible = false;
            UnrealPakP.Visible = false;
            SettingsP.Visible = true;
        }
        private void UECastoc_Click(object sender, EventArgs e)
        {
            UECastocP.Visible = true;
            UnrealPakP.Visible = false;
            SettingsP.Visible = false;
        }
        private void UnrealPak_Click(object sender, EventArgs e)
        {
           /* UECastocP.Visible = false;
            UnrealPakP.Visible = true;
            SettingsP.Visible = false;*/
        }
        //cmd workers    
        private void runcmd_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = command;
            startInfo.WorkingDirectory = curfolder;
            process.StartInfo = startInfo;
            process.Start();

        }
        private void ProcessExited1(object sender, RunWorkerCompletedEventArgs e)
        {
            runer2.RunWorkerAsync();
        }
        private void runcmd2_DoWork(object sender, DoWorkEventArgs e)
        {

            System.Diagnostics.Process process1 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo1 = new System.Diagnostics.ProcessStartInfo();
            startInfo1.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo1.FileName = "cmd.exe";
            startInfo1.Arguments = command2;
            startInfo1.WorkingDirectory = curfolder;
            process1.StartInfo = startInfo1;
            process1.Start();

        }
        private void ProcessExited2(object sender, RunWorkerCompletedEventArgs e)
        {
            getorginalname();
        }
        //UnrealPak WIP

        //drop checkers

        //drag rules

        //Settings

        //drop checkers
        private void UnrealPakSet_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                drop = (string[])e.Data.GetData(DataFormats.FileDrop);
                dropinfo = drop[0];
                if (dropinfo.Contains("UnrealPak.exe"))
                {
                    name = "UnrealPak.exe";
                    path = dropinfo.Replace(name, "");
                    addtojson();
                    return;
                }
            }
        }
        private void UECastocSet_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                drop = (string[])e.Data.GetData(DataFormats.FileDrop);
                dropinfo = drop[0];
                if (dropinfo.Contains("main.exe"))
                {
                    name = "main.exe";
                    path = dropinfo.Replace(name, "");
                    addtojson();
                    return;
                }
            }
        }
        private void OutputSet_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                drop = (string[])e.Data.GetData(DataFormats.FileDrop);
                dropinfo = drop[0];
                name = "output";
                path = dropinfo + "\\";
                addtojson();
                return;
            }
        }
        //drag rules
        private void UnrealPakSet_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            string[] File1 = (string[])e.Data.GetData(DataFormats.FileDrop);
            string check = File1[0];
            if (check.Contains("UnrealPak.exe"))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void UECastocSet_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            string[] File1 = (string[])e.Data.GetData(DataFormats.FileDrop);
            string check = File1[0];
            if (check.Contains("main.exe"))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void OutputSet_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
            }
            e.Effect = effects;
        }
        //UECastoc

        //drop checkers
        private void Unpack_DragDrop(object sender, DragEventArgs e)
        {
            aeskey = aeske.Text;
            searcher = "main.exe";
            jsonsearch();
            curfolder = path0;
            searcher = "output";
            jsonsearch();
            output = path0;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                drop = (string[])e.Data.GetData(DataFormats.FileDrop);
                dropinfo = drop[0];
                if (dropinfo.Contains(".utoc"))
                {
                    dropinfo = dropinfo.Replace(".utoc", "");
                }
                else
                {
                    dropinfo = dropinfo.Replace(".ucas", "");
                }
                if (File.Exists(curfolder + "main.exe"))
                {
                    //command = $" unpackAll \"{dropinfo}.utoc\" \"{dropinfo}.ucas\" \"{output}z_mod_P\" {aeske.Text}";
                    command2 = $@"/c main.exe manifest ""{dropinfo}.utoc"" ""{dropinfo}.ucas"" ""{output}manifest.json"" ""{aeske.Text}""";
                    command = $@"/c main.exe unpackAll ""{dropinfo}.utoc"" ""{dropinfo}.ucas"" ""{output}z_mod_P\\"" ""{aeske.Text}""";
                    runer.RunWorkerAsync();
                }
                return;
            }
        }
        private void Pack_DragDrop(object sender, DragEventArgs e)
        {
            aeskey = aeske.Text;
            searcher = "main.exe";
            jsonsearch();
            curfolder = path0;
            searcher = "output";
            jsonsearch();
            output = path0;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                drop = (string[])e.Data.GetData(DataFormats.FileDrop);
                dropinfo = drop[0];
                string dpo = Path.GetFileName(dropinfo);
                string[] subDirectories = Directory.GetDirectories(dropinfo);
                foreach (string subDirectory in subDirectories)
                {
                    string subDirectoryName = Path.GetFileName(subDirectory);
                    string input = dropinfo + "";
                    if (File.Exists(curfolder + "main.exe"))
                    {
                        command = $@"pack ""{input}"" ""{output}manifest.json"" ""{output}{dpo}"" ""none"" ""{aeske.Text}""";
                        //command = "/c main.exe pack" + " \"" + input + "*\"" + " \"" + output + "manifest.json\"" + " \"" + output + dpo + "\" " + "none " + aeske.Text;
                        Process.Start(curfolder + "main.exe", command);
                    }
                }
                return;
            }
        }
        //drag rules
        private void Unpack_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            drop = (string[])e.Data.GetData(DataFormats.FileDrop);
            dropinfo = drop[0];
            if (dropinfo.Contains(".utoc") || dropinfo.Contains(".ucas"))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void Pack_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
            }
            e.Effect = effects;
        }
        //OTHER
        private void rdmchunkid_Click(object sender, EventArgs e)
        {
            int num = 0;
            int numa = 0;
            if (customnam.Text != "")
            {
                byte[] bytes = Encoding.ASCII.GetBytes(customnam.Text);
                num = BitConverter.ToInt32(bytes, 0);
            }
            Random random = new Random();
            byte[] buffer = new byte[8];
            random.NextBytes(buffer);
            chunkided = BitConverter.ToUInt64(buffer, 0);
            chunkid2 = chunkided.ToString();
            if (customnam.Text != "")
            {
                numa = (int)chunkided;
                int greatvalue = num + numa;
                UInt64 numUInt64 = (UInt64)greatvalue;
                chunkid2 = numUInt64.ToString();
            }
            else
            {
                chunkided = BitConverter.ToUInt64(buffer, 0);
                chunkid2 = chunkided.ToString();
            }
            chunkid.Clear();
            chunkid.Text = chunkid2;
            searcher = "output";
            jsonsearch();
            output = path0;
            string filePath = output + "manifest.json";
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("packageID"))
                {
                    string match = Regex.Match(lines[i], ": " + "(.+?)" + ",").Groups[1].Value;
                    string newLine = lines[i].Replace(match, chunkid2);
                    lines[i] = newLine;
                    break;
                }
            }
            File.WriteAllLines(filePath, lines);
        }
        //customname
        public void getorginalname()
        {
            searcher = "output";
            jsonsearch();
            output = path0;
            Thread.Sleep(4000);
            string[] files = Directory.GetDirectories(output + "z_mod_P\\");
            foreach (string file in files)
            {
                string subDirectoryName = Path.GetFileName(file);
                name = "orginal";
                path = subDirectoryName;
                path = path.Replace(" ", "");
                addtojson();
                manifestfix();
                return;
            }
        }
        public void filerename()
        {
            searcher = "output";
            jsonsearch();
            output = path0;
            searcher = "orginal";
            jsonsearch();
            orginal = path0;
            string[] files = Directory.GetDirectories(output + "z_mod_P\\");
            foreach (string file in files)
            {
                string subDirectoryName = Path.GetFileName(file);
                string folderl = output + "z_mod_P\\";
                string first = folderl + subDirectoryName;
                string second = folderl + customnam.Text;
                string orginall = folderl + orginal;
                if (customnam.Text != "" && cstmnam.Checked == true)
                {
                    Directory.Move(first, second);
                    return;
                }
                if (first != orginall && orginal != output)
                {
                    Directory.Move(first, orginall);
                    return;
                }
                return;
            }
        }
        private void customnam_TextChanged(object sender, EventArgs e)
        {
            cstmnam.Checked = false;
                name = "custom_name";
                path = customnam.Text;
                addtojson();
                return;
        }
        private void cstmnam_CheckedChanged(object sender, EventArgs e)
        {
            if (customnam.Text != "" && cstmnam.Checked == true)
            {
                manifestfix();
            }
            else
            {
                manifestfix();
            }
        }
    }
}
