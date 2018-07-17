using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Practice_Form
{
    public partial class EditEntries : Form
    {
        List <string> _LoadedStrings = null;

        public EditEntries()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public List<string> StringListProperty
        {
            get
            {
                return _LoadedStrings;
            }
            set
            {
                _LoadedStrings = value;
            }
        }

        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            // Gain Access To TextInfo Class In Order To Access TitleCase Method For Capitalisation Of Entries.
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            _LoadedStrings.Add(textInfo.ToTitleCase(textBoxEntryInput.Text));
            listBoxStringList.Items.Add(_LoadedStrings[_LoadedStrings.Count-1]);
        }
    }
}
