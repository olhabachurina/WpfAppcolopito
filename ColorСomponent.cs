using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfAppcolopito
{
    public class ColorСomponent : BaseInpc
    {
        private string _name;
        private byte _value;
        private bool _isEnabled = true;

        public ColorСomponent(string name)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        public byte Value
        {
            get { return _value; }
            set { Set(ref _value, value); }
        }

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { Set(ref _isEnabled, value); }
        }
    }
}
    


