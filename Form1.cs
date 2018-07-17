using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Practice_Form
{
    public partial class StringListPropertyProgram : Form
    {
        //Instantiate New Form, String List And Functions Ready For Editing.
        EditEntries _NewEdit = new EditEntries();
        List<string> _StringList = new List<string>();
        StatFunctions _FormFunctions = new StatFunctions();

        public StringListPropertyProgram()
        {
            InitializeComponent();
        }

        private void ButtonListEdit_Click(object sender, EventArgs e)
        {
            _NewEdit.StringListProperty = _StringList;

            if ( _NewEdit.ShowDialog() == DialogResult.OK)
            {
                _StringList = _NewEdit.StringListProperty;
                foreach (string word in _StringList)
                {
                    listStringList.Items.Add(word);
                }
            }
        }
    }
}
