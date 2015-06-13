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
    // キャンバスサイズ設定用クラス
    public partial class FormSetCanvasSize : Form
    {
        // 他のフォームとのやり取り用
        private String _canvasWidth;
        private String _canvasHeight;
        private Color _canvasColor;
        private Color _gridColor;

        public String canvasWidth
        {
            get
            {
                return _canvasWidth;
            }
            set
            {
                _canvasWidth = value;
            }
        }

        public String canvasHeight
        {
            get
            {
                return _canvasHeight;
            }
            set
            {
                _canvasHeight = value;
            }
        }

        public Color canvasColor
        {
            get
            {
                return _canvasColor;
            }
            set
            {
                _canvasColor = value;
            }
        }

        public Color gridColor
        {
            get
            {
                return _gridColor;
            }
            set
            {
                _gridColor = value;
            }
        }

        public FormSetCanvasSize()
        {
            InitializeComponent();
        }

        // フォームがロードされた時に呼ばれる処理
        private void FormSetCanvasSize_Load(object sendor, EventArgs e)
        {
            this.comboBoxCanvasSizeW.Text = this.canvasWidth;
            this.comboBoxCanvasSizeH.Text = this.canvasHeight;
            buttonChoiceBackColor.BackColor = this.canvasColor;
            buttonChoiceGridColor.BackColor = this.gridColor;
        }

        private void buttonSetCanvasSizeOK_Click(object sender, EventArgs e)
        {
            this.canvasWidth = this.comboBoxCanvasSizeW.Text;
            this.canvasHeight = this.comboBoxCanvasSizeH.Text;
            this.canvasColor = this.buttonChoiceBackColor.BackColor;
            this.gridColor = this.buttonChoiceGridColor.BackColor;
        }

        private void comboBoxCanvasSizeW_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.canvasWidth = this.comboBoxCanvasSizeW.Text;
        }

        private void comboBoxCanvasSizeH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.canvasHeight = this.comboBoxCanvasSizeH.Text;
        }

        // 色設定ダイアログを開く
        private void buttonChoiceBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            d.Color = buttonChoiceBackColor.BackColor;
            if (d.ShowDialog() == DialogResult.OK)
            {
                buttonChoiceBackColor.BackColor = d.Color;
            }
        }

        private void buttonChoiceGridColor_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            d.Color = buttonChoiceGridColor.BackColor;
            if (d.ShowDialog() == DialogResult.OK)
            {
                buttonChoiceGridColor.BackColor = d.Color;
            }
        }

    }
}
