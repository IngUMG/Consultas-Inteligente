namespace Consultas2Nov
{
    partial class CapaPresentacion
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
            this.Cmb_campos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_campos2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_condicion = new System.Windows.Forms.TextBox();
            this.Cmb_operadorcondiciones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.Txt_campo1 = new System.Windows.Forms.TextBox();
            this.btn_nc = new System.Windows.Forms.Button();
            this.btn_adCondicion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_condicion1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_operador = new System.Windows.Forms.TextBox();
            this.Btn_ccompleta = new System.Windows.Forms.Button();
            this.Btn_cpersonalizada = new System.Windows.Forms.Button();
            this.Dgv_resultados = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_campos
            // 
            this.Cmb_campos.FormattingEnabled = true;
            this.Cmb_campos.Location = new System.Drawing.Point(13, 127);
            this.Cmb_campos.Name = "Cmb_campos";
            this.Cmb_campos.Size = new System.Drawing.Size(134, 21);
            this.Cmb_campos.TabIndex = 5;
            this.Cmb_campos.SelectedIndexChanged += new System.EventHandler(this.Cmb_campos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Campos De Tabla:";
            // 
            // Cmb_campos2
            // 
            this.Cmb_campos2.FormattingEnabled = true;
            this.Cmb_campos2.Location = new System.Drawing.Point(15, 213);
            this.Cmb_campos2.Name = "Cmb_campos2";
            this.Cmb_campos2.Size = new System.Drawing.Size(134, 21);
            this.Cmb_campos2.TabIndex = 7;
            this.Cmb_campos2.SelectedIndexChanged += new System.EventHandler(this.Cmb_campos2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Campos De Tabla:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Condición 2:";
            // 
            // Txt_condicion
            // 
            this.Txt_condicion.Location = new System.Drawing.Point(242, 276);
            this.Txt_condicion.Name = "Txt_condicion";
            this.Txt_condicion.Size = new System.Drawing.Size(108, 20);
            this.Txt_condicion.TabIndex = 15;
            this.Txt_condicion.TextChanged += new System.EventHandler(this.Txt_condicion_TextChanged);
            // 
            // Cmb_operadorcondiciones
            // 
            this.Cmb_operadorcondiciones.FormattingEnabled = true;
            this.Cmb_operadorcondiciones.Items.AddRange(new object[] {
            "MAYOR QUE",
            "MENOR QUE",
            "IGUAL",
            "MENOR O IGUAL",
            "MAYOR O IGUAL",
            "DIFERENTE"});
            this.Cmb_operadorcondiciones.Location = new System.Drawing.Point(169, 213);
            this.Cmb_operadorcondiciones.Name = "Cmb_operadorcondiciones";
            this.Cmb_operadorcondiciones.Size = new System.Drawing.Size(117, 21);
            this.Cmb_operadorcondiciones.TabIndex = 14;
            this.Cmb_operadorcondiciones.SelectedIndexChanged += new System.EventHandler(this.Cmb_operadorcondiciones_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Operador de Condiciones";
            // 
            // Btn_crear
            // 
            this.Btn_crear.Location = new System.Drawing.Point(301, 326);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(94, 27);
            this.Btn_crear.TabIndex = 18;
            this.Btn_crear.Text = "Crear Consulta";
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_creacond_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(356, 121);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(39, 31);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_campo1
            // 
            this.Txt_campo1.Location = new System.Drawing.Point(242, 127);
            this.Txt_campo1.Name = "Txt_campo1";
            this.Txt_campo1.Size = new System.Drawing.Size(108, 20);
            this.Txt_campo1.TabIndex = 20;
            // 
            // btn_nc
            // 
            this.btn_nc.Location = new System.Drawing.Point(15, 326);
            this.btn_nc.Name = "btn_nc";
            this.btn_nc.Size = new System.Drawing.Size(108, 27);
            this.btn_nc.TabIndex = 22;
            this.btn_nc.Text = "Cancelar Consulta";
            this.btn_nc.UseVisualStyleBackColor = true;
            this.btn_nc.Click += new System.EventHandler(this.btn_nc_Click);
            // 
            // btn_adCondicion
            // 
            this.btn_adCondicion.Location = new System.Drawing.Point(356, 270);
            this.btn_adCondicion.Name = "btn_adCondicion";
            this.btn_adCondicion.Size = new System.Drawing.Size(39, 31);
            this.btn_adCondicion.TabIndex = 24;
            this.btn_adCondicion.Text = "ADD";
            this.btn_adCondicion.UseVisualStyleBackColor = true;
            this.btn_adCondicion.Click += new System.EventHandler(this.btn_adCondicion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Condición 1:";
            // 
            // Txt_condicion1
            // 
            this.Txt_condicion1.Location = new System.Drawing.Point(15, 276);
            this.Txt_condicion1.Name = "Txt_condicion1";
            this.Txt_condicion1.Size = new System.Drawing.Size(108, 20);
            this.Txt_condicion1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Operador:";
            // 
            // Txt_operador
            // 
            this.Txt_operador.Location = new System.Drawing.Point(128, 276);
            this.Txt_operador.Name = "Txt_operador";
            this.Txt_operador.Size = new System.Drawing.Size(108, 20);
            this.Txt_operador.TabIndex = 27;
            // 
            // Btn_ccompleta
            // 
            this.Btn_ccompleta.Location = new System.Drawing.Point(12, 59);
            this.Btn_ccompleta.Name = "Btn_ccompleta";
            this.Btn_ccompleta.Size = new System.Drawing.Size(130, 23);
            this.Btn_ccompleta.TabIndex = 30;
            this.Btn_ccompleta.Text = "Consulta Completa";
            this.Btn_ccompleta.UseVisualStyleBackColor = true;
            this.Btn_ccompleta.Click += new System.EventHandler(this.Btn_ccompleta_Click);
            // 
            // Btn_cpersonalizada
            // 
            this.Btn_cpersonalizada.Location = new System.Drawing.Point(265, 59);
            this.Btn_cpersonalizada.Name = "Btn_cpersonalizada";
            this.Btn_cpersonalizada.Size = new System.Drawing.Size(130, 23);
            this.Btn_cpersonalizada.TabIndex = 31;
            this.Btn_cpersonalizada.Text = "Consulta Personalizada";
            this.Btn_cpersonalizada.UseVisualStyleBackColor = true;
            this.Btn_cpersonalizada.Click += new System.EventHandler(this.Btn_cpersonalizada_Click);
            // 
            // Dgv_resultados
            // 
            this.Dgv_resultados.AllowUserToAddRows = false;
            this.Dgv_resultados.AllowUserToDeleteRows = false;
            this.Dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_resultados.Location = new System.Drawing.Point(15, 375);
            this.Dgv_resultados.Name = "Dgv_resultados";
            this.Dgv_resultados.ReadOnly = true;
            this.Dgv_resultados.Size = new System.Drawing.Size(380, 97);
            this.Dgv_resultados.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CapaPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 513);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dgv_resultados);
            this.Controls.Add(this.Btn_cpersonalizada);
            this.Controls.Add(this.Btn_ccompleta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_operador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_condicion1);
            this.Controls.Add(this.btn_adCondicion);
            this.Controls.Add(this.btn_nc);
            this.Controls.Add(this.Txt_campo1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_condicion);
            this.Controls.Add(this.Cmb_operadorcondiciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_campos2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_campos);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CapaPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas Inteligentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapaPresentacion_FormClosing);
            this.Load += new System.EventHandler(this.CapaPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_campos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_campos2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_condicion;
        private System.Windows.Forms.ComboBox Cmb_operadorcondiciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox Txt_campo1;
        private System.Windows.Forms.Button btn_nc;
        private System.Windows.Forms.Button btn_adCondicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_condicion1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_operador;
        private System.Windows.Forms.Button Btn_ccompleta;
        private System.Windows.Forms.Button Btn_cpersonalizada;
        private System.Windows.Forms.DataGridView Dgv_resultados;
        private System.Windows.Forms.Button button2;
    }
}