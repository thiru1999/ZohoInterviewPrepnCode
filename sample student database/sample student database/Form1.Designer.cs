namespace sample_student_database
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.phno = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.MALE = new System.Windows.Forms.RadioButton();
            this.LOAD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "STUDENT_NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "STUDENT_PH_NO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(171, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(311, 27);
            this.name.TabIndex = 3;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(171, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(311, 27);
            this.id.TabIndex = 4;
            this.id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // phno
            // 
            this.phno.Location = new System.Drawing.Point(171, 145);
            this.phno.Name = "phno";
            this.phno.Size = new System.Drawing.Size(311, 27);
            this.phno.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(570, 115);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FEMALE";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MALE
            // 
            this.MALE.AutoSize = true;
            this.MALE.Location = new System.Drawing.Point(570, 69);
            this.MALE.Name = "MALE";
            this.MALE.Size = new System.Drawing.Size(68, 24);
            this.MALE.TabIndex = 7;
            this.MALE.TabStop = true;
            this.MALE.Text = "MALE";
            this.MALE.UseVisualStyleBackColor = true;
            // 
            // LOAD
            // 
            this.LOAD.Location = new System.Drawing.Point(147, 278);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(144, 52);
            this.LOAD.TabIndex = 8;
            this.LOAD.Text = "LOAD";
            this.LOAD.UseVisualStyleBackColor = true;
            this.LOAD.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LOAD);
            this.Controls.Add(this.MALE);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.phno);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox id;
        private TextBox phno;
        private RadioButton radioButton1;
        private RadioButton MALE;
        private Button LOAD;
        private Button button2;
    }
}