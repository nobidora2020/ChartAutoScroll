
namespace ChartAutoScroll
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series97 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series98 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series99 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series100 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series101 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series102 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series103 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series104 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series105 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series106 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series107 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series108 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PowerDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartCbx = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MzChk = new System.Windows.Forms.CheckBox();
            this.MyChk = new System.Windows.Forms.CheckBox();
            this.MxChk = new System.Windows.Forms.CheckBox();
            this.FzChk = new System.Windows.Forms.CheckBox();
            this.FyChk = new System.Windows.Forms.CheckBox();
            this.FxChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PowerDataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PowerDataChart
            // 
            this.PowerDataChart.BackColor = System.Drawing.Color.Black;
            this.PowerDataChart.BorderlineColor = System.Drawing.Color.Black;
            this.PowerDataChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea9.AxisX.Interval = 1D;
            chartArea9.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea9.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.LabelStyle.Enabled = false;
            chartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisX.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.Maximum = 5D;
            chartArea9.AxisX.Minimum = -5D;
            chartArea9.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea9.AxisX.ScaleView.Zoomable = false;
            chartArea9.AxisX.ScrollBar.BackColor = System.Drawing.Color.DarkGray;
            chartArea9.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Black;
            chartArea9.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea9.AxisX.ScrollBar.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.Interval = 20D;
            chartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorTickMark.Interval = 10D;
            chartArea9.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.Maximum = 140D;
            chartArea9.AxisY.Minimum = -140D;
            chartArea9.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea9.BackColor = System.Drawing.Color.Black;
            chartArea9.BorderColor = System.Drawing.Color.White;
            chartArea9.Name = "ChartArea1";
            this.PowerDataChart.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.Color.White;
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.PowerDataChart.Legends.Add(legend9);
            this.PowerDataChart.Location = new System.Drawing.Point(12, 40);
            this.PowerDataChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PowerDataChart.Name = "PowerDataChart";
            series97.ChartArea = "ChartArea1";
            series97.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series97.Color = System.Drawing.Color.Blue;
            series97.Legend = "Legend1";
            series97.Name = "SeriesFx";
            series98.ChartArea = "ChartArea1";
            series98.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series98.Color = System.Drawing.Color.Green;
            series98.Legend = "Legend1";
            series98.Name = "SeriesFy";
            series99.ChartArea = "ChartArea1";
            series99.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series99.Color = System.Drawing.Color.Red;
            series99.Legend = "Legend1";
            series99.Name = "SeriesFz";
            series100.ChartArea = "ChartArea1";
            series100.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series100.Color = System.Drawing.Color.Aqua;
            series100.Legend = "Legend1";
            series100.Name = "SeriesMx";
            series101.ChartArea = "ChartArea1";
            series101.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series101.Color = System.Drawing.Color.Lime;
            series101.Legend = "Legend1";
            series101.Name = "SeriesMy";
            series102.ChartArea = "ChartArea1";
            series102.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series102.Color = System.Drawing.Color.Fuchsia;
            series102.Legend = "Legend1";
            series102.Name = "SeriesMz";
            series103.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series103.ChartArea = "ChartArea1";
            series103.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series103.Color = System.Drawing.Color.Aqua;
            series103.Legend = "Legend1";
            series103.Name = "SeriesFx_Off";
            series104.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series104.ChartArea = "ChartArea1";
            series104.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series104.Color = System.Drawing.Color.Lime;
            series104.Legend = "Legend1";
            series104.Name = "SeriesFy_Off";
            series105.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series105.ChartArea = "ChartArea1";
            series105.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series105.Color = System.Drawing.Color.Fuchsia;
            series105.Legend = "Legend1";
            series105.Name = "SeriesFz_Off";
            series106.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series106.ChartArea = "ChartArea1";
            series106.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series106.Color = System.Drawing.Color.Blue;
            series106.Legend = "Legend1";
            series106.Name = "SeriesMx_Off";
            series107.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series107.ChartArea = "ChartArea1";
            series107.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series107.Color = System.Drawing.Color.Green;
            series107.Legend = "Legend1";
            series107.Name = "SeriesMy_Off";
            series108.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series108.ChartArea = "ChartArea1";
            series108.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series108.Color = System.Drawing.Color.Red;
            series108.Legend = "Legend1";
            series108.Name = "SeriesMz_Off";
            this.PowerDataChart.Series.Add(series97);
            this.PowerDataChart.Series.Add(series98);
            this.PowerDataChart.Series.Add(series99);
            this.PowerDataChart.Series.Add(series100);
            this.PowerDataChart.Series.Add(series101);
            this.PowerDataChart.Series.Add(series102);
            this.PowerDataChart.Series.Add(series103);
            this.PowerDataChart.Series.Add(series104);
            this.PowerDataChart.Series.Add(series105);
            this.PowerDataChart.Series.Add(series106);
            this.PowerDataChart.Series.Add(series107);
            this.PowerDataChart.Series.Add(series108);
            this.PowerDataChart.Size = new System.Drawing.Size(643, 398);
            this.PowerDataChart.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Yごと";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(852, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "Yレンジ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(689, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(193, 249);
            this.dataGridView1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(676, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 65);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(756, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 65);
            this.button5.TabIndex = 9;
            this.button5.Text = "clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 442);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(643, 21);
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(689, 497);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chartCbx
            // 
            this.chartCbx.AutoSize = true;
            this.chartCbx.Location = new System.Drawing.Point(435, 483);
            this.chartCbx.Name = "chartCbx";
            this.chartCbx.Size = new System.Drawing.Size(101, 19);
            this.chartCbx.TabIndex = 12;
            this.chartCbx.Text = "checkBox1";
            this.chartCbx.UseVisualStyleBackColor = true;
            this.chartCbx.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("メイリオ", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 466);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // MzChk
            // 
            this.MzChk.AutoSize = true;
            this.MzChk.ForeColor = System.Drawing.Color.Fuchsia;
            this.MzChk.Location = new System.Drawing.Point(276, 13);
            this.MzChk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MzChk.Name = "MzChk";
            this.MzChk.Size = new System.Drawing.Size(47, 19);
            this.MzChk.TabIndex = 57;
            this.MzChk.Text = "Mz";
            this.MzChk.UseVisualStyleBackColor = true;
            this.MzChk.CheckedChanged += new System.EventHandler(this.MzChk_CheckedChanged);
            // 
            // MyChk
            // 
            this.MyChk.AutoSize = true;
            this.MyChk.ForeColor = System.Drawing.Color.Lime;
            this.MyChk.Location = new System.Drawing.Point(226, 13);
            this.MyChk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyChk.Name = "MyChk";
            this.MyChk.Size = new System.Drawing.Size(47, 19);
            this.MyChk.TabIndex = 56;
            this.MyChk.Text = "My";
            this.MyChk.UseVisualStyleBackColor = true;
            this.MyChk.CheckedChanged += new System.EventHandler(this.MyChk_CheckedChanged);
            // 
            // MxChk
            // 
            this.MxChk.AutoSize = true;
            this.MxChk.ForeColor = System.Drawing.Color.Aqua;
            this.MxChk.Location = new System.Drawing.Point(176, 13);
            this.MxChk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MxChk.Name = "MxChk";
            this.MxChk.Size = new System.Drawing.Size(47, 19);
            this.MxChk.TabIndex = 55;
            this.MxChk.Text = "Mx";
            this.MxChk.UseVisualStyleBackColor = true;
            this.MxChk.CheckedChanged += new System.EventHandler(this.MxChk_CheckedChanged);
            // 
            // FzChk
            // 
            this.FzChk.AutoSize = true;
            this.FzChk.ForeColor = System.Drawing.Color.Red;
            this.FzChk.Location = new System.Drawing.Point(126, 13);
            this.FzChk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FzChk.Name = "FzChk";
            this.FzChk.Size = new System.Drawing.Size(44, 19);
            this.FzChk.TabIndex = 54;
            this.FzChk.Text = "Fz";
            this.FzChk.UseVisualStyleBackColor = true;
            this.FzChk.CheckedChanged += new System.EventHandler(this.FzChk_CheckedChanged);
            // 
            // FyChk
            // 
            this.FyChk.AutoSize = true;
            this.FyChk.Checked = true;
            this.FyChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FyChk.ForeColor = System.Drawing.Color.Green;
            this.FyChk.Location = new System.Drawing.Point(76, 13);
            this.FyChk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FyChk.Name = "FyChk";
            this.FyChk.Size = new System.Drawing.Size(44, 19);
            this.FyChk.TabIndex = 53;
            this.FyChk.Text = "Fy";
            this.FyChk.UseVisualStyleBackColor = true;
            this.FyChk.CheckedChanged += new System.EventHandler(this.FyChk_CheckedChanged);
            // 
            // FxChk
            // 
            this.FxChk.AutoSize = true;
            this.FxChk.Checked = true;
            this.FxChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FxChk.ForeColor = System.Drawing.Color.Blue;
            this.FxChk.Location = new System.Drawing.Point(25, 13);
            this.FxChk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FxChk.Name = "FxChk";
            this.FxChk.Size = new System.Drawing.Size(44, 19);
            this.FxChk.TabIndex = 52;
            this.FxChk.Text = "Fx";
            this.FxChk.UseVisualStyleBackColor = true;
            this.FxChk.CheckedChanged += new System.EventHandler(this.FxChk_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 655);
            this.Controls.Add(this.MzChk);
            this.Controls.Add(this.MyChk);
            this.Controls.Add(this.MxChk);
            this.Controls.Add(this.FzChk);
            this.Controls.Add(this.FyChk);
            this.Controls.Add(this.FxChk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chartCbx);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PowerDataChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PowerDataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PowerDataChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chartCbx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox MzChk;
        private System.Windows.Forms.CheckBox MyChk;
        private System.Windows.Forms.CheckBox MxChk;
        private System.Windows.Forms.CheckBox FzChk;
        private System.Windows.Forms.CheckBox FyChk;
        private System.Windows.Forms.CheckBox FxChk;
    }
}

