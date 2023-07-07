namespace Wrapped_Chicken
{
    partial class Wrapped_Chicken
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wrapped_Chicken));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCopy = new System.Windows.Forms.TextBox();
            this.inputPaste = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonCopy = new System.Windows.Forms.Button();
            this.ButtonPaste = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListboxPresets = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textEvents = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Praetorian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wrapped Chicken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copy";
            // 
            // inputCopy
            // 
            this.inputCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputCopy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCopy.ForeColor = System.Drawing.Color.White;
            this.inputCopy.Location = new System.Drawing.Point(52, 25);
            this.inputCopy.Name = "inputCopy";
            this.inputCopy.Size = new System.Drawing.Size(236, 26);
            this.inputCopy.TabIndex = 2;
            this.inputCopy.Text = "C:\\";
            // 
            // inputPaste
            // 
            this.inputPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputPaste.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPaste.ForeColor = System.Drawing.Color.White;
            this.inputPaste.Location = new System.Drawing.Point(52, 57);
            this.inputPaste.Name = "inputPaste";
            this.inputPaste.Size = new System.Drawing.Size(236, 26);
            this.inputPaste.TabIndex = 4;
            this.inputPaste.Text = "C:\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Paste";
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.BackColor = System.Drawing.Color.Green;
            this.ButtonCopy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCopy.ForeColor = System.Drawing.Color.White;
            this.ButtonCopy.Location = new System.Drawing.Point(294, 25);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(26, 22);
            this.ButtonCopy.TabIndex = 5;
            this.ButtonCopy.Text = "◢";
            this.ButtonCopy.UseVisualStyleBackColor = false;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // ButtonPaste
            // 
            this.ButtonPaste.BackColor = System.Drawing.Color.Green;
            this.ButtonPaste.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPaste.ForeColor = System.Drawing.Color.White;
            this.ButtonPaste.Location = new System.Drawing.Point(294, 57);
            this.ButtonPaste.Name = "ButtonPaste";
            this.ButtonPaste.Size = new System.Drawing.Size(26, 21);
            this.ButtonPaste.TabIndex = 6;
            this.ButtonPaste.Text = "◢";
            this.ButtonPaste.UseVisualStyleBackColor = false;
            this.ButtonPaste.Click += new System.EventHandler(this.ButtonPaste_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.ButtonCreate);
            this.groupBox1.Controls.Add(this.ButtonClear);
            this.groupBox1.Controls.Add(this.inputCopy);
            this.groupBox1.Controls.Add(this.ButtonPaste);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonCopy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputPaste);
            this.groupBox1.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy / paste folders";
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.Green;
            this.ButtonCreate.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreate.ForeColor = System.Drawing.Color.White;
            this.ButtonCreate.Location = new System.Drawing.Point(97, 98);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(223, 27);
            this.ButtonCreate.TabIndex = 13;
            this.ButtonCreate.Text = "Copy";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Maroon;
            this.ButtonClear.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(9, 98);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(82, 27);
            this.ButtonClear.TabIndex = 14;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.ListboxPresets);
            this.groupBox2.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(353, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Presets";
            // 
            // ListboxPresets
            // 
            this.ListboxPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ListboxPresets.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxPresets.ForeColor = System.Drawing.Color.White;
            this.ListboxPresets.FormattingEnabled = true;
            this.ListboxPresets.ItemHeight = 18;
            this.ListboxPresets.Location = new System.Drawing.Point(6, 21);
            this.ListboxPresets.Name = "ListboxPresets";
            this.ListboxPresets.Size = new System.Drawing.Size(130, 112);
            this.ListboxPresets.TabIndex = 0;
            this.ListboxPresets.SelectedIndexChanged += new System.EventHandler(this.ListboxPresets_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(6, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(389, 18);
            this.progressBar.TabIndex = 9;
            // 
            // textEvents
            // 
            this.textEvents.AutoSize = true;
            this.textEvents.BackColor = System.Drawing.Color.Black;
            this.textEvents.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEvents.ForeColor = System.Drawing.Color.White;
            this.textEvents.Location = new System.Drawing.Point(401, 25);
            this.textEvents.Name = "textEvents";
            this.textEvents.Size = new System.Drawing.Size(58, 18);
            this.textEvents.TabIndex = 10;
            this.textEvents.Text = "Waiting";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.progressBar);
            this.groupBox4.Controls.Add(this.textEvents);
            this.groupBox4.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(16, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(479, 54);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Worker";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Maroon;
            this.ButtonExit.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(435, 5);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(63, 27);
            this.ButtonExit.TabIndex = 15;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Wrapped_Chicken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(509, 238);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(509, 238);
            this.MinimumSize = new System.Drawing.Size(509, 238);
            this.Name = "Wrapped_Chicken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wrapped Chicken";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCopy;
        private System.Windows.Forms.TextBox inputPaste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonCopy;
        private System.Windows.Forms.Button ButtonPaste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label textEvents;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ListBox ListboxPresets;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonClear;
    }
}

