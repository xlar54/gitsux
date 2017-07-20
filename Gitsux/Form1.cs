using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gitsux
{
    public partial class Form1 : Form
    {
        FileSystemWatcher watcher = new FileSystemWatcher();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void doCommand(string command)
        {
            Git gp = new Git();
            string result = gp.ExecuteCommand(command, lblWorkingDirectory.Text);

            textBox2.Invoke(t => t.Text = command);
            textBox1.Invoke(t => t.Clear());
            textBox1.Invoke(t => t.AppendText(result.Replace("\n", Environment.NewLine)));

            int s1 = result.IndexOf("On branch");
            
            if (s1 > -1)
            {
                s1 += 10;
                int s2 = result.IndexOf("\n", s1);

                lblCurrentBranch.Invoke(t => t.Text = result.Substring(s1, s2 - s1));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDialog = new FolderBrowserDialog();
            DialogResult result = fDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblWorkingDirectory.Text = fDialog.SelectedPath;
                doCommand("init");
            }    
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            doCommand("status");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDialog = new FolderBrowserDialog();
            DialogResult result = fDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblWorkingDirectory.Text = fDialog.SelectedPath;
                doCommand("status");

                watcher.Path = fDialog.SelectedPath;
                //watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName;
                watcher.Filter = "*.*";
                watcher.Changed += Watcher_Changed;
                watcher.Created += Watcher_Changed;
                watcher.Renamed += Watcher_Changed;
                watcher.Deleted += Watcher_Changed;
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;

                /*Git gp = new Git();
                List<Branch> branches = gp.GetBranches(lblWorkingDirectory.Text);

                foreach (Branch b in branches)
                {
                    comboBox1.Items.Add(b.name);

                    if (b.isCurrent)
                        comboBox1.SelectedItem = b.name;
                }*/
                    


            }
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            if(e.Name.Contains(".git"))
                return; 
            else
                doCommand("status");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Please provide a comment for this commit:";

            input.ShowDialog();

            string comment = input.Result;

            doCommand("commit -m \"" + comment + "\"");
        }

        private void btnListTracked_Click(object sender, EventArgs e)
        {
            doCommand("ls-tree -r " + lblCurrentBranch.Text + " --name-only");
        }

        private void btnListUntracked_Click(object sender, EventArgs e)
        {
            doCommand("ls-files --others --exclude-standard");
        }

        private void btnDisplayLog_Click(object sender, EventArgs e)
        {
            doCommand("log");
        }

        private void btnListBranches_Click(object sender, EventArgs e)
        {
            doCommand("branch");
        }

        private void btnCreateBranch_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Please provide a new branch name:";

            input.ShowDialog();

            string branchName = input.Result;

            doCommand("checkout -b " + branchName);
        }

        private void btnChangeBranches_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Which branch to switch to?";

            input.ShowDialog();

            string branchName = input.Result;

            doCommand("checkout " + branchName);
        }

        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Which branch to delete?";

            input.ShowDialog();

            string branchName = input.Result;

            doCommand("branch -D " + branchName);
        }

        private void btnMergeBranch_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Merge current branch with which branch?";

            input.ShowDialog();

            string branchName = input.Result;

            doCommand("merge " + branchName);
        }

        private void btnUndoCheckIn_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                doCommand("revert HEAD^");
            else
                doCommand("reset HEAD^ --hard");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Revert to which commit?  (sha1)";

            input.ShowDialog();

            string sha1 = input.Result.Trim();

            if (radioButton1.Checked)
            {
                //doCommand("revert " + sha1);
                doCommand("revert --no-commit " + sha1 + "..HEAD");
                doCommand("commit -m \"revert from " + sha1 + "\"");
            }                
            else
                doCommand("reset --hard " + sha1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doCommand("add -A");
            doCommand("status");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doCommand("diff --name-only --cached");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            doCommand("diff --name-only");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Filename to commit";

            input.ShowDialog();

            string file = input.Result;

            doCommand("add \"" + file + "\"");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            doCommand("ls-tree --name-only -r " + lblCurrentBranch.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            doCommand("reset HEAD");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Filename to unstage";

            input.ShowDialog();

            string file = input.Result.Trim();

            doCommand("reset HEAD \"" + file + "\"");
            doCommand("status");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            doCommand("log --pretty=format:\" % h % ad | % s % d[% an]\" --graph --date=short");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "SHA1 of commit to check out";

            input.ShowDialog();

            string sha1 = input.Result;

            doCommand("checkout " + sha1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Tag name";

            input.ShowDialog();

            string tag = input.Result;

            doCommand("tag " + tag);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            doCommand("tag ");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Which file do you want to get last commit";

            input.ShowDialog();

            string sha1 = input.Result.Trim();

            doCommand("checkout -- \"" + sha1 + "\"");
            //doCommand("status");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            doCommand("checkout " + lblCurrentBranch.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            doCommand("stash");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            doCommand("stash list");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Which stash do you want to apply?";

            input.ShowDialog();

            string stash = input.Result;

            doCommand("stash apply " + stash);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Which stash do you want to delete?";

            input.ShowDialog();

            string stash = input.Result;

            doCommand("stash drop " + stash);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Which stash do you want to apply?";

            input.ShowDialog();

            string stash = input.Result;

            doCommand("stash pop " + stash);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Which file do you wish to untrack?";

            input.ShowDialog();

            string file = input.Result.Trim();

            doCommand("rm --cached \"" + file + "\"");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();

            input.Prompt = "Updated comment:";

            input.ShowDialog();

            string comment = input.Result.Trim();

            doCommand("commit --amend -m \"" + comment + "\"");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            doCommand("remote -v");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Prompt = "Short name for remote:";
            input.ShowDialog();
            string shortname = input.Result.Trim();

            input = new InputForm();
            input.Prompt = "URL for remote:";
            input.ShowDialog();
            string url = input.Result.Trim();


            doCommand("remote add " + shortname + " " + url);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Prompt = "Name of remote to fetch from:";
            input.ShowDialog();
            string remote = input.Result.Trim();


            doCommand("fetch " + remote);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            doCommand("push origin " + lblCurrentBranch.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Prompt = "Name of remote to show detail:";
            input.ShowDialog();
            string remote = input.Result.Trim();


            doCommand("remote show " + remote);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Prompt = "Old short name for remote:";
            input.ShowDialog();
            string oldname = input.Result.Trim();

            input = new InputForm();
            input.Prompt = "New short name for remote:";
            input.ShowDialog();
            string newname = input.Result.Trim();


            doCommand("remote rename " + oldname + " " + newname);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Prompt = "Name of remote to remove:";
            input.ShowDialog();
            string remote = input.Result.Trim();


            doCommand("remote remove " + remote);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Prompt = "URL of remote repository:";
            input.ShowDialog();
            string remote = input.Result.Trim();

            FolderBrowserDialog fDialog = new FolderBrowserDialog();
            DialogResult result = fDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblWorkingDirectory.Text = fDialog.SelectedPath;

                doCommand("clone " + remote + " \"" + lblWorkingDirectory.Text + "\"" );
            }

            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string t = textBox2.Text;

            if (t.StartsWith("git "))
                t = t.Substring(4);

            doCommand(t);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            doCommand("branch -a");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Prompt = "Local branch:";
            input.ShowDialog();
            string local = input.Result.Trim();

            input = new InputForm();
            input.Prompt = "Remote branch (remotename/branch):";
            input.ShowDialog();
            string remote = input.Result.Trim();


            doCommand("diff " + local + " " + remote);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Prompt = "Name of remote to pull from:";
            input.ShowDialog();
            string remote = input.Result.Trim();


            doCommand("pull " + remote);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            doCommand("diff HEAD");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            doCommand("diff");
        }
    }
}
