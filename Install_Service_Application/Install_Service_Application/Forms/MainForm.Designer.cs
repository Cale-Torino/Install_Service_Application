namespace Install_Service_Application
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Install_button1 = new Button();
            Uninstall_button = new Button();
            richTextBox = new RichTextBox();
            Start_button = new Button();
            Stop_button = new Button();
            Restart_button = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // Install_button1
            // 
            Install_button1.Location = new Point(12, 12);
            Install_button1.Name = "Install_button1";
            Install_button1.Size = new Size(112, 34);
            Install_button1.TabIndex = 0;
            Install_button1.Text = "Install";
            Install_button1.UseVisualStyleBackColor = true;
            Install_button1.Click += Install_button1_Click;
            // 
            // Uninstall_button
            // 
            Uninstall_button.Location = new Point(130, 12);
            Uninstall_button.Name = "Uninstall_button";
            Uninstall_button.Size = new Size(112, 34);
            Uninstall_button.TabIndex = 1;
            Uninstall_button.Text = "Uninstall";
            Uninstall_button.UseVisualStyleBackColor = true;
            Uninstall_button.Click += Uninstall_button_Click;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = Color.Black;
            richTextBox.ForeColor = Color.White;
            richTextBox.Location = new Point(12, 52);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new Size(584, 279);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            // 
            // Start_button
            // 
            Start_button.Location = new Point(248, 12);
            Start_button.Name = "Start_button";
            Start_button.Size = new Size(112, 34);
            Start_button.TabIndex = 3;
            Start_button.Text = "Start";
            Start_button.UseVisualStyleBackColor = true;
            Start_button.Click += Start_button_Click;
            // 
            // Stop_button
            // 
            Stop_button.Location = new Point(366, 12);
            Stop_button.Name = "Stop_button";
            Stop_button.Size = new Size(112, 34);
            Stop_button.TabIndex = 4;
            Stop_button.Text = "Stop";
            Stop_button.UseVisualStyleBackColor = true;
            Stop_button.Click += Stop_button_Click;
            // 
            // Restart_button
            // 
            Restart_button.Location = new Point(484, 12);
            Restart_button.Name = "Restart_button";
            Restart_button.Size = new Size(112, 34);
            Restart_button.TabIndex = 5;
            Restart_button.Text = "Restart";
            Restart_button.UseVisualStyleBackColor = true;
            Restart_button.Click += Restart_button_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Dock = DockStyle.Bottom;
            label.Location = new Point(0, 334);
            label.Name = "label";
            label.Size = new Size(60, 25);
            label.TabIndex = 6;
            label.Text = "Ready";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 359);
            Controls.Add(label);
            Controls.Add(Restart_button);
            Controls.Add(Stop_button);
            Controls.Add(Start_button);
            Controls.Add(richTextBox);
            Controls.Add(Uninstall_button);
            Controls.Add(Install_button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Installer";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Install_button1;
        private Button Uninstall_button;
        private RichTextBox richTextBox;
        private Button Start_button;
        private Button Stop_button;
        private Button Restart_button;
        private Label label;
    }
}