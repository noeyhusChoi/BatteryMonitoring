using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.Model
{
    public class Option
    {
        public Option()
        {
            _sms = false;
            _reboot = false;
        }
        
        public Option(bool sms, bool reboot)
        {
            _sms = sms;
            _reboot = reboot;
        }
        
        bool _sms;
        public bool SMS
        {
            get { return _sms; }
            set { _sms = value; }
        }

        bool _reboot;
        public bool Reboot
        {
            get { return _reboot; }
            set { _reboot = value; }
        }
    }
}
