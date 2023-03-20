
namespace Qur_an_App
{
    partial class feesForm
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
            System.Windows.Forms.Label studentIdLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label payLabel;
            System.Windows.Forms.Label notPayLabel;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feesForm));
            this.amounttextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButtonFees = new System.Windows.Forms.Button();
            this.DeleteFeesbutton2 = new System.Windows.Forms.Button();
            this.SortByNotPaybutton1 = new System.Windows.Forms.Button();
            this.stIdtextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Addbutton8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NotPaytextBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PaytextBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.feesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.feesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.feesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.feesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesTableAdapter = new Qur_an_App.SchoolSystemDataSetTableAdapters.FeesTableAdapter();
            this.tableAdapterManager = new Qur_an_App.SchoolSystemDataSetTableAdapters.TableAdapterManager();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.notPayTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            studentIdLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            payLabel = new System.Windows.Forms.Label();
            notPayLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingNavigator)).BeginInit();
            this.feesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Location = new System.Drawing.Point(872, 270);
            studentIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new System.Drawing.Size(89, 19);
            studentIdLabel.TabIndex = 49;
            studentIdLabel.Text = "Student Id:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(872, 308);
            amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(72, 19);
            amountLabel.TabIndex = 51;
            amountLabel.Text = "Amount:";
            // 
            // payLabel
            // 
            payLabel.AutoSize = true;
            payLabel.Location = new System.Drawing.Point(872, 346);
            payLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            payLabel.Name = "payLabel";
            payLabel.Size = new System.Drawing.Size(40, 19);
            payLabel.TabIndex = 53;
            payLabel.Text = "Pay:";
            // 
            // notPayLabel
            // 
            notPayLabel.AutoSize = true;
            notPayLabel.Location = new System.Drawing.Point(872, 384);
            notPayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notPayLabel.Name = "notPayLabel";
            notPayLabel.Size = new System.Drawing.Size(70, 19);
            notPayLabel.TabIndex = 55;
            notPayLabel.Text = "Not Pay:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(872, 424);
            dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(47, 19);
            dateLabel.TabIndex = 57;
            dateLabel.Text = "Date:";
            // 
            // amounttextBox2
            // 
            this.amounttextBox2.Location = new System.Drawing.Point(166, 152);
            this.amounttextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amounttextBox2.Name = "amounttextBox2";
            this.amounttextBox2.Size = new System.Drawing.Size(169, 27);
            this.amounttextBox2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "Amount";
            // 
            // BackButtonFees
            // 
            this.BackButtonFees.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackButtonFees.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonFees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButtonFees.Location = new System.Drawing.Point(956, 526);
            this.BackButtonFees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButtonFees.Name = "BackButtonFees";
            this.BackButtonFees.Size = new System.Drawing.Size(92, 37);
            this.BackButtonFees.TabIndex = 38;
            this.BackButtonFees.Text = "Back";
            this.BackButtonFees.UseVisualStyleBackColor = false;
            this.BackButtonFees.Click += new System.EventHandler(this.BackButtonFees_Click);
            // 
            // DeleteFeesbutton2
            // 
            this.DeleteFeesbutton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteFeesbutton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFeesbutton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteFeesbutton2.Location = new System.Drawing.Point(650, 238);
            this.DeleteFeesbutton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteFeesbutton2.Name = "DeleteFeesbutton2";
            this.DeleteFeesbutton2.Size = new System.Drawing.Size(112, 37);
            this.DeleteFeesbutton2.TabIndex = 37;
            this.DeleteFeesbutton2.Text = "Delete";
            this.DeleteFeesbutton2.UseVisualStyleBackColor = false;
            this.DeleteFeesbutton2.Click += new System.EventHandler(this.DeleteFeesbutton2_Click);
            // 
            // SortByNotPaybutton1
            // 
            this.SortByNotPaybutton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SortByNotPaybutton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByNotPaybutton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SortByNotPaybutton1.Location = new System.Drawing.Point(292, 238);
            this.SortByNotPaybutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortByNotPaybutton1.Name = "SortByNotPaybutton1";
            this.SortByNotPaybutton1.Size = new System.Drawing.Size(225, 37);
            this.SortByNotPaybutton1.TabIndex = 36;
            this.SortByNotPaybutton1.Text = "Sort By Not Pay";
            this.SortByNotPaybutton1.UseVisualStyleBackColor = false;
            this.SortByNotPaybutton1.Click += new System.EventHandler(this.SortByNotPaybutton1_Click);
            // 
            // stIdtextBox1
            // 
            this.stIdtextBox1.Location = new System.Drawing.Point(166, 114);
            this.stIdtextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stIdtextBox1.Name = "stIdtextBox1";
            this.stIdtextBox1.Size = new System.Drawing.Size(169, 27);
            this.stIdtextBox1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(442, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 50);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fees";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Student Id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(462, 114);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 27);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // Addbutton8
            // 
            this.Addbutton8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Addbutton8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addbutton8.Location = new System.Drawing.Point(124, 238);
            this.Addbutton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Addbutton8.Name = "Addbutton8";
            this.Addbutton8.Size = new System.Drawing.Size(135, 37);
            this.Addbutton8.TabIndex = 30;
            this.Addbutton8.Text = "Add";
            this.Addbutton8.UseVisualStyleBackColor = false;
            this.Addbutton8.Click += new System.EventHandler(this.Addbutton8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 58);
            this.panel1.TabIndex = 42;
            // 
            // NotPaytextBox4
            // 
            this.NotPaytextBox4.Location = new System.Drawing.Point(532, 191);
            this.NotPaytextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotPaytextBox4.Name = "NotPaytextBox4";
            this.NotPaytextBox4.Size = new System.Drawing.Size(169, 27);
            this.NotPaytextBox4.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(411, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 30);
            this.label6.TabIndex = 45;
            this.label6.Text = "Not Pay";
            // 
            // PaytextBox3
            // 
            this.PaytextBox3.Location = new System.Drawing.Point(166, 190);
            this.PaytextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaytextBox3.Name = "PaytextBox3";
            this.PaytextBox3.Size = new System.Drawing.Size(169, 27);
            this.PaytextBox3.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(18, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 30);
            this.label5.TabIndex = 47;
            this.label5.Text = "Pay";
            // 
            // feesBindingNavigator
            // 
            this.feesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.feesBindingNavigator.BindingSource = this.feesBindingSource;
            this.feesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.feesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.feesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.feesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.feesBindingNavigatorSaveItem});
            this.feesBindingNavigator.Location = new System.Drawing.Point(0, 58);
            this.feesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.feesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.feesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.feesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.feesBindingNavigator.Name = "feesBindingNavigator";
            this.feesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.feesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.feesBindingNavigator.Size = new System.Drawing.Size(1380, 33);
            this.feesBindingNavigator.TabIndex = 49;
            this.feesBindingNavigator.Text = "bindingNavigator1";
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
            // feesBindingSource
            // 
            this.feesBindingSource.DataMember = "Fees";
            this.feesBindingSource.DataSource = this.schoolSystemDataSet;
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
            // feesBindingNavigatorSaveItem
            // 
            this.feesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.feesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("feesBindingNavigatorSaveItem.Image")));
            this.feesBindingNavigatorSaveItem.Name = "feesBindingNavigatorSaveItem";
            this.feesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.feesBindingNavigatorSaveItem.Text = "Save Data";
            this.feesBindingNavigatorSaveItem.Click += new System.EventHandler(this.feesBindingNavigatorSaveItem_Click);
            // 
            // feesDataGridView
            // 
            this.feesDataGridView.AutoGenerateColumns = false;
            this.feesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.feesDataGridView.DataSource = this.feesBindingSource;
            this.feesDataGridView.Location = new System.Drawing.Point(24, 284);
            this.feesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.feesDataGridView.Name = "feesDataGridView";
            this.feesDataGridView.RowHeadersWidth = 62;
            this.feesDataGridView.Size = new System.Drawing.Size(790, 234);
            this.feesDataGridView.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pay";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pay";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NotPay";
            this.dataGridViewTextBoxColumn4.HeaderText = "NotPay";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // feesTableAdapter
            // 
            this.feesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.FeesTableAdapter = this.feesTableAdapter;
            this.tableAdapterManager.LogInTableAdapter = null;
            this.tableAdapterManager.StudentDegreesTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Qur_an_App.SchoolSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feesBindingSource, "StudentId", true));
            this.studentIdTextBox.Location = new System.Drawing.Point(969, 266);
            this.studentIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(298, 27);
            this.studentIdTextBox.TabIndex = 50;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feesBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(969, 304);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(298, 27);
            this.amountTextBox.TabIndex = 52;
            // 
            // payTextBox
            // 
            this.payTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feesBindingSource, "Pay", true));
            this.payTextBox.Location = new System.Drawing.Point(969, 342);
            this.payTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.Size = new System.Drawing.Size(298, 27);
            this.payTextBox.TabIndex = 54;
            // 
            // notPayTextBox
            // 
            this.notPayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feesBindingSource, "NotPay", true));
            this.notPayTextBox.Location = new System.Drawing.Point(969, 380);
            this.notPayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notPayTextBox.Name = "notPayTextBox";
            this.notPayTextBox.Size = new System.Drawing.Size(298, 27);
            this.notPayTextBox.TabIndex = 56;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.feesBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(969, 418);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(298, 27);
            this.dateDateTimePicker.TabIndex = 58;
            // 
            // feesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1380, 576);
            this.Controls.Add(studentIdLabel);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(payLabel);
            this.Controls.Add(this.payTextBox);
            this.Controls.Add(notPayLabel);
            this.Controls.Add(this.notPayTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.feesDataGridView);
            this.Controls.Add(this.feesBindingNavigator);
            this.Controls.Add(this.PaytextBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NotPaytextBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.amounttextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButtonFees);
            this.Controls.Add(this.DeleteFeesbutton2);
            this.Controls.Add(this.SortByNotPaybutton1);
            this.Controls.Add(this.stIdtextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Addbutton8);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1046, 595);
            this.Name = "feesForm";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.feesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingNavigator)).EndInit();
            this.feesBindingNavigator.ResumeLayout(false);
            this.feesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amounttextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButtonFees;
        private System.Windows.Forms.Button DeleteFeesbutton2;
        private System.Windows.Forms.Button SortByNotPaybutton1;
        private System.Windows.Forms.TextBox stIdtextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Addbutton8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NotPaytextBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PaytextBox3;
        private System.Windows.Forms.Label label5;
        private SchoolSystemDataSet schoolSystemDataSet;
        private System.Windows.Forms.BindingSource feesBindingSource;
        private SchoolSystemDataSetTableAdapters.FeesTableAdapter feesTableAdapter;
        private SchoolSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator feesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton feesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView feesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox payTextBox;
        private System.Windows.Forms.TextBox notPayTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
    }
}