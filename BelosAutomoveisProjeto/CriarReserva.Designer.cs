namespace BelosAutomoveisProjeto
{
    partial class CriarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarReserva));
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            selectVeiculos = new ComboBox();
            calcPrecoBtn = new Button();
            cancelBtn = new Button();
            criarReservaBtn = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(63, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(380, 206);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(278, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // selectVeiculos
            // 
            selectVeiculos.ForeColor = Color.Black;
            selectVeiculos.FormattingEnabled = true;
            selectVeiculos.Location = new Point(63, 133);
            selectVeiculos.Name = "selectVeiculos";
            selectVeiculos.Size = new Size(595, 23);
            selectVeiculos.TabIndex = 2;
            // 
            // calcPrecoBtn
            // 
            calcPrecoBtn.BackColor = Color.Transparent;
            calcPrecoBtn.FlatAppearance.BorderSize = 0;
            calcPrecoBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            calcPrecoBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            calcPrecoBtn.FlatStyle = FlatStyle.Flat;
            calcPrecoBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            calcPrecoBtn.ForeColor = SystemColors.Control;
            calcPrecoBtn.Location = new Point(256, 362);
            calcPrecoBtn.Name = "calcPrecoBtn";
            calcPrecoBtn.Size = new Size(206, 46);
            calcPrecoBtn.TabIndex = 40;
            calcPrecoBtn.UseVisualStyleBackColor = false;
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
            cancelBtn.Location = new Point(143, 440);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(206, 46);
            cancelBtn.TabIndex = 41;
            cancelBtn.UseVisualStyleBackColor = false;
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
            criarReservaBtn.Location = new Point(372, 440);
            criarReservaBtn.Name = "criarReservaBtn";
            criarReservaBtn.Size = new Size(206, 46);
            criarReservaBtn.TabIndex = 42;
            criarReservaBtn.UseVisualStyleBackColor = false;
            // 
            // CriarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(704, 501);
            Controls.Add(criarReservaBtn);
            Controls.Add(cancelBtn);
            Controls.Add(calcPrecoBtn);
            Controls.Add(selectVeiculos);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "CriarReserva";
            Text = "CriarReserva";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox selectVeiculos;
        private Button calcPrecoBtn;
        private Button cancelBtn;
        private Button criarReservaBtn;
    }
}