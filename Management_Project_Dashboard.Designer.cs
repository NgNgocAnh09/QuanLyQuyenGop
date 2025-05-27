namespace QuanLyQuyenGop
{
    partial class Management_Project_Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenDuAn = new System.Windows.Forms.TextBox();
            this.tbMoTaDuAn = new System.Windows.Forms.TextBox();
            this.btThemDuAn = new System.Windows.Forms.Button();
            this.btXoaDuAn = new System.Windows.Forms.Button();
            this.btSuaDuAn = new System.Windows.Forms.Button();
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên dự án";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mô tả dự án";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTenDuAn
            // 
            this.tbTenDuAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTenDuAn.Location = new System.Drawing.Point(136, 42);
            this.tbTenDuAn.Name = "tbTenDuAn";
            this.tbTenDuAn.Size = new System.Drawing.Size(264, 22);
            this.tbTenDuAn.TabIndex = 2;
            // 
            // tbMoTaDuAn
            // 
            this.tbMoTaDuAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMoTaDuAn.Location = new System.Drawing.Point(136, 104);
            this.tbMoTaDuAn.Name = "tbMoTaDuAn";
            this.tbMoTaDuAn.Size = new System.Drawing.Size(456, 22);
            this.tbMoTaDuAn.TabIndex = 2;
            // 
            // btThemDuAn
            // 
            this.btThemDuAn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btThemDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemDuAn.ForeColor = System.Drawing.Color.Navy;
            this.btThemDuAn.Location = new System.Drawing.Point(95, 146);
            this.btThemDuAn.Name = "btThemDuAn";
            this.btThemDuAn.Size = new System.Drawing.Size(111, 60);
            this.btThemDuAn.TabIndex = 3;
            this.btThemDuAn.Text = "Thêm";
            this.btThemDuAn.UseVisualStyleBackColor = false;
            // 
            // btXoaDuAn
            // 
            this.btXoaDuAn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btXoaDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaDuAn.ForeColor = System.Drawing.Color.Navy;
            this.btXoaDuAn.Location = new System.Drawing.Point(378, 146);
            this.btXoaDuAn.Name = "btXoaDuAn";
            this.btXoaDuAn.Size = new System.Drawing.Size(111, 60);
            this.btXoaDuAn.TabIndex = 3;
            this.btXoaDuAn.Text = "Xoá";
            this.btXoaDuAn.UseVisualStyleBackColor = false;
            // 
            // btSuaDuAn
            // 
            this.btSuaDuAn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btSuaDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaDuAn.ForeColor = System.Drawing.Color.Navy;
            this.btSuaDuAn.Location = new System.Drawing.Point(230, 146);
            this.btSuaDuAn.Name = "btSuaDuAn";
            this.btSuaDuAn.Size = new System.Drawing.Size(111, 60);
            this.btSuaDuAn.TabIndex = 3;
            this.btSuaDuAn.Text = "Sửa";
            this.btSuaDuAn.UseVisualStyleBackColor = false;
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDuAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDuAn.Location = new System.Drawing.Point(0, 228);
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.RowHeadersWidth = 51;
            this.dgvDuAn.RowTemplate.Height = 24;
            this.dgvDuAn.Size = new System.Drawing.Size(812, 222);
            this.dgvDuAn.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 53.47594F;
            this.Column1.HeaderText = "Tên dự án";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 146.5241F;
            this.Column2.HeaderText = "Mô tả dự án";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Management_Project_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.dgvDuAn);
            this.Controls.Add(this.btSuaDuAn);
            this.Controls.Add(this.btXoaDuAn);
            this.Controls.Add(this.btThemDuAn);
            this.Controls.Add(this.tbMoTaDuAn);
            this.Controls.Add(this.tbTenDuAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Management_Project_Dashboard";
            this.Text = "Management_Project_Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenDuAn;
        private System.Windows.Forms.TextBox tbMoTaDuAn;
        private System.Windows.Forms.Button btThemDuAn;
        private System.Windows.Forms.Button btXoaDuAn;
        private System.Windows.Forms.Button btSuaDuAn;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}