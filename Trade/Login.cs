using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YuantaOneAPI;
using SKCOMLib;

namespace Trade
{
    public class Trading
    {
        /// <summary>
        /// enumEnvironmentMode.UAT = Test Mode
        /// enumEnvironmentMode.PROD = Trade Mode
        /// </summary>
        public enumEnvironmentMode Mode = enumEnvironmentMode.UAT;
        SKCenterLib centLib = new SKCenterLib();
        SKReplyLib replyLib = new SKReplyLib();
        YuantaOneAPITrader yuantaTrade = new YuantaOneAPITrader();
        YuantaDataHelper yuantaData = new YuantaDataHelper();
        /// <summary>
        /// Using this function to Login
        /// </summary>
        /// <param name="type">0 = 元大,1 =  群益</param>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public bool Login(int type, string Account, string Password,ref string exception)
        {
            if( type==1 || type == 0 )
            {
                try
                {
                    if (type == 1)
                        return yuantaTrade.Login(Account, Password);
                    else
                        return true;
                }
                catch(Exception e)
                {
                    exception = e.ToString();
                }
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
