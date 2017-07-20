using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Gitsux
{
    class Git
    {
        private string filename = @"git.exe";
        ProcessStartInfo start;

        public Git()
        {

        }

        public string ExecuteCommand(string command, string workingDirectory)
        {
            string result = "Invalid command or working directory.";

            if (command != "" && workingDirectory != "Not defined")
            {
                start = new ProcessStartInfo();
                start.WorkingDirectory = workingDirectory;
                start.FileName = filename;
                start.Arguments = "--no-pager " + command;
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.CreateNoWindow = true;
                start.RedirectStandardError = true;

                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadToEnd();
                    }

                    if (result == "")
                    {
                        using (StreamReader reader = process.StandardError)
                        {
                            result = reader.ReadToEnd();
                        }
                    }

                }
            }
            return result;
        }

        public List<Branch> GetBranches(string workingDirectory)
        {
            List<Branch> branchList = new List<Branch>();
            string branches = this.ExecuteCommand("branch", workingDirectory);

            var aBranches = branches.Split('\n');

            foreach (string s in aBranches)
            {
                if (s != "")
                {
                    Branch b = new Branch();

                    if (s.Contains("*"))
                        b.isCurrent = true;

                    b.name = s.Replace("*", "").Trim();
                    branchList.Add(b);
                }
            }

            return branchList;

        }
        
    }

    public class Branch
    {
        public string name = "";
        public bool isCurrent = false;
    }
}
