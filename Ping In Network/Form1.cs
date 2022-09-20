namespace Ping_In_Network

{
    using System.Text;
    using System.Net.NetworkInformation;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string Ipaddress = textBox1.Text;
                int timeOut=5;
                Ping ping = new Ping();
                PingReply reply = ping.Send(Ipaddress, timeOut);
                StringBuilder sb = new StringBuilder();
                sb.Append("IP Address: " + reply.Address.ToString());
                sb.Append("\nStatus: " + reply.Status.ToString());
                sb.Append("\nTime: " + reply.RoundtripTime.ToString());
                MessageBox.Show(sb.ToString(),"PingResult: "+Ipaddress);
            }
            catch
            {
                MessageBox.Show("IP Not Found!");
            }
        }
    }
}