
namespace HalloCam.UI
{
    partial class KameraView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HerstellerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModellColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.herstellerTextBox = new System.Windows.Forms.TextBox();
            this.modellTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Neue Kamera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(178, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(359, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ausgewählte Kamera entfernen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(543, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Als XML Datei speichern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Location = new System.Drawing.Point(831, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hupen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(998, 96);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Location = new System.Drawing.Point(3, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "XML Datei lesen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HerstellerColumn,
            this.ModellColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(482, 523);
            this.dataGridView1.TabIndex = 2;
            // 
            // HerstellerColumn
            // 
            this.HerstellerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HerstellerColumn.DataPropertyName = "Hersteller";
            this.HerstellerColumn.HeaderText = "Hersteller";
            this.HerstellerColumn.MinimumWidth = 10;
            this.HerstellerColumn.Name = "HerstellerColumn";
            this.HerstellerColumn.Width = 161;
            // 
            // ModellColumn
            // 
            this.ModellColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModellColumn.DataPropertyName = "Modell";
            this.ModellColumn.HeaderText = "Modell";
            this.ModellColumn.MinimumWidth = 10;
            this.ModellColumn.Name = "ModellColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hersteller";
            // 
            // herstellerTextBox
            // 
            this.herstellerTextBox.Location = new System.Drawing.Point(523, 143);
            this.herstellerTextBox.Name = "herstellerTextBox";
            this.herstellerTextBox.Size = new System.Drawing.Size(423, 39);
            this.herstellerTextBox.TabIndex = 4;
            // 
            // modellTextBox
            // 
            this.modellTextBox.Location = new System.Drawing.Point(523, 243);
            this.modellTextBox.Name = "modellTextBox";
            this.modellTextBox.Size = new System.Drawing.Size(423, 39);
            this.modellTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modell";
            // 
            // KameraView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modellTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.herstellerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "KameraView";
            this.Size = new System.Drawing.Size(998, 619);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HerstellerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModellColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox herstellerTextBox;
        private System.Windows.Forms.TextBox modellTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
    }
}
