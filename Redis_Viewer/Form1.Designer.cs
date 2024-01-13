namespace Redis_Viewer
{
    partial class Form1
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
            label1 = new Label();
            Host = new TextBox();
            Port = new TextBox();
            label2 = new Label();
            MasterPassword = new TextBox();
            label3 = new Label();
            btnConnect = new Button();
            Output = new RichTextBox();
            Command = new TextBox();
            comboBox1 = new ComboBox();
            btnGetValue = new Button();
            CommandBox = new ComboBox();
            InputBox = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Server Ipv4 Address";
            // 
            // Host
            // 
            Host.Location = new Point(133, 15);
            Host.Name = "Host";
            Host.Size = new Size(134, 23);
            Host.TabIndex = 1;
            Host.TextChanged += Host_TextChanged;
            // 
            // Port
            // 
            Port.Location = new Point(308, 15);
            Port.Name = "Port";
            Port.Size = new Size(84, 23);
            Port.TabIndex = 3;
            Port.TextChanged += Port_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 15);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Port";
            // 
            // MasterPassword
            // 
            MasterPassword.Location = new Point(528, 15);
            MasterPassword.Name = "MasterPassword";
            MasterPassword.Size = new Size(163, 23);
            MasterPassword.TabIndex = 5;
            MasterPassword.Text = "Db 0 Password";
            MasterPassword.TextChanged += MasterPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 14);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 4;
            label3.Text = "Redis Master Password";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(713, 14);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Output
            // 
            Output.AccessibleRole = AccessibleRole.ScrollBar;
            Output.AutoWordSelection = true;
            Output.Location = new Point(12, 143);
            Output.Name = "Output";
            Output.Size = new Size(776, 429);
            Output.TabIndex = 7;
            Output.Text = "";
            Output.TextChanged += Output_TextChanged;
            // 
            // Command
            // 
            Command.Location = new Point(12, 583);
            Command.Name = "Command";
            Command.Size = new Size(776, 23);
            Command.TabIndex = 8;
            Command.TextChanged += Command_TextChanged;
            Command.KeyDown += Command_KeyDown;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(375, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnGetValue
            // 
            btnGetValue.Location = new Point(667, 113);
            btnGetValue.Name = "btnGetValue";
            btnGetValue.Size = new Size(121, 23);
            btnGetValue.TabIndex = 10;
            btnGetValue.Text = "Execute";
            btnGetValue.UseVisualStyleBackColor = true;
            btnGetValue.Click += btnGetValue_Click;
            // 
            // CommandBox
            // 
            CommandBox.FormattingEnabled = true;
            CommandBox.Location = new Point(101, 114);
            CommandBox.Name = "CommandBox";
            CommandBox.Size = new Size(218, 23);
            CommandBox.TabIndex = 11;
            CommandBox.SelectedIndexChanged += CommandBox_SelectedIndexChanged;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(133, 48);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(655, 46);
            InputBox.TabIndex = 12;
            InputBox.Text = "";
            InputBox.TextChanged += InputBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 58);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 113);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 14;
            label5.Text = "Perform Action ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 113);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 15;
            label6.Text = "On Key";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(InputBox);
            Controls.Add(CommandBox);
            Controls.Add(btnGetValue);
            Controls.Add(comboBox1);
            Controls.Add(Command);
            Controls.Add(Output);
            Controls.Add(btnConnect);
            Controls.Add(MasterPassword);
            Controls.Add(label3);
            Controls.Add(Port);
            Controls.Add(label2);
            Controls.Add(Host);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Redis Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Host;
        private TextBox Port;
        private Label label2;
        private TextBox MasterPassword;
        private Label label3;
        private Button btnConnect;
        private RichTextBox Output;
        private TextBox Command;
        private ComboBox comboBox1;
        private Button btnGetValue;
        private ComboBox CommandBox;
        private RichTextBox InputBox;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
