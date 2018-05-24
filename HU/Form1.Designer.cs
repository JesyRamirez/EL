namespace HU
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
            this.button2 = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RichTextBox();
            this.primary = new System.Windows.Forms.Button();
            this.marking = new System.Windows.Forms.Button();
            this.retraction = new System.Windows.Forms.Button();
            this.insulator = new System.Windows.Forms.Button();
            this.secondary = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.itemm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.validation = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.RichTextBox();
            this.spinning = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tiempo
            // 
            this.tiempo.Interval = 20000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(24, 85);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(128, 45);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(437, 203);
            this.info.TabIndex = 5;
            this.info.Text = "";
            // 
            // primary
            // 
            this.primary.BackColor = System.Drawing.Color.Red;
            this.primary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.primary.Location = new System.Drawing.Point(138, 286);
            this.primary.Name = "primary";
            this.primary.Size = new System.Drawing.Size(110, 52);
            this.primary.TabIndex = 6;
            this.primary.Text = "Primary color";
            this.primary.UseVisualStyleBackColor = false;
            this.primary.Click += new System.EventHandler(this.button1_Click);
            // 
            // marking
            // 
            this.marking.BackColor = System.Drawing.Color.Red;
            this.marking.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.marking.Location = new System.Drawing.Point(254, 286);
            this.marking.Name = "marking";
            this.marking.Size = new System.Drawing.Size(110, 52);
            this.marking.TabIndex = 7;
            this.marking.Text = "Marking";
            this.marking.UseVisualStyleBackColor = false;
            this.marking.Click += new System.EventHandler(this.marking_Click);
            // 
            // retraction
            // 
            this.retraction.BackColor = System.Drawing.Color.Red;
            this.retraction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retraction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.retraction.Location = new System.Drawing.Point(370, 286);
            this.retraction.Name = "retraction";
            this.retraction.Size = new System.Drawing.Size(110, 52);
            this.retraction.TabIndex = 8;
            this.retraction.Text = "Retraction cut";
            this.retraction.UseVisualStyleBackColor = false;
            this.retraction.Click += new System.EventHandler(this.retraction_Click);
            // 
            // insulator
            // 
            this.insulator.BackColor = System.Drawing.Color.Red;
            this.insulator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insulator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insulator.Location = new System.Drawing.Point(138, 378);
            this.insulator.Name = "insulator";
            this.insulator.Size = new System.Drawing.Size(110, 52);
            this.insulator.TabIndex = 9;
            this.insulator.Text = "Insulator appearance";
            this.insulator.UseVisualStyleBackColor = false;
            this.insulator.Click += new System.EventHandler(this.insulator_Click);
            this.insulator.DragOver += new System.Windows.Forms.DragEventHandler(this.insulator_DragOver);
            this.insulator.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.insulator_QueryContinueDrag);
            // 
            // secondary
            // 
            this.secondary.BackColor = System.Drawing.Color.Red;
            this.secondary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondary.Location = new System.Drawing.Point(254, 378);
            this.secondary.Name = "secondary";
            this.secondary.Size = new System.Drawing.Size(110, 52);
            this.secondary.TabIndex = 10;
            this.secondary.Text = "Secondary color diameter";
            this.secondary.UseVisualStyleBackColor = false;
            this.secondary.Click += new System.EventHandler(this.secondary_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Status information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Report";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemm});
            this.listView1.Location = new System.Drawing.Point(592, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(198, 205);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // itemm
            // 
            this.itemm.Text = "item";
            // 
            // validation
            // 
            this.validation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validation.Image = global::HU.Properties.Resources.ok;
            this.validation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.validation.Location = new System.Drawing.Point(857, 208);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(101, 60);
            this.validation.TabIndex = 20;
            this.validation.Text = "Validation";
            this.validation.UseVisualStyleBackColor = true;
            this.validation.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(836, 43);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(137, 154);
            this.report.TabIndex = 24;
            this.report.Text = "";
            // 
            // spinning
            // 
            this.spinning.BackColor = System.Drawing.Color.Red;
            this.spinning.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.spinning.ForeColor = System.Drawing.Color.White;
            this.spinning.Location = new System.Drawing.Point(370, 378);
            this.spinning.Name = "spinning";
            this.spinning.Size = new System.Drawing.Size(110, 52);
            this.spinning.TabIndex = 25;
            this.spinning.Text = "Spinning";
            this.spinning.UseVisualStyleBackColor = false;
            this.spinning.Click += new System.EventHandler(this.spinning_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 272);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 35);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(573, 333);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 34);
            this.textBox2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Edit control spool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Extrusion revision";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(573, 390);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 38);
            this.textBox3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Quality line revision";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(574, 452);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(224, 38);
            this.textBox4.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(576, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Control auto";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 502);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.spinning);
            this.Controls.Add(this.report);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.validation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondary);
            this.Controls.Add(this.insulator);
            this.Controls.Add(this.retraction);
            this.Controls.Add(this.marking);
            this.Controls.Add(this.primary);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Ebeam Labeling: Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button primary;
        private System.Windows.Forms.Button marking;
        private System.Windows.Forms.Button retraction;
        private System.Windows.Forms.Button insulator;
        private System.Windows.Forms.Button secondary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button validation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader itemm;
        private System.Windows.Forms.RichTextBox report;
        private System.Windows.Forms.Button spinning;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RichTextBox info;
        public System.Windows.Forms.ListView listView1;
    }
}

