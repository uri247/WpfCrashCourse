using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hello
{
    /// <summary>
    /// Interaction logic for LogLevelChoice.xaml
    /// </summary>
    public partial class LogLevelChoice : UserControl
    {
        private string _label = "";

        public LogLevelChoice()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return _label; }
            set
            {
                this._label = value;
                this.BaseLabel.Content = value;
            }
        }

    }
}
