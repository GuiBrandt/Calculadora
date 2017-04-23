namespace Calculadora
{
    partial class FormCalculadora
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
            this.edVisor = new System.Windows.Forms.TextBox();
            this.edResultado = new System.Windows.Forms.TextBox();
            this.lbSequencias = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edVisor
            // 
            this.edVisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edVisor.Location = new System.Drawing.Point(13, 12);
            this.edVisor.Name = "edVisor";
            this.edVisor.Size = new System.Drawing.Size(212, 20);
            this.edVisor.TabIndex = 0;
            this.edVisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edVisor_KeyPress);
            // 
            // edResultado
            // 
            this.edResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edResultado.Location = new System.Drawing.Point(13, 38);
            this.edResultado.Name = "edResultado";
            this.edResultado.ReadOnly = true;
            this.edResultado.Size = new System.Drawing.Size(212, 20);
            this.edResultado.TabIndex = 1;
            // 
            // lbSequencias
            // 
            this.lbSequencias.AutoSize = true;
            this.lbSequencias.Location = new System.Drawing.Point(12, 61);
            this.lbSequencias.Name = "lbSequencias";
            this.lbSequencias.Size = new System.Drawing.Size(44, 26);
            this.lbSequencias.TabIndex = 2;
            this.lbSequencias.Text = "Infixa:\r\nPosfixa:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button20, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnIgual, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button17, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 268);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(180, 215);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(54, 50);
            this.button20.TabIndex = 19;
            this.button20.Tag = "(";
            this.button20.Text = "(";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(121, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 50);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Location = new System.Drawing.Point(62, 215);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(53, 50);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(3, 215);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(53, 50);
            this.button17.TabIndex = 16;
            this.button17.Tag = "0";
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(180, 162);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 47);
            this.button16.TabIndex = 15;
            this.button16.Tag = ")";
            this.button16.Text = ")";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(121, 162);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(53, 47);
            this.button15.TabIndex = 14;
            this.button15.Tag = "3";
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(62, 162);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(53, 47);
            this.button14.TabIndex = 13;
            this.button14.Tag = "2";
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(3, 162);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(53, 47);
            this.button13.TabIndex = 12;
            this.button13.Tag = "1";
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(180, 109);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 47);
            this.button12.TabIndex = 11;
            this.button12.Tag = ".";
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(121, 109);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 47);
            this.button11.TabIndex = 10;
            this.button11.Tag = "6";
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(62, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 47);
            this.button10.TabIndex = 9;
            this.button10.Tag = "5";
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(3, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 47);
            this.button9.TabIndex = 8;
            this.button9.Tag = "4";
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(180, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 47);
            this.button8.TabIndex = 7;
            this.button8.Tag = "+";
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(121, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 47);
            this.button7.TabIndex = 6;
            this.button7.Tag = "9";
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(62, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 47);
            this.button6.TabIndex = 5;
            this.button6.Tag = "8";
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(3, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 47);
            this.button5.TabIndex = 4;
            this.button5.Tag = "7";
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(180, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 47);
            this.button4.TabIndex = 3;
            this.button4.Tag = "-";
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(121, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 47);
            this.button3.TabIndex = 2;
            this.button3.Tag = "*";
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(62, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 47);
            this.button2.TabIndex = 1;
            this.button2.Tag = "/";
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 47);
            this.button1.TabIndex = 0;
            this.button1.Tag = "^";
            this.button1.Text = "^";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDigito_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 363);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbSequencias);
            this.Controls.Add(this.edResultado);
            this.Controls.Add(this.edVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(253, 372);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edVisor;
        private System.Windows.Forms.TextBox edResultado;
        private System.Windows.Forms.Label lbSequencias;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

