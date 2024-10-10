namespace Magazin
{
    partial class Magazin
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
            dataGridView1 = new DataGridView();
            Name = new TextBox();
            Price = new TextBox();
            Count = new TextBox();
            Unit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Category = new ComboBox();
            button1 = new Button();
            Id = new TextBox();
            IdLabel = new Label();
            DeleteButton = new Button();
            UpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(868, 372);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Name
            // 
            Name.Location = new Point(971, 49);
            Name.Multiline = true;
            Name.Name = "Name";
            Name.Size = new Size(213, 35);
            Name.TabIndex = 1;
            // 
            // Price
            // 
            Price.Location = new Point(971, 114);
            Price.Multiline = true;
            Price.Name = "Price";
            Price.Size = new Size(213, 36);
            Price.TabIndex = 2;
            // 
            // Count
            // 
            Count.Location = new Point(971, 179);
            Count.Multiline = true;
            Count.Name = "Count";
            Count.Size = new Size(213, 35);
            Count.TabIndex = 3;
            // 
            // Unit
            // 
            Unit.Location = new Point(971, 243);
            Unit.Multiline = true;
            Unit.Name = "Unit";
            Unit.Size = new Size(213, 37);
            Unit.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(971, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(971, 88);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 6;
            label2.Text = "Narxi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(971, 153);
            label3.Name = "label3";
            label3.Size = new Size(43, 23);
            label3.TabIndex = 7;
            label3.Text = "Soni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(971, 217);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 8;
            label4.Text = "Birlik";
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "OziqOvqat", "Elektronika", "Sport", "Detskiy" });
            Category.Location = new Point(971, 309);
            Category.Name = "Category";
            Category.Size = new Size(213, 28);
            Category.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(971, 365);
            button1.Name = "button1";
            button1.Size = new Size(93, 36);
            button1.TabIndex = 10;
            button1.Text = "Qo'shish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Id
            // 
            Id.Location = new Point(971, 439);
            Id.Multiline = true;
            Id.Name = "Id";
            Id.Size = new Size(72, 35);
            Id.TabIndex = 11;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 10F);
            IdLabel.Location = new Point(930, 440);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(25, 23);
            IdLabel.TabIndex = 12;
            IdLabel.Text = "Id";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(1058, 438);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 36);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Uchirish";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(1084, 365);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(100, 36);
            UpdateButton.TabIndex = 14;
            UpdateButton.Text = "O'zgartirish";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Magazin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 569);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(IdLabel);
            Controls.Add(Id);
            Controls.Add(button1);
            Controls.Add(Category);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Unit);
            Controls.Add(Count);
            Controls.Add(Price);
            Controls.Add(Name);
            Controls.Add(dataGridView1);
            //Name = "Magazin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox Name;
        private TextBox Price;
        private TextBox Count;
        private TextBox Unit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Category;
        private Button button1;
        private TextBox Id;
        private Label IdLabel;
        private Button DeleteButton;
        private Button UpdateButton;
    }
}