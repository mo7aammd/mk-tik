using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakarmTech
{
    class IpCalc
    {
        private int ip1, ip2, ip3, ip4, suffix;

        public IpCalc(int ip1, int ip2, int ip3, int ip4, int suffix)
        {

            this.ip1 = ip1;
            this.ip2 = ip2;
            this.ip3 = ip3;
            this.ip4 = ip4;
            this.suffix = suffix;
        }

        public string getNetworkNumber()
        {
            return networkNumber(ip1, ip2, ip3, ip4, suffix);
        }

        public string getBroadcastNumber()
        {
            return broadcastNumber(ip1, ip2, ip3, ip4, suffix);
        }

        public string getMaskNumber()
        {
            return maskNumber(ip1, ip2, ip3, ip4, suffix);
        }

        public string getFirstIp()
        {
            return firstIp(ip1, ip2, ip3, ip4, suffix);
        }

        public string getLastIp()
        {
            return lastIp(ip1, ip2, ip3, ip4, suffix);
        }



        private int whereDivide(int sufix)
        {

            switch (sufix)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    return 1;

                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                    return 2;

                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                    return 3;

                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                case 32:
                    return 4;

                default:
                    return 1;

            }
        }
        private int whereDivideBin(int sufix)
        {
            return sufix % 8;
        }
        private string intToBinaryString(int ip)
        {

            string bin = Convert.ToString(ip, 2);
            string fillBin = "";
            if (bin.Length != 8)
            {
                for (int i = bin.Length; i < 8; i++)
                {
                    fillBin += "0";
                }
            }

            return fillBin + bin;
        }
        private int binaryStringToInt(string ip)
        {
            return Convert.ToInt32(ip, 2);
        }
        private string networkNumber(int ip1, int ip2, int ip3, int ip4, int sufix)
        {

            // where the sub will be
            int ipDivided;//ip that will be divided
            switch (whereDivide(sufix))
            {

                case 1:
                    ipDivided = ip1;
                    break;
                case 2:
                    ipDivided = ip2;
                    break;
                case 3:
                    ipDivided = ip3;
                    break;
                case 4:
                    ipDivided = ip4;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }
            int ipPartComplite;
            if (sufix % 8 == 0)
            {
                ipPartComplite = ipDivided;
            }
            else
            {
                string ipBin = intToBinaryString(ipDivided);// ip decimal to binary

                string ipPart1 = ipBin.Substring(0, whereDivideBin(sufix));//part of binary ip will not divide
                string ipPart2 = ipBin.Substring(whereDivideBin(sufix));//part of binary ip tah will be divided
                
                //part of ip after divide process
                string ipPart2After = "";
                for (int i = 0; i < ipPart2.Length; i++)
                {
                    ipPart2After += "0";
                }

                string ipPartReady = ipPart1 + ipPart2After;//concatinate binary ip
                ipPartComplite = binaryStringToInt(ipPartReady);// binary to decimel
            }
            switch (whereDivide(sufix))// assign modified ip to orginal variable and do some process
            {

                case 1:
                    ip1 = ipPartComplite;
                    ip2 = 0;
                    ip3 = 0;
                    ip4 = 0;
                    break;
                case 2:
                    ip2 = ipPartComplite;
                    ip3 = 0;
                    ip4 = 0;
                    break;
                case 3:
                    ip3 = ipPartComplite;
                    ip4 = 0;
                    break;
                case 4:
                    ip4 = ipPartComplite;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }

            var finalIp = "" + ip1 + "." + ip2 + "." + ip3 + "." + ip4;//final ip formate

            return finalIp;
        }

        private string broadcastNumber(int ip1, int ip2, int ip3, int ip4, int sufix)
        {


            // where the sub will be
            int ipDivided;//ip that will be divided
            switch (whereDivide(sufix))
            {

                case 1:
                    ipDivided = ip1;
                    break;
                case 2:
                    ipDivided = ip2;
                    break;
                case 3:
                    ipDivided = ip3;
                    break;
                case 4:
                    ipDivided = ip4;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }
            int ipPartComplite;
            if (sufix % 8 == 0)
            {
                ipPartComplite = ipDivided;
            }
            else
            {
                string ipBin = intToBinaryString(ipDivided);// ip decimal to binary

                string ipPart1 = ipBin.Substring(0, whereDivideBin(sufix));//part of binary ip will not divide
                string ipPart2 = ipBin.Substring(whereDivideBin(sufix));//part of binary ip that will be divided
                                                                        //part of ip after divide process
                string ipPart2After = "";
                for (int i = 0; i < ipPart2.Length; i++)
                {
                    ipPart2After += "1";
                }

                string ipPartReady = ipPart1 + ipPart2After;//concatinate binary ip
                ipPartComplite = binaryStringToInt(ipPartReady);// binary to decimel
            }
            switch (whereDivide(sufix))// assign modifide ip to orginal variable and do some process
            {

                case 1:
                    ip1 = ipPartComplite;
                    ip2 = 255;
                    ip3 = 255;
                    ip4 = 255;
                    break;
                case 2:
                    ip2 = ipPartComplite;
                    ip3 = 255;
                    ip4 = 255;
                    break;
                case 3:
                    ip3 = ipPartComplite;
                    ip4 = 255;
                    break;
                case 4:
                    ip4 = ipPartComplite;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }

            var finalIp = "" + ip1 + "." + ip2 + "." + ip3 + "." + ip4;//final ip formate

            return finalIp;

        }
        private string maskNumber(int ip1, int ip2, int ip3, int ip4, int sufix)
        {
            // where the sub will be
            int ipDivided;//ip that will be divided
            switch (whereDivide(sufix))
            {

                case 1:
                    ipDivided = ip1;
                    break;
                case 2:
                    ipDivided = ip2;
                    break;
                case 3:
                    ipDivided = ip3;
                    break;
                case 4:
                    ipDivided = ip4;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }
            int ipPartComplite;
            if (sufix % 8 == 0)
            {
                ipPartComplite = 255;
            }
            else
            {
                string ipBin = intToBinaryString(ipDivided);// ip decimal to binary

                string ipPart1 = ipBin.Substring(0, whereDivideBin(sufix));//part of binary ip will not divide
                string ipPart2 = ipBin.Substring(whereDivideBin(sufix));//part of binary ip that will be divided

                //part of ip after divide process
                string ipPart1After = "";
                for (int i = 0; i < ipPart1.Length; i++)
                {
                    ipPart1After += "1";
                }
                string ipPart2After = "";
                for (int i = 0; i < ipPart2.Length; i++)
                {
                    ipPart2After += "0";
                }

                string ipPartReady = ipPart1After + ipPart2After;//concatinate binary ip
                ipPartComplite = binaryStringToInt(ipPartReady);// binary to decimel
            }
            switch (whereDivide(sufix))// assign modifide ip to orginal variable and do some process
            {

                case 1:
                    ip1 = ipPartComplite;
                    ip2 = 0;
                    ip3 = 0;
                    ip4 = 0;
                    break;
                case 2:
                    ip1 = 255;
                    ip2 = ipPartComplite;
                    ip3 = 0;
                    ip4 = 0;
                    break;
                case 3:
                    ip1 = 255;
                    ip2 = 255;
                    ip3 = ipPartComplite;
                    ip4 = 0;
                    break;
                case 4:
                    ip1 = 255;
                    ip2 = 255;
                    ip3 = 255;
                    ip4 = ipPartComplite;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }

            var finalIp = "" + ip1 + "." + ip2 + "." + ip3 + "." + ip4;//final ip formate

            return finalIp;
        }

        private string firstIp(int ip1, int ip2, int ip3, int ip4, int sufix)
        {
            // where the sub will be
            int ipDivided;//ip that will be divided
            switch (whereDivide(sufix))
            {

                case 1:
                    ipDivided = ip1;
                    break;
                case 2:
                    ipDivided = ip2;
                    break;
                case 3:
                    ipDivided = ip3;
                    break;
                case 4:
                    ipDivided = ip4;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }
            int ipPartComplite;
            if (sufix % 8 == 0)
            {
                ipPartComplite = ipDivided;
            }
            else
            {
                string ipBin = intToBinaryString(ipDivided);// ip decimal to binary

                string ipPart1 = ipBin.Substring(0, whereDivideBin(sufix));//part of binary ip will not divide
                string ipPart2 = ipBin.Substring(whereDivideBin(sufix));//part of binary ip tah will be divided
                                                                        //part of ip after divide process
                string ipPart2After = "";
                for (int i = 0; i < ipPart2.Length; i++)
                {
                    ipPart2After += "0";
                }

                string ipPartReady = ipPart1 + ipPart2After;//concatinate binary ip
                ipPartComplite = binaryStringToInt(ipPartReady);// binary to decimel
            }
            switch (whereDivide(sufix))// assign modifide ip to orginal variable and do some process
            {

                case 1:
                    ip1 = ipPartComplite;
                    ip2 = 0;
                    ip3 = 0;
                    ip4 = 0;
                    break;
                case 2:
                    ip2 = ipPartComplite;
                    ip3 = 0;
                    ip4 = 0;
                    break;
                case 3:
                    ip3 = ipPartComplite;
                    ip4 = 0;
                    break;
                case 4:
                    ip4 = ipPartComplite;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }

            var finalIp = "" + ip1 + "." + ip2 + "." + ip3 + "." + (ip4 + 1);//final ip formate

            return finalIp;
        }
        private string lastIp(int ip1, int ip2, int ip3, int ip4, int sufix)
        {
            // where the sub will be
            int ipDivided;//ip that will be divided
            switch (whereDivide(sufix))
            {

                case 1:
                    ipDivided = ip1;
                    break;
                case 2:
                    ipDivided = ip2;
                    break;
                case 3:
                    ipDivided = ip3;
                    break;
                case 4:
                    ipDivided = ip4;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }
            int ipPartComplite;
            if (sufix % 8 == 0)
            {
                ipPartComplite = ipDivided;
            }
            else
            {
                string ipBin = intToBinaryString(ipDivided);// ip decimal to binary

                string ipPart1 = ipBin.Substring(0, whereDivideBin(sufix));//part of binary ip will not divide
                string ipPart2 = ipBin.Substring(whereDivideBin(sufix));//part of binary ip that will be divided
                                                                        //part of ip after divide process
                string ipPart2After = "";
                for (int i = 0; i < ipPart2.Length; i++)
                {
                    ipPart2After += "1";
                }

                string ipPartReady = ipPart1 + ipPart2After;//concatinate binary ip
                ipPartComplite = binaryStringToInt(ipPartReady);// binary to decimel
            }
            switch (whereDivide(sufix))// assign modifide ip to orginal variable and do some process
            {

                case 1:
                    ip1 = ipPartComplite;
                    ip2 = 255;
                    ip3 = 255;
                    ip4 = 255;
                    break;
                case 2:
                    ip2 = ipPartComplite;
                    ip3 = 255;
                    ip4 = 255;
                    break;
                case 3:
                    ip3 = ipPartComplite;
                    ip4 = 255;
                    break;
                case 4:
                    ip4 = ipPartComplite;
                    break;
                default:
                    ipDivided = 0;
                    break;
            }

            var finalIp = "" + ip1 + "." + ip2 + "." + ip3 + "." + (ip4 - 1);//final ip formate

            return finalIp;
        }
    }
}
