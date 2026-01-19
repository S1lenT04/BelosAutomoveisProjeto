namespace BelosAutomoveisProjeto
{
    partial class VeiculoListItem
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiculoListItem));
            matriculatxt = new Label();
            marcatxt = new Label();
            modelotxt = new Label();
            anotxt = new Label();
            precotxt = new Label();
            datatxt = new Label();
            estadoImg = new PictureBox();
            categoriaImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)estadoImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaImg).BeginInit();
            SuspendLayout();
            // 
            // matriculatxt
            // 
            matriculatxt.AutoSize = true;
            matriculatxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            matriculatxt.ForeColor = Color.White;
            matriculatxt.Location = new Point(146, 24);
            matriculatxt.Name = "matriculatxt";
            matriculatxt.Size = new Size(22, 25);
            matriculatxt.TabIndex = 0;
            matriculatxt.Text = "1";
            // 
            // marcatxt
            // 
            marcatxt.AutoSize = true;
            marcatxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            marcatxt.ForeColor = Color.White;
            marcatxt.Location = new Point(332, 24);
            marcatxt.Name = "marcatxt";
            marcatxt.Size = new Size(22, 25);
            marcatxt.TabIndex = 1;
            marcatxt.Text = "1";
            // 
            // modelotxt
            // 
            modelotxt.AutoSize = true;
            modelotxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            modelotxt.ForeColor = Color.White;
            modelotxt.Location = new Point(536, 24);
            modelotxt.Name = "modelotxt";
            modelotxt.Size = new Size(22, 25);
            modelotxt.TabIndex = 2;
            modelotxt.Text = "1";
            // 
            // anotxt
            // 
            anotxt.AutoSize = true;
            anotxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            anotxt.ForeColor = Color.White;
            anotxt.Location = new Point(750, 24);
            anotxt.Name = "anotxt";
            anotxt.Size = new Size(22, 25);
            anotxt.TabIndex = 3;
            anotxt.Text = "1";
            // 
            // precotxt
            // 
            precotxt.AutoSize = true;
            precotxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            precotxt.ForeColor = Color.White;
            precotxt.Location = new Point(925, 24);
            precotxt.Name = "precotxt";
            precotxt.Size = new Size(22, 25);
            precotxt.TabIndex = 4;
            precotxt.Text = "1";
            // 
            // datatxt
            // 
            datatxt.AutoSize = true;
            datatxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            datatxt.ForeColor = Color.White;
            datatxt.Location = new Point(1101, 24);
            datatxt.Name = "datatxt";
            datatxt.Size = new Size(22, 25);
            datatxt.TabIndex = 5;
            datatxt.Text = "1";
            // 
            // estadoImg
            // 
            estadoImg.Location = new Point(19, 30);
            estadoImg.Name = "estadoImg";
            estadoImg.Size = new Size(18, 18);
            estadoImg.TabIndex = 6;
            estadoImg.TabStop = false;
            // 
            // categoriaImg
            // 
            categoriaImg.Location = new Point(55, 26);
            categoriaImg.Name = "categoriaImg";
            categoriaImg.Size = new Size(27, 25);
            categoriaImg.TabIndex = 7;
            categoriaImg.TabStop = false;
            categoriaImg.Click += pictureBox2_Click;
            // 
            // VeiculoListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(categoriaImg);
            Controls.Add(estadoImg);
            Controls.Add(datatxt);
            Controls.Add(precotxt);
            Controls.Add(anotxt);
            Controls.Add(modelotxt);
            Controls.Add(marcatxt);
            Controls.Add(matriculatxt);
            Name = "VeiculoListItem";
            Size = new Size(1424, 76);
            ((System.ComponentModel.ISupportInitialize)estadoImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label matriculatxt;
        private Label marcatxt;
        private Label modelotxt;
        private Label anotxt;
        private Label precotxt;
        private Label datatxt;
        private PictureBox estadoImg;
        private PictureBox categoriaImg;
    }
}
