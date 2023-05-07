using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midas_Manager {
    public static class ProgramWideFunctions {

        public static Process cmd = new Process();
        public static Process pwshell = new Process();

        public static void CommandPrompt(string command) {
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        public static void Powershell(string command) {
            pwshell.StartInfo.FileName = "powershell.exe";
            pwshell.StartInfo.RedirectStandardInput = true;
            pwshell.StartInfo.RedirectStandardOutput = true;
            pwshell.StartInfo.CreateNoWindow = false;
            pwshell.StartInfo.UseShellExecute = false;
            pwshell.Start();

            pwshell.StandardInput.WriteLine(command);
            pwshell.StandardInput.Flush();
            pwshell.StandardInput.Close();
            pwshell.WaitForExit();
            Console.WriteLine(pwshell.StandardOutput.ReadToEnd());
        }
    }
}
