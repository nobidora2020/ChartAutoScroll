using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            dataGridView1.AllowUserToAddRows = false;
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
        }


        private void button2_Click(object sender, EventArgs e) {
            // データを追加
            LoGraphFx.InfoSeries(out string[] name, out Color[] color, out string[] colorName);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < name.Length; i++) {
                // 行を追加
                dataGridView1.Rows.Add(name[i], colorName[i], true);
                // チェック状態の復元
                if (isCheckSeries != null && i < isCheckSeries.Length) {
                    dataGridView1.Rows[i].Cells[2].Value = isCheckSeries?[i];
                }
                // 実際の色を取得
                bool itIsTransparent = color[i] == Color.Transparent; // 透明のとき
                dataGridView1[1, i].Style.BackColor = itIsTransparent ? Color.Empty : color[i];
                // インデックス番号から算出した色を取得
                dataGridView1[1, i].Style.BackColor = LoGraphFx.ColorSeries(i);
            }
            dataGridView1.Refresh();
            dataGridView1.Update();
        }


        /// <summary>
        /// チェック状態
        /// </summary>
        bool[] isCheckSeries;


        private void Button3_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            var isCheckList = new List<bool>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                var isCheck = (bool)dataGridView1.Rows[i].Cells[2].Value;
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
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
    }
}
