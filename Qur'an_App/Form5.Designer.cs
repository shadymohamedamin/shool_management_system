namespace Qur_an_App
{
    partial class EventsForm
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
            System.Windows.Forms.Label dateIdLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label eventNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Deletbutton4 = new System.Windows.Forms.Button();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.SortByDatebutton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimedateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.DatedateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EventNamecomboBox1 = new System.Windows.Forms.ComboBox();
            this.DescriptioncomboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButtonEvents = new System.Windows.Forms.Button();
            this.eventsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolSystemDataSet = new Qur_an_App.SchoolSystemDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eventsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.eventsTableAdapter = new Qur_an_App.SchoolSystemDataSetTableAdapters.EventsTableAdapter();
            this.tableAdapterManager = new Qur_an_App.SchoolSystemDataSetTableAdapters.TableAdapterManager();
            dateIdLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            eventNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingNavigator)).BeginInit();
            this.eventsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateIdLabel
            // 
            dateIdLabel.AutoSize = true;
            dateIdLabel.Location = new System.Drawing.Point(1014, 246);
            dateIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateIdLabel.Name = "dateIdLabel";
            dateIdLabel.Size = new System.Drawing.Size(67, 19);
            dateIdLabel.TabIndex = 25;
            dateIdLabel.Text = "Date Id:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(1014, 284);
            timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(51, 19);
            timeLabel.TabIndex = 27;
            timeLabel.Text = "Time:";
            // 
            // eventNameLabel
            // 
            eventNameLabel.AutoSize = true;
            eventNameLabel.Location = new System.Drawing.Point(1014, 320);
            eventNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eventNameLabel.Name = "eventNameLabel";
            eventNameLabel.Size = new System.Drawing.Size(100, 19);
            eventNameLabel.TabIndex = 29;
            eventNameLabel.Text = "Event Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(1014, 358);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(94, 19);
            descriptionLabel.TabIndex = 31;
            descriptionLabel.Text = "Description:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(1014, 396);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 19);
            idLabel.TabIndex = 33;
            idLabel.Text = "Id:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.91797F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.08984F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.08984F));
            this.tableLayoutPanel2.Controls.Add(this.Deletbutton4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Addbutton1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SortByDatebutton1, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 221);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(729, 48);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // Deletbutton4
            // 
            this.Deletbutton4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Deletbutton4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletbutton4.Location = new System.Drawing.Point(235, 4);
            this.Deletbutton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Deletbutton4.Name = "Deletbutton4";
            this.Deletbutton4.Size = new System.Drawing.Size(110, 37);
            this.Deletbutton4.TabIndex = 22;
            this.Deletbutton4.Text = "Delete";
            this.Deletbutton4.UseVisualStyleBackColor = false;
            this.Deletbutton4.Click += new System.EventHandler(this.Deletbutton4_Click);
            // 
            // Addbutton1
            // 
            this.Addbutton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Addbutton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton1.Location = new System.Drawing.Point(4, 4);
            this.Addbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(102, 37);
            this.Addbutton1.TabIndex = 19;
            this.Addbutton1.Text = "Add";
            this.Addbutton1.UseVisualStyleBackColor = false;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // SortByDatebutton1
            // 
            this.SortByDatebutton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SortByDatebutton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByDatebutton1.Location = new System.Drawing.Point(483, 4);
            this.SortByDatebutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortByDatebutton1.Name = "SortByDatebutton1";
            this.SortByDatebutton1.Size = new System.Drawing.Size(154, 37);
            this.SortByDatebutton1.TabIndex = 26;
            this.SortByDatebutton1.Text = "Sorte By Date";
            this.SortByDatebutton1.UseVisualStyleBackColor = false;
            this.SortByDatebutton1.Click += new System.EventHandler(this.SortByDatebutton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.70616F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.90476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.38095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 688F));
            this.tableLayoutPanel1.Controls.Add(this.TimedateTimePicker3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DatedateTimePicker2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EventNamecomboBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DescriptioncomboBox2, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1386, 89);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // TimedateTimePicker3
            // 
            this.TimedateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TimedateTimePicker3.Location = new System.Drawing.Point(502, 48);
            this.TimedateTimePicker3.Name = "TimedateTimePicker3";
            this.TimedateTimePicker3.Size = new System.Drawing.Size(190, 27);
            this.TimedateTimePicker3.TabIndex = 15;
            // 
            // DatedateTimePicker2
            // 
            this.DatedateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DatedateTimePicker2.Location = new System.Drawing.Point(294, 48);
            this.DatedateTimePicker2.Name = "DatedateTimePicker2";
            this.DatedateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.DatedateTimePicker2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(700, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(502, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Events Nme:";
            // 
            // EventNamecomboBox1
            // 
            this.EventNamecomboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EventNamecomboBox1.FormattingEnabled = true;
            this.EventNamecomboBox1.Items.AddRange(new object[] {
            "اجتماع مدرسين",
            "اجتماع مشرفين",
            "حفل ختم القران",
            "المسابقة السنوية"});
            this.EventNamecomboBox1.Location = new System.Drawing.Point(3, 48);
            this.EventNamecomboBox1.Name = "EventNamecomboBox1";
            this.EventNamecomboBox1.Size = new System.Drawing.Size(278, 27);
            this.EventNamecomboBox1.TabIndex = 11;
            // 
            // DescriptioncomboBox2
            // 
            this.DescriptioncomboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescriptioncomboBox2.FormattingEnabled = true;
            this.DescriptioncomboBox2.Items.AddRange(new object[] {
            ".تحديد الخط الدراسية,مقدار ورد القران,طريقة التقيم",
            ".متابعة المشرفين لمستوى الطلاب ,توجيهات للمدرسين لتحسين خطة التدريس",
            ".اجراء حفل لطالب او مجموعة طلاب عند ختمهم القران فى وجود المدرسين والموجهين والطل" +
                "اب",
            " .مسابقة تجرى فى شهر رمضان من كل عام على مستوى المدرسةيعقبها تكريم الاوئل فى المس" +
                "ابقة"});
            this.DescriptioncomboBox2.Location = new System.Drawing.Point(700, 48);
            this.DescriptioncomboBox2.Name = "DescriptioncomboBox2";
            this.DescriptioncomboBox2.Size = new System.Drawing.Size(666, 27);
            this.DescriptioncomboBox2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 51);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(652, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Events";
            // 
            // BackButtonEvents
            // 
            this.BackButtonEvents.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackButtonEvents.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonEvents.Location = new System.Drawing.Point(1000, 699);
            this.BackButtonEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButtonEvents.Name = "BackButtonEvents";
            this.BackButtonEvents.Size = new System.Drawing.Size(81, 37);
            this.BackButtonEvents.TabIndex = 24;
            this.BackButtonEvents.Text = "Back";
            this.BackButtonEvents.UseVisualStyleBackColor = false;
            this.BackButtonEvents.Click += new System.EventHandler(this.BackButtonEvents_Click);
            // 
            // eventsBindingNavigator
            // 
            this.eventsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventsBindingNavigator.BindingSource = this.eventsBindingSource;
            this.eventsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.eventsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eventsBindingNavigatorSaveItem});
            this.eventsBindingNavigator.Location = new System.Drawing.Point(0, 51);
            this.eventsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventsBindingNavigator.Name = "eventsBindingNavigator";
            this.eventsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.eventsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventsBindingNavigator.Size = new System.Drawing.Size(1461, 33);
            this.eventsBindingNavigator.TabIndex = 25;
            this.eventsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.schoolSystemDataSet;
            // 
            // schoolSystemDataSet
            // 
            this.schoolSystemDataSet.DataSetName = "SchoolSystemDataSet";
            this.schoolSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // eventsBindingNavigatorSaveItem
            // 
            this.eventsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventsBindingNavigatorSaveItem.Image")));
            this.eventsBindingNavigatorSaveItem.Name = "eventsBindingNavigatorSaveItem";
            this.eventsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.eventsBindingNavigatorSaveItem.Text = "Save Data";
            this.eventsBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventsBindingNavigatorSaveItem_Click);
            // 
            // eventsDataGridView
            // 
            this.eventsDataGridView.AutoGenerateColumns = false;
            this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.eventsDataGridView.DataSource = this.eventsBindingSource;
            this.eventsDataGridView.Location = new System.Drawing.Point(16, 316);
            this.eventsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventsDataGridView.Name = "eventsDataGridView";
            this.eventsDataGridView.RowHeadersWidth = 62;
            this.eventsDataGridView.Size = new System.Drawing.Size(819, 322);
            this.eventsDataGridView.TabIndex = 25;
            this.eventsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DateId";
            this.dataGridViewTextBoxColumn1.HeaderText = "DateId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn2.HeaderText = "Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EventName";
            this.dataGridViewTextBoxColumn3.HeaderText = "EventName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dateIdDateTimePicker
            // 
            this.dateIdDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventsBindingSource, "DateId", true));
            this.dateIdDateTimePicker.Location = new System.Drawing.Point(1126, 240);
            this.dateIdDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateIdDateTimePicker.Name = "dateIdDateTimePicker";
            this.dateIdDateTimePicker.Size = new System.Drawing.Size(298, 27);
            this.dateIdDateTimePicker.TabIndex = 26;
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventsBindingSource, "Time", true));
            this.timeDateTimePicker.Location = new System.Drawing.Point(1126, 278);
            this.timeDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.Size = new System.Drawing.Size(298, 27);
            this.timeDateTimePicker.TabIndex = 28;
            this.timeDateTimePicker.ValueChanged += new System.EventHandler(this.timeDateTimePicker_ValueChanged);
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "EventName", true));
            this.eventNameTextBox.Location = new System.Drawing.Point(1126, 316);
            this.eventNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(298, 27);
            this.eventNameTextBox.TabIndex = 30;
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.eventNameTextBox_TextChanged_1);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(1126, 354);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(298, 27);
            this.descriptionTextBox.TabIndex = 32;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged_1);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(1126, 392);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(298, 27);
            this.idTextBox.TabIndex = 34;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EventsTableAdapter = this.eventsTableAdapter;
            this.tableAdapterManager.FeesTableAdapter = null;
            this.tableAdapterManager.LogInTableAdapter = null;
            this.tableAdapterManager.StudentDegreesTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Qur_an_App.SchoolSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1461, 770);
            this.Controls.Add(dateIdLabel);
            this.Controls.Add(this.dateIdDateTimePicker);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeDateTimePicker);
            this.Controls.Add(eventNameLabel);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.eventsDataGridView);
            this.Controls.Add(this.eventsBindingNavigator);
            this.Controls.Add(this.BackButtonEvents);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1046, 595);
            this.Name = "EventsForm";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingNavigator)).EndInit();
            this.eventsBindingNavigator.ResumeLayout(false);
            this.eventsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker DatedateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EventNamecomboBox1;
        private System.Windows.Forms.ComboBox DescriptioncomboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Deletbutton4;
        private System.Windows.Forms.Button BackButtonEvents;
        private SchoolSystemDataSet schoolSystemDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private SchoolSystemDataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private SchoolSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eventsBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker TimedateTimePicker3;
        private System.Windows.Forms.Button SortByDatebutton1;
        private System.Windows.Forms.DataGridView eventsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DateTimePicker dateIdDateTimePicker;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}