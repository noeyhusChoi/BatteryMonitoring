using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.Controller
{
    internal class clsNotice
    {
        const string section = "Contact";
        string[] _phonenumbers;

        public string[] GetPhoneNumbers()
        {
            NameValueCollection contact = (NameValueCollection)ConfigurationManager.GetSection(section);

            string[] names = contact.AllKeys;
            string[] phonenumbers = contact.AllKeys.Select(x => contact[x]).ToArray();

            return phonenumbers;
        }

        public void SendToSMS(string msg)
        {
            _phonenumbers = GetPhoneNumbers();

            foreach (var phonenumber in _phonenumbers)
            {
                const string ID = "nextsq";
                const string API_KEY = "3xtk0zw4ti95nr2yce41v6fywhd6f96v";
                const string SENDER = "07048206884";
                const string TEST_MODE = "Y";

                string smsContent = msg; // dtFaultByDevcieSMS.Rows[0]["SMS_CONTENT"].ToString();
                string receiver = phonenumber;

                if (receiver.Contains("+82"))
                    receiver = receiver.Replace("+82", "0");

                //테스트 임시 수신자.
                //receiver = "01044466179";

                using (HttpClient client = new HttpClient())
                {
                    MultipartFormDataContent formData = new MultipartFormDataContent();
                    formData.Add(new StringContent(ID), "user_id");            // SMS 아이디
                    formData.Add(new StringContent(API_KEY), "key");           // 인증키
                    formData.Add(new StringContent(smsContent), "msg");        // 메세지 내용
                    formData.Add(new StringContent(receiver), "receiver");     // 수신번호
                    formData.Add(new StringContent(SENDER), "sender");         // 발신번호
                    formData.Add(new StringContent(TEST_MODE), "testmode_yn"); // Y 인경우 실제문자 전송X , 자동취소(환불) 처리

                    client.DefaultRequestHeaders.Add("Accept", "*/*");

                    var response = client.PostAsync("https://apis.aligo.in/send/", formData).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine(response.StatusCode);
                        clsLog.LogToAll(string.Format("SMS SEND RESULT : {0} {1}", phonenumber, response.StatusCode));
                    }
                    else
                    {
                        var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        Console.WriteLine(content);
                        clsLog.LogToAll(string.Format("SMS SEND RESULT : {0} {1}", phonenumber, response.StatusCode));
                    }
                }
            }
        }
    }
}
