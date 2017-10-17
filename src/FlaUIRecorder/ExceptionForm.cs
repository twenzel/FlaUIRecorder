using System;
using System.Windows.Forms;

using FlaUIRecorder.Extensions;

namespace FlaUIRecorder
{
    public partial class ExceptionForm : Form
    {
        private readonly Exception _exception;

        public ExceptionForm(Exception exception)
        {
            InitializeComponent();

            _exception = exception;

            DrawErrorMessage();
        }

        private string Exceptiontext
        {
            get
            {
                var details = chkboxShowDetails.Checked ? _exception.ErrorString() : string.Empty;
                var stackTrace = chkboxShowStackTrace.Checked ? _exception.FormatStackTrace() : string.Empty;
                var detailedErrorMessage = string.Format("{0}{1}{2}{1}{3}{1}{4}", _exception.Message,
                                                            Environment.NewLine, details, "".PadLeft(10, '-'),
                                                            stackTrace);

                return detailedErrorMessage;
            }
        }

        private void DrawErrorMessage()
        {
            txtErrorMessage.Text = Exceptiontext;
        }

        private void BtnCopyError_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Exceptiontext);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkboxShowDetails_CheckedChanged(object sender, EventArgs e)
        {
            DrawErrorMessage();
        }

        private void ChkboxShowStackTrace_CheckedChanged(object sender, EventArgs e)
        {
            DrawErrorMessage();
        }
    }
}
