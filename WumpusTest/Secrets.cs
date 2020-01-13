using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WumpusTest
{
    class Secrets
    {

        // instance variables
        private Random random = new Random();
        private ArrayList secrets;

        public Secrets()
        {
            readSecretsFile();
        }

        private void readSecretsFile()
        {
            string[] lines = Properties.Resources.Secrets.Trim().Split(new[] { System.Environment.NewLine }, StringSplitOptions.None);
            secrets = new ArrayList(lines);
        }

        public string getRandomSecret()
        {
            int index = random.Next(0, secrets.Count);
            string secret = (string)secrets[index];
            secrets.RemoveAt(index);
            return secret;
        }

    }

}
