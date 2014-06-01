namespace LootAlert
{
    partial class ItemFilterEditor
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxQuality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinLVL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listEnabled = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnAllLeft = new System.Windows.Forms.Button();
            this.listDisabled = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // boxQuality
            // 
            this.boxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxQuality.FormattingEnabled = true;
            this.boxQuality.Location = new System.Drawing.Point(95, 33);
            this.boxQuality.Name = "boxQuality";
            this.boxQuality.Size = new System.Drawing.Size(99, 21);
            this.boxQuality.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quality";
            // 
            // txtMinLVL
            // 
            this.txtMinLVL.Location = new System.Drawing.Point(95, 61);
            this.txtMinLVL.Name = "txtMinLVL";
            this.txtMinLVL.Size = new System.Drawing.Size(100, 20);
            this.txtMinLVL.TabIndex = 4;
            this.txtMinLVL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinLVL_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min ItemLevel";
            // 
            // listEnabled
            // 
            this.listEnabled.FormattingEnabled = true;
            this.listEnabled.Location = new System.Drawing.Point(217, 37);
            this.listEnabled.Name = "listEnabled";
            this.listEnabled.Size = new System.Drawing.Size(120, 225);
            this.listEnabled.TabIndex = 6;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(343, 80);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(343, 109);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "<-";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Location = new System.Drawing.Point(343, 166);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(75, 23);
            this.btnAllRight.TabIndex = 9;
            this.btnAllRight.Text = "All ->";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnAllLeft
            // 
            this.btnAllLeft.Location = new System.Drawing.Point(343, 195);
            this.btnAllLeft.Name = "btnAllLeft";
            this.btnAllLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAllLeft.TabIndex = 10;
            this.btnAllLeft.Text = "<- All";
            this.btnAllLeft.UseVisualStyleBackColor = true;
            this.btnAllLeft.Click += new System.EventHandler(this.btnAllLeft_Click);
            // 
            // listDisabled
            // 
            this.listDisabled.FormattingEnabled = true;
            this.listDisabled.Location = new System.Drawing.Point(424, 37);
            this.listDisabled.Name = "listDisabled";
            this.listDisabled.Size = new System.Drawing.Size(120, 225);
            this.listDisabled.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 239);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Active";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Inactive";
            // 
            // txtSound
            // 
            this.txtSound.Location = new System.Drawing.Point(56, 88);
            this.txtSound.Name = "txtSound";
            this.txtSound.Size = new System.Drawing.Size(139, 20);
            this.txtSound.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sound";
            // 
            // ItemFilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 274);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listDisabled);
            this.Controls.Add(this.btnAllLeft);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.listEnabled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinLVL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxQuality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "ItemFilterEditor";
            this.Text = "Edit Item Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinLVL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listEnabled;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnAllLeft;
        private System.Windows.Forms.ListBox listDisabled;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.Label label6;
    }
}