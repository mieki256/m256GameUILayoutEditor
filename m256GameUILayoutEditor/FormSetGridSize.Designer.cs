namespace m256GameUILayoutEditor
{
    partial class FormSetGridSize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGridW = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGridH = new System.Windows.Forms.ComboBox();
            this.buttonGridSizeOK = new System.Windows.Forms.Button();
            this.buttonGridSizeCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Size";
            // 
            // comboBoxGridW
            // 
            this.comboBoxGridW.FormattingEnabled = true;
            this.comboBoxGridW.Items.AddRange(new object[] {
            "8",
            "10",
            "16",
            "20",
            "24",
            "32",
            "40",
            "48",
            "60",
            "64",
            "80",
            "128"});
            this.comboBoxGridW.Location = new System.Drawing.Point(69, 12);
            this.comboBoxGridW.Name = "comboBoxGridW";
            this.comboBoxGridW.Size = new System.Drawing.Size(121, 20);
            this.comboBoxGridW.TabIndex = 1;
            this.comboBoxGridW.SelectedIndexChanged += new System.EventHandler(this.comboBoxGridW_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            // 
            // comboBoxGridH
            // 
            this.comboBoxGridH.FormattingEnabled = true;
            this.comboBoxGridH.Items.AddRange(new object[] {
            "8",
            "10",
            "16",
            "20",
            "24",
            "32",
            "40",
            "48",
            "60",
            "64",
            "80",
            "128"});
            this.comboBoxGridH.Location = new System.Drawing.Point(213, 12);
            this.comboBoxGridH.Name = "comboBoxGridH";
            this.comboBoxGridH.Size = new System.Drawing.Size(121, 20);
            this.comboBoxGridH.TabIndex = 3;
            this.comboBoxGridH.SelectedIndexChanged += new System.EventHandler(this.comboBoxGridH_SelectedIndexChanged);
            // 
            // buttonGridSizeOK
            // 
            this.buttonGridSizeOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGridSizeOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGridSizeOK.Location = new System.Drawing.Point(236, 77);
            this.buttonGridSizeOK.Name = "buttonGridSizeOK";
            this.buttonGridSizeOK.Size = new System.Drawing.Size(75, 23);
            this.buttonGridSizeOK.TabIndex = 4;
            this.buttonGridSizeOK.Text = "OK";
            this.buttonGridSizeOK.UseVisualStyleBackColor = true;
            this.buttonGridSizeOK.Click += new System.EventHandler(this.buttonGridSizeOK_Click);
            // 
            // buttonGridSizeCancel
            // 
            this.buttonGridSizeCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGridSizeCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGridSizeCancel.Location = new System.Drawing.Point(317, 77);
            this.buttonGridSizeCancel.Name = "buttonGridSizeCancel";
            this.buttonGridSizeCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonGridSizeCancel.TabIndex = 5;
            this.buttonGridSizeCancel.Text = "Cancel";
            this.buttonGridSizeCancel.UseVisualStyleBackColor = true;
            // 
            // FormSetGridSize
            // 
            this.AcceptButton = this.buttonGridSizeOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonGridSizeCancel;
            this.ClientSize = new System.Drawing.Size(404, 112);
            this.Controls.Add(this.buttonGridSizeCancel);
            this.Controls.Add(this.buttonGridSizeOK);
            this.Controls.Add(this.comboBoxGridH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGridW);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 150);
            this.Name = "FormSetGridSize";
            this.Text = "Set Grid Size";
            this.Load += new System.EventHandler(this.FormSetGridSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGridW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGridH;
        private System.Windows.Forms.Button buttonGridSizeOK;
        private System.Windows.Forms.Button buttonGridSizeCancel;
    }
}