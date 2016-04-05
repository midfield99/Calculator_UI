using System;
using System.Diagnostics;

namespace Python_Accessor
{
    public class Python_Script
    {
        private Process process = new Process();
        private ProcessStartInfo startInfo = new ProcessStartInfo();
        private string script;

        public Python_Script(string file)
        {
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "python";
            script = file;
            process.StartInfo = startInfo;
        }

        public string Run(string flag, string arguments = null)
        {
            string res = "";
            startInfo.Arguments = script + " " + arguments;
            startInfo.Arguments = script + " " + String.Format("\"{0}\"  \"{1}\"", flag, arguments);
            Console.WriteLine(startInfo.Arguments);
            process.Start();
            res = process.StandardOutput.ReadToEnd();

            process.WaitForExit();
            return res.TrimEnd('\r', '\n');
        }

        //Creates a python script that imports the file and calls the method in script
        public string Call_Function(string method, string arguments = null, bool print = false)
        {
            string res = "";
            string prnt = "";
            if (print) { prnt = " print "; }
            string method_loc = script.Replace(".py", String.Empty);
            startInfo.Arguments = String.Format(" -c \"import {0}; {3} {0}.{1}(' {2} ')\"", method_loc, method, arguments, prnt);

            process.Start();
            res = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            process.Close();
            return res.TrimEnd('\r', '\n');
        }
    }
}
