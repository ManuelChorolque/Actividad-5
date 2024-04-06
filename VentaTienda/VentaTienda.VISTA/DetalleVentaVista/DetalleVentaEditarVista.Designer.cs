namespace VentaTienda.VISTA.DetalleVentaVista
{
    partial class DetalleVentaEditarVista
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
            button4 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.Cancel;
            button4.Location = new Point(335, 256);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 27;
            button4.Text = "CANCELAR";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.OK;
            button3.Location = new Point(177, 256);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 26;
            button3.Text = "GUARDAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 193);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(339, 23);
            textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 148);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(339, 23);
            textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 23);
            textBox3.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(372, 66);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 22;
            button2.Text = "SELECCIONAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(372, 27);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 20;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 196);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 18;
            label5.Text = "TOTAL DETALLE :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 151);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 17;
            label4.Text = "PRECIO UNITARIO :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 112);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 16;
            label3.Text = "CANTIDAD :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 69);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 15;
            label2.Text = "PRODUCTO :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 30);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 14;
            label1.Text = "VENTA :";
            // 
            // DetalleVentaEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 306);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleVentaEditarVista";
            Text = "DetalleVentaEditarVista";
            Load += DetalleVentaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button2;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}