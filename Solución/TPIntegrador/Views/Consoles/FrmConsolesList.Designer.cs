﻿namespace TPIntegrador.Views
{
    partial class FrmConsolesList
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
            this.gConsoles = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSearcher = new System.Windows.Forms.TextBox();
            this.lstConsoles = new System.Windows.Forms.ListBox();
            this.gConsoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gConsoles
            // 
            this.gConsoles.Controls.Add(this.btnBack);
            this.gConsoles.Controls.Add(this.btnDelete);
            this.gConsoles.Controls.Add(this.btnEdit);
            this.gConsoles.Controls.Add(this.btnNew);
            this.gConsoles.Controls.Add(this.txtSearcher);
            this.gConsoles.Controls.Add(this.lstConsoles);
            this.gConsoles.Location = new System.Drawing.Point(12, 12);
            this.gConsoles.Name = "gConsoles";
            this.gConsoles.Size = new System.Drawing.Size(776, 426);
            this.gConsoles.TabIndex = 0;
            this.gConsoles.TabStop = false;
            this.gConsoles.Text = "Consoles";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(694, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(615, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(534, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(453, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSearcher
            // 
            this.txtSearcher.Location = new System.Drawing.Point(6, 16);
            this.txtSearcher.Name = "txtSearcher";
            this.txtSearcher.Size = new System.Drawing.Size(442, 20);
            this.txtSearcher.TabIndex = 1;
            this.txtSearcher.TextChanged += new System.EventHandler(this.txtSearcher_TextChanged);
            // 
            // lstConsoles
            // 
            this.lstConsoles.FormattingEnabled = true;
            this.lstConsoles.Location = new System.Drawing.Point(6, 45);
            this.lstConsoles.Name = "lstConsoles";
            this.lstConsoles.Size = new System.Drawing.Size(764, 368);
            this.lstConsoles.TabIndex = 0;
            this.lstConsoles.SelectedIndexChanged += new System.EventHandler(this.lstConsoles_SelectedIndexChanged);
            // 
            // FrmConsolesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gConsoles);
            this.Name = "FrmConsolesList";
            this.Text = "FrmConsolesList";
            this.Load += new System.EventHandler(this.FrmConsolesList_Load);
            this.gConsoles.ResumeLayout(false);
            this.gConsoles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gConsoles;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSearcher;
        private System.Windows.Forms.ListBox lstConsoles;
    }
}