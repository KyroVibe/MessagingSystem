using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace MessagingSystem {
    public class Host {

        private TcpListener list;

        private Thread accepting, running;

        private List<string> newMessages;
        private List<TcpClient> clients;

        public Host(IPAddress ip, int port) {
            list = new TcpListener(ip, port);
            list.Start(3);

            accepting = new Thread(() => AcceptClients());
            accepting.Start();
            running = new Thread(() => Update());
            running.Start();
        }

        public void Update() {

        }

        public void AcceptClients() {

            clients = new List<TcpClient>();

            while (true) {
                TcpClient newClient = list.AcceptTcpClient();
                clients.Add(newClient);
            }
        }

        // Utility Functions

        public void Send(string a, TcpClient b) {
            StreamWriter sw = new StreamWriter(b.GetStream());
            sw.WriteLine(a);
            sw.Flush();
            sw.Close();
        }

    }
}
