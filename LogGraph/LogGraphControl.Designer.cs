
namespace LogGraph
{
    partial class LogGraphControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TrackBarScale = new System.Windows.Forms.TrackBar();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.TrackBarScale, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Graph, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TrackBarScale
            // 
            this.TrackBarScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarScale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrackBarScale.LargeChange = 2;
            this.TrackBarScale.Location = new System.Drawing.Point(4, 34);
            this.TrackBarScale.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarScale.Maximum = 11;
            this.TrackBarScale.Name = "TrackBarScale";
            this.TrackBarScale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarScale.Size = new System.Drawing.Size(22, 437);
            this.TrackBarScale.TabIndex = 4;
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea1.AxisX.LabelStyle.Format = "F2";
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea1.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea1.AxisY.LabelStyle.Format = "f1";
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LabelStyle.TruncatedLabels = true;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkBlue;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            this.Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Graph.Location = new System.Drawing.Point(34, 34);
            this.Graph.Margin = new System.Windows.Forms.Padding(4);
            this.Graph.Name = "Graph";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(830, 437);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(33, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(832, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LogGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LogGraphControl";
            this.Size = new System.Drawing.Size(898, 525);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.TrackBar TrackBarScale;
        private System.Windows.Forms.Button button1;
    }
}
