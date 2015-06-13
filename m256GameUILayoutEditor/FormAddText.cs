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
    // テキストオブジェクト追加UI用クラス
    public partial class FormAddText : Form
    {
        private string _fontName;
        private int _fontSize;
        private Color _fontColor;
        private string _textStr;

        public string fontName
        {
            get
            {
                return _fontName;
            }
            set
            {
                _fontName = value;
            }
        }

        public int fontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
            }
        }

        public Color fontColor
        {
            get
            {
                return _fontColor;
            }
            set
            {
                _fontColor = value;
            }
        }

        public string textStr
        {
            get
            {
                return _textStr;
            }
            set
            {
                _textStr = value;
            }
        }

        public FormAddText()
        {
            InitializeComponent();
        }

        // フォームロード時の処理
        private void FormAddText_Load(object sender, EventArgs e)
        {
            this.comboBoxFontName.Text = this.fontName;
            this.numericUpDownFontSize.Value = this.fontSize;
            this.buttonChoiceColor.BackColor = this.fontColor;
            this.textBoxInputArea.Text = this.textStr;
        }

        // OKボタンが押された
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.fontName = this.comboBoxFontName.Text;
            this.fontSize = Decimal.ToInt32(this.numericUpDownFontSize.Value);
            this.fontColor = this.buttonChoiceColor.BackColor;
            this.textStr = this.textBoxInputArea.Text;
        }

        // 色選択ダイアログを開いてフォント色を指定
        private void buttonChoiceColor_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            d.Color = buttonChoiceColor.BackColor;
            if (d.ShowDialog() == DialogResult.OK)
            {
                buttonChoiceColor.BackColor = d.Color;
                pictureBoxPreview.Invalidate();
            }
        }

        // PictureBox 内の描画処理
        private void pictureBoxPreview_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Silver, g.VisibleClipBounds);

            string fontName = comboBoxFontName.Text;
            if (fontName == string.Empty) fontName = "Arial";

            string s = textBoxInputArea.Text;
            int fsize = Decimal.ToInt32(numericUpDownFontSize.Value);
            Color col = buttonChoiceColor.BackColor;

            Font fnt = new Font(fontName, fsize);
            SolidBrush b = new SolidBrush(col);
            g.DrawString(s, fnt, b, 0, 0);
            b.Dispose();
            fnt.Dispose();
        }

        private void textBoxInputArea_TextChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Invalidate();
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Invalidate();
        }

        private void comboBoxFontName_TextChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Invalidate();
        }

    }
}
