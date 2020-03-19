namespace NotasDaEscola
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdicionarDis = new System.Windows.Forms.Button();
            this.btnExcluirDis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trimestre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trimestre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trimestre3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recuperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprovacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditarDis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarDis
            // 
            this.btnAdicionarDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarDis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionarDis.Location = new System.Drawing.Point(6, 19);
            this.btnAdicionarDis.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarDis.Name = "btnAdicionarDis";
            this.btnAdicionarDis.Size = new System.Drawing.Size(179, 49);
            this.btnAdicionarDis.TabIndex = 2;
            this.btnAdicionarDis.Text = "Adicionar Nova Disciplina";
            this.btnAdicionarDis.UseVisualStyleBackColor = true;
            this.btnAdicionarDis.Click += new System.EventHandler(this.btnAdicionarDis_Click);
            // 
            // btnExcluirDis
            // 
            this.btnExcluirDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirDis.Location = new System.Drawing.Point(399, 19);
            this.btnExcluirDis.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirDis.Name = "btnExcluirDis";
            this.btnExcluirDis.Size = new System.Drawing.Size(214, 49);
            this.btnExcluirDis.TabIndex = 3;
            this.btnExcluirDis.Text = "Excluir Disciplina Selecionada";
            this.btnExcluirDis.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Disciplina,
            this.Trimestre1,
            this.Trimestre2,
            this.Trimestre3,
            this.Recuperacao,
            this.Media,
            this.Total,
            this.Aprovacao});
            this.dataGridView1.Location = new System.Drawing.Point(6, 71);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 412);
            this.dataGridView1.TabIndex = 4;
            // 
            // Disciplina
            // 
            this.Disciplina.HeaderText = "Disciplina";
            this.Disciplina.MinimumWidth = 155;
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.ReadOnly = true;
            this.Disciplina.Width = 155;
            // 
            // Trimestre1
            // 
            this.Trimestre1.HeaderText = "Primeiro Trimestre";
            this.Trimestre1.MinimumWidth = 155;
            this.Trimestre1.Name = "Trimestre1";
            this.Trimestre1.Width = 155;
            // 
            // Trimestre2
            // 
            this.Trimestre2.HeaderText = "Segundo Trimestre";
            this.Trimestre2.MinimumWidth = 155;
            this.Trimestre2.Name = "Trimestre2";
            this.Trimestre2.Width = 155;
            // 
            // Trimestre3
            // 
            this.Trimestre3.HeaderText = "Terceiro Trimestre";
            this.Trimestre3.MinimumWidth = 155;
            this.Trimestre3.Name = "Trimestre3";
            this.Trimestre3.Width = 155;
            // 
            // Recuperacao
            // 
            this.Recuperacao.HeaderText = "Recuperação";
            this.Recuperacao.MinimumWidth = 100;
            this.Recuperacao.Name = "Recuperacao";
            // 
            // Media
            // 
            this.Media.HeaderText = "Média";
            this.Media.MinimumWidth = 100;
            this.Media.Name = "Media";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 100;
            this.Total.Name = "Total";
            // 
            // Aprovacao
            // 
            this.Aprovacao.HeaderText = "Aprovação";
            this.Aprovacao.MinimumWidth = 100;
            this.Aprovacao.Name = "Aprovacao";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnEditarDis);
            this.groupBox2.Controls.Add(this.btnExcluirDis);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnAdicionarDis);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1075, 492);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disciplinas";
            // 
            // btnEditarDis
            // 
            this.btnEditarDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarDis.Location = new System.Drawing.Point(185, 19);
            this.btnEditarDis.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarDis.Name = "btnEditarDis";
            this.btnEditarDis.Size = new System.Drawing.Size(214, 49);
            this.btnEditarDis.TabIndex = 5;
            this.btnEditarDis.Text = "Editar Disciplina Selecionada";
            this.btnEditarDis.UseVisualStyleBackColor = true;
            this.btnEditarDis.Click += new System.EventHandler(this.btnEditarDis_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 507);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas da Escola";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionarDis;
        private System.Windows.Forms.Button btnExcluirDis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trimestre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trimestre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trimestre3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recuperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Media;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprovacao;
        private System.Windows.Forms.Button btnEditarDis;
        private System.Windows.Forms.Timer timer2;
    }
}

