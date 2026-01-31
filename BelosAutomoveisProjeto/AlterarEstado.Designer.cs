namespace BelosAutomoveisProjeto
{
    partial class AlterarEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarEstado));
            selectVeiculos = new ComboBox();
            estadoCombo = new ComboBox();
            criarReservaBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // selectVeiculos
            // 
            selectVeiculos.DropDownStyle = ComboBoxStyle.DropDownList;
            selectVeiculos.ForeColor = Color.Black;
            selectVeiculos.FormattingEnabled = true;
            selectVeiculos.Location = new Point(63, 133);
            selectVeiculos.Name = "selectVeiculos";
            selectVeiculos.Size = new Size(595, 23);
            selectVeiculos.TabIndex = 3;
            // 
            // estadoCombo
            // 
            estadoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            estadoCombo.ForeColor = Color.Black;
            estadoCombo.FormattingEnabled = true;
            estadoCombo.Items.AddRange(new object[] { "Disponível", "Reservado", "Manutenção", "Alugado" });
            estadoCombo.Location = new Point(63, 213);
            estadoCombo.Name = "estadoCombo";
            estadoCombo.Size = new Size(595, 23);
            estadoCombo.TabIndex = 4;
            // 
            // criarReservaBtn
            // 
            criarReservaBtn.BackColor = Color.Transparent;
            criarReservaBtn.FlatAppearance.BorderSize = 0;
            criarReservaBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            criarReservaBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            criarReservaBtn.FlatStyle = FlatStyle.Flat;
            criarReservaBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            criarReservaBtn.ForeColor = SystemColors.Control;
            criarReservaBtn.Location = new Point(371, 352);
            criarReservaBtn.Name = "criarReservaBtn";
            criarReservaBtn.Size = new Size(206, 46);
            criarReservaBtn.TabIndex = 44;
            criarReservaBtn.UseVisualStyleBackColor = false;
            criarReservaBtn.Click += criarReservaBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Transparent;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.ForeColor = SystemColors.Control;
            cancelBtn.Location = new Point(142, 352);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(206, 46);
            cancelBtn.TabIndex = 43;
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AlterarEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(704, 417);
            Controls.Add(criarReservaBtn);
            Controls.Add(cancelBtn);
            Controls.Add(estadoCombo);
            Controls.Add(selectVeiculos);
            Name = "AlterarEstado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarEstado";
            Load += AlterarEstado_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox selectVeiculos;
        private ComboBox estadoCombo;
        private Button criarReservaBtn;
        private Button cancelBtn;
    }
}