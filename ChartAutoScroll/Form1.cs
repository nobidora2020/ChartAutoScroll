using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
// 横に流れるチャート

namespace ChartAutoScroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDatalist();

            PowerDataChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            PowerDataChart.Series[0].Color = Color.White;

            // 横ラベル表示
            PowerDataChart.ChartAreas[0].AxisX.LabelStyle.Enabled = true;

            // コンボボックス
            for (int i = 1; i < 30; i++)
            {
                int num = i * 10;
                xRangeCmb.Items.Add(num.ToString());
            }
            PowerDataChart.Series[0].Enabled = FxChk.Checked;
            PowerDataChart.Series[1].Enabled = FyChk.Checked;
            PowerDataChart.Series[2].Enabled = FzChk.Checked;
            PowerDataChart.Series[3].Enabled = MxChk.Checked;
            PowerDataChart.Series[4].Enabled = MyChk.Checked;
            PowerDataChart.Series[5].Enabled = MzChk.Checked;

            // チャートの罫線を表示（1つ以上のデータが必要）
            PowerDataChart.Series[6].Points.Clear();
            PowerDataChart.Series[6].Points.AddY(0);

            xRangeCmb.Text = xnum - PowerDataChart.ChartAreas[0].AxisX.Minimum +"";
        }




        /// <summary>
        /// ダミーの力データ
        /// </summary>
        private void DummyData2()
        {
            Random r = new Random();
            int i = r.Next(99);
            string fx = $"{r.Next(-9, 9)}.{r.Next(99)}";
            string fy = $"{r.Next(-9, 9)}.{r.Next(99)}";
            string fz = $"{r.Next(-9, 9)}.{r.Next(99)}";
            string mx = $"{r.Next(-9, 9)}.{r.Next(999)}";
            string my = $"{r.Next(-9, 9)}.{r.Next(999)}";
            string mz = $"{r.Next(-9, 9)}.{r.Next(999)}";


            PowerDataChart.Series[0].Points.AddXY(xnum, double.Parse(fx));
            PowerDataChart.Series[1].Points.AddXY(xnum, double.Parse(fy));
            PowerDataChart.Series[2].Points.AddXY(xnum, double.Parse(fz));
            PowerDataChart.Series[3].Points.AddXY(xnum, double.Parse(mx));
            PowerDataChart.Series[4].Points.AddXY(xnum, double.Parse(my));
            PowerDataChart.Series[5].Points.AddXY(xnum, double.Parse(mz));

            // Xレンジ
            double xRange = double.Parse(dataGridView1.Rows[7].Cells[1].Value.ToString());
            if (double.TryParse(xRangeCmb.Text, out double d))
            {
                xRange = d;
            }

            PowerDataChart.ChartAreas[0].AxisX.Minimum = xnum - xRange;
            PowerDataChart.ChartAreas[0].AxisX.Maximum = xnum;
            PowerDataChart.ChartAreas[0].AxisX.Interval = xRange / 10;


            xnum++;
            textBox2.Text = xnum.ToString();
            hScrollBar1.Maximum = xnum;
            hScrollBar1.Value = hScrollBar1.Maximum;
        }


        public int xnum { get; set; }


        // １つずつグラフを追加
        private void OneAddBtn_Click(object sender, EventArgs e)
        {
            // チャートの罫線を表示（1つ以上のデータが必要）
            PowerDataChart.Series[6].Points.Clear();
            PowerDataChart.Series[6].Points.AddY(0);

            DummyData2();
        }


        // Yの max, min, インターバルの設定
        private void YIntervalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PowerDataChart.ChartAreas[0].AxisY.Minimum = double.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString());
                PowerDataChart.ChartAreas[0].AxisY.Maximum = double.Parse(dataGridView1.Rows[1].Cells[1].Value.ToString());
                PowerDataChart.ChartAreas[0].AxisY.Interval = double.Parse(dataGridView1.Rows[2].Cells[1].Value.ToString());
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }


        private void YRangeBtn_Click(object sender, EventArgs e)
        {
            double d = double.Parse(dataGridView1.Rows[4].Cells[1].Value.ToString());
            
            PowerDataChart.ChartAreas[0].AxisY.Minimum = -d * 5;
            PowerDataChart.ChartAreas[0].AxisY.Maximum = d * 5;
            PowerDataChart.ChartAreas[0].AxisY.Interval = d;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PowerDataChart.ChartAreas[0].AxisX.Minimum = double.Parse(dataGridView1.Rows[5].Cells[1].Value.ToString());
            PowerDataChart.ChartAreas[0].AxisX.Maximum = double.Parse(dataGridView1.Rows[6].Cells[1].Value.ToString());
        }

        

        /// <summary>
        /// データのセット
        /// </summary>
        private void SetDatalist()
        {
            // データセットを作成
            DataSet dataSet = new DataSet("データリスト");
            // データテーブルを作成
            DataTable table = new DataTable("Table");
            // データテーブルに列を追加
            table.Columns.Add("ラベル");
            table.Columns.Add("値");

            // データセットにデータテーブルを追加
            dataSet.Tables.Add(table);

            table.Rows.Add("min", "-10");
            table.Rows.Add("max", "10");
            table.Rows.Add("interval", "2");
            table.Rows.Add("固定", "10");
            table.Rows.Add("Yレンジ", "2");
            table.Rows.Add("X min", "2");
            table.Rows.Add("X max", "5");
            table.Rows.Add("X レンジ", "100");

            string[] array = new string[] { "いち", "に" };
            table.Rows.Add(array); //テーブルは配列が入る

            double yRange = 2.0;
            PowerDataChart.ChartAreas[0].AxisY.Minimum = -yRange * 5;
            PowerDataChart.ChartAreas[0].AxisY.Maximum = yRange * 5;
            PowerDataChart.ChartAreas[0].AxisY.Interval = yRange;

            // データグリッドにテーブルを表示する
            this.dataGridView1.DataSource = table;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            //DataGridView1の行の高さをユーザーが変更できないようにする
            dataGridView1.AllowUserToResizeRows = false;
            //DataGridViewのすべての行の高さを自動調整する
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            //DataGridViewのすべての列の幅を自動調整する
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        
        // グラフのクリア
        private void ClearBtn_Click(object sender, EventArgs e) 
        {
            PowerDataChart.Series[0].Points.Clear();
            xnum = 0;
        }


        // スクロールバーの移動
        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double xRange = double.Parse(dataGridView1.Rows[7].Cells[1].Value.ToString());
            hScrollBar1.Maximum = xnum;
            if (xnum > 8)
            {
                int p = hScrollBar1.Value;
                p += 8;
                textBox1.Text = p.ToString();
                textBox2.Text = xnum.ToString();
                PowerDataChart.ChartAreas[0].AxisX.Minimum = -5000;
                PowerDataChart.ChartAreas[0].AxisX.Maximum = p;
                PowerDataChart.ChartAreas[0].AxisX.Minimum = p - xRange;
                PowerDataChart.ChartAreas[0].AxisX.Interval = xRange / 10;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DummyData2();
        }


        // タイマー１の起動・停止
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                timer1.Interval = 100;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }


        private void XRangeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Xレンジ
                double xRange = double.Parse(dataGridView1.Rows[7].Cells[1].Value.ToString());
                xRange = double.Parse(xRangeCmb.Text);
                PowerDataChart.ChartAreas[0].AxisX.Minimum = xnum - xRange;
                PowerDataChart.ChartAreas[0].AxisX.Maximum = xnum;
                PowerDataChart.ChartAreas[0].AxisX.Interval = xRange / 10;

                Console.WriteLine($"xnum:{xnum} xRnage:{xRange}");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }


        #region 各グラフの表示設定


        private void FxChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            PowerDataChart.Series[0].Enabled = c.Checked;
        }

        private void FyChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            PowerDataChart.Series[1].Enabled = c.Checked;
        }

        private void FzChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            PowerDataChart.Series[2].Enabled = c.Checked;

        }

        private void MxChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            PowerDataChart.Series[3].Enabled = c.Checked;
        }

        private void MyChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            PowerDataChart.Series[4].Enabled = c.Checked;
        }

        private void MzChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            PowerDataChart.Series[5].Enabled = c.Checked;
        }
        #endregion

        
    }
}
