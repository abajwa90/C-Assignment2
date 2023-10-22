using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    /// <summary>
    /// this api counts the total emoticons in a sentence and keeps count of them
    /// to give an output based on the total (happy, unsure, sad)
    /// </summary>

    [System.Web.Http.Route("api/J2/Get/{moodMessage}")]
    public class J2Controller : ApiController
    {
        public string Get(string moodMessage, int happyNum, int sadNum)
        {

            for (int i = 0; i < moodMessage.Length - 1; i++)
            {

                if (moodMessage[i] == ':' && moodMessage[i + 1] == '-' && moodMessage[i + 1] == ')')
                {
                    happyNum = moodMessage[i];
                    happyNum++;
                }
                else if (moodMessage[i] == ':' && moodMessage[i + 1] == '-' && moodMessage[i + 1] == ')')
                {
                    sadNum = moodMessage[i];
                    sadNum++;
                }
            }


            if (happyNum > sadNum)
            {
                return "happy";

            }
            else if (happyNum == sadNum)
            {
                return "unsure";
            }
            else if (happyNum < sadNum)
            {
                return "sad";
            }
            else
            {
                return "invalid";
            }
        }
    }
}