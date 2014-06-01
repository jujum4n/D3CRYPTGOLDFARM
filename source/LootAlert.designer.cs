namespace LootAlert
{
    partial class LootAlert
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTestSound = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.boxFilters = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bntRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTestSound
            // 
            this.btnTestSound.Location = new System.Drawing.Point(13, 43);
            this.btnTestSound.Name = "btnTestSound";
            this.btnTestSound.Size = new System.Drawing.Size(75, 23);
            this.btnTestSound.TabIndex = 1;
            this.btnTestSound.Text = "Test sound";
            this.btnTestSound.UseVisualStyleBackColor = true;
            this.btnTestSound.Click += new System.EventHandler(this.btnTestSound_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(13, 85);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Edit";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // boxFilters
            // 
            this.boxFilters.FormattingEnabled = true;
            this.boxFilters.Location = new System.Drawing.Point(112, 13);
            this.boxFilters.Name = "boxFilters";
            this.boxFilters.Size = new System.Drawing.Size(140, 169);
            this.boxFilters.TabIndex = 8;
            this.boxFilters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.boxFilters_ItemCheck);
            this.boxFilters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boxFilters_MouseClick);
            this.boxFilters.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxFilters_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bntRemove
            // 
            this.bntRemove.Location = new System.Drawing.Point(13, 145);
            this.bntRemove.Name = "bntRemove";
            this.bntRemove.Size = new System.Drawing.Size(75, 23);
            this.bntRemove.TabIndex = 10;
            this.bntRemove.Text = "Remove";
            this.bntRemove.UseVisualStyleBackColor = true;
            this.bntRemove.Click += new System.EventHandler(this.bntRemove_Click);
            // 
            // LootAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 200);
            this.Controls.Add(this.bntRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.boxFilters);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnTestSound);
            this.Controls.Add(this.btnStart);
            this.Name = "LootAlert";
            this.Text = "Loot Alert";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTestSound;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.CheckedListBox boxFilters;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bntRemove;
    }
}

