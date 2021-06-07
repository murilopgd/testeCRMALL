namespace TesteCRMALL_Murilo
{
    partial class FormCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroClientes));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLocalizar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.TxtCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.DtpDataNascimentoCliente = new System.Windows.Forms.DateTimePicker();
            this.CbSexoCliente = new System.Windows.Forms.ComboBox();
            this.TxtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNumeroCliente = new System.Windows.Forms.TextBox();
            this.TxtBairroCliente = new System.Windows.Forms.TextBox();
            this.TxtComplementoCliente = new System.Windows.Forms.TextBox();
            this.CbEstadoCliente = new System.Windows.Forms.ComboBox();
            this.TxtCidadeCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.BtnExcluir, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnCancelar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnLocalizar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNovo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnGravar, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(428, 6);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 43);
            this.BtnExcluir.TabIndex = 22;
            this.BtnExcluir.TabStop = false;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(3, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 43);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.TabStop = false;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLocalizar
            // 
            this.BtnLocalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLocalizar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocalizar.ForeColor = System.Drawing.Color.Navy;
            this.BtnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLocalizar.Image")));
            this.BtnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLocalizar.Location = new System.Drawing.Point(109, 6);
            this.BtnLocalizar.Name = "BtnLocalizar";
            this.BtnLocalizar.Size = new System.Drawing.Size(100, 43);
            this.BtnLocalizar.TabIndex = 18;
            this.BtnLocalizar.TabStop = false;
            this.BtnLocalizar.Text = "Localizar";
            this.BtnLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLocalizar.UseVisualStyleBackColor = true;
            this.BtnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovo.Location = new System.Drawing.Point(215, 6);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(100, 43);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGravar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGravar.Image")));
            this.BtnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravar.Location = new System.Drawing.Point(321, 6);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(100, 43);
            this.BtnGravar.TabIndex = 50;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // TxtCepCliente
            // 
            this.TxtCepCliente.Location = new System.Drawing.Point(3, 70);
            this.TxtCepCliente.Mask = "00000-999";
            this.TxtCepCliente.Name = "TxtCepCliente";
            this.TxtCepCliente.Size = new System.Drawing.Size(97, 20);
            this.TxtCepCliente.TabIndex = 3;
            this.TxtCepCliente.Leave += new System.EventHandler(this.TxtCepCliente_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtCidadeCliente, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.CbEstadoCliente, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.TxtComplementoCliente, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtNumeroCliente, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtBairroCliente, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtEnderecoCliente, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CbSexoCliente, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtCepCliente, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DtpDataNascimentoCliente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtNomeCliente, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeCliente.Location = new System.Drawing.Point(3, 23);
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.Size = new System.Drawing.Size(255, 20);
            this.TxtNomeCliente.TabIndex = 0;
            // 
            // DtpDataNascimentoCliente
            // 
            this.DtpDataNascimentoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataNascimentoCliente.Location = new System.Drawing.Point(264, 23);
            this.DtpDataNascimentoCliente.Name = "DtpDataNascimentoCliente";
            this.DtpDataNascimentoCliente.Size = new System.Drawing.Size(102, 20);
            this.DtpDataNascimentoCliente.TabIndex = 1;
            // 
            // CbSexoCliente
            // 
            this.CbSexoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSexoCliente.FormattingEnabled = true;
            this.CbSexoCliente.Items.AddRange(new object[] {
            "Maculino",
            "Feminino"});
            this.CbSexoCliente.Location = new System.Drawing.Point(394, 23);
            this.CbSexoCliente.Name = "CbSexoCliente";
            this.CbSexoCliente.Size = new System.Drawing.Size(121, 21);
            this.CbSexoCliente.TabIndex = 2;
            // 
            // TxtEnderecoCliente
            // 
            this.TxtEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEnderecoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEnderecoCliente.Location = new System.Drawing.Point(3, 117);
            this.TxtEnderecoCliente.Name = "TxtEnderecoCliente";
            this.TxtEnderecoCliente.Size = new System.Drawing.Size(255, 20);
            this.TxtEnderecoCliente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bairro";
            // 
            // TxtNumeroCliente
            // 
            this.TxtNumeroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumeroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumeroCliente.Location = new System.Drawing.Point(264, 117);
            this.TxtNumeroCliente.Name = "TxtNumeroCliente";
            this.TxtNumeroCliente.Size = new System.Drawing.Size(124, 20);
            this.TxtNumeroCliente.TabIndex = 5;
            // 
            // TxtBairroCliente
            // 
            this.TxtBairroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBairroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBairroCliente.Location = new System.Drawing.Point(394, 117);
            this.TxtBairroCliente.Name = "TxtBairroCliente";
            this.TxtBairroCliente.Size = new System.Drawing.Size(126, 20);
            this.TxtBairroCliente.TabIndex = 6;
            // 
            // TxtComplementoCliente
            // 
            this.TxtComplementoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtComplementoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComplementoCliente.Location = new System.Drawing.Point(3, 164);
            this.TxtComplementoCliente.Name = "TxtComplementoCliente";
            this.TxtComplementoCliente.Size = new System.Drawing.Size(255, 20);
            this.TxtComplementoCliente.TabIndex = 7;
            // 
            // CbEstadoCliente
            // 
            this.CbEstadoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstadoCliente.FormattingEnabled = true;
            this.CbEstadoCliente.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.CbEstadoCliente.Location = new System.Drawing.Point(264, 211);
            this.CbEstadoCliente.Name = "CbEstadoCliente";
            this.CbEstadoCliente.Size = new System.Drawing.Size(121, 21);
            this.CbEstadoCliente.TabIndex = 9;
            // 
            // TxtCidadeCliente
            // 
            this.TxtCidadeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCidadeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCidadeCliente.Location = new System.Drawing.Point(3, 211);
            this.TxtCidadeCliente.Name = "TxtCidadeCliente";
            this.TxtCidadeCliente.Size = new System.Drawing.Size(255, 20);
            this.TxtCidadeCliente.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Complemento";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Estado";
            // 
            // FormCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormCadastroClientes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FormCadastroClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroClientes_KeyDown);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLocalizar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.MaskedTextBox TxtCepCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEnderecoCliente;
        private System.Windows.Forms.ComboBox CbSexoCliente;
        private System.Windows.Forms.DateTimePicker DtpDataNascimentoCliente;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCidadeCliente;
        private System.Windows.Forms.ComboBox CbEstadoCliente;
        private System.Windows.Forms.TextBox TxtComplementoCliente;
        private System.Windows.Forms.TextBox TxtNumeroCliente;
        private System.Windows.Forms.TextBox TxtBairroCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}