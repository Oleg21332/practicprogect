namespace ppractic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.add = new System.Windows.Forms.Button();
            this.closed = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.iddel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ssearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ppractikDataSet = new ppractic.ppractikDataSet();
            this.bookTableAdapter = new ppractic.ppractikDataSetTableAdapters.bookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppractikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(501, 261);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(92, 36);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // closed
            // 
            this.closed.Location = new System.Drawing.Point(501, 312);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(92, 36);
            this.closed.TabIndex = 1;
            this.closed.Text = "Завершить работу";
            this.closed.UseVisualStyleBackColor = true;
            this.closed.Click += new System.EventHandler(this.closed_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(305, 261);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(92, 36);
            this.search.TabIndex = 3;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // iddel
            // 
            this.iddel.Location = new System.Drawing.Point(9, 261);
            this.iddel.Multiline = true;
            this.iddel.Name = "iddel";
            this.iddel.Size = new System.Drawing.Size(92, 36);
            this.iddel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите ID книги";
            // 
            // ssearch
            // 
            this.ssearch.Location = new System.Drawing.Point(207, 261);
            this.ssearch.Multiline = true;
            this.ssearch.Name = "ssearch";
            this.ssearch.Size = new System.Drawing.Size(92, 36);
            this.ssearch.TabIndex = 6;
            this.ssearch.TextChanged += new System.EventHandler(this.ssearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idКнигиDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.названиеКнигиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 242);
            this.dataGridView1.TabIndex = 7;
            // 
            // idКнигиDataGridViewTextBoxColumn
            // 
            this.idКнигиDataGridViewTextBoxColumn.DataPropertyName = "id книги";
            this.idКнигиDataGridViewTextBoxColumn.HeaderText = "id книги";
            this.idКнигиDataGridViewTextBoxColumn.Name = "idКнигиDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // названиеКнигиDataGridViewTextBoxColumn
            // 
            this.названиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.Name = "названиеКнигиDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.ppractikDataSet;
            // 
            // ppractikDataSet
            // 
            this.ppractikDataSet.DataSetName = "ppractikDataSet";
            this.ppractikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ssearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iddel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.closed);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppractikDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button closed;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox iddel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ssearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ppractikDataSet ppractikDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private ppractikDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
    }
}

