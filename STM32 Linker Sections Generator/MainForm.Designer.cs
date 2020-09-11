namespace STM32_Generate_Linker_Sections
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("STM32 Flash - origin: 0x08000000 - length: 0x20000 - end: 0x08020000");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("STM32 RAM - origin: 0x20000000 - length: 0x10000 - end: 0x20010000");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBoxSectionName = new System.Windows.Forms.TextBox();
            this.labelSectionName = new System.Windows.Forms.Label();
            this.labelSectionOrigin = new System.Windows.Forms.Label();
            this.textBoxSectionOrigin = new System.Windows.Forms.TextBox();
            this.buttonAddSection = new System.Windows.Forms.Button();
            this.labelSectionOriginU = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSectionOriginM = new NumericUpDownK();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownSectionOriginL = new NumericUpDownB();
            this.numericUpDownSectionSizeL = new NumericUpDownB();
            this.labelSectionSizeSign = new System.Windows.Forms.Label();
            this.numericUpDownSectionSizeM = new NumericUpDownK();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSectionSize = new System.Windows.Forms.TextBox();
            this.buttonRemoveSection = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSectionEndL = new NumericUpDownB();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSectionEndM = new NumericUpDownK();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSectionEndU = new System.Windows.Forms.Label();
            this.textBoxSectionEnd = new System.Windows.Forms.TextBox();
            this.checkBoxSectionSizeSubtractBytes = new System.Windows.Forms.CheckBox();
            this.textBoxLinkerCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionOriginM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionOriginL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionSizeL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionSizeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionEndL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionEndM)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 33);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "STM_FLASH";
            treeNode1.Text = "STM32 Flash - origin: 0x08000000 - length: 0x20000 - end: 0x08020000";
            treeNode2.Name = "STM_RAM";
            treeNode2.Text = "STM32 RAM - origin: 0x20000000 - length: 0x10000 - end: 0x20010000";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(588, 165);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBoxSectionName
            // 
            this.textBoxSectionName.Location = new System.Drawing.Point(611, 80);
            this.textBoxSectionName.Name = "textBoxSectionName";
            this.textBoxSectionName.Size = new System.Drawing.Size(382, 22);
            this.textBoxSectionName.TabIndex = 1;
            // 
            // labelSectionName
            // 
            this.labelSectionName.AutoSize = true;
            this.labelSectionName.Location = new System.Drawing.Point(608, 61);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(45, 16);
            this.labelSectionName.TabIndex = 3;
            this.labelSectionName.Text = "Name";
            // 
            // labelSectionOrigin
            // 
            this.labelSectionOrigin.AutoSize = true;
            this.labelSectionOrigin.Location = new System.Drawing.Point(608, 117);
            this.labelSectionOrigin.Name = "labelSectionOrigin";
            this.labelSectionOrigin.Size = new System.Drawing.Size(43, 16);
            this.labelSectionOrigin.TabIndex = 6;
            this.labelSectionOrigin.Text = "Origin";
            // 
            // textBoxSectionOrigin
            // 
            this.textBoxSectionOrigin.Location = new System.Drawing.Point(611, 136);
            this.textBoxSectionOrigin.Name = "textBoxSectionOrigin";
            this.textBoxSectionOrigin.Size = new System.Drawing.Size(382, 22);
            this.textBoxSectionOrigin.TabIndex = 4;
            this.textBoxSectionOrigin.TextChanged += new System.EventHandler(this.textBoxSectionOrigin_TextChanged);
            // 
            // buttonAddSection
            // 
            this.buttonAddSection.Location = new System.Drawing.Point(611, 13);
            this.buttonAddSection.Name = "buttonAddSection";
            this.buttonAddSection.Size = new System.Drawing.Size(126, 35);
            this.buttonAddSection.TabIndex = 7;
            this.buttonAddSection.Text = "Add Section";
            this.buttonAddSection.UseVisualStyleBackColor = true;
            this.buttonAddSection.Click += new System.EventHandler(this.buttonAddSection_Click);
            // 
            // labelSectionOriginU
            // 
            this.labelSectionOriginU.AutoSize = true;
            this.labelSectionOriginU.Location = new System.Drawing.Point(611, 165);
            this.labelSectionOriginU.Name = "labelSectionOriginU";
            this.labelSectionOriginU.Size = new System.Drawing.Size(77, 16);
            this.labelSectionOriginU.TabIndex = 8;
            this.labelSectionOriginU.Text = "0x08000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "+";
            // 
            // numericUpDownSectionOriginM
            // 
            this.numericUpDownSectionOriginM.Location = new System.Drawing.Point(725, 163);
            this.numericUpDownSectionOriginM.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownSectionOriginM.Name = "numericUpDownSectionOriginM";
            this.numericUpDownSectionOriginM.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSectionOriginM.TabIndex = 11;
            this.numericUpDownSectionOriginM.ValueChanged += new System.EventHandler(this.numericUpDownSectionOriginM_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(851, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "+";
            // 
            // numericUpDownSectionOriginL
            // 
            this.numericUpDownSectionOriginL.Location = new System.Drawing.Point(873, 163);
            this.numericUpDownSectionOriginL.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDownSectionOriginL.Name = "numericUpDownSectionOriginL";
            this.numericUpDownSectionOriginL.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSectionOriginL.TabIndex = 13;
            this.numericUpDownSectionOriginL.ValueChanged += new System.EventHandler(this.numericUpDownSectionOriginL_ValueChanged);
            // 
            // numericUpDownSectionSizeL
            // 
            this.numericUpDownSectionSizeL.Location = new System.Drawing.Point(874, 248);
            this.numericUpDownSectionSizeL.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDownSectionSizeL.Name = "numericUpDownSectionSizeL";
            this.numericUpDownSectionSizeL.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSectionSizeL.TabIndex = 21;
            this.numericUpDownSectionSizeL.ValueChanged += new System.EventHandler(this.numericUpDownSectionSizeL_ValueChanged);
            // 
            // labelSectionSizeSign
            // 
            this.labelSectionSizeSign.AutoSize = true;
            this.labelSectionSizeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionSizeSign.Location = new System.Drawing.Point(852, 250);
            this.labelSectionSizeSign.Name = "labelSectionSizeSign";
            this.labelSectionSizeSign.Size = new System.Drawing.Size(16, 16);
            this.labelSectionSizeSign.TabIndex = 20;
            this.labelSectionSizeSign.Text = "+";
            // 
            // numericUpDownSectionSizeM
            // 
            this.numericUpDownSectionSizeM.Location = new System.Drawing.Point(726, 248);
            this.numericUpDownSectionSizeM.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numericUpDownSectionSizeM.Name = "numericUpDownSectionSizeM";
            this.numericUpDownSectionSizeM.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSectionSizeM.TabIndex = 19;
            this.numericUpDownSectionSizeM.ValueChanged += new System.EventHandler(this.numericUpDownSectionSizeM_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Size";
            // 
            // textBoxSectionSize
            // 
            this.textBoxSectionSize.Location = new System.Drawing.Point(612, 221);
            this.textBoxSectionSize.Name = "textBoxSectionSize";
            this.textBoxSectionSize.Size = new System.Drawing.Size(382, 22);
            this.textBoxSectionSize.TabIndex = 14;
            this.textBoxSectionSize.TextChanged += new System.EventHandler(this.textBoxSectionSize_TextChanged);
            // 
            // buttonRemoveSection
            // 
            this.buttonRemoveSection.Location = new System.Drawing.Point(744, 13);
            this.buttonRemoveSection.Name = "buttonRemoveSection";
            this.buttonRemoveSection.Size = new System.Drawing.Size(123, 35);
            this.buttonRemoveSection.TabIndex = 22;
            this.buttonRemoveSection.Text = "Remove Section";
            this.buttonRemoveSection.UseVisualStyleBackColor = true;
            this.buttonRemoveSection.Click += new System.EventHandler(this.buttonRemoveSection_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(611, 359);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(382, 52);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Update Section and Generate Code";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "End";
            // 
            // numericUpDownSectionEndL
            // 
            this.numericUpDownSectionEndL.Location = new System.Drawing.Point(873, 322);
            this.numericUpDownSectionEndL.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDownSectionEndL.Name = "numericUpDownSectionEndL";
            this.numericUpDownSectionEndL.ReadOnly = true;
            this.numericUpDownSectionEndL.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSectionEndL.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(851, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "+";
            // 
            // numericUpDownSectionEndM
            // 
            this.numericUpDownSectionEndM.Location = new System.Drawing.Point(725, 322);
            this.numericUpDownSectionEndM.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownSectionEndM.Name = "numericUpDownSectionEndM";
            this.numericUpDownSectionEndM.ReadOnly = true;
            this.numericUpDownSectionEndM.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSectionEndM.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "+";
            // 
            // labelSectionEndU
            // 
            this.labelSectionEndU.AutoSize = true;
            this.labelSectionEndU.Location = new System.Drawing.Point(611, 324);
            this.labelSectionEndU.Name = "labelSectionEndU";
            this.labelSectionEndU.Size = new System.Drawing.Size(77, 16);
            this.labelSectionEndU.TabIndex = 26;
            this.labelSectionEndU.Text = "0x08000000";
            // 
            // textBoxSectionEnd
            // 
            this.textBoxSectionEnd.Location = new System.Drawing.Point(611, 295);
            this.textBoxSectionEnd.Name = "textBoxSectionEnd";
            this.textBoxSectionEnd.ReadOnly = true;
            this.textBoxSectionEnd.Size = new System.Drawing.Size(382, 22);
            this.textBoxSectionEnd.TabIndex = 25;
            // 
            // checkBoxSectionSizeSubtractBytes
            // 
            this.checkBoxSectionSizeSubtractBytes.AutoSize = true;
            this.checkBoxSectionSizeSubtractBytes.Location = new System.Drawing.Point(611, 249);
            this.checkBoxSectionSizeSubtractBytes.Name = "checkBoxSectionSizeSubtractBytes";
            this.checkBoxSectionSizeSubtractBytes.Size = new System.Drawing.Size(113, 20);
            this.checkBoxSectionSizeSubtractBytes.TabIndex = 31;
            this.checkBoxSectionSizeSubtractBytes.Text = "Subtract Bytes";
            this.checkBoxSectionSizeSubtractBytes.UseVisualStyleBackColor = true;
            this.checkBoxSectionSizeSubtractBytes.CheckedChanged += new System.EventHandler(this.checkBoxSectionSizeSubtractBytes_CheckedChanged);
            // 
            // textBoxLinkerCode
            // 
            this.textBoxLinkerCode.Location = new System.Drawing.Point(13, 221);
            this.textBoxLinkerCode.Multiline = true;
            this.textBoxLinkerCode.Name = "textBoxLinkerCode";
            this.textBoxLinkerCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLinkerCode.Size = new System.Drawing.Size(588, 190);
            this.textBoxLinkerCode.TabIndex = 32;
            this.textBoxLinkerCode.Text = "MEMORY\r\n{\r\n}\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Generated Linker Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Sections Tree";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 425);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLinkerCode);
            this.Controls.Add(this.checkBoxSectionSizeSubtractBytes);
            this.Controls.Add(this.numericUpDownSectionEndL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSectionEndM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSectionEndU);
            this.Controls.Add(this.textBoxSectionEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRemoveSection);
            this.Controls.Add(this.numericUpDownSectionSizeL);
            this.Controls.Add(this.labelSectionSizeSign);
            this.Controls.Add(this.numericUpDownSectionSizeM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSectionSize);
            this.Controls.Add(this.numericUpDownSectionOriginL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownSectionOriginM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSectionOriginU);
            this.Controls.Add(this.buttonAddSection);
            this.Controls.Add(this.labelSectionOrigin);
            this.Controls.Add(this.textBoxSectionOrigin);
            this.Controls.Add(this.labelSectionName);
            this.Controls.Add(this.textBoxSectionName);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STM32 Linker Sections Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionOriginM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionOriginL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionSizeL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionSizeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionEndL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSectionEndM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBoxSectionName;
        private System.Windows.Forms.Label labelSectionName;
        private System.Windows.Forms.Label labelSectionOrigin;
        private System.Windows.Forms.TextBox textBoxSectionOrigin;
        private System.Windows.Forms.Button buttonAddSection;
        private System.Windows.Forms.Label labelSectionOriginU;
        private System.Windows.Forms.Label label4;
        private NumericUpDownK numericUpDownSectionOriginM;
        private System.Windows.Forms.Label label5;
        private NumericUpDownB numericUpDownSectionOriginL;
        private NumericUpDownB numericUpDownSectionSizeL;
        private System.Windows.Forms.Label labelSectionSizeSign;
        private NumericUpDownK numericUpDownSectionSizeM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSectionSize;
        private System.Windows.Forms.Button buttonRemoveSection;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private NumericUpDownB numericUpDownSectionEndL;
        private System.Windows.Forms.Label label2;
        private NumericUpDownK numericUpDownSectionEndM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSectionEndU;
        private System.Windows.Forms.TextBox textBoxSectionEnd;
        private System.Windows.Forms.CheckBox checkBoxSectionSizeSubtractBytes;
        private System.Windows.Forms.TextBox textBoxLinkerCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}