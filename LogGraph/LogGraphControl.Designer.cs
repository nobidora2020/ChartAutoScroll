
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LabelTimeOffset = new System.Windows.Forms.Label();
            this.LabelAxisRange = new System.Windows.Forms.Label();
            this.AxisOffsetYLabel = new System.Windows.Forms.Label();
            this.AxisScaleLabel = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TrackBarScale = new System.Windows.Forms.TrackBar();
            this.TrackBarOffset = new System.Windows.Forms.TrackBar();
            this.TrackBarRange = new System.Windows.Forms.TrackBar();
            this.TablePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TrackBarTimer = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRange)).BeginInit();
            this.TablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTimeOffset
            // 
            this.LabelTimeOffset.AutoSize = true;
            this.LabelTimeOffset.BackColor = System.Drawing.Color.DodgerBlue;
            this.LabelTimeOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTimeOffset.ForeColor = System.Drawing.Color.FloralWhite;
            this.LabelTimeOffset.Location = new System.Drawing.Point(1, 1);
            this.LabelTimeOffset.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTimeOffset.Name = "LabelTimeOffset";
            this.LabelTimeOffset.Size = new System.Drawing.Size(38, 28);
            this.LabelTimeOffset.TabIndex = 11;
            this.LabelTimeOffset.Text = "label2";
            this.LabelTimeOffset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAxisRange
            // 
            this.LabelAxisRange.AutoSize = true;
            this.LabelAxisRange.BackColor = System.Drawing.Color.Olive;
            this.LabelAxisRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAxisRange.Location = new System.Drawing.Point(824, 452);
            this.LabelAxisRange.Margin = new System.Windows.Forms.Padding(1);
            this.LabelAxisRange.Name = "LabelAxisRange";
            this.LabelAxisRange.Size = new System.Drawing.Size(38, 28);
            this.LabelAxisRange.TabIndex = 10;
            this.LabelAxisRange.Text = "label1";
            this.LabelAxisRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AxisOffsetYLabel
            // 
            this.AxisOffsetYLabel.AutoSize = true;
            this.AxisOffsetYLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.AxisOffsetYLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AxisOffsetYLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.AxisOffsetYLabel.Location = new System.Drawing.Point(824, 1);
            this.AxisOffsetYLabel.Margin = new System.Windows.Forms.Padding(1);
            this.AxisOffsetYLabel.Name = "AxisOffsetYLabel";
            this.AxisOffsetYLabel.Size = new System.Drawing.Size(38, 28);
            this.AxisOffsetYLabel.TabIndex = 6;
            this.AxisOffsetYLabel.Text = "label2";
            this.AxisOffsetYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AxisScaleLabel
            // 
            this.AxisScaleLabel.AutoSize = true;
            this.AxisScaleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AxisScaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AxisScaleLabel.Location = new System.Drawing.Point(1, 452);
            this.AxisScaleLabel.Margin = new System.Windows.Forms.Padding(1);
            this.AxisScaleLabel.Name = "AxisScaleLabel";
            this.AxisScaleLabel.Size = new System.Drawing.Size(38, 28);
            this.AxisScaleLabel.TabIndex = 5;
            this.AxisScaleLabel.Text = "label1";
            this.AxisScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = 90;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea2.AxisX.LabelStyle.Format = "F2";
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea2.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorTickMark.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea2.AxisY.LabelStyle.Format = "f1";
            chartArea2.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.LabelStyle.TruncatedLabels = true;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkBlue;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.SystemColors.ControlLight;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorTickMark.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea2);
            this.Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Graph.Location = new System.Drawing.Point(43, 33);
            this.Graph.Name = "Graph";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.CornflowerBlue;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.Graph.Series.Add(series2);
            this.Graph.Size = new System.Drawing.Size(777, 415);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // TrackBarScale
            // 
            this.TrackBarScale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TrackBarScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarScale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrackBarScale.LargeChange = 2;
            this.TrackBarScale.Location = new System.Drawing.Point(1, 31);
            this.TrackBarScale.Margin = new System.Windows.Forms.Padding(1);
            this.TrackBarScale.Maximum = 11;
            this.TrackBarScale.Name = "TrackBarScale";
            this.TrackBarScale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarScale.Size = new System.Drawing.Size(38, 419);
            this.TrackBarScale.TabIndex = 4;
            this.TrackBarScale.Scroll += new System.EventHandler(this.TrackBarScale_Scroll);
            // 
            // TrackBarOffset
            // 
            this.TrackBarOffset.BackColor = System.Drawing.Color.DarkGreen;
            this.TrackBarOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrackBarOffset.LargeChange = 2;
            this.TrackBarOffset.Location = new System.Drawing.Point(824, 31);
            this.TrackBarOffset.Margin = new System.Windows.Forms.Padding(1);
            this.TrackBarOffset.Maximum = 14;
            this.TrackBarOffset.Name = "TrackBarOffset";
            this.TrackBarOffset.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarOffset.Size = new System.Drawing.Size(38, 419);
            this.TrackBarOffset.TabIndex = 7;
            this.TrackBarOffset.Scroll += new System.EventHandler(this.TrackBarOffset_Scroll);
            // 
            // TrackBarRange
            // 
            this.TrackBarRange.BackColor = System.Drawing.Color.Olive;
            this.TrackBarRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarRange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrackBarRange.LargeChange = 2;
            this.TrackBarRange.Location = new System.Drawing.Point(41, 452);
            this.TrackBarRange.Margin = new System.Windows.Forms.Padding(1);
            this.TrackBarRange.Maximum = 11;
            this.TrackBarRange.Name = "TrackBarRange";
            this.TrackBarRange.Size = new System.Drawing.Size(781, 28);
            this.TrackBarRange.TabIndex = 8;
            this.TrackBarRange.Scroll += new System.EventHandler(this.TrackBarRange_Scroll);
            // 
            // TablePanel1
            // 
            this.TablePanel1.ColumnCount = 3;
            this.TablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TablePanel1.Controls.Add(this.TrackBarRange, 1, 2);
            this.TablePanel1.Controls.Add(this.TrackBarOffset, 2, 1);
            this.TablePanel1.Controls.Add(this.TrackBarScale, 0, 1);
            this.TablePanel1.Controls.Add(this.AxisScaleLabel, 0, 2);
            this.TablePanel1.Controls.Add(this.AxisOffsetYLabel, 2, 0);
            this.TablePanel1.Controls.Add(this.LabelAxisRange, 2, 2);
            this.TablePanel1.Controls.Add(this.LabelTimeOffset, 0, 0);
            this.TablePanel1.Controls.Add(this.Graph, 1, 1);
            this.TablePanel1.Controls.Add(this.TrackBarTimer, 1, 0);
            this.TablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel1.Location = new System.Drawing.Point(0, 0);
            this.TablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.TablePanel1.Name = "TablePanel1";
            this.TablePanel1.RowCount = 3;
            this.TablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel1.Size = new System.Drawing.Size(863, 481);
            this.TablePanel1.TabIndex = 0;
            // 
            // TrackBarTimer
            // 
            this.TrackBarTimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.TrackBarTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarTimer.Location = new System.Drawing.Point(43, 3);
            this.TrackBarTimer.Maximum = 14;
            this.TrackBarTimer.Name = "TrackBarTimer";
            this.TrackBarTimer.Size = new System.Drawing.Size(777, 24);
            this.TrackBarTimer.TabIndex = 12;
            this.TrackBarTimer.Scroll += new System.EventHandler(this.TrackBarTimer_Scroll);
            // 
            // LogGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.TablePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogGraphControl";
            this.Size = new System.Drawing.Size(863, 481);
            this.Load += new System.EventHandler(this.LogGraphControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRange)).EndInit();
            this.TablePanel1.ResumeLayout(false);
            this.TablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTimeOffset;
        private System.Windows.Forms.Label LabelAxisRange;
        private System.Windows.Forms.Label AxisOffsetYLabel;
        private System.Windows.Forms.Label AxisScaleLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.TrackBar TrackBarScale;
        private System.Windows.Forms.TrackBar TrackBarOffset;
        private System.Windows.Forms.TrackBar TrackBarRange;
        private System.Windows.Forms.TableLayoutPanel TablePanel1;
        private System.Windows.Forms.TrackBar TrackBarTimer;
    }
}
