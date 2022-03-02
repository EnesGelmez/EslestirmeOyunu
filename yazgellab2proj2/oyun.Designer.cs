
namespace yazgellab2proj2
{
    partial class oyun
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
            this.components = new System.ComponentModel.Container();
            this.gb_oyun = new System.Windows.Forms.GroupBox();
            this.denemesayisi = new System.Windows.Forms.Label();
            this.anlikpuanlbl = new System.Windows.Forms.Label();
            this.saniyelbl = new System.Windows.Forms.Label();
            this.dakikalbl = new System.Windows.Forms.Label();
            this.donmeani1 = new System.Windows.Forms.Timer(this.components);
            this.donmeani2 = new System.Windows.Forms.Timer(this.components);
            this.kaybolmaani = new System.Windows.Forms.Timer(this.components);
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.gb_oyun.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_oyun
            // 
            this.gb_oyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.gb_oyun.Controls.Add(this.denemesayisi);
            this.gb_oyun.Controls.Add(this.anlikpuanlbl);
            this.gb_oyun.Controls.Add(this.saniyelbl);
            this.gb_oyun.Controls.Add(this.dakikalbl);
            this.gb_oyun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_oyun.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gb_oyun.Location = new System.Drawing.Point(-6, -6);
            this.gb_oyun.Name = "gb_oyun";
            this.gb_oyun.Size = new System.Drawing.Size(1140, 940);
            this.gb_oyun.TabIndex = 5;
            this.gb_oyun.TabStop = false;
            // 
            // denemesayisi
            // 
            this.denemesayisi.AutoSize = true;
            this.denemesayisi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denemesayisi.Location = new System.Drawing.Point(808, 247);
            this.denemesayisi.Name = "denemesayisi";
            this.denemesayisi.Size = new System.Drawing.Size(23, 25);
            this.denemesayisi.TabIndex = 3;
            this.denemesayisi.Text = "0";
            // 
            // anlikpuanlbl
            // 
            this.anlikpuanlbl.AutoSize = true;
            this.anlikpuanlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anlikpuanlbl.Location = new System.Drawing.Point(907, 122);
            this.anlikpuanlbl.Name = "anlikpuanlbl";
            this.anlikpuanlbl.Size = new System.Drawing.Size(23, 25);
            this.anlikpuanlbl.TabIndex = 2;
            this.anlikpuanlbl.Text = "0";
            // 
            // saniyelbl
            // 
            this.saniyelbl.AutoSize = true;
            this.saniyelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saniyelbl.Location = new System.Drawing.Point(774, 401);
            this.saniyelbl.Name = "saniyelbl";
            this.saniyelbl.Size = new System.Drawing.Size(34, 25);
            this.saniyelbl.TabIndex = 1;
            this.saniyelbl.Text = "00";
            // 
            // dakikalbl
            // 
            this.dakikalbl.AutoSize = true;
            this.dakikalbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dakikalbl.Location = new System.Drawing.Point(349, 58);
            this.dakikalbl.Name = "dakikalbl";
            this.dakikalbl.Size = new System.Drawing.Size(23, 25);
            this.dakikalbl.TabIndex = 0;
            this.dakikalbl.Text = "0";
            // 
            // donmeani1
            // 
            this.donmeani1.Interval = 1;
            this.donmeani1.Tick += new System.EventHandler(this.donmeani1_Tick);
            // 
            // donmeani2
            // 
            this.donmeani2.Interval = 1;
            this.donmeani2.Tick += new System.EventHandler(this.donmeani2_Tick);
            // 
            // kaybolmaani
            // 
            this.kaybolmaani.Interval = 1;
            this.kaybolmaani.Tick += new System.EventHandler(this.kaybolmaani_Tick);
            // 
            // zaman
            // 
            this.zaman.Interval = 1000;
            this.zaman.Tick += new System.EventHandler(this.zaman_Tick);
            // 
            // oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(996, 937);
            this.Controls.Add(this.gb_oyun);
            this.Name = "oyun";
            this.Text = "Oyun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oyun_FormClosing);
            this.Load += new System.EventHandler(this.oyun_Load);
            this.gb_oyun.ResumeLayout(false);
            this.gb_oyun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_oyun;
        private System.Windows.Forms.Timer donmeani1;
        private System.Windows.Forms.Timer donmeani2;
        private System.Windows.Forms.Timer kaybolmaani;
        private System.Windows.Forms.Timer zaman;
        private System.Windows.Forms.Label dakikalbl;
        private System.Windows.Forms.Label saniyelbl;
        private System.Windows.Forms.Label anlikpuanlbl;
        private System.Windows.Forms.Label denemesayisi;
    }
}