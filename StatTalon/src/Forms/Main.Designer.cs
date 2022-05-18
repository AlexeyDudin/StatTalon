
namespace StatTalon.src.Forms
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxIllPeople = new System.Windows.Forms.GroupBox();
            this.groupBoxIll = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxStatistic = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеБолезнямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеБольнымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSetStatTalon = new StatTalon.DataSetStatTalon();
            this.bindingSourceMkbTen = new System.Windows.Forms.BindingSource(this.components);
            this.mkb_tableTableAdapter = new StatTalon.DataSetStatTalonTableAdapters.mkb_tableTableAdapter();
            this.buttonIllWorker = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxIll.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStatTalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMkbTen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxIllPeople, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxIll, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxStatistic, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxIllPeople
            // 
            this.groupBoxIllPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIllPeople.Location = new System.Drawing.Point(195, 3);
            this.groupBoxIllPeople.Name = "groupBoxIllPeople";
            this.groupBoxIllPeople.Size = new System.Drawing.Size(186, 360);
            this.groupBoxIllPeople.TabIndex = 1;
            this.groupBoxIllPeople.TabStop = false;
            this.groupBoxIllPeople.Text = "Управление больными";
            // 
            // groupBoxIll
            // 
            this.groupBoxIll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIll.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxIll.Location = new System.Drawing.Point(3, 3);
            this.groupBoxIll.Name = "groupBoxIll";
            this.groupBoxIll.Size = new System.Drawing.Size(186, 360);
            this.groupBoxIll.TabIndex = 0;
            this.groupBoxIll.TabStop = false;
            this.groupBoxIll.Text = "Управление болезнями";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonIllWorker, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(173, 334);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxStatistic
            // 
            this.groupBoxStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatistic.Location = new System.Drawing.Point(387, 3);
            this.groupBoxStatistic.Name = "groupBoxStatistic";
            this.groupBoxStatistic.Size = new System.Drawing.Size(186, 360);
            this.groupBoxStatistic.TabIndex = 2;
            this.groupBoxStatistic.TabStop = false;
            this.groupBoxStatistic.Text = "Отчеты";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеБолезнямиToolStripMenuItem,
            this.управлениеБольнымиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеБолезнямиToolStripMenuItem
            // 
            this.управлениеБолезнямиToolStripMenuItem.Name = "управлениеБолезнямиToolStripMenuItem";
            this.управлениеБолезнямиToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.управлениеБолезнямиToolStripMenuItem.Text = "Управление болезнями";
            // 
            // управлениеБольнымиToolStripMenuItem
            // 
            this.управлениеБольнымиToolStripMenuItem.Name = "управлениеБольнымиToolStripMenuItem";
            this.управлениеБольнымиToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.управлениеБольнымиToolStripMenuItem.Text = "Управление больными";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // dataSetStatTalon
            // 
            this.dataSetStatTalon.DataSetName = "DataSetStatTalon";
            this.dataSetStatTalon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceMkbTen
            // 
            this.bindingSourceMkbTen.DataMember = "mkb_table";
            this.bindingSourceMkbTen.DataSource = this.dataSetStatTalon;
            // 
            // mkb_tableTableAdapter
            // 
            this.mkb_tableTableAdapter.ClearBeforeFill = true;
            // 
            // buttonIllWorker
            // 
            this.buttonIllWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIllWorker.Location = new System.Drawing.Point(3, 3);
            this.buttonIllWorker.Name = "buttonIllWorker";
            this.buttonIllWorker.Size = new System.Drawing.Size(167, 29);
            this.buttonIllWorker.TabIndex = 0;
            this.buttonIllWorker.Text = "Управление болезнями";
            this.buttonIllWorker.UseVisualStyleBackColor = true;
            this.buttonIllWorker.Click += new System.EventHandler(this.buttonIllWorker_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Статистические талоны v2";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxIll.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStatTalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMkbTen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxIllPeople;
        private System.Windows.Forms.GroupBox groupBoxIll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxStatistic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеБолезнямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеБольнымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private DataSetStatTalon dataSetStatTalon;
        private System.Windows.Forms.BindingSource bindingSourceMkbTen;
        private DataSetStatTalonTableAdapters.mkb_tableTableAdapter mkb_tableTableAdapter;
        private System.Windows.Forms.Button buttonIllWorker;
    }
}

