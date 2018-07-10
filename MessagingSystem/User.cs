using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace MessagingSystem {
    public class User {

        public string username;
        public TcpClient client;

        public User(TcpClient client, string username) {
            this.client = client;
            this.username = username;
        }

        public void Send(string a) {
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.WriteLine(a);
            sw.Flush();
            sw.Close();
        }

        public string Recieve() {
            StreamReader sr = new StreamReader(client.GetStream());
            string b = sr.ReadLine();
            sr.Close();
            return b;
        }

    }
}
