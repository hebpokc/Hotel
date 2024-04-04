
namespace Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.dischargeRadioButton = new System.Windows.Forms.RadioButton();
            this.busyRadioButton = new System.Windows.Forms.RadioButton();
            this.freeRadioButton = new System.Windows.Forms.RadioButton();
            this.regRadioButton = new System.Windows.Forms.RadioButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.guestsDataGridView = new System.Windows.Forms.DataGridView();
            this.guestListLabel = new System.Windows.Forms.Label();
            this.changeStatusBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.departureLabel = new System.Windows.Forms.Label();
            this.arrivalTextBox = new System.Windows.Forms.TextBox();
            this.arivalLabel = new System.Windows.Forms.Label();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.FioLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel2 = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.guestRoomLabel = new System.Windows.Forms.Label();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.timePictureBox = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.seacrhBtn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.timeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timePictureBox)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.changeStatusBtn);
            this.splitContainer1.Panel2.Controls.Add(this.viewBtn);
            this.splitContainer1.Panel2.Controls.Add(this.departureTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.departureLabel);
            this.splitContainer1.Panel2.Controls.Add(this.arrivalTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.arivalLabel);
            this.splitContainer1.Panel2.Controls.Add(this.FioTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.FioLabel);
            this.splitContainer1.Panel2.Controls.Add(this.statusComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.statusLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.PhotoPictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.guestRoomLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1036, 646);
            this.splitContainer1.SplitterDistance = 658;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(-2, -1);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.allRadioButton);
            this.splitContainer2.Panel1.Controls.Add(this.dischargeRadioButton);
            this.splitContainer2.Panel1.Controls.Add(this.busyRadioButton);
            this.splitContainer2.Panel1.Controls.Add(this.freeRadioButton);
            this.splitContainer2.Panel1.Controls.Add(this.regRadioButton);
            this.splitContainer2.Panel1.Controls.Add(this.statusLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.guestsDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.guestListLabel);
            this.splitContainer2.Size = new System.Drawing.Size(660, 666);
            this.splitContainer2.SplitterDistance = 157;
            this.splitContainer2.TabIndex = 0;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allRadioButton.Location = new System.Drawing.Point(3, 45);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(52, 22);
            this.allRadioButton.TabIndex = 7;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "Все";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // dischargeRadioButton
            // 
            this.dischargeRadioButton.AutoSize = true;
            this.dischargeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dischargeRadioButton.Location = new System.Drawing.Point(3, 222);
            this.dischargeRadioButton.Name = "dischargeRadioButton";
            this.dischargeRadioButton.Size = new System.Drawing.Size(132, 22);
            this.dischargeRadioButton.TabIndex = 6;
            this.dischargeRadioButton.Text = "Выписываются";
            this.dischargeRadioButton.UseVisualStyleBackColor = true;
            // 
            // busyRadioButton
            // 
            this.busyRadioButton.AutoSize = true;
            this.busyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.busyRadioButton.Location = new System.Drawing.Point(3, 179);
            this.busyRadioButton.Name = "busyRadioButton";
            this.busyRadioButton.Size = new System.Drawing.Size(78, 22);
            this.busyRadioButton.TabIndex = 5;
            this.busyRadioButton.Text = "Заняты";
            this.busyRadioButton.UseVisualStyleBackColor = true;
            // 
            // freeRadioButton
            // 
            this.freeRadioButton.AutoSize = true;
            this.freeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRadioButton.Location = new System.Drawing.Point(3, 135);
            this.freeRadioButton.Name = "freeRadioButton";
            this.freeRadioButton.Size = new System.Drawing.Size(108, 22);
            this.freeRadioButton.TabIndex = 4;
            this.freeRadioButton.Text = "Свободные";
            this.freeRadioButton.UseVisualStyleBackColor = true;
            // 
            // regRadioButton
            // 
            this.regRadioButton.AutoSize = true;
            this.regRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regRadioButton.Location = new System.Drawing.Point(3, 91);
            this.regRadioButton.Name = "regRadioButton";
            this.regRadioButton.Size = new System.Drawing.Size(150, 22);
            this.regRadioButton.TabIndex = 3;
            this.regRadioButton.Text = "Зарезервировано";
            this.regRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(43, 10);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 20);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Статус";
            // 
            // guestsDataGridView
            // 
            this.guestsDataGridView.AllowUserToAddRows = false;
            this.guestsDataGridView.AllowUserToDeleteRows = false;
            this.guestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsDataGridView.Location = new System.Drawing.Point(19, 45);
            this.guestsDataGridView.Name = "guestsDataGridView";
            this.guestsDataGridView.ReadOnly = true;
            this.guestsDataGridView.Size = new System.Drawing.Size(461, 586);
            this.guestsDataGridView.TabIndex = 4;
            this.guestsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestsDataGridView_CellClick);
            // 
            // guestListLabel
            // 
            this.guestListLabel.AutoSize = true;
            this.guestListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestListLabel.Location = new System.Drawing.Point(181, 10);
            this.guestListLabel.Name = "guestListLabel";
            this.guestListLabel.Size = new System.Drawing.Size(131, 20);
            this.guestListLabel.TabIndex = 3;
            this.guestListLabel.Text = "Список гостей";
            // 
            // changeStatusBtn
            // 
            this.changeStatusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeStatusBtn.Location = new System.Drawing.Point(18, 600);
            this.changeStatusBtn.Name = "changeStatusBtn";
            this.changeStatusBtn.Size = new System.Drawing.Size(156, 32);
            this.changeStatusBtn.TabIndex = 13;
            this.changeStatusBtn.Text = "Изменить статус";
            this.changeStatusBtn.UseVisualStyleBackColor = true;
            this.changeStatusBtn.Click += new System.EventHandler(this.changeStatusBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewBtn.Location = new System.Drawing.Point(203, 600);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(156, 32);
            this.viewBtn.TabIndex = 12;
            this.viewBtn.Text = "Просмотр карточки";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // departureTextBox
            // 
            this.departureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureTextBox.Location = new System.Drawing.Point(137, 440);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.ReadOnly = true;
            this.departureTextBox.Size = new System.Drawing.Size(88, 24);
            this.departureTextBox.TabIndex = 11;
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureLabel.Location = new System.Drawing.Point(14, 440);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(120, 20);
            this.departureLabel.TabIndex = 10;
            this.departureLabel.Text = "Дата выезда";
            // 
            // arrivalTextBox
            // 
            this.arrivalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivalTextBox.Location = new System.Drawing.Point(137, 400);
            this.arrivalTextBox.Name = "arrivalTextBox";
            this.arrivalTextBox.ReadOnly = true;
            this.arrivalTextBox.Size = new System.Drawing.Size(88, 24);
            this.arrivalTextBox.TabIndex = 9;
            // 
            // arivalLabel
            // 
            this.arivalLabel.AutoSize = true;
            this.arivalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arivalLabel.Location = new System.Drawing.Point(14, 400);
            this.arivalLabel.Name = "arivalLabel";
            this.arivalLabel.Size = new System.Drawing.Size(117, 20);
            this.arivalLabel.TabIndex = 8;
            this.arivalLabel.Text = "Дата заезда";
            // 
            // FioTextBox
            // 
            this.FioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioTextBox.Location = new System.Drawing.Point(70, 359);
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.ReadOnly = true;
            this.FioTextBox.Size = new System.Drawing.Size(252, 24);
            this.FioTextBox.TabIndex = 7;
            // 
            // FioLabel
            // 
            this.FioLabel.AutoSize = true;
            this.FioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioLabel.Location = new System.Drawing.Point(14, 361);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(50, 20);
            this.FioLabel.TabIndex = 6;
            this.FioLabel.Text = "ФИО";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Зарезервировано",
            "Свободные",
            "Заняты",
            "Выписываются"});
            this.statusComboBox.Location = new System.Drawing.Point(88, 315);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(234, 26);
            this.statusComboBox.TabIndex = 5;
            // 
            // statusLabel2
            // 
            this.statusLabel2.AutoSize = true;
            this.statusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel2.Location = new System.Drawing.Point(14, 318);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(68, 20);
            this.statusLabel2.TabIndex = 3;
            this.statusLabel2.Text = "Статус";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::Hotel.Properties.Resources.human;
            this.PhotoPictureBox.Location = new System.Drawing.Point(66, 46);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(256, 256);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PhotoPictureBox.TabIndex = 3;
            this.PhotoPictureBox.TabStop = false;
            // 
            // guestRoomLabel
            // 
            this.guestRoomLabel.AutoSize = true;
            this.guestRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestRoomLabel.Location = new System.Drawing.Point(87, 11);
            this.guestRoomLabel.Name = "guestRoomLabel";
            this.guestRoomLabel.Size = new System.Drawing.Size(174, 20);
            this.guestRoomLabel.TabIndex = 4;
            this.guestRoomLabel.Text = "Номер комнаты - №";
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Controls.Add(this.timePictureBox);
            this.timeGroupBox.Controls.Add(this.labelTime);
            this.timeGroupBox.Location = new System.Drawing.Point(0, -2);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Size = new System.Drawing.Size(271, 43);
            this.timeGroupBox.TabIndex = 1;
            this.timeGroupBox.TabStop = false;
            // 
            // timePictureBox
            // 
            this.timePictureBox.Image = global::Hotel.Properties.Resources.time1;
            this.timePictureBox.Location = new System.Drawing.Point(223, 2);
            this.timePictureBox.Name = "timePictureBox";
            this.timePictureBox.Size = new System.Drawing.Size(48, 41);
            this.timePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.timePictureBox.TabIndex = 3;
            this.timePictureBox.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(56, 11);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 25);
            this.labelTime.TabIndex = 2;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.refreshBtn);
            this.searchGroupBox.Controls.Add(this.seacrhBtn);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(298, -3);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(725, 44);
            this.searchGroupBox.TabIndex = 2;
            this.searchGroupBox.TabStop = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = global::Hotel.Properties.Resources.refresh;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.Location = new System.Drawing.Point(660, 4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 40);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // seacrhBtn
            // 
            this.seacrhBtn.BackgroundImage = global::Hotel.Properties.Resources.search1;
            this.seacrhBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seacrhBtn.Location = new System.Drawing.Point(593, 4);
            this.seacrhBtn.Name = "seacrhBtn";
            this.seacrhBtn.Size = new System.Drawing.Size(50, 40);
            this.seacrhBtn.TabIndex = 1;
            this.seacrhBtn.UseVisualStyleBackColor = true;
            this.seacrhBtn.Click += new System.EventHandler(this.seacrhBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.searchTextBox.Location = new System.Drawing.Point(6, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(566, 24);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Поиск...";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 686);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timePictureBox)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox timePictureBox;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button seacrhBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label guestListLabel;
        private System.Windows.Forms.Label guestRoomLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel2;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.TextBox FioTextBox;
        private System.Windows.Forms.TextBox arrivalTextBox;
        private System.Windows.Forms.Label arivalLabel;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.RadioButton dischargeRadioButton;
        private System.Windows.Forms.RadioButton busyRadioButton;
        private System.Windows.Forms.RadioButton freeRadioButton;
        private System.Windows.Forms.RadioButton regRadioButton;
        private System.Windows.Forms.DataGridView guestsDataGridView;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button changeStatusBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.RadioButton allRadioButton;
    }
}

