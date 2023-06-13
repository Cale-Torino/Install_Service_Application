using System.Diagnostics;

namespace Install_Service_Application.Classes
{
    internal class CMDClass
    {
        public void PIDkill(int PID)
        {
            try
            {
                //Kill the cmd process and close the window
                Process p = Process.GetProcessById(PID);
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    p.CloseMainWindow();
                }
                else
                {
                    p.Kill();
                    p.Close();
                    p.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not run Kill CMD PID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public int CMDStartServer(string CMD_command, string CMD_workingdir)
        {
            try
            {
                //Method to start cmd (for server) in the specified dir and run a command.
                //Runs as admin to avoid conflicts.
                var p = new ProcessStartInfo();
                p.UseShellExecute = true;//use the OS shell
                p.WorkingDirectory = CMD_workingdir;//C:\Windows\System32
                p.FileName = @"C:\Windows\System32\cmd.exe";//find cmd location
                p.Verb = "runas";//run as admin
                p.Arguments = CMD_command;//set your cmd command
                p.WindowStyle = ProcessWindowStyle.Normal;//show the window `Normal` or `Hidden` to hide.
                Process _Process = Process.Start(p);//Initiate the process
                //_Process.WaitForExit();//wait for _Process to exit
                return _Process.Id;//Return PID
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not run command successfully", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public int SendCMDCommandNormal(string CMD_command, string CMD_workingdir)
        {
            try
            {
                //Method to start cmd in the specified dir and run a command.
                //Does not need admin priv
                ProcessStartInfo p = new();
                p.UseShellExecute = true;
                p.WorkingDirectory = CMD_workingdir;//C:\Windows\System32
                p.FileName = @"C:\Windows\System32\cmd.exe";
                //p.Verb = "runas"; //run as admin
                p.Arguments = CMD_command;
                p.WindowStyle = ProcessWindowStyle.Normal;
                Process _Process = Process.Start(p);
                _Process.WaitForExit();//wait for _Process to exit
                return _Process.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not run command successfully", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
