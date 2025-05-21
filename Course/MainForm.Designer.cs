namespace Course
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ButtAddСountry = new Button();
            ButtEditСountry = new Button();
            ButtDetailsCountry = new Button();
            ButtDeleteCountry = new Button();
            ButtSearchCountries = new Button();
            TableCountries = new DataGridView();
            TBoxSearchCountries = new TextBox();
            lblSearchResults = new Label();
            lblNumberCountries = new Label();
            lblTotalPopulation = new Label();
            lblАverageАrea = new Label();
            ComboBoxPartWorld = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TableCountries).BeginInit();
            SuspendLayout();
            // 
            // ButtAddСountry
            // 
            ButtAddСountry.Location = new Point(20, 25);
            ButtAddСountry.Margin = new Padding(3, 4, 3, 4);
            ButtAddСountry.Name = "ButtAddСountry";
            ButtAddСountry.Size = new Size(140, 50);
            ButtAddСountry.TabIndex = 0;
            ButtAddСountry.Text = "Додати Країну";
            ButtAddСountry.UseVisualStyleBackColor = true;
            ButtAddСountry.Click += ButtAddСountry_Click;
            // 
            // ButtEditСountry
            // 
            ButtEditСountry.Location = new Point(181, 25);
            ButtEditСountry.Margin = new Padding(3, 4, 3, 4);
            ButtEditСountry.Name = "ButtEditСountry";
            ButtEditСountry.Size = new Size(140, 50);
            ButtEditСountry.TabIndex = 1;
            ButtEditСountry.Text = "Редагувати";
            ButtEditСountry.UseVisualStyleBackColor = true;
            ButtEditСountry.Click += ButtEditCountry_Click;
            // 
            // ButtDetailsCountry
            // 
            ButtDetailsCountry.Location = new Point(340, 25);
            ButtDetailsCountry.Margin = new Padding(3, 4, 3, 4);
            ButtDetailsCountry.Name = "ButtDetailsCountry";
            ButtDetailsCountry.Size = new Size(140, 50);
            ButtDetailsCountry.TabIndex = 2;
            ButtDetailsCountry.Text = "Деталі";
            ButtDetailsCountry.UseVisualStyleBackColor = true;
            ButtDetailsCountry.Click += ButtDetailsCountry_Click;
            // 
            // ButtDeleteCountry
            // 
            ButtDeleteCountry.Location = new Point(500, 25);
            ButtDeleteCountry.Margin = new Padding(3, 4, 3, 4);
            ButtDeleteCountry.Name = "ButtDeleteCountry";
            ButtDeleteCountry.Size = new Size(140, 50);
            ButtDeleteCountry.TabIndex = 3;
            ButtDeleteCountry.Text = "Видалити";
            ButtDeleteCountry.UseVisualStyleBackColor = true;
            ButtDeleteCountry.Click += ButtDeleteCountry_Click;
            // 
            // ButtSearchCountries
            // 
            ButtSearchCountries.Location = new Point(959, 28);
            ButtSearchCountries.Margin = new Padding(3, 4, 3, 4);
            ButtSearchCountries.Name = "ButtSearchCountries";
            ButtSearchCountries.Size = new Size(80, 50);
            ButtSearchCountries.TabIndex = 4;
            ButtSearchCountries.Text = "Пошук";
            ButtSearchCountries.UseVisualStyleBackColor = true;
            ButtSearchCountries.Click += ButtSearchCountries_Click;
            // 
            // TableCountries
            // 
            TableCountries.AllowUserToAddRows = false;
            TableCountries.AllowUserToDeleteRows = false;
            TableCountries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableCountries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableCountries.Location = new Point(20, 100);
            TableCountries.Margin = new Padding(3, 4, 3, 4);
            TableCountries.MultiSelect = false;
            TableCountries.Name = "TableCountries";
            TableCountries.ReadOnly = true;
            TableCountries.RowHeadersWidth = 51;
            TableCountries.RowTemplate.Height = 24;
            TableCountries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableCountries.Size = new Size(1019, 556);
            TableCountries.TabIndex = 5;
            // 
            // TBoxSearchCountries
            // 
            TBoxSearchCountries.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBoxSearchCountries.Location = new Point(646, 28);
            TBoxSearchCountries.Margin = new Padding(3, 4, 3, 4);
            TBoxSearchCountries.Name = "TBoxSearchCountries";
            TBoxSearchCountries.Size = new Size(152, 27);
            TBoxSearchCountries.TabIndex = 6;
            // 
            // lblSearchResults
            // 
            lblSearchResults.AutoSize = true;
            lblSearchResults.Location = new Point(647, 72);
            lblSearchResults.Name = "lblSearchResults";
            lblSearchResults.Size = new Size(0, 20);
            lblSearchResults.TabIndex = 7;
            // 
            // lblNumberCountries
            // 
            lblNumberCountries.AutoSize = true;
            lblNumberCountries.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblNumberCountries.Location = new Point(17, 685);
            lblNumberCountries.Name = "lblNumberCountries";
            lblNumberCountries.Size = new Size(115, 18);
            lblNumberCountries.TabIndex = 8;
            lblNumberCountries.Text = "Кількість країн:";
            // 
            // lblTotalPopulation
            // 
            lblTotalPopulation.AutoSize = true;
            lblTotalPopulation.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblTotalPopulation.Location = new Point(312, 685);
            lblTotalPopulation.Name = "lblTotalPopulation";
            lblTotalPopulation.Size = new Size(154, 18);
            lblTotalPopulation.TabIndex = 9;
            lblTotalPopulation.Text = "Загальне населення:";
            // 
            // lblАverageАrea
            // 
            lblАverageАrea.AutoSize = true;
            lblАverageАrea.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblАverageАrea.Location = new Point(677, 685);
            lblАverageАrea.Name = "lblАverageАrea";
            lblАverageАrea.Size = new Size(121, 18);
            lblАverageАrea.TabIndex = 10;
            lblАverageАrea.Text = "Середня площа:";
            // 
            // ComboBoxPartWorld
            // 
            ComboBoxPartWorld.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPartWorld.Items.AddRange(new object[] { "Усі", "Азія", "Європа", "Африка", "Австралія і Океанія", "Пн. Америка", "Пд. Америка" });
            ComboBoxPartWorld.Location = new Point(804, 28);
            ComboBoxPartWorld.Margin = new Padding(3, 4, 3, 4);
            ComboBoxPartWorld.Name = "ComboBoxPartWorld";
            ComboBoxPartWorld.Size = new Size(149, 28);
            ComboBoxPartWorld.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 736);
            Controls.Add(ComboBoxPartWorld);
            Controls.Add(lblАverageАrea);
            Controls.Add(lblTotalPopulation);
            Controls.Add(lblNumberCountries);
            Controls.Add(lblSearchResults);
            Controls.Add(TBoxSearchCountries);
            Controls.Add(TableCountries);
            Controls.Add(ButtSearchCountries);
            Controls.Add(ButtDeleteCountry);
            Controls.Add(ButtDetailsCountry);
            Controls.Add(ButtEditСountry);
            Controls.Add(ButtAddСountry);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довідник географа";
            ((System.ComponentModel.ISupportInitialize)TableCountries).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion


        private Button ButtAddСountry;
        private Button ButtEditСountry;
        private Button ButtDetailsCountry;
        private Button ButtDeleteCountry;
        private Button ButtSearchCountries;
        private DataGridView TableCountries;
        private TextBox TBoxSearchCountries;
        private Label lblSearchResults;
        private Label lblNumberCountries;
        private Label lblTotalPopulation;
        private Label lblАverageАrea;
        private ComboBox ComboBoxPartWorld;
    }
}