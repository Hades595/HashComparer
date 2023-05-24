using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace HashComparer
{
    public partial class Form1 : Form
    {
        public static List<String> srcFiles;
        public static List<String> destFiles;

        public static bool enableMD5 = true;
        public static bool enableSHA1 = true;
        public static bool enableSHA256 = false;

        public Form1()
        {
            InitializeComponent();
            initalizeListView();
            
        }

        public void initalizeListView()
        {
            listView1.Clear();

            listView1.GridLines = true;
            listView1.AllowColumnReorder = true;
            listView1.LabelEdit = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Ascending;
            listView1.View = View.Details;

            listView1.Columns.Add("File Path");

            if (enableMD5)
            {
                listView1.Columns.Add("MD5");
            }
            if (enableSHA1)
            {
                listView1.Columns.Add("SHA1");
            }
            if (enableSHA256)
            {
                listView1.Columns.Add("SHA256");
            }

            listView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                srcFiles = ListDirectory(sourceFolderTreeView, folderBrowser.SelectedPath);
                SourceFoldertextBox.Text = folderBrowser.SelectedPath.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                destFiles = ListDirectory(DestinationTreeView, folderBrowser.SelectedPath);
                DestinationtextBox.Text = folderBrowser.SelectedPath.ToString();
            }
        }

        private void calculateHashesButton_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            string[] arr = new string[2];

            foreach (string file in srcFiles)
            {
                arr[0] = file;
                arr[1] = calculate_MD5(file);
                item = new ListViewItem(arr);
                listView1.Items.Add(item);
                listView1.Update();
            }

        }

        private static List<String> ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();

            List<string> temp = new List<string>();

            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            stack.Push(node);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                var directoryInfo = (DirectoryInfo)currentNode.Tag;
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                    currentNode.Nodes.Add(childDirectoryNode);
                    stack.Push(childDirectoryNode);
                }
                foreach (var file in directoryInfo.GetFiles())
                {
                    currentNode.Nodes.Add(new TreeNode(file.Name));
                    temp.Add(file.FullName);
                }

            }

            treeView.Nodes.Add(node);

            return temp;
        }

        public string calculate_MD5(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    string md5hash = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    return md5hash;
                }
            }
        }

        public string calculate_SHA1(string filePath)
        {
            return null;
        }

        public string calculate_SHA256(string filePath)
        {
            return null;
        }

        //private void UpdateProgress()
        //{
        //    if (progressBar1.Value < progressBar1.Maximum)
        //    {
        //        progressBar1.Value++;
        //        int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
        //        progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
        //        Application.DoEvents();
        //    }
        //}


    }
}
