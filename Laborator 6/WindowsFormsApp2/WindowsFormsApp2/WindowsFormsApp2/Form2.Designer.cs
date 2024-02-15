namespace WindowsFormsApp2
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.testdbDataSet = new WindowsFormsApp2.TestdbDataSet();
            this.temperaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temperaturaTableAdapter = new WindowsFormsApp2.TestdbDataSetTableAdapters.TemperaturaTableAdapter();
            this.temperaturaINTERIORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umiditateINTERIORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexuldeCalduraINTERIORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaEXTERIORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umiditateEXTERIORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(587, 759);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(880, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Temperatura Interior";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1016, 689);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(608, 62);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Temperatura_Interior";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Umiditate_Interior";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Index_de_Caldura_Interior";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(839, 621);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // testdbDataSet
            // 
            this.testdbDataSet.DataSetName = "TestdbDataSet";
            this.testdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temperaturaBindingSource
            // 
            this.temperaturaBindingSource.DataMember = "Temperatura";
            this.temperaturaBindingSource.DataSource = this.testdbDataSet;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 759);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private TestdbDataSet testdbDataSet;
        private System.Windows.Forms.BindingSource temperaturaBindingSource;
        private TestdbDataSetTableAdapters.TemperaturaTableAdapter temperaturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaINTERIORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umiditateINTERIORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexuldeCalduraINTERIORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaEXTERIORCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umiditateEXTERIORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexuldeCalduraEXTERIORCDataGridViewTextBoxColumn;
    }
}