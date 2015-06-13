using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m256GameUILayoutEditor
{
    public partial class FormSetGridSize : Form
    {
        private string _gridWidth;
        private string _gridHeight;

        public string gridWidth
        {
            get
            {
                return _gridWidth;
            }
            set
            {
                _gridWidth = value;
            }
        }

        public string gridHeight
        {
            get
            {
                return _gridHeight;
            }
            set
            {
                _gridHeight = value;
            }
        }

        public FormSetGridSize()
        {
            InitializeComponent();
        }

        private void FormSetGridSize_Load(object sender, EventArgs e)
        {
            this.comboBoxGridW.Text = this.gridWidth;
            this.comboBoxGridH.Text = this.gridHeight;
        }

        private void buttonGridSizeOK_Click(object sender, EventArgs e)
        {
            this.gridWidth = this.comboBoxGridW.Text;
            this.gridHeight = this.comboBoxGridH.Text;
        }

        private void comboBoxGridW_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gridWidth = this.comboBoxGridW.Text;
        }

        private void comboBoxGridH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gridHeight = this.comboBoxGridH.Text;
        }
    }
}
