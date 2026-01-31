namespace BelosAutomoveisProjeto
{
    partial class Faturação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faturação));
            calcularFaturacaoBtn = new Button();
            cancelBtn = new Button();
            faturacaoPrecoLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // calcularFaturacaoBtn
            // 
            calcularFaturacaoBtn.BackColor = Color.Transparent;
            calcularFaturacaoBtn.FlatAppearance.BorderSize = 0;
            calcularFaturacaoBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            calcularFaturacaoBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            calcularFaturacaoBtn.FlatStyle = FlatStyle.Flat;
            calcularFaturacaoBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            calcularFaturacaoBtn.ForeColor = SystemColors.Control;
            calcularFaturacaoBtn.Location = new Point(371, 350);
            calcularFaturacaoBtn.Name = "calcularFaturacaoBtn";
            calcularFaturacaoBtn.Size = new Size(206, 46);
            calcularFaturacaoBtn.TabIndex = 44;
            calcularFaturacaoBtn.UseVisualStyleBackColor = false;
            calcularFaturacaoBtn.Click += calcularFaturacaoBtn_Click;
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
            cancelBtn.Location = new Point(142, 350);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(206, 46);
            cancelBtn.TabIndex = 43;
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // faturacaoPrecoLabel
            // 
            faturacaoPrecoLabel.AutoSize = true;
            faturacaoPrecoLabel.BackColor = Color.Transparent;
            faturacaoPrecoLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            faturacaoPrecoLabel.ForeColor = Color.White;
            faturacaoPrecoLabel.Location = new Point(328, 277);
            faturacaoPrecoLabel.Name = "faturacaoPrecoLabel";
            faturacaoPrecoLabel.Size = new Size(61, 25);
            faturacaoPrecoLabel.TabIndex = 45;
            faturacaoPrecoLabel.Text = "label1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(65, 134);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(593, 23);
            dateTimePicker1.TabIndex = 46;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(65, 213);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(593, 23);
            dateTimePicker2.TabIndex = 47;
            // 
            // Faturação
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(704, 418);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(faturacaoPrecoLabel);
            Controls.Add(calcularFaturacaoBtn);
            Controls.Add(cancelBtn);
            Name = "Faturação";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faturação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcularFaturacaoBtn;
        private Button cancelBtn;
        private Label faturacaoPrecoLabel;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}