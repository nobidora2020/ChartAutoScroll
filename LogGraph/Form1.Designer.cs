
namespace LogGraph
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DgvSeries = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.BtnOutputLog = new System.Windows.Forms.Button();
            this.btnAddSeries = new System.Windows.Forms.Button();
            this.LoGraphFx = new LogGraph.LogGraphControl();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSeries)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("メイリオ", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 583);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.25919F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.74081F));
            this.tableLayoutPanel1.Controls.Add(this.LoGraphFx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.50626F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.49374F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 583);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.DgvSeries);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(713, 3);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(426, 577);
            this.panel2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(0, 384);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 184);
            this.listBox1.TabIndex = 1;
            // 
            // DgvSeries
            // 
            this.DgvSeries.AllowUserToResizeRows = false;
            this.DgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnColor,
            this.ColumnCheck});
            this.DgvSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvSeries.Location = new System.Drawing.Point(0, 0);
            this.DgvSeries.Name = "DgvSeries";
            this.DgvSeries.RowHeadersVisible = false;
            this.DgvSeries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvSeries.RowTemplate.Height = 21;
            this.DgvSeries.Size = new System.Drawing.Size(426, 328);
            this.DgvSeries.TabIndex = 0;
            this.DgvSeries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSeries_CellContentClick);
            this.DgvSeries.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSeries_CellContentDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox2);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.BtnOutputLog);
            this.panel3.Controls.Add(this.btnAddSeries);
            this.panel3.Location = new System.Drawing.Point(3, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 198);
            this.panel3.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(234, 97);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(356, 94);
            this.listBox2.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(450, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 87);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnOutputLog
            // 
            this.BtnOutputLog.Location = new System.Drawing.Point(9, 96);
            this.BtnOutputLog.Name = "BtnOutputLog";
            this.BtnOutputLog.Size = new System.Drawing.Size(141, 87);
            this.BtnOutputLog.TabIndex = 1;
            this.BtnOutputLog.Text = "OutputLog";
            this.BtnOutputLog.UseVisualStyleBackColor = true;
            this.BtnOutputLog.Click += new System.EventHandler(this.BtnOutputLog_Click);
            // 
            // btnAddSeries
            // 
            this.btnAddSeries.Location = new System.Drawing.Point(9, 3);
            this.btnAddSeries.Name = "btnAddSeries";
            this.btnAddSeries.Size = new System.Drawing.Size(141, 87);
            this.btnAddSeries.TabIndex = 1;
            this.btnAddSeries.Text = "AddSiries";
            this.btnAddSeries.UseVisualStyleBackColor = true;
            this.btnAddSeries.Click += new System.EventHandler(this.BtnAddSeries_Click);
            // 
            // LoGraphFx
            // 
            this.LoGraphFx.BackColor = System.Drawing.SystemColors.Window;
            this.LoGraphFx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoGraphFx.Location = new System.Drawing.Point(2, 3);
            this.LoGraphFx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoGraphFx.Name = "LoGraphFx";
            this.LoGraphFx.Size = new System.Drawing.Size(706, 364);
            this.LoGraphFx.TabIndex = 2;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.HeaderText = "#";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnIndex.Width = 24;
            // 
            // ColumnColor
            // 
            this.ColumnColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnColor.HeaderText = "色";
            this.ColumnColor.Name = "ColumnColor";
            this.ColumnColor.ReadOnly = true;
            this.ColumnColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.HeaderText = "表示/非表示";
            this.ColumnCheck.Name = "ColumnCheck";
            this.ColumnCheck.Width = 79;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 583);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSeries)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddSeries;
        private LogGraphControl LoGraphFx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvSeries;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button BtnOutputLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
    }
}

