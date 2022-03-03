using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LogGraph
{
    public partial class LogGraphControl : UserControl
    {
		public int AxisScale {
			get { return int.Parse(AxisScaleLabel.Text); }
		}
		public int AxisOffsetY {
			get { return int.Parse(AxisOffsetYLabel.Text); }
		}
		public int AxisRange {
			get { return int.Parse(LabelAxisRange.Text); }
		}
		public int AxisOffsetX {
			get { return int.Parse(LabelTimeOffset.Text); }
		}

		public LogGraphControl() {
            InitializeComponent();
        }
		private void LogGraphControl_Load(object sender, EventArgs e) {
			TrackBarScale.Value = 5;
			TrackBarOffset.Value = 5;
			TrackBarRange.Value = 5;
			TrackBarTimer.Value = 5;

			AxisScaleLabel.Text = scaleList[TrackBarScale.Value].ToString(); ;
			AxisOffsetYLabel.Text = offsetList[TrackBarOffset.Value].ToString();
			LabelAxisRange.Text = scaleList[TrackBarRange.Value].ToString();
			LabelTimeOffset.Text = offsetList[TrackBarTimer.Value].ToString();
		}

		internal void UpdateValue(double[] dt, double[] data) {
			// シリーズの自動生成
			int seriesIndex = SeriesCount - 1;
			if (seriesIndex > 0) {
				MakeSeries();
			}
			else {
				SeriesCount++;
			}
			// プロット先
			ChartArea c = this.Graph.ChartAreas[0];
			// X軸のプロット間隔
			c.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
			for (int i = 0; i < dt.Length; i++) {
				// データプロット
				this.Graph.Series[seriesIndex].Points.AddXY(dt[i], data[i]);
			}
			// レンジの自動調整
			c.AxisX.Minimum = double.NaN;
			c.AxisX.Maximum = double.NaN;
			c.AxisY.Maximum = double.NaN;
			c.AxisY.Minimum = double.NaN;
			UpdateTrackBar();
			this.Refresh();
		}

		/// <summary>
		/// シリーズの動的生成時にカウント値
		/// </summary>
		int SeriesCount = 1;

		// シリーズの生成
		public void MakeSeries() {
			Series addSeris = new Series();
			addSeris.BorderWidth = 2;
			addSeris.ChartArea = "ChartArea1";
			addSeris.ChartType = SeriesChartType.FastLine;
			addSeris.IsVisibleInLegend = false;
			addSeris.Name = "Series" + SeriesCount;
			addSeris.Color = ColorSeries();
			this.Graph.Series.Add(addSeris);
			SeriesCount++;
		}

		// シリーズごとにグラフの色を変える
		private Color ColorSeries() {
			var color = Color.Red;
			switch (SeriesCount % 6) {
				case 0:
					color = Color.Magenta;
					break;
				case 1:
					color = Color.CornflowerBlue;
					break;
				case 2:
					color = Color.LightGreen;
					break;
				case 3:
					color = Color.Red;
					break;
				case 4:
					color = Color.Cyan;
					break;
				case 5:
					color = Color.Lime;
					break;
			}
			return color;
		}

		// トラックバーの更新
		private void UpdateTrackBar() {
			UpdateYValue();
			UpdateXVaule();
			this.Refresh();
		}

		// Y軸方向のトラックバーの更新
		private void UpdateYValue() {
			ChartArea c = this.Graph.ChartAreas[0];
			var points = this.Graph.Series[0].Points;
			if (points.Count == 0) {
				return;
			}
			var maxYValue = points.Max(v => v.YValues[0]);  // 最大値
			var minYValue = points.Min(v => v.YValues[0]);  // 最小値
			// 複数シリーズで最小最大を取得
			MaxAndMiniValue(out maxYValue, out minYValue, XOrYAxisType. YAxis); 
			var difference = maxYValue - minYValue;         // レンジの差（表示範囲）
			double rate = AxisScale / 100f;                 // 倍率
			var half = difference / 2;                      // 範囲の半分
			var center = (maxYValue + minYValue) / 2;       // 最小と最大の中央位置
			// 拡大・縮小を調整
			c.AxisY.Maximum = center + (half / rate);
			c.AxisY.Minimum = center - (half / rate);
			// オフセットを調整
			double offset = AxisOffsetY / 100f;    // 倍率
			var distance = maxYValue - (center - (half / rate));
			var ajust = distance * offset;
			c.AxisY.Maximum += ajust;
			c.AxisY.Minimum += ajust;
		}

		// X軸方向のトラックバーの更新
		private void UpdateXVaule() {
			ChartArea c = this.Graph.ChartAreas[0];
			var points = this.Graph.Series[0].Points;
			if (points.Count == 0) {
				return;
			}
			// x軸の値
			var maxXValue = points.Max(v => v.XValue);      // 最大値
			var minXValue = points.Min(v => v.XValue);      // 最小値 
			// 複数シリーズで最小最大を取得
			MaxAndMiniValue(out maxXValue, out minXValue, XOrYAxisType.XAxis);  
			var difference = maxXValue - minXValue;         // レンジの差（表示範囲）
			double rate = AxisRange / 100f;                 // 倍率
			var half = difference / 2;                      // 範囲の半分
			var center = (maxXValue + minXValue) / 2;       // 最小と最大の中央位置
			// 拡大・縮小を調整
			c.AxisX.Maximum = center + (half / rate);
			c.AxisX.Minimum = center - (half / rate);
			// オフセットを調整
			double offset = this.AxisOffsetX / 100f;    // 倍率
			var distance = maxXValue - (center - (half / rate));
			var ajust = distance * offset;
			c.AxisX.Maximum += ajust;
			c.AxisX.Minimum += ajust;
		}

		// シリーズ内でY値の最小最大値を取得
		private void MaxAndMiniValue(out double maxYValue, out double minYValue, XOrYAxisType type) {
			var maxList = new List<double>();
			var minList = new List<double>();
			foreach (Series pointValue in Graph.Series) {
				bool isXAxis = type == XOrYAxisType.XAxis;
				var max = isXAxis ? pointValue.Points.Max(v => v.XValue) : pointValue.Points.Max(v => v.YValues[0]);
				var min = isXAxis ? pointValue.Points.Min(v => v.XValue) : pointValue.Points.Min(v => v.YValues[0]);
				maxList.Add(max);
				minList.Add(min);
			}
			maxYValue = maxList.Max();
			minYValue = minList.Min();
		}

        // XY軸の種類
        enum XOrYAxisType
        {
            XAxis,
            YAxis
        }


        private void TrackBarScale_Scroll(object sender, EventArgs e) {
			var v = ((TrackBar)sender);
			AxisScaleLabel.Text = scaleList[v.Value].ToString();
			UpdateTrackBar();
		}

		private void TrackBarOffset_Scroll(object sender, EventArgs e) {
			var v = ((TrackBar)sender);
            AxisOffsetYLabel.Text = offsetList[v.Value].ToString();
			UpdateTrackBar();
		}

        private void TrackBarRange_Scroll(object sender, EventArgs e) {
			var v = ((TrackBar)sender);
			LabelAxisRange.Text = scaleList[v.Value].ToString();
			UpdateTrackBar();
		}

        private void TrackBarTimer_Scroll(object sender, EventArgs e) {
			var v = ((TrackBar)sender);
			LabelTimeOffset.Text = offsetList[v.Value].ToString();
			UpdateTrackBar();
		}

		int[] scaleList = new int[] {
			1, 5, 10, 25, 50, 75, 100, 200, 400, 800, 1600, 3200, 6400 };

		int[] offsetList = new int[] {
			 -100, -75, -50, -25, -10, -5, -1, 0, 1, 5, 10, 25, 50, 75, 100 };

		// シリーズの情報を取得
		public void InfoSeries(out string[] name, out Color[] color, out string[] colorName) {
			int seriesIndex = SeriesCount - 1;
			var list = new List<string>();
			var listColor = new List<Color>();
			var cName = new List<string>();

			foreach (var item in this.Graph.Series) {
				list.Add(item.Name);
				listColor.Add(item.Color);
				cName.Add(item.Color.ToString());
            }
			name = list.ToArray();
			color = listColor.ToArray();
			colorName = cName.ToArray();

			//this.Graph.Series[seriesIndex-1].Color = Color.Transparent;
			//this.Graph.Series[seriesIndex-1].BorderColor = Color.Transparent;
		}
		// シリーズを非表示
		public void HideSeries(int index) {
            this.Graph.Series[index].Color = Color.Transparent;
		}


		public void ShowSeries(int index) {
			this.Graph.Series[index].Color = ColorSeries(index);
		}


		public Color ColorSeries(int index) {
			var count = index + 1;
			var color = Color.Red;
			switch (count % 6) {
				case 0:
					color = Color.Magenta;
					break;
				case 1:
					color = Color.CornflowerBlue;
					break;
				case 2:
					color = Color.LightGreen;
					break;
				case 3:
					color = Color.Red;
					break;
				case 4:
					color = Color.Cyan;
					break;
				case 5:
					color = Color.Lime;
					break;
			}
			return color;
		}


	}
}
