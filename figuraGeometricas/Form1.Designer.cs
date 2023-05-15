namespace figuraGeometricas
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
            txtSide = new TextBox();
            txtSide2 = new TextBox();
            txtSide3 = new TextBox();
            label1 = new Label();
            lblSide = new Label();
            lblSide2 = new Label();
            lblSide3 = new Label();
            cmbFigure = new ComboBox();
            btnCreateFigure = new Button();
            groupBox1 = new GroupBox();
            btnListFigure = new Button();
            btnNew = new Button();
            lblPerimeter = new Label();
            lblSurface = new Label();
            listFigure = new ListBox();
            lblCreateFigure = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSide
            // 
            txtSide.Location = new Point(256, 36);
            txtSide.Name = "txtSide";
            txtSide.Size = new Size(125, 27);
            txtSide.TabIndex = 0;
            // 
            // txtSide2
            // 
            txtSide2.Location = new Point(256, 76);
            txtSide2.Name = "txtSide2";
            txtSide2.Size = new Size(125, 27);
            txtSide2.TabIndex = 0;
            // 
            // txtSide3
            // 
            txtSide3.Location = new Point(256, 112);
            txtSide3.Name = "txtSide3";
            txtSide3.Size = new Size(125, 27);
            txtSide3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 1;
            label1.Text = "¿Qué figura desea crear?";
            // 
            // lblSide
            // 
            lblSide.AutoSize = true;
            lblSide.Location = new Point(119, 39);
            lblSide.Name = "lblSide";
            lblSide.Size = new Size(0, 20);
            lblSide.TabIndex = 1;
            // 
            // lblSide2
            // 
            lblSide2.AutoSize = true;
            lblSide2.Location = new Point(119, 79);
            lblSide2.Name = "lblSide2";
            lblSide2.Size = new Size(54, 20);
            lblSide2.TabIndex = 1;
            lblSide2.Text = "Lado 2";
            // 
            // lblSide3
            // 
            lblSide3.AutoSize = true;
            lblSide3.Location = new Point(119, 115);
            lblSide3.Name = "lblSide3";
            lblSide3.Size = new Size(54, 20);
            lblSide3.TabIndex = 1;
            lblSide3.Text = "Lado 3";
            // 
            // cmbFigure
            // 
            cmbFigure.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFigure.ForeColor = SystemColors.InfoText;
            cmbFigure.FormattingEnabled = true;
            cmbFigure.Items.AddRange(new object[] { "Circulo", "Triangulo", "Cuadrado" });
            cmbFigure.Location = new Point(192, 12);
            cmbFigure.Name = "cmbFigure";
            cmbFigure.Size = new Size(207, 25);
            cmbFigure.TabIndex = 4;
            cmbFigure.Tag = "Seleccione una figura";
            cmbFigure.Text = "Seleccione la figura";
            cmbFigure.SelectedIndexChanged += cmbFigure_SelectedIndexChanged;
            // 
            // btnCreateFigure
            // 
            btnCreateFigure.Location = new Point(271, 168);
            btnCreateFigure.Name = "btnCreateFigure";
            btnCreateFigure.Size = new Size(94, 29);
            btnCreateFigure.TabIndex = 7;
            btnCreateFigure.Text = "Crear";
            btnCreateFigure.UseVisualStyleBackColor = true;
            btnCreateFigure.Click += btnCreateFigure_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListFigure);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(txtSide);
            groupBox1.Controls.Add(btnCreateFigure);
            groupBox1.Controls.Add(txtSide2);
            groupBox1.Controls.Add(txtSide3);
            groupBox1.Controls.Add(lblSide3);
            groupBox1.Controls.Add(lblSide2);
            groupBox1.Controls.Add(lblSide);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 215);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Figura";
            // 
            // btnListFigure
            // 
            btnListFigure.Location = new Point(25, 168);
            btnListFigure.Name = "btnListFigure";
            btnListFigure.Size = new Size(94, 29);
            btnListFigure.TabIndex = 9;
            btnListFigure.Text = "Listar";
            btnListFigure.UseVisualStyleBackColor = true;
            btnListFigure.Click += btnListFigure_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(141, 168);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 8;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lblPerimeter
            // 
            lblPerimeter.AutoSize = true;
            lblPerimeter.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPerimeter.ForeColor = SystemColors.GrayText;
            lblPerimeter.Location = new Point(438, 87);
            lblPerimeter.Name = "lblPerimeter";
            lblPerimeter.Size = new Size(0, 22);
            lblPerimeter.TabIndex = 9;
            // 
            // lblSurface
            // 
            lblSurface.AutoSize = true;
            lblSurface.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSurface.ForeColor = SystemColors.GrayText;
            lblSurface.Location = new Point(438, 174);
            lblSurface.Name = "lblSurface";
            lblSurface.Size = new Size(0, 22);
            lblSurface.TabIndex = 9;
            // 
            // listFigure
            // 
            listFigure.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listFigure.ForeColor = SystemColors.HotTrack;
            listFigure.FormattingEnabled = true;
            listFigure.ItemHeight = 23;
            listFigure.Location = new Point(12, 311);
            listFigure.Name = "listFigure";
            listFigure.Size = new Size(843, 280);
            listFigure.TabIndex = 11;
            // 
            // lblCreateFigure
            // 
            lblCreateFigure.AutoSize = true;
            lblCreateFigure.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCreateFigure.ForeColor = SystemColors.ActiveCaption;
            lblCreateFigure.Location = new Point(438, 26);
            lblCreateFigure.Name = "lblCreateFigure";
            lblCreateFigure.Size = new Size(0, 22);
            lblCreateFigure.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 609);
            Controls.Add(lblCreateFigure);
            Controls.Add(listFigure);
            Controls.Add(lblSurface);
            Controls.Add(lblPerimeter);
            Controls.Add(groupBox1);
            Controls.Add(cmbFigure);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSide;
        private TextBox txtSide2;
        private TextBox txtSide3;
        private Label label1;
        private Label lblSide;
        private Label lblSide2;
        private Label lblSide3;
        private ComboBox cmbFigure;
        private Button btnCreateFigure;
        private GroupBox groupBox1;
        private Button btnNew;
        private Label lblPerimeter;
        private Label lblSurface;
        private ListBox listFigure;
        private Button btnListFigure;
        private Label lblCreateFigure;
    }
}