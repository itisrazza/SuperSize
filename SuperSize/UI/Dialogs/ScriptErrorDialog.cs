using IronPython.Runtime;
using Microsoft.Scripting.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.UI.Dialogs
{
    public partial class ScriptErrorDialog : Form
    {
        public Exception Exception { get; }

        public ScriptErrorDialog(Exception ex)
        {
            Exception = ex;
            InitializeComponent();

            _exceptionMessage.Text = $"{ex.GetType().Name}: {ex.Message}";
            _exceptionDetails.Text = FormatExceptionContent(ex);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private static string FormatExceptionContent(Exception ex)
        {
            var sb = new StringBuilder();

            foreach (DictionaryEntry data in ex.Data)
            {
                if (data.Key == typeof(DynamicStackFrame))
                {
                    sb.AppendLine("Script Stack Trace:");
                    foreach (var frame in (List<DynamicStackFrame>)data.Value!)
                    {
                        sb.AppendLine(frame.ToString());
                    }
                }
            }

            sb.AppendLine($"Source: {ex.Source}");
            sb.AppendLine();

            sb.AppendLine(".NET Stack Trace:");
            sb.AppendLine(ex.StackTrace);

            return sb.ToString();
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}
