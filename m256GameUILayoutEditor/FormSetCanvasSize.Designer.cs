namespace m256GameUILayoutEditor
{
    partial class FormSetCanvasSize
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
            this.comboBoxCanvasSizeW = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCanvasSizeH = new System.Windows.Forms.ComboBox();
            this.buttonSetCanvasSizeOK = new System.Windows.Forms.Button();
            this.buttonSetCanvasSizeCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChoiceBackColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChoiceGridColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canvas Size";
            // 
            // comboBoxCanvasSizeW
            // 
            this.comboBoxCanvasSizeW.FormattingEnabled = true;
            this.comboBoxCanvasSizeW.Items.AddRange(new object[] {
            "240",
            "256",
            "320",
            "480",
            "512",
            "600",
            "640",
            "720",
            "768",
            "800",
            "960",
            "1024",
            "1050",
            "1080",
            "1152",
            "1200",
            "1280",
            "1366",
            "1400",
            "1600",
            "1920"});
            this.comboBoxCanvasSizeW.Location = new System.Drawing.Point(99, 12);
            this.comboBoxCanvasSizeW.Name = "comboBoxCanvasSizeW";
            this.comboBoxCanvasSizeW.Size = new System.Drawing.Size(96, 20);
            this.comboBoxCanvasSizeW.TabIndex = 1;
            this.comboBoxCanvasSizeW.SelectedIndexChanged += new System.EventHandler(this.comboBoxCanvasSizeW_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            // 
            // comboBoxCanvasSizeH
            // 
            this.comboBoxCanvasSizeH.FormattingEnabled = true;
            this.comboBoxCanvasSizeH.Items.AddRange(new object[] {
            "240",
            "256",
            "320",
            "480",
            "512",
            "600",
            "640",
            "720",
            "768",
            "800",
            "960",
            "1024",
            "1050",
            "1080",
            "1152",
            "1200",
            "1280",
            "1366",
            "1400",
            "1600",
            "1920"});
            this.comboBoxCanvasSizeH.Location = new System.Drawing.Point(218, 12);
            this.comboBoxCanvasSizeH.Name = "comboBoxCanvasSizeH";
            this.comboBoxCanvasSizeH.Size = new System.Drawing.Size(96, 20);
            this.comboBoxCanvasSizeH.TabIndex = 3;
            this.comboBoxCanvasSizeH.SelectedIndexChanged += new System.EventHandler(this.comboBoxCanvasSizeH_SelectedIndexChanged);
            // 
            // buttonSetCanvasSizeOK
            // 
            this.buttonSetCanvasSizeOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetCanvasSizeOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSetCanvasSizeOK.Location = new System.Drawing.Point(236, 127);
            this.buttonSetCanvasSizeOK.Name = "buttonSetCanvasSizeOK";
            this.buttonSetCanvasSizeOK.Size = new System.Drawing.Size(75, 23);
            this.buttonSetCanvasSizeOK.TabIndex = 4;
            this.buttonSetCanvasSizeOK.Text = "OK";
            this.buttonSetCanvasSizeOK.UseVisualStyleBackColor = true;
            this.buttonSetCanvasSizeOK.Click += new System.EventHandler(this.buttonSetCanvasSizeOK_Click);
            // 
            // buttonSetCanvasSizeCancel
            // 
            this.buttonSetCanvasSizeCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetCanvasSizeCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSetCanvasSizeCancel.Location = new System.Drawing.Point(317, 127);
            this.buttonSetCanvasSizeCancel.Name = "buttonSetCanvasSizeCancel";
            this.buttonSetCanvasSizeCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonSetCanvasSizeCancel.TabIndex = 5;
            this.buttonSetCanvasSizeCancel.Text = "Cancel";
            this.buttonSetCanvasSizeCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Canvas Color";
            // 
            // buttonChoiceBackColor
            // 
            this.buttonChoiceBackColor.Location = new System.Drawing.Point(99, 51);
            this.buttonChoiceBackColor.Name = "buttonChoiceBackColor";
            this.buttonChoiceBackColor.Size = new System.Drawing.Size(160, 24);
            this.buttonChoiceBackColor.TabIndex = 7;
            this.buttonChoiceBackColor.UseVisualStyleBackColor = true;
            this.buttonChoiceBackColor.Click += new System.EventHandler(this.buttonChoiceBackColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grid Color";
            // 
            // buttonChoiceGridColor
            // 
            this.buttonChoiceGridColor.Location = new System.Drawing.Point(99, 81);
            this.buttonChoiceGridColor.Name = "buttonChoiceGridColor";
            this.buttonChoiceGridColor.Size = new System.Drawing.Size(160, 24);
            this.buttonChoiceGridColor.TabIndex = 9;
            this.buttonChoiceGridColor.UseVisualStyleBackColor = true;
            this.buttonChoiceGridColor.Click += new System.EventHandler(this.buttonChoiceGridColor_Click);
            // 
            // FormSetCanvasSize
            // 
            this.AcceptButton = this.buttonSetCanvasSizeOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSetCanvasSizeCancel;
            this.ClientSize = new System.Drawing.Size(404, 162);
            this.Controls.Add(this.buttonChoiceGridColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonChoiceBackColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSetCanvasSizeCancel);
            this.Controls.Add(this.buttonSetCanvasSizeOK);
            this.Controls.Add(this.comboBoxCanvasSizeH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCanvasSizeW);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 200);
            this.Name = "FormSetCanvasSize";
            this.Text = "Set Canvas Size";
            this.Load += new System.EventHandler(this.FormSetCanvasSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCanvasSizeW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCanvasSizeH;
        private System.Windows.Forms.Button buttonSetCanvasSizeOK;
        private System.Windows.Forms.Button buttonSetCanvasSizeCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChoiceBackColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChoiceGridColor;

    }
}