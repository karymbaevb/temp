namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.misBox2 = new System.Windows.Forms.Label();
            this.misBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabOut = new System.Windows.Forms.Label();
            this.TimeLab = new System.Windows.Forms.Label();
            this.tolLabOut = new System.Windows.Forms.Label();
            this.tolLab = new System.Windows.Forms.Label();
            this.iterLabOut = new System.Windows.Forms.Label();
            this.iterLab = new System.Windows.Forms.Label();
            this.funcLabOut = new System.Windows.Forms.Label();
            this.funcLab = new System.Windows.Forms.Label();
            this.xLabOut = new System.Windows.Forms.Label();
            this.xLab = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tLab = new System.Windows.Forms.Label();
            this.max_timeBox = new System.Windows.Forms.TextBox();
            this.m_iterLab = new System.Windows.Forms.Label();
            this.iterBox = new System.Windows.Forms.TextBox();
            this.tolerLab = new System.Windows.Forms.Label();
            this.tolBox = new System.Windows.Forms.TextBox();
            this.bLab = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.TextBox();
            this.aLab = new System.Windows.Forms.Label();
            this.aBox = new System.Windows.Forms.TextBox();
            this.functionLab = new System.Windows.Forms.Label();
            this.funcBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 257);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(714, 25);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(373, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 22;
            this.button2.Text = "Clear";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.timeLabOut);
            this.groupBox1.Controls.Add(this.TimeLab);
            this.groupBox1.Controls.Add(this.tolLabOut);
            this.groupBox1.Controls.Add(this.tolLab);
            this.groupBox1.Controls.Add(this.iterLabOut);
            this.groupBox1.Controls.Add(this.iterLab);
            this.groupBox1.Controls.Add(this.funcLabOut);
            this.groupBox1.Controls.Add(this.funcLab);
            this.groupBox1.Controls.Add(this.xLabOut);
            this.groupBox1.Controls.Add(this.xLab);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(373, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 238);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.misBox2);
            this.panel1.Controls.Add(this.misBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 56);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // misBox2
            // 
            this.misBox2.AutoSize = true;
            this.misBox2.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Italic);
            this.misBox2.Location = new System.Drawing.Point(75, 27);
            this.misBox2.Name = "misBox2";
            this.misBox2.Size = new System.Drawing.Size(0, 17);
            this.misBox2.TabIndex = 35;
            // 
            // misBox
            // 
            this.misBox.AutoSize = true;
            this.misBox.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Italic);
            this.misBox.Location = new System.Drawing.Point(71, 9);
            this.misBox.Name = "misBox";
            this.misBox.Size = new System.Drawing.Size(0, 17);
            this.misBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Message:";
            // 
            // timeLabOut
            // 
            this.timeLabOut.AutoSize = true;
            this.timeLabOut.Location = new System.Drawing.Point(154, 151);
            this.timeLabOut.Name = "timeLabOut";
            this.timeLabOut.Size = new System.Drawing.Size(0, 13);
            this.timeLabOut.TabIndex = 31;
            // 
            // TimeLab
            // 
            this.TimeLab.AutoSize = true;
            this.TimeLab.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLab.Location = new System.Drawing.Point(13, 150);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(136, 19);
            this.TimeLab.TabIndex = 30;
            this.TimeLab.Text = "Elapse time(in sec)";
            // 
            // tolLabOut
            // 
            this.tolLabOut.AutoSize = true;
            this.tolLabOut.Location = new System.Drawing.Point(113, 116);
            this.tolLabOut.Name = "tolLabOut";
            this.tolLabOut.Size = new System.Drawing.Size(0, 13);
            this.tolLabOut.TabIndex = 29;
            // 
            // tolLab
            // 
            this.tolLab.AutoSize = true;
            this.tolLab.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tolLab.Location = new System.Drawing.Point(13, 116);
            this.tolLab.Name = "tolLab";
            this.tolLab.Size = new System.Drawing.Size(65, 19);
            this.tolLab.TabIndex = 28;
            this.tolLab.Text = "abs(b-a)";
            // 
            // iterLabOut
            // 
            this.iterLabOut.AutoSize = true;
            this.iterLabOut.Location = new System.Drawing.Point(113, 86);
            this.iterLabOut.Name = "iterLabOut";
            this.iterLabOut.Size = new System.Drawing.Size(0, 13);
            this.iterLabOut.TabIndex = 27;
            // 
            // iterLab
            // 
            this.iterLab.AutoSize = true;
            this.iterLab.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterLab.Location = new System.Drawing.Point(13, 86);
            this.iterLab.Name = "iterLab";
            this.iterLab.Size = new System.Drawing.Size(68, 19);
            this.iterLab.TabIndex = 26;
            this.iterLab.Text = "Iteration";
            // 
            // funcLabOut
            // 
            this.funcLabOut.AutoSize = true;
            this.funcLabOut.Location = new System.Drawing.Point(120, 53);
            this.funcLabOut.Name = "funcLabOut";
            this.funcLabOut.Size = new System.Drawing.Size(0, 13);
            this.funcLabOut.TabIndex = 25;
            // 
            // funcLab
            // 
            this.funcLab.AutoSize = true;
            this.funcLab.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.funcLab.Location = new System.Drawing.Point(9, 52);
            this.funcLab.Name = "funcLab";
            this.funcLab.Size = new System.Drawing.Size(89, 19);
            this.funcLab.TabIndex = 24;
            this.funcLab.Text = "Function(x)";
            // 
            // xLabOut
            // 
            this.xLabOut.AutoSize = true;
            this.xLabOut.Location = new System.Drawing.Point(120, 25);
            this.xLabOut.Name = "xLabOut";
            this.xLabOut.Size = new System.Drawing.Size(0, 13);
            this.xLabOut.TabIndex = 23;
            // 
            // xLab
            // 
            this.xLab.AutoSize = true;
            this.xLab.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xLab.Location = new System.Drawing.Point(13, 20);
            this.xLab.Name = "xLab";
            this.xLab.Size = new System.Drawing.Size(19, 19);
            this.xLab.TabIndex = 22;
            this.xLab.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tLab);
            this.groupBox2.Controls.Add(this.max_timeBox);
            this.groupBox2.Controls.Add(this.m_iterLab);
            this.groupBox2.Controls.Add(this.iterBox);
            this.groupBox2.Controls.Add(this.tolerLab);
            this.groupBox2.Controls.Add(this.tolBox);
            this.groupBox2.Controls.Add(this.bLab);
            this.groupBox2.Controls.Add(this.bBox);
            this.groupBox2.Controls.Add(this.aLab);
            this.groupBox2.Controls.Add(this.aBox);
            this.groupBox2.Controls.Add(this.functionLab);
            this.groupBox2.Controls.Add(this.funcBox);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(15, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 238);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter ";
            // 
            // tLab
            // 
            this.tLab.AutoSize = true;
            this.tLab.Location = new System.Drawing.Point(7, 181);
            this.tLab.Name = "tLab";
            this.tLab.Size = new System.Drawing.Size(98, 14);
            this.tLab.TabIndex = 23;
            this.tLab.Text = "max_time (in sec)";
            // 
            // max_timeBox
            // 
            this.max_timeBox.Location = new System.Drawing.Point(112, 178);
            this.max_timeBox.Name = "max_timeBox";
            this.max_timeBox.Size = new System.Drawing.Size(116, 21);
            this.max_timeBox.TabIndex = 22;
            this.max_timeBox.Text = "30";
            // 
            // m_iterLab
            // 
            this.m_iterLab.AutoSize = true;
            this.m_iterLab.Location = new System.Drawing.Point(24, 153);
            this.m_iterLab.Name = "m_iterLab";
            this.m_iterLab.Size = new System.Drawing.Size(78, 14);
            this.m_iterLab.TabIndex = 21;
            this.m_iterLab.Text = "max_iteration";
            // 
            // iterBox
            // 
            this.iterBox.Location = new System.Drawing.Point(112, 148);
            this.iterBox.Name = "iterBox";
            this.iterBox.Size = new System.Drawing.Size(116, 21);
            this.iterBox.TabIndex = 20;
            this.iterBox.Text = "100";
            // 
            // tolerLab
            // 
            this.tolerLab.AutoSize = true;
            this.tolerLab.Location = new System.Drawing.Point(45, 123);
            this.tolerLab.Name = "tolerLab";
            this.tolerLab.Size = new System.Drawing.Size(56, 14);
            this.tolerLab.TabIndex = 19;
            this.tolerLab.Text = "tolerance";
            // 
            // tolBox
            // 
            this.tolBox.Location = new System.Drawing.Point(112, 120);
            this.tolBox.Name = "tolBox";
            this.tolBox.Size = new System.Drawing.Size(228, 21);
            this.tolBox.TabIndex = 18;
            this.tolBox.Text = "1e-28";
            // 
            // bLab
            // 
            this.bLab.AutoSize = true;
            this.bLab.Location = new System.Drawing.Point(57, 93);
            this.bLab.Name = "bLab";
            this.bLab.Size = new System.Drawing.Size(44, 14);
            this.bLab.TabIndex = 17;
            this.bLab.Text = "Enter b";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(112, 87);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(116, 21);
            this.bBox.TabIndex = 16;
            this.bBox.Text = "3";
            // 
            // aLab
            // 
            this.aLab.AutoSize = true;
            this.aLab.Location = new System.Drawing.Point(57, 58);
            this.aLab.Name = "aLab";
            this.aLab.Size = new System.Drawing.Size(43, 14);
            this.aLab.TabIndex = 15;
            this.aLab.Text = "Enter a";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(112, 53);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(116, 21);
            this.aBox.TabIndex = 14;
            this.aBox.Text = "1";
            // 
            // functionLab
            // 
            this.functionLab.AutoSize = true;
            this.functionLab.Location = new System.Drawing.Point(49, 28);
            this.functionLab.Name = "functionLab";
            this.functionLab.Size = new System.Drawing.Size(54, 14);
            this.functionLab.TabIndex = 13;
            this.functionLab.Text = "Function";
            // 
            // funcBox
            // 
            this.funcBox.Location = new System.Drawing.Point(108, 25);
            this.funcBox.Name = "funcBox";
            this.funcBox.Size = new System.Drawing.Size(228, 21);
            this.funcBox.TabIndex = 12;
            this.funcBox.Text = "2*x^3+3*x^2-9*x-9";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(791, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label timeLabOut;
        private System.Windows.Forms.Label TimeLab;
        private System.Windows.Forms.Label tolLabOut;
        private System.Windows.Forms.Label tolLab;
        private System.Windows.Forms.Label iterLabOut;
        private System.Windows.Forms.Label iterLab;
        private System.Windows.Forms.Label funcLabOut;
        private System.Windows.Forms.Label funcLab;
        private System.Windows.Forms.Label xLabOut;
        private System.Windows.Forms.Label xLab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label m_iterLab;
        private System.Windows.Forms.TextBox iterBox;
        private System.Windows.Forms.Label tolerLab;
        private System.Windows.Forms.TextBox tolBox;
        private System.Windows.Forms.Label bLab;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Label aLab;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.Label functionLab;
        private System.Windows.Forms.TextBox funcBox;
        private System.Windows.Forms.Label tLab;
        private System.Windows.Forms.TextBox max_timeBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label misBox;
        private System.Windows.Forms.Label misBox2;
    }
}

