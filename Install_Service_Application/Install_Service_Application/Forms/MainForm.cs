using Install_Service_Application.Classes;

namespace Install_Service_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Install_button1_Click(object sender, EventArgs e)
        {
            richTextBox.AppendText($"[{DateTime.Now}] : Installing Service...\n");
            CMDClass cmd = new();
            string dir = "/k start Windows_Test_Logger_Service.exe -install&&exit 0";
            int r = cmd.CMDStartServer(dir, $"{AppDomain.CurrentDomain.BaseDirectory}Service_App\\");
            richTextBox.AppendText($"[{DateTime.Now}] : {dir}\n");
            richTextBox.AppendText($"[{DateTime.Now}] : Install Complete! PID = {r}\n");
        }

        private void Uninstall_button_Click(object sender, EventArgs e)
        {
            richTextBox.AppendText($"[{DateTime.Now}] : Uninstalling Service...\n");
            CMDClass cmd = new();
            string dir = "/k start Windows_Test_Logger_Service.exe -uninstall&&exit 0";
            int r = cmd.CMDStartServer(dir, $"{AppDomain.CurrentDomain.BaseDirectory}Service_App\\");
            richTextBox.AppendText($"[{DateTime.Now}] : {dir}\n");
            richTextBox.AppendText($"[{DateTime.Now}] : Uninstall Complete! PID = {r}\n");
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.AppendText($"[{DateTime.Now}] : Starting Service...\n");
                //CMDClass cmd = new();
                //string dir = "/k net start Windows_Test_Logger_Service.exe_Service&&exit 0";
                //int r = cmd.CMDStartServer(dir, $"{AppDomain.CurrentDomain.BaseDirectory}Service_App\\");
                System.Diagnostics.Process.Start("net", "start Windows_Test_Logger_Service.exe_Service").WaitForExit();
                //richTextBox.AppendText($"[{DateTime.Now}] : {dir}\n");
                richTextBox.AppendText($"[{DateTime.Now}] : Starting Service Complete!\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Start Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.AppendText($"[{DateTime.Now}] : Stopping Service...\n");
                //CMDClass cmd = new();
                //string dir = "/k net stop Windows_Test_Logger_Service.exe_Service&&exit 0";
                //int r = cmd.CMDStartServer(dir, $"{AppDomain.CurrentDomain.BaseDirectory}Service_App\\");
                System.Diagnostics.Process.Start("net", "stop Windows_Test_Logger_Service.exe_Service").WaitForExit();
                //richTextBox.AppendText($"[{DateTime.Now}] : {dir}\n");
                richTextBox.AppendText($"[{DateTime.Now}] : Stopping Service Complete!\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Stop Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Restart_button_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.AppendText($"[{DateTime.Now}] : Restarting Service...\n");
                //CMDClass cmd = new();
                //string dir = "/k net start Windows_Test_Logger_Service.exe_Service&&exit 0";
                //int r = cmd.CMDStartServer(dir, $"{AppDomain.CurrentDomain.BaseDirectory}Service_App\\");
                System.Diagnostics.Process.Start("net", "stop Windows_Test_Logger_Service.exe_Service").WaitForExit();
                System.Diagnostics.Process.Start("net", "start Windows_Test_Logger_Service.exe_Service").WaitForExit();
                //richTextBox.AppendText($"[{DateTime.Now}] : {dir}\n");
                richTextBox.AppendText($"[{DateTime.Now}] : Restarting Service Complete!\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Restart Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}