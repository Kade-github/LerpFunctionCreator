namespace LerpCreation
{
    partial class LFC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LFC));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.createStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteStep = new System.Windows.Forms.Button();
            this.dupStep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ifCheck = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.operation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xVal = new System.Windows.Forms.TextBox();
            this.operationVal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveStep = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Maximum = 1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Black;
            chartArea1.CursorX.Interval = 0.1D;
            chartArea1.CursorY.Interval = 0.1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(-1, 26);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.CustomProperties = "LineTension=1";
            series1.Name = "Lerp Func";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(536, 424);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(541, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(256, 52);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // createStep
            // 
            this.createStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createStep.Location = new System.Drawing.Point(541, 88);
            this.createStep.Name = "createStep";
            this.createStep.Size = new System.Drawing.Size(75, 23);
            this.createStep.TabIndex = 2;
            this.createStep.Text = "Create Step";
            this.createStep.UseVisualStyleBackColor = true;
            this.createStep.Click += new System.EventHandler(this.createStep_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(541, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Steps";
            // 
            // deleteStep
            // 
            this.deleteStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStep.Location = new System.Drawing.Point(622, 88);
            this.deleteStep.Name = "deleteStep";
            this.deleteStep.Size = new System.Drawing.Size(75, 23);
            this.deleteStep.TabIndex = 4;
            this.deleteStep.Text = "Delete Step";
            this.deleteStep.UseVisualStyleBackColor = true;
            this.deleteStep.Click += new System.EventHandler(this.deleteStep_Click);
            // 
            // dupStep
            // 
            this.dupStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dupStep.Location = new System.Drawing.Point(703, 88);
            this.dupStep.Name = "dupStep";
            this.dupStep.Size = new System.Drawing.Size(94, 23);
            this.dupStep.TabIndex = 5;
            this.dupStep.Text = "Duplicate Step";
            this.dupStep.UseVisualStyleBackColor = true;
            this.dupStep.Click += new System.EventHandler(this.dupStep_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(541, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Instructions";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(541, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(249, 80);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // ifCheck
            // 
            this.ifCheck.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ifCheck.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ifCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ifCheck.FormattingEnabled = true;
            this.ifCheck.Items.AddRange(new object[] {"LessThan", "GreaterThan", "LessThanOrEqual", "GreaterThanOrEqual"});
            this.ifCheck.Location = new System.Drawing.Point(622, 145);
            this.ifCheck.Name = "ifCheck";
            this.ifCheck.Size = new System.Drawing.Size(166, 21);
            this.ifCheck.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(541, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "If Check";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(541, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Operation";
            // 
            // operation
            // 
            this.operation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.operation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {"Addition", "Subtraction", "Multiplication", "Division", "Pow", "SquareRoot"});
            this.operation.Location = new System.Drawing.Point(622, 198);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(166, 21);
            this.operation.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(541, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Check X Val";
            // 
            // xVal
            // 
            this.xVal.Location = new System.Drawing.Point(622, 172);
            this.xVal.Name = "xVal";
            this.xVal.Size = new System.Drawing.Size(166, 20);
            this.xVal.TabIndex = 14;
            this.xVal.TextChanged += new System.EventHandler(this.xVal_TextChanged);
            // 
            // operationVal
            // 
            this.operationVal.Location = new System.Drawing.Point(622, 225);
            this.operationVal.Name = "operationVal";
            this.operationVal.Size = new System.Drawing.Size(166, 20);
            this.operationVal.TabIndex = 16;
            this.operationVal.TextChanged += new System.EventHandler(this.operationVal_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(541, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Operation Val";
            // 
            // saveStep
            // 
            this.saveStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveStep.Location = new System.Drawing.Point(541, 255);
            this.saveStep.Name = "saveStep";
            this.saveStep.Size = new System.Drawing.Size(75, 23);
            this.saveStep.TabIndex = 17;
            this.saveStep.Text = "Save Step";
            this.saveStep.UseVisualStyleBackColor = true;
            this.saveStep.Click += new System.EventHandler(this.saveStep_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(541, 334);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(257, 106);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(249, 80);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "C++";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(249, 80);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lua";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(249, 80);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(541, 338);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(257, 106);
            this.tabControl2.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(23, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 15);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Dark Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveStep);
            this.Controls.Add(this.operationVal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xVal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ifCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dupStep);
            this.Controls.Add(this.deleteStep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createStep);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "LFC";
            this.Text = "Lerp Function Creator";
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.TabControl tabControl2;


        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.ComboBox ifCheck;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        
        
        
        
        
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox operationVal;
        private System.Windows.Forms.TextBox xVal;
        private System.Windows.Forms.Button deleteStep;
        private System.Windows.Forms.Button dupStep;

        private System.Windows.Forms.Button createStep;
        private System.Windows.Forms.Button saveStep;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        #endregion
    }
}