namespace HU
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.primary = new System.Windows.Forms.Button();
            this.marking = new System.Windows.Forms.Button();
            this.retraction = new System.Windows.Forms.Button();
            this.insulator = new System.Windows.Forms.Button();
            this.secondary = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.spinning = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.RichTextBox();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.itemm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(130, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(134, 65);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(390, 167);
            this.info.TabIndex = 3;
            this.info.Text = "";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemm});
            this.listView1.Location = new System.Drawing.Point(575, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(206, 167);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // primary
            // 
            this.primary.BackColor = System.Drawing.Color.Red;
            this.primary.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primary.ForeColor = System.Drawing.Color.White;
            this.primary.Location = new System.Drawing.Point(111, 318);
            this.primary.Name = "primary";
            this.primary.Size = new System.Drawing.Size(106, 49);
            this.primary.TabIndex = 5;
            this.primary.Text = "Primary color";
            this.primary.UseVisualStyleBackColor = false;
            this.primary.Click += new System.EventHandler(this.button3_Click);
            // 
            // marking
            // 
            this.marking.BackColor = System.Drawing.Color.Red;
            this.marking.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marking.ForeColor = System.Drawing.Color.White;
            this.marking.Location = new System.Drawing.Point(223, 318);
            this.marking.Name = "marking";
            this.marking.Size = new System.Drawing.Size(106, 49);
            this.marking.TabIndex = 6;
            this.marking.Text = "Marking";
            this.marking.UseVisualStyleBackColor = false;
            this.marking.Click += new System.EventHandler(this.marking_Click);
            // 
            // retraction
            // 
            this.retraction.BackColor = System.Drawing.Color.Red;
            this.retraction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retraction.ForeColor = System.Drawing.Color.White;
            this.retraction.Location = new System.Drawing.Point(335, 318);
            this.retraction.Name = "retraction";
            this.retraction.Size = new System.Drawing.Size(106, 49);
            this.retraction.TabIndex = 7;
            this.retraction.Text = "Retraction cut";
            this.retraction.UseVisualStyleBackColor = false;
            this.retraction.Click += new System.EventHandler(this.retraction_Click);
            // 
            // insulator
            // 
            this.insulator.BackColor = System.Drawing.Color.Red;
            this.insulator.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insulator.ForeColor = System.Drawing.Color.White;
            this.insulator.Location = new System.Drawing.Point(447, 317);
            this.insulator.Name = "insulator";
            this.insulator.Size = new System.Drawing.Size(106, 49);
            this.insulator.TabIndex = 8;
            this.insulator.Text = "Insulator appearance";
            this.insulator.UseVisualStyleBackColor = false;
            this.insulator.Click += new System.EventHandler(this.insulator_Click);
            // 
            // secondary
            // 
            this.secondary.BackColor = System.Drawing.Color.Red;
            this.secondary.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondary.ForeColor = System.Drawing.Color.White;
            this.secondary.Location = new System.Drawing.Point(559, 317);
            this.secondary.Name = "secondary";
            this.secondary.Size = new System.Drawing.Size(106, 49);
            this.secondary.TabIndex = 9;
            this.secondary.Text = "Secondary color diameter";
            this.secondary.UseVisualStyleBackColor = false;
            this.secondary.Click += new System.EventHandler(this.secondary_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::HU.Properties.Resources.ok;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(134, 249);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 41);
            this.button8.TabIndex = 10;
            this.button8.Text = "Validation";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(470, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reports";
            // 
            // spinning
            // 
            this.spinning.BackColor = System.Drawing.Color.Red;
            this.spinning.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinning.ForeColor = System.Drawing.Color.White;
            this.spinning.Location = new System.Drawing.Point(671, 319);
            this.spinning.Name = "spinning";
            this.spinning.Size = new System.Drawing.Size(106, 47);
            this.spinning.TabIndex = 12;
            this.spinning.Text = "Spinning";
            this.spinning.UseVisualStyleBackColor = false;
            this.spinning.Click += new System.EventHandler(this.spinning_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(821, 91);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(51, 96);
            this.report.TabIndex = 13;
            this.report.Text = "";
            // 
            // tiempo
            // 
            this.tiempo.Interval = 20000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 393);
            this.Controls.Add(this.report);
            this.Controls.Add(this.spinning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.secondary);
            this.Controls.Add(this.insulator);
            this.Controls.Add(this.retraction);
            this.Controls.Add(this.marking);
            this.Controls.Add(this.primary);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Ebeam labeling: Operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button primary;
        private System.Windows.Forms.Button marking;
        private System.Windows.Forms.Button retraction;
        private System.Windows.Forms.Button insulator;
        private System.Windows.Forms.Button secondary;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button spinning;
        private System.Windows.Forms.RichTextBox report;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.ColumnHeader itemm;
    }
}