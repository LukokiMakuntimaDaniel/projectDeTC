
namespace MaquinaDeTuring
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sair = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paste = new System.Windows.Forms.PictureBox();
            this.cut = new System.Windows.Forms.PictureBox();
            this.copy = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.run = new System.Windows.Forms.PictureBox();
            this.compiller = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.instrucaoTuring = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mystate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.run)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compiller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.sair);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.paste);
            this.panel1.Controls.Add(this.cut);
            this.panel1.Controls.Add(this.copy);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.run);
            this.panel1.Controls.Add(this.compiller);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.open);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 51);
            this.panel1.TabIndex = 0;
            // 
            // sair
            // 
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.Image = ((System.Drawing.Image)(resources.GetObject("sair.Image")));
            this.sair.Location = new System.Drawing.Point(446, 13);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(37, 28);
            this.sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sair.TabIndex = 10;
            this.sair.TabStop = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(667, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Espaço da fita em simulação";
            // 
            // paste
            // 
            this.paste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paste.Image = ((System.Drawing.Image)(resources.GetObject("paste.Image")));
            this.paste.Location = new System.Drawing.Point(407, 13);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(37, 28);
            this.paste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paste.TabIndex = 9;
            this.paste.TabStop = false;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // cut
            // 
            this.cut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cut.Image = ((System.Drawing.Image)(resources.GetObject("cut.Image")));
            this.cut.Location = new System.Drawing.Point(368, 13);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(37, 28);
            this.cut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cut.TabIndex = 8;
            this.cut.TabStop = false;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy.Image = ((System.Drawing.Image)(resources.GetObject("copy.Image")));
            this.copy.Location = new System.Drawing.Point(329, 13);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(37, 28);
            this.copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copy.TabIndex = 7;
            this.copy.TabStop = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // stop
            // 
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(290, 13);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(37, 28);
            this.stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stop.TabIndex = 6;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // run
            // 
            this.run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.run.Image = ((System.Drawing.Image)(resources.GetObject("run.Image")));
            this.run.Location = new System.Drawing.Point(251, 12);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(37, 28);
            this.run.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.run.TabIndex = 5;
            this.run.TabStop = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // compiller
            // 
            this.compiller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compiller.Image = ((System.Drawing.Image)(resources.GetObject("compiller.Image")));
            this.compiller.Location = new System.Drawing.Point(212, 13);
            this.compiller.Name = "compiller";
            this.compiller.Size = new System.Drawing.Size(37, 28);
            this.compiller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.compiller.TabIndex = 4;
            this.compiller.TabStop = false;
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(173, 13);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(37, 28);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.save.TabIndex = 3;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.Location = new System.Drawing.Point(134, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(37, 28);
            this.open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.open.TabIndex = 2;
            this.open.TabStop = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(91, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(37, 28);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // instrucaoTuring
            // 
            this.instrucaoTuring.Location = new System.Drawing.Point(12, 98);
            this.instrucaoTuring.Multiline = true;
            this.instrucaoTuring.Name = "instrucaoTuring";
            this.instrucaoTuring.Size = new System.Drawing.Size(420, 392);
            this.instrucaoTuring.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(96, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite o seu codigo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.mystate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 92);
            this.panel2.TabIndex = 5;
            // 
            // mystate
            // 
            this.mystate.AutoSize = true;
            this.mystate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mystate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mystate.Location = new System.Drawing.Point(455, 36);
            this.mystate.Name = "mystate";
            this.mystate.Size = new System.Drawing.Size(0, 21);
            this.mystate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(360, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Blue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(594, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(408, 461);
            this.listBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 604);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instrucaoTuring);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.run)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compiller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox open;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.PictureBox sair;
        private System.Windows.Forms.PictureBox paste;
        private System.Windows.Forms.PictureBox cut;
        private System.Windows.Forms.PictureBox copy;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox run;
        private System.Windows.Forms.PictureBox compiller;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox instrucaoTuring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mystate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

