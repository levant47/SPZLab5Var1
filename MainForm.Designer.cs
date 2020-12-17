namespace SPZLab5Var1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teacherCreateButton = new System.Windows.Forms.Button();
            this.teacherEditButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherCreateButton
            // 
            this.teacherCreateButton.Location = new System.Drawing.Point(12, 37);
            this.teacherCreateButton.Name = "teacherCreateButton";
            this.teacherCreateButton.Size = new System.Drawing.Size(75, 23);
            this.teacherCreateButton.TabIndex = 1;
            this.teacherCreateButton.Text = "Создать";
            this.teacherCreateButton.UseVisualStyleBackColor = true;
            this.teacherCreateButton.Click += new System.EventHandler(this.teacherCreateButton_Click);
            // 
            // teacherEditButton
            // 
            this.teacherEditButton.Location = new System.Drawing.Point(93, 37);
            this.teacherEditButton.Name = "teacherEditButton";
            this.teacherEditButton.Size = new System.Drawing.Size(104, 23);
            this.teacherEditButton.TabIndex = 2;
            this.teacherEditButton.Text = "Редактировать";
            this.teacherEditButton.UseVisualStyleBackColor = true;
            this.teacherEditButton.Click += new System.EventHandler(this.teacherEditButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Учителя";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // AgeColumn
            // 
            this.AgeColumn.HeaderText = "Возраст";
            this.AgeColumn.Name = "AgeColumn";
            this.AgeColumn.ReadOnly = true;
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AllowUserToAddRows = false;
            this.teachersDataGridView.AllowUserToDeleteRows = false;
            this.teachersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.AgeColumn});
            this.teachersDataGridView.Location = new System.Drawing.Point(12, 66);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.ReadOnly = true;
            this.teachersDataGridView.Size = new System.Drawing.Size(357, 188);
            this.teachersDataGridView.TabIndex = 0;
            this.teachersDataGridView.Text = "dataGridView1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacherEditButton);
            this.Controls.Add(this.teacherCreateButton);
            this.Controls.Add(this.teachersDataGridView);
            this.Name = "MainForm";
            this.Text = "SPZ";
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button teacherCreateButton;
        private System.Windows.Forms.Button teacherEditButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
    }
}

