namespace Ejercicio_DesktopApp
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnImportarPaquetes = new Button();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            btnEnviar = new Button();
            btnIniciarCamion = new Button();
            comboBox1 = new ComboBox();
            listBox4 = new ListBox();
            btnRetirar = new Button();
            btnAgregar = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnImportarPaquetes);
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(26, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 25);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Zona3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 25);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Zona2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Zona1";
            // 
            // btnImportarPaquetes
            // 
            btnImportarPaquetes.Location = new Point(449, 51);
            btnImportarPaquetes.Name = "btnImportarPaquetes";
            btnImportarPaquetes.Size = new Size(108, 94);
            btnImportarPaquetes.TabIndex = 3;
            btnImportarPaquetes.Text = "Importar paquete pedidos";
            btnImportarPaquetes.UseVisualStyleBackColor = true;
            btnImportarPaquetes.Click += button1_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(301, 51);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 94);
            listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(159, 51);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnEnviar);
            groupBox2.Controls.Add(btnIniciarCamion);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(listBox4);
            groupBox2.Controls.Add(btnRetirar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Location = new Point(26, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(703, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 151);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 6;
            label4.Text = "Peso total en kg";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(172, 101);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnIniciarCamion
            // 
            btnIniciarCamion.Location = new Point(45, 101);
            btnIniciarCamion.Name = "btnIniciarCamion";
            btnIniciarCamion.Size = new Size(82, 23);
            btnIniciarCamion.TabIndex = 4;
            btnIniciarCamion.Text = "iniciar";
            btnIniciarCamion.UseVisualStyleBackColor = true;
            btnIniciarCamion.Click += btnIniciarCamion_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 23);
            comboBox1.TabIndex = 3;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(330, 41);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(253, 124);
            listBox4.TabIndex = 2;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(602, 80);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(75, 23);
            btnRetirar.TabIndex = 1;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(602, 41);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnImportarPaquetes;
        private GroupBox groupBox2;
        private ListBox listBox4;
        private Button btnRetirar;
        private Button btnAgregar;
        private OpenFileDialog openFileDialog1;
        private Button btnEnviar;
        private Button btnIniciarCamion;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
    }
}
