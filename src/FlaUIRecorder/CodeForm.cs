using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlaUIRecorder.Internal;

namespace FlaUIRecorder
{
    public partial class CodeForm : Form
    {
        public CodeForm()
        {
            InitializeComponent();
        }
        
        internal void Init(RecordSession recordSession)
        {
            txtCode.Text = recordSession.Code;
            Text = "Session " + recordSession.StartTime.ToString("g");
        }
    }
}
