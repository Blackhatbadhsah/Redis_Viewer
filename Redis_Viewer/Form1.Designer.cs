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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
