namespace Loteria.MA
{
    partial class MegaSena
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
            this.cbNumeros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridNumeros = new System.Windows.Forms.DataGridView();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNum = new System.Windows.Forms.Button();
            this.btnSurpresinha = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gridApostas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tblLoteria = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlMegaSena = new System.Windows.Forms.Panel();
            this.gridNumerosSorteio = new System.Windows.Forms.DataGridView();
            this.gridConsultaAcertos = new System.Windows.Forms.DataGridView();
            this.btnSortear = new System.Windows.Forms.Button();
            this.btnConsultaAcertos = new System.Windows.Forms.Button();
            this.NumeroSorteio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerosFormatados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerosAposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeAcerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridApostas)).BeginInit();
            this.tblLoteria.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMegaSena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumerosSorteio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaAcertos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNumeros
            // 
            this.cbNumeros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNumeros.FormattingEnabled = true;
            this.cbNumeros.Location = new System.Drawing.Point(32, 53);
            this.cbNumeros.Name = "cbNumeros";
            this.cbNumeros.Size = new System.Drawing.Size(121, 21);
            this.cbNumeros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha os Números:";
            // 
            // gridNumeros
            // 
            this.gridNumeros.AllowUserToAddRows = false;
            this.gridNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Del});
            this.gridNumeros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridNumeros.Location = new System.Drawing.Point(32, 81);
            this.gridNumeros.Name = "gridNumeros";
            this.gridNumeros.Size = new System.Drawing.Size(213, 178);
            this.gridNumeros.TabIndex = 2;
            this.gridNumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNumeros_CellContentClick);
            // 
            // Del
            // 
            this.Del.HeaderText = "Del";
            this.Del.Name = "Del";
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Del.Text = "D";
            this.Del.UseColumnTextForButtonValue = true;
            this.Del.Width = 70;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // btnAddNum
            // 
            this.btnAddNum.Location = new System.Drawing.Point(251, 81);
            this.btnAddNum.Name = "btnAddNum";
            this.btnAddNum.Size = new System.Drawing.Size(95, 23);
            this.btnAddNum.TabIndex = 3;
            this.btnAddNum.Text = "Add Nº";
            this.btnAddNum.UseVisualStyleBackColor = true;
            this.btnAddNum.Click += new System.EventHandler(this.btnAddNum_Click);
            // 
            // btnSurpresinha
            // 
            this.btnSurpresinha.Location = new System.Drawing.Point(251, 110);
            this.btnSurpresinha.Name = "btnSurpresinha";
            this.btnSurpresinha.Size = new System.Drawing.Size(95, 23);
            this.btnSurpresinha.TabIndex = 4;
            this.btnSurpresinha.Text = "Surpresinha";
            this.btnSurpresinha.UseVisualStyleBackColor = true;
            this.btnSurpresinha.Click += new System.EventHandler(this.btnSurpresinha_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(251, 236);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gridApostas
            // 
            this.gridApostas.AllowUserToAddRows = false;
            this.gridApostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridApostas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Data,
            this.NumerosFormatados});
            this.gridApostas.Location = new System.Drawing.Point(359, 81);
            this.gridApostas.Name = "gridApostas";
            this.gridApostas.Size = new System.Drawing.Size(417, 178);
            this.gridApostas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apostas Cadastradas:";
            // 
            // tblLoteria
            // 
            this.tblLoteria.Controls.Add(this.tabPage1);
            this.tblLoteria.Controls.Add(this.tabPage2);
            this.tblLoteria.Location = new System.Drawing.Point(-1, -1);
            this.tblLoteria.Name = "tblLoteria";
            this.tblLoteria.SelectedIndex = 0;
            this.tblLoteria.Size = new System.Drawing.Size(849, 376);
            this.tblLoteria.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConsultaAcertos);
            this.tabPage2.Controls.Add(this.btnSortear);
            this.tabPage2.Controls.Add(this.gridConsultaAcertos);
            this.tabPage2.Controls.Add(this.gridNumerosSorteio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorteio MegaSena";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlMegaSena);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aposta MegaSena";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlMegaSena
            // 
            this.pnlMegaSena.Controls.Add(this.label2);
            this.pnlMegaSena.Controls.Add(this.gridApostas);
            this.pnlMegaSena.Controls.Add(this.btnCadastrar);
            this.pnlMegaSena.Controls.Add(this.btnSurpresinha);
            this.pnlMegaSena.Controls.Add(this.btnAddNum);
            this.pnlMegaSena.Controls.Add(this.gridNumeros);
            this.pnlMegaSena.Controls.Add(this.label1);
            this.pnlMegaSena.Controls.Add(this.cbNumeros);
            this.pnlMegaSena.Location = new System.Drawing.Point(6, 2);
            this.pnlMegaSena.Name = "pnlMegaSena";
            this.pnlMegaSena.Size = new System.Drawing.Size(826, 340);
            this.pnlMegaSena.TabIndex = 0;
            // 
            // gridNumerosSorteio
            // 
            this.gridNumerosSorteio.AllowUserToAddRows = false;
            this.gridNumerosSorteio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNumerosSorteio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroSorteio});
            this.gridNumerosSorteio.Location = new System.Drawing.Point(44, 62);
            this.gridNumerosSorteio.Name = "gridNumerosSorteio";
            this.gridNumerosSorteio.Size = new System.Drawing.Size(145, 211);
            this.gridNumerosSorteio.TabIndex = 0;
            // 
            // gridConsultaAcertos
            // 
            this.gridConsultaAcertos.AllowUserToAddRows = false;
            this.gridConsultaAcertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultaAcertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aposta,
            this.DataAposta,
            this.NumerosAposta,
            this.QuantidadeAcerto});
            this.gridConsultaAcertos.Location = new System.Drawing.Point(315, 62);
            this.gridConsultaAcertos.Name = "gridConsultaAcertos";
            this.gridConsultaAcertos.Size = new System.Drawing.Size(498, 211);
            this.gridConsultaAcertos.TabIndex = 1;
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(44, 33);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(75, 23);
            this.btnSortear.TabIndex = 2;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // btnConsultaAcertos
            // 
            this.btnConsultaAcertos.Enabled = false;
            this.btnConsultaAcertos.Location = new System.Drawing.Point(315, 33);
            this.btnConsultaAcertos.Name = "btnConsultaAcertos";
            this.btnConsultaAcertos.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaAcertos.TabIndex = 3;
            this.btnConsultaAcertos.Text = "Consultar Acertos";
            this.btnConsultaAcertos.UseVisualStyleBackColor = true;
            this.btnConsultaAcertos.Click += new System.EventHandler(this.btnConsultaAcertos_Click);
            // 
            // NumeroSorteio
            // 
            this.NumeroSorteio.HeaderText = "Numero";
            this.NumeroSorteio.Name = "NumeroSorteio";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 150;
            // 
            // NumerosFormatados
            // 
            this.NumerosFormatados.HeaderText = "Números";
            this.NumerosFormatados.Name = "NumerosFormatados";
            this.NumerosFormatados.Width = 150;
            // 
            // Aposta
            // 
            this.Aposta.HeaderText = "Aposta";
            this.Aposta.Name = "Aposta";
            this.Aposta.Width = 70;
            // 
            // DataAposta
            // 
            this.DataAposta.HeaderText = "Data";
            this.DataAposta.Name = "DataAposta";
            this.DataAposta.Width = 150;
            // 
            // NumerosAposta
            // 
            this.NumerosAposta.HeaderText = "Números";
            this.NumerosAposta.Name = "NumerosAposta";
            this.NumerosAposta.Width = 150;
            // 
            // QuantidadeAcerto
            // 
            this.QuantidadeAcerto.HeaderText = "Acertos";
            this.QuantidadeAcerto.Name = "QuantidadeAcerto";
            this.QuantidadeAcerto.Width = 60;
            // 
            // MegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 375);
            this.Controls.Add(this.tblLoteria);
            this.Name = "MegaSena";
            this.Text = "MegaSena";
            ((System.ComponentModel.ISupportInitialize)(this.gridNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridApostas)).EndInit();
            this.tblLoteria.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlMegaSena.ResumeLayout(false);
            this.pnlMegaSena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumerosSorteio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaAcertos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.Button btnAddNum;
        private System.Windows.Forms.Button btnSurpresinha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView gridApostas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tblLoteria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlMegaSena;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConsultaAcertos;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.DataGridView gridConsultaAcertos;
        private System.Windows.Forms.DataGridView gridNumerosSorteio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSorteio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerosFormatados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerosAposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeAcerto;
    }
}