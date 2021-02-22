using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanBST
{
    public class EncodedChar
    {
        private string character;
        private string binary;

        public string Character
        {
            get { return character; }
            set { character = value; }
        }
        public string Binary
        {
            get { return binary; }
            set { binary = value; }
        }

        public EncodedChar()
        {
            this.Character = "";
            this.Binary = "";
        }
    }
}
