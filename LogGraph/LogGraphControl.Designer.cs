
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
            this.AxisOffsetYLabel = new System.Windows.Forms.Label();
            this.AxisScaleLabel = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TrackBarScale = new System.Windows.Forms.TrackBar();
            this.TrackBarOffset = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarOffset)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AxisOffsetYLabel
            // 
            this.AxisOffsetYLabel.AutoSize = true;
            this.AxisOffsetYLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AxisOffsetYLabel.Location = new System.Drawing.Point(792, 448);
            this.AxisOffsetYLabel.Name = "AxisOffsetYLabel";
            this.AxisOffsetYLabel.Size = new System.Drawing.Size(44, 30);
            this.AxisOffsetYLabel.TabIndex = 6;
            this.AxisOffsetYLabel.Text = "label2";
            // 
            // AxisScaleLabel
            // 
            this.AxisScaleLabel.AutoSize = true;
            this.AxisScaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AxisScaleLabel.Location = new System.Drawing.Point(3, 448);
            this.AxisScaleLabel.Name = "AxisScaleLabel";
            this.AxisScaleLabel.Size = new System.Drawing.Size(35, 30);
            this.AxisScaleLabel.TabIndex = 5;
            this.AxisScaleLabel.Text = "label1";
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
            this.Graph.Location = new System.Drawing.Point(44, 33);
            this.Graph.Name = "Graph";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(742, 412);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // TrackBarScale
            // 
            this.TrackBarScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarScale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrackBarScale.LargeChange = 2;
            this.TrackBarScale.Location = new System.Drawing.Point(3, 33);
            this.TrackBarScale.Maximum = 11;
            this.TrackBarScale.Name = "TrackBarScale";
            this.TrackBarScale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarScale.Size = new System.Drawing.Size(35, 412);
            this.TrackBarScale.TabIndex = 4;
            this.TrackBarScale.Scroll += new System.EventHandler(this.TrackBarScale_Scroll);
            // 
            // TrackBarOffset
            // 
            this.TrackBarOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrackBarOffset.LargeChange = 2;
            this.TrackBarOffset.Location = new System.Drawing.Point(792, 33);
            this.TrackBarOffset.Maximum = 11;
            this.TrackBarOffset.Name = "TrackBarOffset";
            this.TrackBarOffset.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarOffset.Size = new System.Drawing.Size(44, 412);
            this.TrackBarOffset.TabIndex = 7;
            this.TrackBarOffset.Scroll += new System.EventHandler(this.TrackBarOffset_Scroll);
            // 
            // panel1
            // 
            this.panel1.ColumnCount = 3;
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel1.Controls.Add(this.TrackBarOffset, 2, 1);
            this.panel1.Controls.Add(this.TrackBarScale, 0, 1);
            this.panel1.Controls.Add(this.Graph, 1, 1);
            this.panel1.Controls.Add(this.AxisScaleLabel, 0, 2);
            this.panel1.Controls.Add(this.AxisOffsetYLabel, 2, 2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.RowCount = 3;
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel1.Size = new System.Drawing.Size(839, 478);
            this.panel1.TabIndex = 0;
            // 
            // LogGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogGraphControl";
            this.Size = new System.Drawing.Size(839, 478);
            this.Load += new System.EventHandler(this.LogGraphControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarOffset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AxisOffsetYLabel;
        private System.Windows.Forms.Label AxisScaleLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.TrackBar TrackBarScale;
        private System.Windows.Forms.TrackBar TrackBarOffset;
        private System.Windows.Forms.TableLayoutPanel panel1;
    }
}
