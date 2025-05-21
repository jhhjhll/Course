namespace Course
{
    partial class AddingСountry
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
            lblNameСountry = new Label();
            lblСapitalСountry = new Label();
            lblPopulationСountry = new Label();
            lblAreaСountry = new Label();
            lblPartWorld = new Label();
            lblAdditionalFacts = new Label();
            TBNameCountry = new TextBox();
            TBСapitalCountry = new TextBox();
            NumUDPopulationCountry = new NumericUpDown();
            NumUDAreaCountry = new NumericUpDown();
            TBAdditionalFacts = new TextBox();
            ButtSave = new Button();
            ButtCancel = new Button();
            ComboBoxPartWorld = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)NumUDPopulationCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUDAreaCountry).BeginInit();
            SuspendLayout();
            // 
            // lblNameСountry
            // 
            lblNameСountry.AutoSize = true;
            lblNameСountry.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNameСountry.Location = new Point(20, 25);
            lblNameСountry.Name = "lblNameСountry";
            lblNameСountry.Size = new Size(55, 18);
            lblNameСountry.TabIndex = 0;
            lblNameСountry.Text = "Назва:";
            // 
            // lblСapitalСountry
            // 
            lblСapitalСountry.AutoSize = true;
            lblСapitalСountry.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblСapitalСountry.Location = new Point(20, 75);
            lblСapitalСountry.Name = "lblСapitalСountry";
            lblСapitalСountry.Size = new Size(72, 18);
            lblСapitalСountry.TabIndex = 1;
            lblСapitalСountry.Text = "Столиця:";
            // 
            // lblPopulationСountry
            // 
            lblPopulationСountry.AutoSize = true;
            lblPopulationСountry.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPopulationСountry.Location = new Point(20, 125);
            lblPopulationСountry.Name = "lblPopulationСountry";
            lblPopulationСountry.Size = new Size(88, 18);
            lblPopulationСountry.TabIndex = 2;
            lblPopulationСountry.Text = "Населення:";
            // 
            // lblAreaСountry
            // 
            lblAreaСountry.AutoSize = true;
            lblAreaСountry.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAreaСountry.Location = new Point(20, 175);
            lblAreaСountry.Name = "lblAreaСountry";
            lblAreaСountry.Size = new Size(94, 18);
            lblAreaСountry.TabIndex = 3;
            lblAreaСountry.Text = "Площа(км²):";
            // 
            // lblPartWorld
            // 
            lblPartWorld.AutoSize = true;
            lblPartWorld.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPartWorld.Location = new Point(20, 225);
            lblPartWorld.Name = "lblPartWorld";
            lblPartWorld.Size = new Size(106, 18);
            lblPartWorld.TabIndex = 4;
            lblPartWorld.Text = "Частина світу:";
            // 
            // lblAdditionalFacts
            // 
            lblAdditionalFacts.AutoSize = true;
            lblAdditionalFacts.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAdditionalFacts.Location = new Point(20, 275);
            lblAdditionalFacts.Name = "lblAdditionalFacts";
            lblAdditionalFacts.Size = new Size(133, 18);
            lblAdditionalFacts.TabIndex = 5;
            lblAdditionalFacts.Text = "Додаткові факти:";
            // 
            // TBNameCountry
            // 
            TBNameCountry.Location = new Point(173, 25);
            TBNameCountry.Margin = new Padding(3, 4, 3, 4);
            TBNameCountry.Name = "TBNameCountry";
            TBNameCountry.Size = new Size(185, 27);
            TBNameCountry.TabIndex = 6;
            // 
            // TBСapitalCountry
            // 
            TBСapitalCountry.Location = new Point(173, 70);
            TBСapitalCountry.Margin = new Padding(3, 4, 3, 4);
            TBСapitalCountry.Name = "TBСapitalCountry";
            TBСapitalCountry.Size = new Size(185, 27);
            TBСapitalCountry.TabIndex = 7;
            // 
            // NumUDPopulationCountry
            // 
            NumUDPopulationCountry.Location = new Point(173, 125);
            NumUDPopulationCountry.Margin = new Padding(3, 4, 3, 4);
            NumUDPopulationCountry.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
            NumUDPopulationCountry.Name = "NumUDPopulationCountry";
            NumUDPopulationCountry.Size = new Size(185, 27);
            NumUDPopulationCountry.TabIndex = 8;
            // 
            // NumUDAreaCountry
            // 
            NumUDAreaCountry.Location = new Point(173, 175);
            NumUDAreaCountry.Margin = new Padding(3, 4, 3, 4);
            NumUDAreaCountry.Maximum = new decimal(new int[] { 20000000, 0, 0, 0 });
            NumUDAreaCountry.Name = "NumUDAreaCountry";
            NumUDAreaCountry.Size = new Size(185, 27);
            NumUDAreaCountry.TabIndex = 9;
            // 
            // TBAdditionalFacts
            // 
            TBAdditionalFacts.Location = new Point(23, 319);
            TBAdditionalFacts.Margin = new Padding(3, 4, 3, 4);
            TBAdditionalFacts.Multiline = true;
            TBAdditionalFacts.Name = "TBAdditionalFacts";
            TBAdditionalFacts.ScrollBars = ScrollBars.Vertical;
            TBAdditionalFacts.Size = new Size(335, 129);
            TBAdditionalFacts.TabIndex = 11;
            // 
            // ButtSave
            // 
            ButtSave.Location = new Point(268, 460);
            ButtSave.Margin = new Padding(3, 4, 3, 4);
            ButtSave.Name = "ButtSave";
            ButtSave.Size = new Size(90, 31);
            ButtSave.TabIndex = 12;
            ButtSave.Text = "Зберегти";
            ButtSave.UseVisualStyleBackColor = true;
            ButtSave.Click += ButtSave_Click;
            // 
            // ButtCancel
            // 
            ButtCancel.Location = new Point(170, 460);
            ButtCancel.Margin = new Padding(3, 4, 3, 4);
            ButtCancel.Name = "ButtCancel";
            ButtCancel.Size = new Size(90, 31);
            ButtCancel.TabIndex = 13;
            ButtCancel.Text = "Скасувати";
            ButtCancel.UseVisualStyleBackColor = true;
            ButtCancel.Click += ButtCancel_Click;
            // 
            // ComboBoxPartWorld
            // 
            ComboBoxPartWorld.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPartWorld.Items.AddRange(new object[] { "Азія", "Європа", "Африка", "Австралія і Океанія", "Пн. Америка", "Пд. Америка" });
            ComboBoxPartWorld.Location = new Point(173, 225);
            ComboBoxPartWorld.Margin = new Padding(3, 4, 3, 4);
            ComboBoxPartWorld.Name = "ComboBoxPartWorld";
            ComboBoxPartWorld.Size = new Size(185, 28);
            ComboBoxPartWorld.TabIndex = 10;
            // 
            // AddingСountry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 504);
            Controls.Add(ButtCancel);
            Controls.Add(ButtSave);
            Controls.Add(TBAdditionalFacts);
            Controls.Add(ComboBoxPartWorld);
            Controls.Add(NumUDAreaCountry);
            Controls.Add(NumUDPopulationCountry);
            Controls.Add(TBСapitalCountry);
            Controls.Add(TBNameCountry);
            Controls.Add(lblAdditionalFacts);
            Controls.Add(lblPartWorld);
            Controls.Add(lblAreaСountry);
            Controls.Add(lblPopulationСountry);
            Controls.Add(lblСapitalСountry);
            Controls.Add(lblNameСountry);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddingСountry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddingСountry";
            ((System.ComponentModel.ISupportInitialize)NumUDPopulationCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUDAreaCountry).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private Label lblNameСountry;
        private Label lblСapitalСountry;
        private Label lblPopulationСountry;
        private Label lblAreaСountry;
        private Label lblPartWorld;
        private Label lblAdditionalFacts;
        private TextBox TBNameCountry;
        private TextBox TBСapitalCountry;
        private NumericUpDown NumUDPopulationCountry;
        private NumericUpDown NumUDAreaCountry;
        private TextBox TBAdditionalFacts;
        private Button ButtSave;
        private Button ButtCancel;
        private ComboBox ComboBoxPartWorld;
    }
}