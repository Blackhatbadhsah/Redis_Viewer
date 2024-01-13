using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json;
using StackExchange.Redis;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using static Hangfire.Storage.JobStorageFeatures;

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
        public string command { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }


        public void connect()
        {
            try
            {
                var redisConnectionString = $"{this.Host.Text}:{this.Port.Text}";
                Dictionary<string, List<string>> Keys = new Dictionary<string, List<string>>();

                Connection = ConnectionMultiplexer.Connect(new ConfigurationOptions
                {
                    EndPoints = { { redisConnectionString } },
                    AbortOnConnectFail = false,
                    Password = this.MasterPassword.Text,
                    ConnectTimeout = 10000,
                    SyncTimeout = 5000,
                    KeepAlive = 500,
                    AllowAdmin = true
                });

                DataBase = Connection.GetDatabase();
                Subscriber = Connection.GetSubscriber();

                Console.WriteLine($"Connected to Host {redisConnectionString}");

                // Retrieve all keys using the Keys method of IServer
                var keys = Connection.GetServer(redisConnectionString).Keys();

                this.comboBox1.DataSource = keys.ToList();

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
        private void Command_KeyDown(object sender, KeyEventArgs e)
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

        private void Command_TextChanged(object sender, EventArgs e)
        {



        }

        private void ExecuteCommand(string command)
        {

            string[] result = RunCommand(command).GetAwaiter().GetResult();
            foreach (var x in result)
                Output.Text += $"> {command}\n{x}\n";

        }





        private async Task<string[]> RunCommand(string command)
        {
            try
            {
                var cmd = command.Split(" ")[0];
                var arg = command.Replace(cmd + " ", "").Split(" ").ToList();
                var result = string.Empty;
                switch (CommandBox.Text)
                {
                    case "get":
                        result = DataBase.Execute(CommandBox.Text, arg, CommandFlags.PreferMaster).ToString();
                        break;
                    case "rpop":
                        result = DataBase.ListRightPop(arg[0]);
                        break;
                    case "lpop":
                        result = DataBase.ListLeftPop(arg[0]);
                        break;
                    default:
                        result = "unexpected";
                        break;
                }


                return [result];
            }
            catch (Exception ex)
            {
                return [$"Error: {ex.Message}"];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            command = comboBox1.Text;
            CommandBox.DataSource = (DataBase.KeyType(command).ToString() == "String") ? new List<string> { "get" } : DataBase.KeyType(command).ToString() == "List" ? new List<string> { "Right Pop", "Left Pop" ,"Length"} : "";
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            var cmd = command.Split(" ")[0];
            var arg = command.Replace(cmd + " ", "").Split(" ").ToList();
            var result = string.Empty;
            switch (CommandBox.Text)
            {
                case "get":
                    result = DataBase.Execute(CommandBox.Text, arg, CommandFlags.PreferMaster).ToString();
                    break;
                case "Right Pop":
                    result = DataBase.ListRightPop(arg[0]);
                    break;
                case "Left Pop":
                    result = DataBase.ListLeftPop(arg[0]);
                    break;
                case "Length":
                    result = DataBase.ListLength(arg[0]).ToString();
                    break;
                default:
                    result = "unexpected";
                    break;
            }
            //var outputText= RunCommand(command).GetAwaiter().GetResult();

            Output.Text += $"> {command}\n{result}\n";

        }

        private void CommandBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }
    }
}
