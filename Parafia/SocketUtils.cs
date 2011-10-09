using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Sockets;
using System.IO;

namespace Parafia
{
    public class SocketUtils
    {
        public static TcpClient ConnectToSrv()
        {
            TcpClient tcpclnt = new TcpClient();
            tcpclnt.Connect("127.0.0.1", 8001);

            return tcpclnt;
        }

        public static String RequestRelicID(int cash, TcpClient tcpclnt)
        {
            String output = String.Empty;

            String str = cash.ToString();

            Stream stm = tcpclnt.GetStream();
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);

            stm.Write(ba, 0, ba.Length);

            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            for (int i = 0; i < k; i++)
                output += Convert.ToChar(bb[i]);

            return output;
        }

        public static void SendGreatChangeReturningCost(string value, TcpClient tcpclnt)
        {
            Stream stm = tcpclnt.GetStream();
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(value);

            stm.Write(ba, 0, ba.Length);
        }

        public static void CloseConnectToSrv(TcpClient tcpclnt)
        {
            tcpclnt.Close();
        }
    }
}
