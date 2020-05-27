namespace Auto_Shutdown
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lbl_horas = new System.Windows.Forms.Label();
            this.Lbl_min = new System.Windows.Forms.Label();
            this.Lbl_seg = new System.Windows.Forms.Label();
            this.Btn_Mh = new System.Windows.Forms.Button();
            this.Btn_lh = new System.Windows.Forms.Button();
            this.Btn_lm = new System.Windows.Forms.Button();
            this.Btn_mm = new System.Windows.Forms.Button();
            this.Btn_ls = new System.Windows.Forms.Button();
            this.Btn_Ms = new System.Windows.Forms.Button();
            this.Time_s = new System.Windows.Forms.Timer(this.components);
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Timer(this.components);
            this.Lbl_restante = new System.Windows.Forms.Label();
            this.cb_margen = new System.Windows.Forms.CheckBox();
            this.gb_avanzado = new System.Windows.Forms.GroupBox();
            this.cb_reiniciar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_avanzado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_horas
            // 
            this.Lbl_horas.AutoSize = true;
            this.Lbl_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_horas.Location = new System.Drawing.Point(73, 66);
            this.Lbl_horas.Name = "Lbl_horas";
            this.Lbl_horas.Size = new System.Drawing.Size(63, 69);
            this.Lbl_horas.TabIndex = 0;
            this.Lbl_horas.Text = "0";
            this.Lbl_horas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_horas.Click += new System.EventHandler(this.Lbl_horas_Click);
            // 
            // Lbl_min
            // 
            this.Lbl_min.AutoSize = true;
            this.Lbl_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_min.Location = new System.Drawing.Point(246, 66);
            this.Lbl_min.Name = "Lbl_min";
            this.Lbl_min.Size = new System.Drawing.Size(63, 69);
            this.Lbl_min.TabIndex = 1;
            this.Lbl_min.Text = "0";
            this.Lbl_min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_min.Click += new System.EventHandler(this.Lbl_min_Click);
            // 
            // Lbl_seg
            // 
            this.Lbl_seg.AutoSize = true;
            this.Lbl_seg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seg.Location = new System.Drawing.Point(427, 66);
            this.Lbl_seg.Name = "Lbl_seg";
            this.Lbl_seg.Size = new System.Drawing.Size(63, 69);
            this.Lbl_seg.TabIndex = 2;
            this.Lbl_seg.Text = "0";
            this.Lbl_seg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Mh
            // 
            this.Btn_Mh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mh.Location = new System.Drawing.Point(17, 12);
            this.Btn_Mh.Name = "Btn_Mh";
            this.Btn_Mh.Size = new System.Drawing.Size(170, 51);
            this.Btn_Mh.TabIndex = 3;
            this.Btn_Mh.Text = "/\\";
            this.Btn_Mh.UseVisualStyleBackColor = true;
            this.Btn_Mh.Click += new System.EventHandler(this.Btn_Mh_Click);
            // 
            // Btn_lh
            // 
            this.Btn_lh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_lh.Location = new System.Drawing.Point(17, 138);
            this.Btn_lh.Name = "Btn_lh";
            this.Btn_lh.Size = new System.Drawing.Size(170, 51);
            this.Btn_lh.TabIndex = 5;
            this.Btn_lh.Text = "\\/";
            this.Btn_lh.UseVisualStyleBackColor = true;
            this.Btn_lh.Click += new System.EventHandler(this.Btn_lh_Click);
            // 
            // Btn_lm
            // 
            this.Btn_lm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_lm.Location = new System.Drawing.Point(193, 138);
            this.Btn_lm.Name = "Btn_lm";
            this.Btn_lm.Size = new System.Drawing.Size(170, 51);
            this.Btn_lm.TabIndex = 7;
            this.Btn_lm.Text = "\\/";
            this.Btn_lm.UseVisualStyleBackColor = true;
            this.Btn_lm.Click += new System.EventHandler(this.Btn_lm_Click);
            // 
            // Btn_mm
            // 
            this.Btn_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mm.Location = new System.Drawing.Point(193, 12);
            this.Btn_mm.Name = "Btn_mm";
            this.Btn_mm.Size = new System.Drawing.Size(170, 51);
            this.Btn_mm.TabIndex = 6;
            this.Btn_mm.Text = "/\\";
            this.Btn_mm.UseVisualStyleBackColor = true;
            this.Btn_mm.Click += new System.EventHandler(this.Btn_mm_Click);
            // 
            // Btn_ls
            // 
            this.Btn_ls.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ls.Location = new System.Drawing.Point(369, 138);
            this.Btn_ls.Name = "Btn_ls";
            this.Btn_ls.Size = new System.Drawing.Size(170, 51);
            this.Btn_ls.TabIndex = 9;
            this.Btn_ls.Text = "\\/";
            this.Btn_ls.UseVisualStyleBackColor = true;
            this.Btn_ls.Click += new System.EventHandler(this.Btn_ls_Click);
            // 
            // Btn_Ms
            // 
            this.Btn_Ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ms.Location = new System.Drawing.Point(369, 12);
            this.Btn_Ms.Name = "Btn_Ms";
            this.Btn_Ms.Size = new System.Drawing.Size(170, 51);
            this.Btn_Ms.TabIndex = 8;
            this.Btn_Ms.Text = "/\\";
            this.Btn_Ms.UseVisualStyleBackColor = true;
            this.Btn_Ms.Click += new System.EventHandler(this.Btn_Ms_Click);
            // 
            // Time_s
            // 
            this.Time_s.Interval = 1000;
            this.Time_s.Tick += new System.EventHandler(this.Time_s_Tick);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(401, 196);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(138, 51);
            this.Btn_Start.TabIndex = 10;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Enabled = false;
            this.Btn_Stop.Location = new System.Drawing.Point(401, 253);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(140, 51);
            this.Btn_Stop.TabIndex = 11;
            this.Btn_Stop.Text = "Cancel";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Enabled = true;
            this.Actualizar.Interval = 1;
            this.Actualizar.Tick += new System.EventHandler(this.Actualizar_Tick);
            // 
            // Lbl_restante
            // 
            this.Lbl_restante.AutoSize = true;
            this.Lbl_restante.Location = new System.Drawing.Point(12, 196);
            this.Lbl_restante.Name = "Lbl_restante";
            this.Lbl_restante.Size = new System.Drawing.Size(138, 17);
            this.Lbl_restante.TabIndex = 12;
            this.Lbl_restante.Text = "Seconds Remaining:";
            this.Lbl_restante.Click += new System.EventHandler(this.Lbl_restante_Click);
            // 
            // cb_margen
            // 
            this.cb_margen.AutoSize = true;
            this.cb_margen.Checked = true;
            this.cb_margen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_margen.Location = new System.Drawing.Point(7, 21);
            this.cb_margen.Name = "cb_margen";
            this.cb_margen.Size = new System.Drawing.Size(281, 38);
            this.cb_margen.TabIndex = 13;
            this.cb_margen.Text = "When time ends, warn user and remain \r\n10 seconds more before shutdown";
            this.cb_margen.UseVisualStyleBackColor = true;
            this.cb_margen.CheckedChanged += new System.EventHandler(this.Cb_margen_CheckedChanged);
            // 
            // gb_avanzado
            // 
            this.gb_avanzado.Controls.Add(this.cb_reiniciar);
            this.gb_avanzado.Controls.Add(this.cb_margen);
            this.gb_avanzado.Location = new System.Drawing.Point(17, 226);
            this.gb_avanzado.Name = "gb_avanzado";
            this.gb_avanzado.Size = new System.Drawing.Size(378, 161);
            this.gb_avanzado.TabIndex = 14;
            this.gb_avanzado.TabStop = false;
            this.gb_avanzado.Text = "Advanced";
            // 
            // cb_reiniciar
            // 
            this.cb_reiniciar.AutoSize = true;
            this.cb_reiniciar.Location = new System.Drawing.Point(7, 65);
            this.cb_reiniciar.Name = "cb_reiniciar";
            this.cb_reiniciar.Size = new System.Drawing.Size(206, 21);
            this.cb_reiniciar.TabIndex = 14;
            this.cb_reiniciar.Text = "Reboot instead of shutdown";
            this.cb_reiniciar.UseVisualStyleBackColor = true;
            this.cb_reiniciar.CheckedChanged += new System.EventHandler(this.Cb_reiniciar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Created by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Javier Albero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "(Splashling)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 69);
            this.label4.TabIndex = 18;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 69);
            this.label5.TabIndex = 19;
            this.label5.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 399);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_avanzado);
            this.Controls.Add(this.Lbl_restante);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_ls);
            this.Controls.Add(this.Btn_Ms);
            this.Controls.Add(this.Btn_lm);
            this.Controls.Add(this.Btn_mm);
            this.Controls.Add(this.Btn_lh);
            this.Controls.Add(this.Btn_Mh);
            this.Controls.Add(this.Lbl_seg);
            this.Controls.Add(this.Lbl_min);
            this.Controls.Add(this.Lbl_horas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Shutdown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_avanzado.ResumeLayout(false);
            this.gb_avanzado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_horas;
        private System.Windows.Forms.Label Lbl_min;
        private System.Windows.Forms.Label Lbl_seg;
        private System.Windows.Forms.Button Btn_Mh;
        private System.Windows.Forms.Button Btn_lh;
        private System.Windows.Forms.Button Btn_lm;
        private System.Windows.Forms.Button Btn_mm;
        private System.Windows.Forms.Button Btn_ls;
        private System.Windows.Forms.Button Btn_Ms;
        private System.Windows.Forms.Timer Time_s;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Timer Actualizar;
        private System.Windows.Forms.Label Lbl_restante;
        private System.Windows.Forms.CheckBox cb_margen;
        private System.Windows.Forms.GroupBox gb_avanzado;
        private System.Windows.Forms.CheckBox cb_reiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

