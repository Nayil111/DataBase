﻿namespace WindowsAPI.EditingMode
{
    partial class EditingModeTeachers
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
            this.Exite = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exite
            // 
            this.Exite.Location = new System.Drawing.Point(234, 408);
            this.Exite.Name = "Exite";
            this.Exite.Size = new System.Drawing.Size(214, 30);
            this.Exite.TabIndex = 7;
            this.Exite.Text = "Выйти из режима редактирования";
            this.Exite.UseVisualStyleBackColor = true;
            this.Exite.Click += new System.EventHandler(this.Exite_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(124, 408);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 30);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 408);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 30);
            this.Save.TabIndex = 5;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 387);
            this.dataGridView1.TabIndex = 4;
            // 
            // EditingModeTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exite);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditingModeTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование таблицы \"Преподавателя\"";
            this.Load += new System.EventHandler(this.EditingModeTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Exite;
        private Button Delete;
        private Button Save;
        private DataGridView dataGridView1;
    }
}