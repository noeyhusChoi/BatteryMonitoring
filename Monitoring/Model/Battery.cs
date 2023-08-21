using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.Model
{
    public class Battery
    {
        public Battery()
        {
            _name = "";
            _soc = 0;
            _current = 0;
            _fault = false;
            _firstFault = true;
        }

        public Battery(string name, double soc = 0, int current = 0, bool fault = false, bool hold = true)
        {
            _name = name;
            _soc = soc;
            _current = current;
            _fault = fault;
            _firstFault = hold;
        }

        string _name;
        public string Name 
        { 
            get { return _name; } 
            set {  _name = value; } 
        }

        double _soc;
        public double SOC
        {
            get { return _soc; }
            set { _soc = value; }
        }

        int _current;
        public int Current
        {
            get { return _current; }
            set { _current = value; }
        }

        bool _fault;
        public bool Fault
        { 
            get { return _fault; } 
            set {  _fault = value; } 
        }

        bool _firstFault;
        public bool FirstFault
        {
            get { return _firstFault; }
            set { _firstFault = value; }
        }
    }
}
