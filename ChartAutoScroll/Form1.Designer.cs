
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PowerDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.oneAddBtn = new System.Windows.Forms.Button();
            this.yIntervalBtn = new System.Windows.Forms.Button();
            this.yRangeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartCbx = new System.Windows.Forms.CheckBox();
            this.xRangeCmb = new System.Windows.Forms.ComboBox();
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
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Maximum = 5D;
            chartArea1.AxisX.Minimum = -5D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.Interval = 20D;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.Interval = 10D;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Maximum = 140D;
            chartArea1.AxisY.Minimum = -140D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.PowerDataChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.PowerDataChart.Legends.Add(legend1);
            this.PowerDataChart.Location = new System.Drawing.Point(9, 32);
            this.PowerDataChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PowerDataChart.Name = "PowerDataChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "SeriesFx";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "SeriesFy";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "SeriesFz";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.Aqua;
            series4.Legend = "Legend1";
            series4.Name = "SeriesMx";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.Lime;
            series5.Legend = "Legend1";
            series5.Name = "SeriesMy";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.Fuchsia;
            series6.Legend = "Legend1";
            series6.Name = "SeriesMz";
            series7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Color = System.Drawing.Color.Aqua;
            series7.Legend = "Legend1";
            series7.Name = "SeriesFx_Off";
            series8.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Color = System.Drawing.Color.Lime;
            series8.Legend = "Legend1";
            series8.Name = "SeriesFy_Off";
            series9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Color = System.Drawing.Color.Fuchsia;
            series9.Legend = "Legend1";
            series9.Name = "SeriesFz_Off";
            series10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Color = System.Drawing.Color.Blue;
            series10.Legend = "Legend1";
            series10.Name = "SeriesMx_Off";
            series11.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Color = System.Drawing.Color.Green;
            series11.Legend = "Legend1";
            series11.Name = "SeriesMy_Off";
            series12.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Color = System.Drawing.Color.Red;
            series12.Legend = "Legend1";
            series12.Name = "SeriesMz_Off";
            this.PowerDataChart.Series.Add(series1);
            this.PowerDataChart.Series.Add(series2);
            this.PowerDataChart.Series.Add(series3);
            this.PowerDataChart.Series.Add(series4);
            this.PowerDataChart.Series.Add(series5);
            this.PowerDataChart.Series.Add(series6);
            this.PowerDataChart.Series.Add(series7);
            this.PowerDataChart.Series.Add(series8);
            this.PowerDataChart.Series.Add(series9);
            this.PowerDataChart.Series.Add(series10);
            this.PowerDataChart.Series.Add(series11);
            this.PowerDataChart.Series.Add(series12);
            this.PowerDataChart.Size = new System.Drawing.Size(482, 318);
            this.PowerDataChart.TabIndex = 1;
            // 
            // oneAddBtn
            // 
            this.oneAddBtn.Location = new System.Drawing.Point(507, 19);
            this.oneAddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oneAddBtn.Name = "oneAddBtn";
            this.oneAddBtn.Size = new System.Drawing.Size(56, 46);
            this.oneAddBtn.TabIndex = 2;
            this.oneAddBtn.Text = "One";
            this.oneAddBtn.UseVisualStyleBackColor = true;
            this.oneAddBtn.Click += new System.EventHandler(this.OneAddBtn_Click);
            // 
            // yIntervalBtn
            // 
            this.yIntervalBtn.Location = new System.Drawing.Point(568, 19);
            this.yIntervalBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yIntervalBtn.Name = "yIntervalBtn";
            this.yIntervalBtn.Size = new System.Drawing.Size(56, 46);
            this.yIntervalBtn.TabIndex = 3;
            this.yIntervalBtn.Text = "Yごと";
            this.yIntervalBtn.UseVisualStyleBackColor = true;
            this.yIntervalBtn.Click += new System.EventHandler(this.YIntervalBtn_Click);
            // 
            // yRangeBtn
            // 
            this.yRangeBtn.Location = new System.Drawing.Point(639, 19);
            this.yRangeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yRangeBtn.Name = "yRangeBtn";
            this.yRangeBtn.Size = new System.Drawing.Size(55, 46);
            this.yRangeBtn.TabIndex = 6;
            this.yRangeBtn.Text = "Yレンジ";
            this.yRangeBtn.UseVisualStyleBackColor = true;
            this.yRangeBtn.Click += new System.EventHandler(this.YRangeBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(517, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(145, 210);
            this.dataGridView1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 82);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 52);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(567, 85);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(56, 52);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(9, 354);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(482, 21);
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 386);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 19);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(517, 409);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 19);
            this.textBox2.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chartCbx
            // 
            this.chartCbx.AutoSize = true;
            this.chartCbx.Font = new System.Drawing.Font("メイリオ", 9F);
            this.chartCbx.Location = new System.Drawing.Point(320, 373);
            this.chartCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartCbx.Name = "chartCbx";
            this.chartCbx.Size = new System.Drawing.Size(88, 22);
            this.chartCbx.TabIndex = 12;
            this.chartCbx.Text = "Auto Satrt";
            this.chartCbx.UseVisualStyleBackColor = true;
            this.chartCbx.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // xRangeCmb
            // 
            this.xRangeCmb.Font = new System.Drawing.Font("メイリオ", 9F);
            this.xRangeCmb.FormattingEnabled = true;
            this.xRangeCmb.Location = new System.Drawing.Point(183, 373);
            this.xRangeCmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xRangeCmb.Name = "xRangeCmb";
            this.xRangeCmb.Size = new System.Drawing.Size(92, 26);
            this.xRangeCmb.TabIndex = 13;
            this.xRangeCmb.SelectedIndexChanged += new System.EventHandler(this.XRangeCmb_SelectedIndexChanged);
            // 
            // MzChk
            // 
            this.MzChk.AutoSize = true;
            this.MzChk.ForeColor = System.Drawing.Color.Fuchsia;
            this.MzChk.Location = new System.Drawing.Point(207, 10);
            this.MzChk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MzChk.Name = "MzChk";
            this.MzChk.Size = new System.Drawing.Size(38, 16);
            this.MzChk.TabIndex = 57;
            this.MzChk.Text = "Mz";
            this.MzChk.UseVisualStyleBackColor = true;
            this.MzChk.CheckedChanged += new System.EventHandler(this.MzChk_CheckedChanged);
            // 
            // MyChk
            // 
            this.MyChk.AutoSize = true;
            this.MyChk.ForeColor = System.Drawing.Color.Lime;
            this.MyChk.Location = new System.Drawing.Point(170, 10);
            this.MyChk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MyChk.Name = "MyChk";
            this.MyChk.Size = new System.Drawing.Size(39, 16);
            this.MyChk.TabIndex = 56;
            this.MyChk.Text = "My";
            this.MyChk.UseVisualStyleBackColor = true;
            this.MyChk.CheckedChanged += new System.EventHandler(this.MyChk_CheckedChanged);
            // 
            // MxChk
            // 
            this.MxChk.AutoSize = true;
            this.MxChk.ForeColor = System.Drawing.Color.Aqua;
            this.MxChk.Location = new System.Drawing.Point(132, 10);
            this.MxChk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MxChk.Name = "MxChk";
            this.MxChk.Size = new System.Drawing.Size(39, 16);
            this.MxChk.TabIndex = 55;
            this.MxChk.Text = "Mx";
            this.MxChk.UseVisualStyleBackColor = true;
            this.MxChk.CheckedChanged += new System.EventHandler(this.MxChk_CheckedChanged);
            // 
            // FzChk
            // 
            this.FzChk.AutoSize = true;
            this.FzChk.ForeColor = System.Drawing.Color.Red;
            this.FzChk.Location = new System.Drawing.Point(94, 10);
            this.FzChk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FzChk.Name = "FzChk";
            this.FzChk.Size = new System.Drawing.Size(36, 16);
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
            this.FyChk.Location = new System.Drawing.Point(57, 10);
            this.FyChk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FyChk.Name = "FyChk";
            this.FyChk.Size = new System.Drawing.Size(37, 16);
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
            this.FxChk.Location = new System.Drawing.Point(19, 10);
            this.FxChk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FxChk.Name = "FxChk";
            this.FxChk.Size = new System.Drawing.Size(37, 16);
            this.FxChk.TabIndex = 52;
            this.FxChk.Text = "Fx";
            this.FxChk.UseVisualStyleBackColor = true;
            this.FxChk.CheckedChanged += new System.EventHandler(this.FxChk_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 465);
            this.Controls.Add(this.MzChk);
            this.Controls.Add(this.MyChk);
            this.Controls.Add(this.MxChk);
            this.Controls.Add(this.FzChk);
            this.Controls.Add(this.FyChk);
            this.Controls.Add(this.FxChk);
            this.Controls.Add(this.xRangeCmb);
            this.Controls.Add(this.chartCbx);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yRangeBtn);
            this.Controls.Add(this.yIntervalBtn);
            this.Controls.Add(this.oneAddBtn);
            this.Controls.Add(this.PowerDataChart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button oneAddBtn;
        private System.Windows.Forms.Button yIntervalBtn;
        private System.Windows.Forms.Button yRangeBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chartCbx;
        private System.Windows.Forms.ComboBox xRangeCmb;
        private System.Windows.Forms.CheckBox MzChk;
        private System.Windows.Forms.CheckBox MyChk;
        private System.Windows.Forms.CheckBox MxChk;
        private System.Windows.Forms.CheckBox FzChk;
        private System.Windows.Forms.CheckBox FyChk;
        private System.Windows.Forms.CheckBox FxChk;
    }
}

