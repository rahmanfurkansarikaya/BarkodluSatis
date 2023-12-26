namespace BarkodluSatis
{
    partial class deneme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deneme));
            this.gridOzel1 = new BarkodluSatis.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.gridOzel1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOzel1
            // 
            this.gridOzel1.AllowUserToAddRows = false;
            this.gridOzel1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOzel1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridOzel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOzel1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOzel1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOzel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOzel1.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridOzel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOzel1.EnableHeadersVisualStyles = false;
            this.gridOzel1.Location = new System.Drawing.Point(0, 0);
            this.gridOzel1.Name = "gridOzel1";
            this.gridOzel1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOzel1.RowHeadersVisible = false;
            this.gridOzel1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOzel1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridOzel1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridOzel1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridOzel1.RowTemplate.Height = 28;
            this.gridOzel1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOzel1.Size = new System.Drawing.Size(800, 450);
            this.gridOzel1.TabIndex = 0;
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridOzel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deneme";
            this.Text = "deneme";
            ((System.ComponentModel.ISupportInitialize)(this.gridOzel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private gridOzel gridOzel1;
    }
}