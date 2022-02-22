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


        // リストデータ        
        private void UpdateByListData() {
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

        private void button1_Click(object sender, EventArgs e) {
            UpdateByListData();
        }
    }
}
