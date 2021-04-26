
namespace SinkUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buildButton = new System.Windows.Forms.Button();
            this.SinkLengthLabel = new System.Windows.Forms.Label();
            this.SinkWidthLabel = new System.Windows.Forms.Label();
            this.SinkHeightLabel = new System.Windows.Forms.Label();
            this.CupSinkLengthLabel = new System.Windows.Forms.Label();
            this.CupSinkWidthLabel = new System.Windows.Forms.Label();
            this.DrainHoleDiameterLabel = new System.Windows.Forms.Label();
            this.SinkLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SinkWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SinkHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CupSinkLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CupSinkWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DrainHoleDiameterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CraneHoleDiameterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CraneHoleDiameterLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SinkLengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinkWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinkHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CupSinkLengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CupSinkWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrainHoleDiameterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CraneHoleDiameterNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(319, 254);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(74, 31);
            this.buildButton.TabIndex = 0;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // SinkLengthLabel
            // 
            this.SinkLengthLabel.AutoSize = true;
            this.SinkLengthLabel.Location = new System.Drawing.Point(3, 33);
            this.SinkLengthLabel.Name = "SinkLengthLabel";
            this.SinkLengthLabel.Size = new System.Drawing.Size(59, 13);
            this.SinkLengthLabel.TabIndex = 1;
            this.SinkLengthLabel.Text = "Длина (A):";
            // 
            // SinkWidthLabel
            // 
            this.SinkWidthLabel.AutoSize = true;
            this.SinkWidthLabel.Location = new System.Drawing.Point(120, 33);
            this.SinkWidthLabel.Name = "SinkWidthLabel";
            this.SinkWidthLabel.Size = new System.Drawing.Size(65, 13);
            this.SinkWidthLabel.TabIndex = 2;
            this.SinkWidthLabel.Text = "Ширина (B):";
            // 
            // SinkHeightLabel
            // 
            this.SinkHeightLabel.AutoSize = true;
            this.SinkHeightLabel.Location = new System.Drawing.Point(244, 33);
            this.SinkHeightLabel.Name = "SinkHeightLabel";
            this.SinkHeightLabel.Size = new System.Drawing.Size(65, 13);
            this.SinkHeightLabel.TabIndex = 3;
            this.SinkHeightLabel.Text = "Высота (H):";
            // 
            // CupSinkLengthLabel
            // 
            this.CupSinkLengthLabel.AutoSize = true;
            this.CupSinkLengthLabel.Location = new System.Drawing.Point(3, 33);
            this.CupSinkLengthLabel.Name = "CupSinkLengthLabel";
            this.CupSinkLengthLabel.Size = new System.Drawing.Size(59, 13);
            this.CupSinkLengthLabel.TabIndex = 4;
            this.CupSinkLengthLabel.Text = "Длина (C):";
            // 
            // CupSinkWidthLabel
            // 
            this.CupSinkWidthLabel.AutoSize = true;
            this.CupSinkWidthLabel.Location = new System.Drawing.Point(120, 33);
            this.CupSinkWidthLabel.Name = "CupSinkWidthLabel";
            this.CupSinkWidthLabel.Size = new System.Drawing.Size(65, 13);
            this.CupSinkWidthLabel.TabIndex = 5;
            this.CupSinkWidthLabel.Text = "Ширина (E):";
            // 
            // DrainHoleDiameterLabel
            // 
            this.DrainHoleDiameterLabel.AutoSize = true;
            this.DrainHoleDiameterLabel.Location = new System.Drawing.Point(3, 33);
            this.DrainHoleDiameterLabel.Name = "DrainHoleDiameterLabel";
            this.DrainHoleDiameterLabel.Size = new System.Drawing.Size(182, 13);
            this.DrainHoleDiameterLabel.TabIndex = 6;
            this.DrainHoleDiameterLabel.Text = "Диаметр отверстия для слива (D):";
            // 
            // SinkLengthNumericUpDown
            // 
            this.SinkLengthNumericUpDown.Location = new System.Drawing.Point(68, 31);
            this.SinkLengthNumericUpDown.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.SinkLengthNumericUpDown.Minimum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.SinkLengthNumericUpDown.Name = "SinkLengthNumericUpDown";
            this.SinkLengthNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.SinkLengthNumericUpDown.TabIndex = 8;
            this.SinkLengthNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SinkLengthNumericUpDown.ValueChanged += new System.EventHandler(this.SinkLengthNumericUpDown_ValueChanged);
            // 
            // SinkWidthNumericUpDown
            // 
            this.SinkWidthNumericUpDown.Location = new System.Drawing.Point(191, 31);
            this.SinkWidthNumericUpDown.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.SinkWidthNumericUpDown.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.SinkWidthNumericUpDown.Name = "SinkWidthNumericUpDown";
            this.SinkWidthNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.SinkWidthNumericUpDown.TabIndex = 9;
            this.SinkWidthNumericUpDown.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.SinkWidthNumericUpDown.ValueChanged += new System.EventHandler(this.SinkWidthNumericUpDown_ValueChanged);
            // 
            // SinkHeightNumericUpDown
            // 
            this.SinkHeightNumericUpDown.Location = new System.Drawing.Point(315, 31);
            this.SinkHeightNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.SinkHeightNumericUpDown.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.SinkHeightNumericUpDown.Name = "SinkHeightNumericUpDown";
            this.SinkHeightNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.SinkHeightNumericUpDown.TabIndex = 10;
            this.SinkHeightNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SinkHeightNumericUpDown.ValueChanged += new System.EventHandler(this.SinkHeightNumericUpDown_ValueChanged);
            // 
            // CupSinkLengthNumericUpDown
            // 
            this.CupSinkLengthNumericUpDown.Location = new System.Drawing.Point(68, 31);
            this.CupSinkLengthNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CupSinkLengthNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CupSinkLengthNumericUpDown.Name = "CupSinkLengthNumericUpDown";
            this.CupSinkLengthNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.CupSinkLengthNumericUpDown.TabIndex = 11;
            this.CupSinkLengthNumericUpDown.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.CupSinkLengthNumericUpDown.ValueChanged += new System.EventHandler(this.CupSinkLengthNumericUpDown_ValueChanged);
            // 
            // CupSinkWidthNumericUpDown
            // 
            this.CupSinkWidthNumericUpDown.Location = new System.Drawing.Point(191, 31);
            this.CupSinkWidthNumericUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.CupSinkWidthNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CupSinkWidthNumericUpDown.Name = "CupSinkWidthNumericUpDown";
            this.CupSinkWidthNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.CupSinkWidthNumericUpDown.TabIndex = 12;
            this.CupSinkWidthNumericUpDown.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.CupSinkWidthNumericUpDown.ValueChanged += new System.EventHandler(this.CupSinkWidthNumericUpDown_ValueChanged);
            // 
            // DrainHoleDiameterNumericUpDown
            // 
            this.DrainHoleDiameterNumericUpDown.Location = new System.Drawing.Point(191, 31);
            this.DrainHoleDiameterNumericUpDown.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.DrainHoleDiameterNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.DrainHoleDiameterNumericUpDown.Name = "DrainHoleDiameterNumericUpDown";
            this.DrainHoleDiameterNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.DrainHoleDiameterNumericUpDown.TabIndex = 13;
            this.DrainHoleDiameterNumericUpDown.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.DrainHoleDiameterNumericUpDown.ValueChanged += new System.EventHandler(this.DrainHoleDiameterNumericUpDown_ValueChanged);
            // 
            // CraneHoleDiameterNumericUpDown
            // 
            this.CraneHoleDiameterNumericUpDown.Location = new System.Drawing.Point(191, 56);
            this.CraneHoleDiameterNumericUpDown.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.CraneHoleDiameterNumericUpDown.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CraneHoleDiameterNumericUpDown.Name = "CraneHoleDiameterNumericUpDown";
            this.CraneHoleDiameterNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.CraneHoleDiameterNumericUpDown.TabIndex = 14;
            this.CraneHoleDiameterNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CraneHoleDiameterNumericUpDown.ValueChanged += new System.EventHandler(this.CraneHoleDiameterNumericUpDown_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.SinkLengthLabel);
            this.panel1.Controls.Add(this.SinkLengthNumericUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SinkWidthLabel);
            this.panel1.Controls.Add(this.SinkWidthNumericUpDown);
            this.panel1.Controls.Add(this.SinkHeightLabel);
            this.panel1.Controls.Add(this.SinkHeightNumericUpDown);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 65);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Параметры мойки:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CupSinkLengthLabel);
            this.panel2.Controls.Add(this.CupSinkWidthNumericUpDown);
            this.panel2.Controls.Add(this.CupSinkWidthLabel);
            this.panel2.Controls.Add(this.CupSinkLengthNumericUpDown);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 71);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Параметры чаши:";
            // 
            // CraneHoleDiameterLabel
            // 
            this.CraneHoleDiameterLabel.AutoSize = true;
            this.CraneHoleDiameterLabel.Location = new System.Drawing.Point(3, 58);
            this.CraneHoleDiameterLabel.Name = "CraneHoleDiameterLabel";
            this.CraneHoleDiameterLabel.Size = new System.Drawing.Size(180, 13);
            this.CraneHoleDiameterLabel.TabIndex = 17;
            this.CraneHoleDiameterLabel.Text = "Диаметр отверстия для крана (d):";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.CraneHoleDiameterLabel);
            this.panel3.Controls.Add(this.DrainHoleDiameterLabel);
            this.panel3.Controls.Add(this.CraneHoleDiameterNumericUpDown);
            this.panel3.Controls.Add(this.DrainHoleDiameterNumericUpDown);
            this.panel3.Location = new System.Drawing.Point(12, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 88);
            this.panel3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Параметры отверстий:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(405, 294);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buildButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Sink3DPlugin";
            ((System.ComponentModel.ISupportInitialize)(this.SinkLengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinkWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinkHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CupSinkLengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CupSinkWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrainHoleDiameterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CraneHoleDiameterNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Label SinkLengthLabel;
        private System.Windows.Forms.Label SinkWidthLabel;
        private System.Windows.Forms.Label SinkHeightLabel;
        private System.Windows.Forms.Label CupSinkLengthLabel;
        private System.Windows.Forms.Label CupSinkWidthLabel;
        private System.Windows.Forms.Label DrainHoleDiameterLabel;
        private System.Windows.Forms.NumericUpDown SinkLengthNumericUpDown;
        private System.Windows.Forms.NumericUpDown SinkWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown SinkHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown CupSinkLengthNumericUpDown;
        private System.Windows.Forms.NumericUpDown CupSinkWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown DrainHoleDiameterNumericUpDown;
        private System.Windows.Forms.NumericUpDown CraneHoleDiameterNumericUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CraneHoleDiameterLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

