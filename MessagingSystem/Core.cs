using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingSystem {
    public class Core {
        static void Main(string[] args) { new Core(args); }

        private bool hosting = false;

        public Core(string[] args) {
            // Decide if Client or Host

            Console.Write("\n Would you like to Host the conversation?\n  > ");
            string a = Console.ReadLine();
            if (a.ToLower()[0].Equals('y')) {
                hosting = true;
            }

            if (hosting) {

            }
        }

        public void HostProtocol() {

        }

    }
}
