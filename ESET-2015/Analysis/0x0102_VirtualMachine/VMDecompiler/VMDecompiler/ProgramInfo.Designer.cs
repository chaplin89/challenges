namespace VMDecompiler
{
    partial class ProgramInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramInfoForm));
            this.programInfo = new System.Windows.Forms.DataGridView();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.programInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // programInfo
            // 
            this.programInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.FieldValue});
            this.programInfo.Location = new System.Drawing.Point(12, 12);
            this.programInfo.Name = "programInfo";
            this.programInfo.Size = new System.Drawing.Size(289, 283);
            this.programInfo.TabIndex = 0;
            // 
            // FieldName
            // 
            this.FieldName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldName.FillWeight = 50F;
            this.FieldName.HeaderText = "Name";
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            // 
            // FieldValue
            // 
            this.FieldValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldValue.FillWeight = 50F;
            this.FieldValue.HeaderText = "Value";
            this.FieldValue.Name = "FieldValue";
            this.FieldValue.ReadOnly = true;
            this.FieldValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FieldValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProgramInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 307);
            this.Controls.Add(this.programInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(329, 346);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 346);
            this.Name = "ProgramInfoForm";
            this.Text = "Program Information";
            this.Load += new System.EventHandler(this.ProgramInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView programInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldValue;
    }
}