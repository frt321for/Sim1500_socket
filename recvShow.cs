using System.Windows.Forms;
using thinger.DataConvertLib;

namespace pro2
{
    public partial class recvShow : UserControl
    {
        public recvShow()
        {
            InitializeComponent();
        }

        public int Start { get; set; }
        public int Offset { get; set; }
        public DataType DataType { get; set; }

        private string varString;

        public string VarString
        {
            get { return varString; }
            set
            {
                varString = value;
                textBox1.Text = value;
            }
        }

    }
}
