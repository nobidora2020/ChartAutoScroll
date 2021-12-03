
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.Maximum = 5D;
            chartArea2.AxisX.Minimum = -5D;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea2.AxisX.ScaleView.Zoomable = false;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Black;
            chartArea2.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.Interval = 20D;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.Interval = 10D;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.Maximum = 140D;
            chartArea2.AxisY.Minimum = -140D;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.PowerDataChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.PowerDataChart.Legends.Add(legend2);
            this.PowerDataChart.Location = new System.Drawing.Point(12, 40);
            this.PowerDataChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PowerDataChart.Name = "PowerDataChart";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Color = System.Drawing.Color.Blue;
            series13.Legend = "Legend1";
            series13.Name = "SeriesFx";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Color = System.Drawing.Color.Green;
            series14.Legend = "Legend1";
            series14.Name = "SeriesFy";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series15.Color = System.Drawing.Color.Red;
            series15.Legend = "Legend1";
            series15.Name = "SeriesFz";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series16.Color = System.Drawing.Color.Aqua;
            series16.Legend = "Legend1";
            series16.Name = "SeriesMx";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series17.Color = System.Drawing.Color.Lime;
            series17.Legend = "Legend1";
            series17.Name = "SeriesMy";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series18.Color = System.Drawing.Color.Fuchsia;
            series18.Legend = "Legend1";
            series18.Name = "SeriesMz";
            series19.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series19.Color = System.Drawing.Color.Aqua;
            series19.Legend = "Legend1";
            series19.Name = "SeriesFx_Off";
            series20.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series20.Color = System.Drawing.Color.Lime;
            series20.Legend = "Legend1";
            series20.Name = "SeriesFy_Off";
            series21.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series21.Color = System.Drawing.Color.Fuchsia;
            series21.Legend = "Legend1";
            series21.Name = "SeriesFz_Off";
            series22.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series22.Color = System.Drawing.Color.Blue;
            series22.Legend = "Legend1";
            series22.Name = "SeriesMx_Off";
            series23.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series23.Color = System.Drawing.Color.Green;
            series23.Legend = "Legend1";
            series23.Name = "SeriesMy_Off";
            series24.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series24.Color = System.Drawing.Color.Red;
            series24.Legend = "Legend1";
            series24.Name = "SeriesMz_Off";
            this.PowerDataChart.Series.Add(series13);
            this.PowerDataChart.Series.Add(series14);
            this.PowerDataChart.Series.Add(series15);
            this.PowerDataChart.Series.Add(series16);
            this.PowerDataChart.Series.Add(series17);
            this.PowerDataChart.Series.Add(series18);
            this.PowerDataChart.Series.Add(series19);
            this.PowerDataChart.Series.Add(series20);
            this.PowerDataChart.Series.Add(series21);
            this.PowerDataChart.Series.Add(series22);
            this.PowerDataChart.Series.Add(series23);
            this.PowerDataChart.Series.Add(series24);
            this.PowerDataChart.Size = new System.Drawing.Size(643, 398);
            this.PowerDataChart.TabIndex = 1;
            // 
            // oneAddBtn
            // 
            this.oneAddBtn.Location = new System.Drawing.Point(676, 24);
            this.oneAddBtn.Name = "oneAddBtn";
            this.oneAddBtn.Size = new System.Drawing.Size(75, 58);
            this.oneAddBtn.TabIndex = 2;
            this.oneAddBtn.Text = "One";
            this.oneAddBtn.UseVisualStyleBackColor = true;
            this.oneAddBtn.Click += new System.EventHandler(this.OneAddBtn_Click);
            // 
            // yIntervalBtn
            // 
            this.yIntervalBtn.Location = new System.Drawing.Point(757, 24);
            this.yIntervalBtn.Name = "yIntervalBtn";
            this.yIntervalBtn.Size = new System.Drawing.Size(75, 58);
            this.yIntervalBtn.TabIndex = 3;
            this.yIntervalBtn.Text = "Yごと";
            this.yIntervalBtn.UseVisualStyleBackColor = true;
            this.yIntervalBtn.Click += new System.EventHandler(this.YIntervalBtn_Click);
            // 
            // yRangeBtn
            // 
            this.yRangeBtn.Location = new System.Drawing.Point(852, 24);
            this.yRangeBtn.Name = "yRangeBtn";
            this.yRangeBtn.Size = new System.Drawing.Size(73, 58);
            this.yRangeBtn.TabIndex = 6;
            this.yRangeBtn.Text = "Yレンジ";
            this.yRangeBtn.UseVisualStyleBackColor = true;
            this.yRangeBtn.Click += new System.EventHandler(this.YRangeBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(689, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(193, 263);
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
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(756, 106);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 65);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
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
            this.textBox1.Location = new System.Drawing.Point(689, 483);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(689, 511);
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
            this.chartCbx.Font = new System.Drawing.Font("メイリオ", 9F);
            this.chartCbx.Location = new System.Drawing.Point(427, 466);
            this.chartCbx.Name = "chartCbx";
            this.chartCbx.Size = new System.Drawing.Size(108, 27);
            this.chartCbx.TabIndex = 12;
            this.chartCbx.Text = "Auto Satrt";
            this.chartCbx.UseVisualStyleBackColor = true;
            this.chartCbx.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // xRangeCmb
            // 
            this.xRangeCmb.Font = new System.Drawing.Font("メイリオ", 9F);
            this.xRangeCmb.FormattingEnabled = true;
            this.xRangeCmb.Location = new System.Drawing.Point(244, 466);
            this.xRangeCmb.Name = "xRangeCmb";
            this.xRangeCmb.Size = new System.Drawing.Size(121, 31);
            this.xRangeCmb.TabIndex = 13;
            this.xRangeCmb.SelectedIndexChanged += new System.EventHandler(this.XRangeCmb_SelectedIndexChanged);
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
            this.ClientSize = new System.Drawing.Size(951, 581);
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

