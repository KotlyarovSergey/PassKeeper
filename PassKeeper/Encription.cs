using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace PassKeeper
{

    class Encription
    {
        //private class RowOfTable
        //{
        //    //byte siteLength;
        //    //byte nameLength;
        //    //byte passLength;
        //    //byte commentLength;
        //    public string Site;
        //    public string Name;
        //    public string Pass;
        //    public string Comment;
        //}
        private string _key;
        public Encription(string key)
        {
            _key = key;
        }

        public byte[] Encript(byte[] input)
        {
            byte[] buffer = new byte[input.Length];
            byte shift = ShiftCalc();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)(input[i] + shift);
            }
            return buffer;
        }

        public byte[] Decript(byte[] input)
        {
            byte[] buffer = new byte[input.Length];
            byte shift = ShiftCalc();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)(input[i] - shift);
            }
            return buffer;
        }

        private byte ShiftCalc()
        {
            byte shift = 0;
            for (int i = 0; i < _key.Length; i++)
            {
                shift += (byte)_key[i];
            }

            return shift;
        }
    }
}
