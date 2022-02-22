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
        public LogGraphControl() {
            InitializeComponent();
        }
		private void LogGraphControl_Load(object sender, EventArgs e) {

			AxisScaleLabel.Text = scaleList[TrackBarScale.Value].ToString(); ;
			AxisOffsetYLabel.Text = offsetList[TrackBarOffset.Value].ToString(); ;

		}



		internal void UpdateValue(double[] dt, double[] data) {

			// シリーズの自動生成
			//int seriesIndex = SeriesCount - 1;
			//if (seriesIndex > 0) {
			//	MakeSeries();
			//}
			//else {
			//	SeriesCount++;
			//}

			int seriesIndex = 0;

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

			//if (IsMomentStatus) {
			//	c.AxisY.LabelStyle.Format = "f2";
			//}

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
			//addSeris.Color = Color.Red;
			addSeris.IsVisibleInLegend = false;
			addSeris.Name = "Series" + SeriesCount;

			addSeris.Color = ColorSeries();
			this.Graph.Series.Add(addSeris);

			SeriesCount++;
		}

		// シリーズごとにグラフの色を変える
		public Color ColorSeries() {
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
			ChartArea c = this.Graph.ChartAreas[0];
			var points = this.Graph.Series[0].Points;
			if (points.Count == 0) {
				return;
			}
			var maxYValue = points.Max(v => v.YValues[0]);  // 最大値
			var minYValue = points.Min(v => v.YValues[0]);  // 最小値
			MaxAndMiniValue(out maxYValue, out minYValue);  // 複数シリーズで最小最大を取得

			var AxisScalea = int.Parse(AxisScaleLabel.Text);
			var AxisOffsetY = int.Parse(AxisOffsetYLabel.Text);

#if true
			var difference = maxYValue - minYValue;         // レンジの差（表示範囲）
			double rate = AxisScalea / 100f;                 // 倍率
			var half = difference / 2;                      // 範囲の半分
			var center = (maxYValue + minYValue) / 2;       // 最小と最大の中央位置
			var sc = difference / rate;
			// 拡大・縮小を調整
			c.AxisY.Maximum = center + (half / rate);
			c.AxisY.Minimum = center - (half / rate);
			double offset = AxisOffsetY / 100f;    // 倍率
			var distance = maxYValue - (center - (half / rate));
			var ajust = distance * offset;
			// オフセットを調整
			c.AxisY.Maximum += ajust;
			c.AxisY.Minimum += ajust;

			TrackBarScale.Value = 5;
			TrackBarOffset.Value = 5;

			UpdateTrackBar();
			this.Refresh();
#endif

		}


		// シリーズ内で最小最大値を取得
		private void MaxAndMiniValue(out double maxYValue, out double minYValue) {
			var maxList = new List<double>();
			var minList = new List<double>();
			foreach (Series pointValue in Graph.Series) {
				var maxY = pointValue.Points.Max(v => v.YValues[0]);  // 最大値
				var minY = pointValue.Points.Min(v => v.YValues[0]);  // 最大値
				maxList.Add(maxY);
				minList.Add(minY);
			}
			maxYValue = maxList.Max();
			minYValue = minList.Min();
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



		int[] scaleList = new int[] {
			1, 5, 10, 25, 50, 75, 100, 200, 400, 800, 1600, 3200, 6400 };


		int[] offsetList = new int[] {
			 -100, -75, -50, -25, -10, -5, -1, 0, 1, 5, 10, 25, 50, 75, 100 };

       
    }
}
