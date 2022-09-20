namespace prjRestaurante.visao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProdutos,
            this.mnMesas,
            this.mnComandas,
            this.mnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(92, 528);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnProdutos
            // 
            this.mnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnProdutos.Image")));
            this.mnProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Size = new System.Drawing.Size(79, 35);
            this.mnProdutos.Text = "PRODUTOS";
            this.mnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnMesas
            // 
            this.mnMesas.Image = ((System.Drawing.Image)(resources.GetObject("mnMesas.Image")));
            this.mnMesas.Name = "mnMesas";
            this.mnMesas.Size = new System.Drawing.Size(79, 35);
            this.mnMesas.Text = "MESAS";
            this.mnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnComandas
            // 
            this.mnComandas.Image = ((System.Drawing.Image)(resources.GetObject("mnComandas.Image")));
            this.mnComandas.Name = "mnComandas";
            this.mnComandas.Size = new System.Drawing.Size(79, 35);
            this.mnComandas.Text = "COMANDAS";
            this.mnComandas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnSair
            // 
            this.mnSair.Image = ((System.Drawing.Image)(resources.GetObject("mnSair.Image")));
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(79, 35);
            this.mnSair.Text = "SAIR";
            this.mnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 528);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "CONTROLE DE RESTAURANTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnMesas;
        private System.Windows.Forms.ToolStripMenuItem mnComandas;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
    }
}