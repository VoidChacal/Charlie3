
namespace Livre
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizacao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.curiosidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.info1 = new System.Windows.Forms.RichTextBox();
            this.loading = new System.Windows.Forms.Button();
            this.info2 = new System.Windows.Forms.RichTextBox();
            this.loading2 = new System.Windows.Forms.Button();
            this.info3 = new System.Windows.Forms.RichTextBox();
            this.voltar1 = new System.Windows.Forms.Button();
            this.voltar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(607, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aaaaToolStripMenuItem
            // 
            this.aaaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localizacao,
            this.toolStripSeparator1,
            this.curiosidadesToolStripMenuItem});
            this.aaaaToolStripMenuItem.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9F);
            this.aaaaToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.aaaaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.aaaaToolStripMenuItem.Name = "aaaaToolStripMenuItem";
            this.aaaaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.aaaaToolStripMenuItem.Text = "Index";
            this.aaaaToolStripMenuItem.Click += new System.EventHandler(this.aaaaToolStripMenuItem_Click);
            // 
            // localizacao
            // 
            this.localizacao.Name = "localizacao";
            this.localizacao.Size = new System.Drawing.Size(180, 22);
            this.localizacao.Text = "Localização";
            this.localizacao.Click += new System.EventHandler(this.aaaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // curiosidadesToolStripMenuItem
            // 
            this.curiosidadesToolStripMenuItem.Name = "curiosidadesToolStripMenuItem";
            this.curiosidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.curiosidadesToolStripMenuItem.Text = "Curiosidades";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
            this.progressbar.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.info1.Location = new System.Drawing.Point(53, 37);
            this.info1.Name = "info1";
            this.info1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.info1.Size = new System.Drawing.Size(424, 201);
            this.info1.TabIndex = 5;
            this.info1.Text = resources.GetString("info1.Text");
            this.info1.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(631, 366);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(124, 42);
            this.loading.TabIndex = 6;
            this.loading.Text = "click1";
            this.loading.UseVisualStyleBackColor = true;
            this.loading.Click += new System.EventHandler(this.loading_Click);
            // 
            // info2
            // 
            this.info2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.info2.Location = new System.Drawing.Point(53, 78);
            this.info2.Name = "info2";
            this.info2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.info2.Size = new System.Drawing.Size(424, 330);
            this.info2.TabIndex = 7;
            this.info2.Text = resources.GetString("info2.Text");
            this.info2.Visible = false;
            this.info2.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // loading2
            // 
            this.loading2.Location = new System.Drawing.Point(492, 366);
            this.loading2.Name = "loading2";
            this.loading2.Size = new System.Drawing.Size(124, 42);
            this.loading2.TabIndex = 8;
            this.loading2.Text = "click2";
            this.loading2.UseVisualStyleBackColor = true;
            this.loading2.Visible = false;
            this.loading2.Click += new System.EventHandler(this.loading2_Click);
            // 
            // info3
            // 
            this.info3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.info3.Location = new System.Drawing.Point(53, 141);
            this.info3.Name = "info3";
            this.info3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.info3.Size = new System.Drawing.Size(424, 166);
            this.info3.TabIndex = 9;
            this.info3.Text = "Sua alimentação é composta de 54% carne e 46% de vegetais. Alimenta-se de frutas," +
    " plantas, invertebrados, répteis, anfíbios, pássaros terrestres, ovos, pequenos " +
    "mamíferos e carniça.";
            this.info3.Visible = false;
            // 
            // voltar1
            // 
            this.voltar1.Location = new System.Drawing.Point(631, 306);
            this.voltar1.Name = "voltar1";
            this.voltar1.Size = new System.Drawing.Size(124, 42);
            this.voltar1.TabIndex = 10;
            this.voltar1.Text = "Retroceder";
            this.voltar1.UseVisualStyleBackColor = true;
            this.voltar1.Visible = false;
            this.voltar1.Click += new System.EventHandler(this.voltar1_Click);
            // 
            // voltar2
            // 
            this.voltar2.Location = new System.Drawing.Point(492, 306);
            this.voltar2.Name = "voltar2";
            this.voltar2.Size = new System.Drawing.Size(124, 42);
            this.voltar2.TabIndex = 11;
            this.voltar2.Text = "Retroceder2";
            this.voltar2.UseVisualStyleBackColor = true;
            this.voltar2.Visible = false;
            this.voltar2.Click += new System.EventHandler(this.voltar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar2);
            this.Controls.Add(this.voltar1);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.loading2);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizacao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripMenuItem curiosidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox info1;
        private System.Windows.Forms.Button loading;
        private System.Windows.Forms.RichTextBox info2;
        private System.Windows.Forms.Button loading2;
        private System.Windows.Forms.RichTextBox info3;
        private System.Windows.Forms.Button voltar1;
        private System.Windows.Forms.Button voltar2;
    }
}

