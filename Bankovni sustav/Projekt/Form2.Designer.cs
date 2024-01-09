
namespace Projekt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStednja = new System.Windows.Forms.Button();
            this.buttonKredit = new System.Windows.Forms.Button();
            this.buttonZiro = new System.Windows.Forms.Button();
            this.buttonFond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite željenu radnju:";
            // 
            // buttonStednja
            // 
            this.buttonStednja.BackColor = System.Drawing.Color.LightCyan;
            this.buttonStednja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStednja.Location = new System.Drawing.Point(45, 56);
            this.buttonStednja.Name = "buttonStednja";
            this.buttonStednja.Size = new System.Drawing.Size(111, 36);
            this.buttonStednja.TabIndex = 1;
            this.buttonStednja.Text = "Otvaranje štednje";
            this.buttonStednja.UseVisualStyleBackColor = false;
            this.buttonStednja.Click += new System.EventHandler(this.buttonStednja_Click);
            // 
            // buttonKredit
            // 
            this.buttonKredit.BackColor = System.Drawing.Color.LightCyan;
            this.buttonKredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKredit.Location = new System.Drawing.Point(45, 110);
            this.buttonKredit.Name = "buttonKredit";
            this.buttonKredit.Size = new System.Drawing.Size(111, 36);
            this.buttonKredit.TabIndex = 2;
            this.buttonKredit.Text = "Ugovoranje kredita";
            this.buttonKredit.UseVisualStyleBackColor = false;
            this.buttonKredit.Click += new System.EventHandler(this.buttonKredit_Click);
            // 
            // buttonZiro
            // 
            this.buttonZiro.BackColor = System.Drawing.Color.LightCyan;
            this.buttonZiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZiro.Location = new System.Drawing.Point(45, 166);
            this.buttonZiro.Name = "buttonZiro";
            this.buttonZiro.Size = new System.Drawing.Size(111, 36);
            this.buttonZiro.TabIndex = 3;
            this.buttonZiro.Text = "Otvaranje žiro računa";
            this.buttonZiro.UseVisualStyleBackColor = false;
            this.buttonZiro.Click += new System.EventHandler(this.buttonZiro_Click);
            // 
            // buttonFond
            // 
            this.buttonFond.BackColor = System.Drawing.Color.LightCyan;
            this.buttonFond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFond.Location = new System.Drawing.Point(45, 221);
            this.buttonFond.Name = "buttonFond";
            this.buttonFond.Size = new System.Drawing.Size(111, 36);
            this.buttonFond.TabIndex = 4;
            this.buttonFond.Text = "Otvaranje investicijskog fonda";
            this.buttonFond.UseVisualStyleBackColor = false;
            this.buttonFond.Click += new System.EventHandler(this.buttonFond_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(223, 299);
            this.Controls.Add(this.buttonFond);
            this.Controls.Add(this.buttonZiro);
            this.Controls.Add(this.buttonKredit);
            this.Controls.Add(this.buttonStednja);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStednja;
        private System.Windows.Forms.Button buttonKredit;
        private System.Windows.Forms.Button buttonZiro;
        private System.Windows.Forms.Button buttonFond;
    }
}