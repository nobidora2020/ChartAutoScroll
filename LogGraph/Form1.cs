using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogGraph
{
    public partial class Form1 : Form
    {
        int count = 1; //カウント値
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            DgvSeries.AllowUserToAddRows = false;
        }

        // リストデータ        
        private void UpdateByListData() {
            count = 1;
            Random r = new Random(); //乱数
            var timeList = new List<double>();
            var dataList = new List<double>();
            for (int i = 0; i < 100; i++) {
                var data = double.Parse($"{r.Next(1, 99)}");
                double miliSeconds = TimeSpan.FromSeconds(count).TotalMilliseconds; // 経過時間
                timeList.Add(miliSeconds);
                dataList.Add(data);
                count++;
            }
            this.LoGraphFx.UpdateValue(timeList.ToArray(), dataList.ToArray());
        }
        private void Button1_Click(object sender, EventArgs e) {
            UpdateByListData();
            SetSeriesToDev();

        }
        private void button2_Click(object sender, EventArgs e) {

            SetSeriesToDev();
        }
        /// <summary>
        /// グリッドビューにシリーズを設定する
        /// </summary>
        private void SetSeriesToDev() {
            DgvSeries.Rows.Clear();
            LoGraphFx.InfoSeries(out string[] name, out Color[] color, out string[] colorName);
            for (int i = 0; i < name.Length; i++) {
                // 行を追加
                int indexName = int.Parse(Regex.Replace(name[i], @"[^0-9]", "")) - 1;
                DgvSeries.Rows.Add(indexName, colorName[i], true);
                // チェック状態の復元
                if (isCheckSeries != null && i < isCheckSeries.Length) {
                    DgvSeries.Rows[i].Cells[2].Value = isCheckSeries?[i];
                }
                // 実際の色を取得
                bool itIsTransparent = color[i] == Color.Transparent; // 透明のとき
                DgvSeries[1, i].Style.BackColor = itIsTransparent ? Color.Empty : color[i];
                // インデックス番号から算出した色を取得
                DgvSeries[1, i].Style.BackColor = LoGraphFx.ColorSeries(i);
            }
            DgvSeries.Refresh();
            DgvSeries.Update();
        }

        /// <summary>
        /// チェック状態
        /// </summary>
        bool[] isCheckSeries;


        private void Button3_Click(object sender, EventArgs e) {
            UpdateGraphSeries();
        }

        private void UpdateGraphSeries() {
            listBox1.Items.Clear();
            var isCheckList = new List<bool>();
            for (int i = 0; i < DgvSeries.Rows.Count; i++) {
                var isCheck = (bool)DgvSeries.Rows[i].Cells[2].Value;
                listBox1.Items.Add(isCheck.ToString());
                isCheckList.Add(isCheck);
                if (isCheck) {
                    LoGraphFx.ShowSeries(i);
                }
                else {
                    LoGraphFx.HideSeries(i);
                }
            }
            isCheckSeries = isCheckList.ToArray();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            DgvSeries.Rows.Clear();
            DgvSeries.Refresh();
            DgvSeries.Update();
        }

        private void DgvSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)  {
            this.ColumnCheck.ReadOnly = true;
            UpdateGraphSeries();
            this.ColumnCheck.ReadOnly = false;
        }

        private void DgvSeries_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            this.ColumnCheck.ReadOnly = true;
            UpdateGraphSeries();
            CheckInfo();
            this.ColumnCheck.ReadOnly = false;
        }


        private void CheckInfo() {
            listBox2.Items.Add(DateTime.Now + ":one" + DateTime.Now.Millisecond);
            listBox2.SelectedIndex = listBox2.Items.Count - 1; // 最終行にカーソル移動
            listBox1.Items.Clear();
            for (int i = 0; i < DgvSeries.Rows.Count; i++) {
                var isCheck = (bool)DgvSeries.Rows[i].Cells[2].Value;
                listBox1.Items.Add(isCheck.ToString());
            }
        }

        private void Button4_Click(object sender, EventArgs e) {
            CheckInfo();
        }
    }
}
