namespace BelosAutomoveisProjeto
{
    partial class CategoriasAdicionarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriasAdicionarForm));
            carroBtn = new Button();
            camiaoBtn = new Button();
            motaBtn = new Button();
            camionetaBtn = new Button();
            cancelarBtn = new Button();
            SuspendLayout();
            // 
            // carroBtn
            // 
            carroBtn.BackColor = Color.Transparent;
            carroBtn.FlatAppearance.BorderSize = 0;
            carroBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            carroBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            carroBtn.FlatStyle = FlatStyle.Flat;
            carroBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            carroBtn.ForeColor = SystemColors.Control;
            carroBtn.Location = new Point(122, 90);
            carroBtn.Name = "carroBtn";
            carroBtn.Size = new Size(92, 39);
            carroBtn.TabIndex = 13;
            carroBtn.UseVisualStyleBackColor = false;
            carroBtn.Click += carroBtn_Click;
            // 
            // camiaoBtn
            // 
            camiaoBtn.BackColor = Color.Transparent;
            camiaoBtn.FlatAppearance.BorderSize = 0;
            camiaoBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            camiaoBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            camiaoBtn.FlatStyle = FlatStyle.Flat;
            camiaoBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            camiaoBtn.ForeColor = SystemColors.Control;
            camiaoBtn.Location = new Point(235, 90);
            camiaoBtn.Name = "camiaoBtn";
            camiaoBtn.Size = new Size(108, 39);
            camiaoBtn.TabIndex = 14;
            camiaoBtn.UseVisualStyleBackColor = false;
            camiaoBtn.Click += camiaoBtn_Click;
            // 
            // motaBtn
            // 
            motaBtn.BackColor = Color.Transparent;
            motaBtn.FlatAppearance.BorderSize = 0;
            motaBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            motaBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            motaBtn.FlatStyle = FlatStyle.Flat;
            motaBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            motaBtn.ForeColor = SystemColors.Control;
            motaBtn.Location = new Point(509, 90);
            motaBtn.Name = "motaBtn";
            motaBtn.Size = new Size(92, 39);
            motaBtn.TabIndex = 15;
            motaBtn.UseVisualStyleBackColor = false;
            motaBtn.Click += motaBtn_Click;
            // 
            // camionetaBtn
            // 
            camionetaBtn.BackColor = Color.Transparent;
            camionetaBtn.FlatAppearance.BorderSize = 0;
            camionetaBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            camionetaBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            camionetaBtn.FlatStyle = FlatStyle.Flat;
            camionetaBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            camionetaBtn.ForeColor = SystemColors.Control;
            camionetaBtn.Location = new Point(364, 90);
            camionetaBtn.Name = "camionetaBtn";
            camionetaBtn.Size = new Size(123, 39);
            camionetaBtn.TabIndex = 16;
            camionetaBtn.UseVisualStyleBackColor = false;
            camionetaBtn.Click += camionetaBtn_Click;
            // 
            // cancelarBtn
            // 
            cancelarBtn.BackColor = Color.Transparent;
            cancelarBtn.FlatAppearance.BorderSize = 0;
            cancelarBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cancelarBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cancelarBtn.FlatStyle = FlatStyle.Flat;
            cancelarBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelarBtn.ForeColor = SystemColors.Control;
            cancelarBtn.Location = new Point(262, 163);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(197, 46);
            cancelarBtn.TabIndex = 17;
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += button4_Click;
            // 
            // CategoriasAdicionarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(709, 221);
            Controls.Add(cancelarBtn);
            Controls.Add(camionetaBtn);
            Controls.Add(motaBtn);
            Controls.Add(camiaoBtn);
            Controls.Add(carroBtn);
            Name = "CategoriasAdicionarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriasAdicionarForm";
            ResumeLayout(false);
        }

        #endregion

        private Button carroBtn;
        private Button camiaoBtn;
        private Button motaBtn;
        private Button camionetaBtn;
        private Button cancelarBtn;
    }
}