
namespace SORTEADOR_ONLINE_GRATIS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BItens = new System.Windows.Forms.Button();
            this.BParticipantes = new System.Windows.Forms.Button();
            this.AddParticipante = new System.Windows.Forms.TextBox();
            this.AddItens = new System.Windows.Forms.TextBox();
            this.BSortear = new System.Windows.Forms.Button();
            this.BLimpar = new System.Windows.Forms.Button();
            this.ResultP = new System.Windows.Forms.TextBox();
            this.ResultI = new System.Windows.Forms.TextBox();
            this.ListParticipantes = new System.Windows.Forms.ListView();
            this.ListItens = new System.Windows.Forms.ListView();
            this.Participantes = new System.Windows.Forms.ColumnHeader();
            this.Itens = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // BItens
            // 
            this.BItens.Location = new System.Drawing.Point(607, 80);
            this.BItens.Name = "BItens";
            this.BItens.Size = new System.Drawing.Size(112, 30);
            this.BItens.TabIndex = 0;
            this.BItens.Text = "Add Itens";
            this.BItens.UseVisualStyleBackColor = true;
            this.BItens.Click += new System.EventHandler(this.BItens_Click_1);
            // 
            // BParticipantes
            // 
            this.BParticipantes.Location = new System.Drawing.Point(228, 80);
            this.BParticipantes.Name = "BParticipantes";
            this.BParticipantes.Size = new System.Drawing.Size(112, 30);
            this.BParticipantes.TabIndex = 1;
            this.BParticipantes.Text = "Add Participantes";
            this.BParticipantes.UseVisualStyleBackColor = true;
            this.BParticipantes.Click += new System.EventHandler(this.BParticipantes_Click);
            // 
            // AddParticipante
            // 
            this.AddParticipante.Location = new System.Drawing.Point(12, 85);
            this.AddParticipante.Name = "AddParticipante";
            this.AddParticipante.Size = new System.Drawing.Size(210, 23);
            this.AddParticipante.TabIndex = 2;
            // 
            // AddItens
            // 
            this.AddItens.Location = new System.Drawing.Point(391, 85);
            this.AddItens.Name = "AddItens";
            this.AddItens.Size = new System.Drawing.Size(210, 23);
            this.AddItens.TabIndex = 3;
            this.AddItens.TextChanged += new System.EventHandler(this.AddItens_TextChanged);
            // 
            // BSortear
            // 
            this.BSortear.Location = new System.Drawing.Point(365, 324);
            this.BSortear.Name = "BSortear";
            this.BSortear.Size = new System.Drawing.Size(107, 41);
            this.BSortear.TabIndex = 6;
            this.BSortear.Text = "Sortear";
            this.BSortear.UseVisualStyleBackColor = true;
            this.BSortear.Click += new System.EventHandler(this.BSortear_Click);
            // 
            // BLimpar
            // 
            this.BLimpar.Location = new System.Drawing.Point(252, 324);
            this.BLimpar.Name = "BLimpar";
            this.BLimpar.Size = new System.Drawing.Size(107, 41);
            this.BLimpar.TabIndex = 7;
            this.BLimpar.Text = "Limpar";
            this.BLimpar.UseVisualStyleBackColor = true;
            this.BLimpar.Click += new System.EventHandler(this.BLimpar_Click);
            // 
            // ResultP
            // 
            this.ResultP.Location = new System.Drawing.Point(130, 371);
            this.ResultP.Name = "ResultP";
            this.ResultP.ReadOnly = true;
            this.ResultP.Size = new System.Drawing.Size(210, 23);
            this.ResultP.TabIndex = 8;
            // 
            // ResultI
            // 
            this.ResultI.Location = new System.Drawing.Point(391, 371);
            this.ResultI.Name = "ResultI";
            this.ResultI.ReadOnly = true;
            this.ResultI.Size = new System.Drawing.Size(210, 23);
            this.ResultI.TabIndex = 9;
            // 
            // ListParticipantes
            // 
            this.ListParticipantes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListParticipantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Participantes});
            this.ListParticipantes.GridLines = true;
            this.ListParticipantes.HideSelection = false;
            this.ListParticipantes.HoverSelection = true;
            this.ListParticipantes.Location = new System.Drawing.Point(12, 119);
            this.ListParticipantes.Name = "ListParticipantes";
            this.ListParticipantes.Size = new System.Drawing.Size(328, 199);
            this.ListParticipantes.TabIndex = 12;
            this.ListParticipantes.UseCompatibleStateImageBehavior = false;
            this.ListParticipantes.View = System.Windows.Forms.View.Details;
            // 
            // ListItens
            // 
            this.ListItens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Itens});
            this.ListItens.GridLines = true;
            this.ListItens.HideSelection = false;
            this.ListItens.Location = new System.Drawing.Point(391, 119);
            this.ListItens.Name = "ListItens";
            this.ListItens.Size = new System.Drawing.Size(328, 199);
            this.ListItens.TabIndex = 13;
            this.ListItens.UseCompatibleStateImageBehavior = false;
            this.ListItens.View = System.Windows.Forms.View.Details;
            // 
            // Participantes
            // 
            this.Participantes.Text = "Participantes";
            this.Participantes.Width = 318;
            // 
            // Itens
            // 
            this.Itens.Text = "Itens";
            this.Itens.Width = 319;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 406);
            this.Controls.Add(this.ListItens);
            this.Controls.Add(this.ListParticipantes);
            this.Controls.Add(this.ResultI);
            this.Controls.Add(this.ResultP);
            this.Controls.Add(this.BLimpar);
            this.Controls.Add(this.BSortear);
            this.Controls.Add(this.AddItens);
            this.Controls.Add(this.AddParticipante);
            this.Controls.Add(this.BParticipantes);
            this.Controls.Add(this.BItens);
            this.Name = "Form1";
            this.Text = "Sorteador Online Gratis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BItens;
        private System.Windows.Forms.Button BParticipantes;
        private System.Windows.Forms.TextBox AddParticipante;
        private System.Windows.Forms.TextBox AddItens;
        private System.Windows.Forms.Button BSortear;
        private System.Windows.Forms.Button BLimpar;
        private System.Windows.Forms.TextBox ResultP;
        private System.Windows.Forms.TextBox ResultI;
        private System.Windows.Forms.ListView ListParticipantes;
        private System.Windows.Forms.ColumnHeader Participantes;
        private System.Windows.Forms.ListView ListItens;
        private System.Windows.Forms.ColumnHeader Itens;
    }
}

