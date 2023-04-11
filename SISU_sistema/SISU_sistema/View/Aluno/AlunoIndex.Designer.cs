
namespace SISU_sistema.View.Aluno
{
    partial class AlunoIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.pront1 = new System.Windows.Forms.Button();
            this.ListaAlunos = new System.Windows.Forms.ListBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Erase1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão de Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(92, 81);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(248, 23);
            this.txtnome.TabIndex = 2;
            // 
            // pront1
            // 
            this.pront1.Location = new System.Drawing.Point(357, 83);
            this.pront1.Name = "pront1";
            this.pront1.Size = new System.Drawing.Size(75, 23);
            this.pront1.TabIndex = 3;
            this.pront1.Text = "Pronto";
            this.pront1.UseVisualStyleBackColor = true;
            this.pront1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaAlunos
            // 
            this.ListaAlunos.FormattingEnabled = true;
            this.ListaAlunos.ItemHeight = 15;
            this.ListaAlunos.Location = new System.Drawing.Point(92, 124);
            this.ListaAlunos.Name = "ListaAlunos";
            this.ListaAlunos.Size = new System.Drawing.Size(248, 154);
            this.ListaAlunos.TabIndex = 4;
            this.ListaAlunos.SelectedIndexChanged += new System.EventHandler(this.ListaAlunos_SelectedIndexChanged);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(92, 294);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(248, 84);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Erase1
            // 
            this.Erase1.Location = new System.Drawing.Point(483, 79);
            this.Erase1.Name = "Erase1";
            this.Erase1.Size = new System.Drawing.Size(80, 26);
            this.Erase1.TabIndex = 6;
            this.Erase1.Text = "Apagar";
            this.Erase1.UseVisualStyleBackColor = true;
            this.Erase1.Click += new System.EventHandler(this.Load_Click);
            // 
            // AlunoIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Erase1);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.ListaAlunos);
            this.Controls.Add(this.pront1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlunoIndex";
            this.Text = "AlunoIndex";
            this.Load += new System.EventHandler(this.AlunoIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button pront1;
        private System.Windows.Forms.ListBox ListaAlunos;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button Erase1;
    }
}