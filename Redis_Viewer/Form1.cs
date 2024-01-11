using StackExchange.Redis;
using System.Collections.Immutable;
using System.Security.Cryptography.Xml;

namespace Redis_Viewer
{
    public partial class Form1 : Form, IForm1
    {
       
        public ISubscriber Subscriber { get; set; }
        public ConnectionMultiplexer Connection
        {
            get; set;
        }

        public IDatabase DataBase { get; set; }

        public Form1()
        {
            InitializeComponent();

        }


        public void connect()
        {
            try
            {
                Connection = ConnectionMultiplexer.Connect(new ConfigurationOptions
                {
                    EndPoints = { { this.Host.Text, int.Parse(this.Port.Text) } },
                    AbortOnConnectFail = false, // You can set this based on your requirements
                    Password = this.MasterPassword.Text,                             // other configuration options
                    ConnectTimeout = 10000, // Set the connection timeout to 10 seconds (adjust as needed)
                    SyncTimeout = 5000, // Set the synchronous timeout to 5 seconds (adjust as needed)
                    KeepAlive = 500,
                    AllowAdmin = true
                });
                DataBase = Connection.GetDatabase();
                Subscriber = Connection.GetSubscriber();
                Output.Text += $"Connected to Host {this.Host.Text}\n";
            }
            catch (Exception ex)
            {
                Output.Text += $"{ex.Message}\n";
            }
        }
        private void Host_TextChanged(object sender, EventArgs e)
        {

        }

        private void Port_TextChanged(object sender, EventArgs e)
        {

        }

        private void MasterPassword_TextChanged(object sender, EventArgs e)
        {

        }
          private void Command_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteCommand(Command.Text);
            }

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void Command_TextChanged(object sender,EventArgs e)
        {
    


        }
       
        private void ExecuteCommand(string command )
        {
             
            string[] result = RunCommand(command).GetAwaiter().GetResult();
            foreach (var x in result)
            Output.Text+=$"> {command}\n{x}\n";

        }





        private async Task<string[]> RunCommand(string command)
        {
            try
            {
                var cmd = command.Split(" ")[0];
                var arg = command.Replace(cmd + " ", "").Split(" ");


              var result =  DataBase.Execute("get", arg, CommandFlags.PreferMaster).ToString();
                return [result];
            }
            catch (Exception ex)
            {
                return [$"Error: {ex.Message}"];
            }
        }

    }
}
