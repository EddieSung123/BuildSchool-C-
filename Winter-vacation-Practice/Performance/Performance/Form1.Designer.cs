namespace Performance
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.salse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.white = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sample,
            this.sale,
            this.sales,
            this.money2});
            this.dataGridView1.Location = new System.Drawing.Point(195, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(597, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // sample
            // 
            this.sample.DataPropertyName = "sample";
            this.sample.HeaderText = "產品";
            this.sample.Name = "sample";
            this.sample.ReadOnly = true;
            // 
            // sale
            // 
            this.sale.DataPropertyName = "sale";
            this.sale.HeaderText = "單價";
            this.sale.Name = "sale";
            this.sale.ReadOnly = true;
            // 
            // sales
            // 
            this.sales.DataPropertyName = "sales";
            this.sales.HeaderText = "銷售數量";
            this.sales.Name = "sales";
            this.sales.ReadOnly = true;
            // 
            // money2
            // 
            this.money2.DataPropertyName = "money2";
            this.money2.HeaderText = "銷售總金額";
            this.money2.Name = "money2";
            this.money2.ReadOnly = true;
            this.money2.Width = 110;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salse,
            this.pen,
            this.pencil,
            this.eraser,
            this.ruler,
            this.white,
            this.money});
            this.dataGridView2.Location = new System.Drawing.Point(195, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(974, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // salse
            // 
            this.salse.DataPropertyName = "Name";
            this.salse.HeaderText = "業務員";
            this.salse.Name = "salse";
            this.salse.ReadOnly = true;
            // 
            // pen
            // 
            this.pen.DataPropertyName = "pen";
            this.pen.HeaderText = "原子筆";
            this.pen.Name = "pen";
            this.pen.ReadOnly = true;
            // 
            // pencil
            // 
            this.pencil.DataPropertyName = "pencil";
            this.pencil.HeaderText = "鉛筆";
            this.pencil.Name = "pencil";
            this.pencil.ReadOnly = true;
            // 
            // eraser
            // 
            this.eraser.DataPropertyName = "eraser";
            this.eraser.HeaderText = "橡皮擦";
            this.eraser.Name = "eraser";
            this.eraser.ReadOnly = true;
            // 
            // ruler
            // 
            this.ruler.DataPropertyName = "ruler";
            this.ruler.HeaderText = "尺";
            this.ruler.Name = "ruler";
            this.ruler.ReadOnly = true;
            // 
            // white
            // 
            this.white.DataPropertyName = "white";
            this.white.HeaderText = "立可白";
            this.white.Name = "white";
            this.white.ReadOnly = true;
            // 
            // money
            // 
            this.money.DataPropertyName = "money";
            this.money.HeaderText = "銷售總金額";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            this.money.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "業務員業績";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "產品銷售總額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(900, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "最佳業務員";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(900, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "最佳產品";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1051, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(1051, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "產品";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 564);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn salse;
        private System.Windows.Forms.DataGridViewTextBoxColumn pen;
        private System.Windows.Forms.DataGridViewTextBoxColumn pencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn eraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruler;
        private System.Windows.Forms.DataGridViewTextBoxColumn white;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn sample;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn money2;
    }
}

