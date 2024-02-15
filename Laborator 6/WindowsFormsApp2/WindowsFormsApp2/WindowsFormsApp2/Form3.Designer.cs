namespace WindowsFormsApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testdbDataSet1 = new WindowsFormsApp2.TestdbDataSet1();
            this.temperaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temperaturaTableAdapter = new WindowsFormsApp2.TestdbDataSet1TableAdapters.TemperaturaTableAdapter();
            this.temperaturaINTERIORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umiditateINTERIORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexuldeCalduraINTERIORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaEXTERIORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umiditateEXTERIORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(953, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Temperatura Exterior";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(944, 755);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(563, 70);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Temperatura_Exterior";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Umiditate_Exterior";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Index_de_Caldura_Exterior";
            this.chart3.Series.Add(series1);
            this.chart3.Series.Add(series2);
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(957, 650);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.temperaturaINTERIORCDataGridViewTextBoxColumn,
            this.umiditateINTERIORDataGridViewTextBoxColumn,
            this.indexuldeCalduraINTERIORCDataGridViewTextBoxColumn,
            this.temperaturaEXTERIORCDataGridViewTextBoxColumn,
            this.umiditateEXTERIORDataGridViewTextBoxColumn,
            this.indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.temperaturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-570, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 708);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // testdbDataSet1
            // 
            this.testdbDataSet1.DataSetName = "TestdbDataSet1";
            this.testdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temperaturaBindingSource
            // 
            this.temperaturaBindingSource.DataMember = "Temperatura";
            this.temperaturaBindingSource.DataSource = this.testdbDataSet1;
            // 
            // temperaturaTableAdapter
            // 
            this.temperaturaTableAdapter.ClearBeforeFill = true;
            // 
            // temperaturaINTERIORCDataGridViewTextBoxColumn
            // 
            this.temperaturaINTERIORCDataGridViewTextBoxColumn.DataPropertyName = "Temperatura_INTERIOR_C";
            this.temperaturaINTERIORCDataGridViewTextBoxColumn.HeaderText = "Temperatura_INTERIOR_C";
            this.temperaturaINTERIORCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperaturaINTERIORCDataGridViewTextBoxColumn.Name = "temperaturaINTERIORCDataGridViewTextBoxColumn";
            this.temperaturaINTERIORCDataGridViewTextBoxColumn.Width = 125;
            // 
            // umiditateINTERIORDataGridViewTextBoxColumn
            // 
            this.umiditateINTERIORDataGridViewTextBoxColumn.DataPropertyName = "Umiditate_INTERIOR";
            this.umiditateINTERIORDataGridViewTextBoxColumn.HeaderText = "Umiditate_INTERIOR";
            this.umiditateINTERIORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.umiditateINTERIORDataGridViewTextBoxColumn.Name = "umiditateINTERIORDataGridViewTextBoxColumn";
            this.umiditateINTERIORDataGridViewTextBoxColumn.Width = 125;
            // 
            // indexuldeCalduraINTERIORCDataGridViewTextBoxColumn
            // 
            this.indexuldeCalduraINTERIORCDataGridViewTextBoxColumn.DataPropertyName = "Indexul_de_Caldura_INTERIOR_C";
            this.indexuldeCalduraINTERIORCDataGridViewTextBoxColumn.HeaderText = "Indexul_de_Caldura_INTERIOR_C";
            this.indexuldeCalduraINTERIORCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.indexuldeCalduraINTERIORCDataGridViewTextBoxColumn.Name = "indexuldeCalduraINTERIORCDataGridViewTextBoxColumn";
            this.indexuldeCalduraINTERIORCDataGridViewTextBoxColumn.Width = 125;
            // 
            // temperaturaEXTERIORCDataGridViewTextBoxColumn
            // 
            this.temperaturaEXTERIORCDataGridViewTextBoxColumn.DataPropertyName = "Temperatura_EXTERIOR_C";
            this.temperaturaEXTERIORCDataGridViewTextBoxColumn.HeaderText = "Temperatura_EXTERIOR_C";
            this.temperaturaEXTERIORCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperaturaEXTERIORCDataGridViewTextBoxColumn.Name = "temperaturaEXTERIORCDataGridViewTextBoxColumn";
            this.temperaturaEXTERIORCDataGridViewTextBoxColumn.Width = 125;
            // 
            // umiditateEXTERIORDataGridViewTextBoxColumn
            // 
            this.umiditateEXTERIORDataGridViewTextBoxColumn.DataPropertyName = "Umiditate_EXTERIOR";
            this.umiditateEXTERIORDataGridViewTextBoxColumn.HeaderText = "Umiditate_EXTERIOR";
            this.umiditateEXTERIORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.umiditateEXTERIORDataGridViewTextBoxColumn.Name = "umiditateEXTERIORDataGridViewTextBoxColumn";
            this.umiditateEXTERIORDataGridViewTextBoxColumn.Width = 125;
            // 
            // indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn
            // 
            this.indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn.DataPropertyName = "Indexul_de_Caldura_EXTERIOR_C";
            this.indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn.HeaderText = "Indexul_de_Caldura_EXTERIOR_C";
            this.indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn.Name = "indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn";
            this.indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 819);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TestdbDataSet1 testdbDataSet1;
        private System.Windows.Forms.BindingSource temperaturaBindingSource;
        private TestdbDataSet1TableAdapters.TemperaturaTableAdapter temperaturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaINTERIORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umiditateINTERIORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexuldeCalduraINTERIORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaEXTERIORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umiditateEXTERIORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn;
    }
}