
namespace Hotel
{
    partial class GuestCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestCard));
            this.guestInfoLabel = new System.Windows.Forms.Label();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.FioLabel = new System.Windows.Forms.Label();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.decreaseBtn = new System.Windows.Forms.Button();
            this.increaseBtn = new System.Windows.Forms.Button();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.animalInfoLabel = new System.Windows.Forms.Label();
            this.animalInfoTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guestInfoLabel
            // 
            this.guestInfoLabel.AutoSize = true;
            this.guestInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestInfoLabel.Location = new System.Drawing.Point(110, 20);
            this.guestInfoLabel.Name = "guestInfoLabel";
            this.guestInfoLabel.Size = new System.Drawing.Size(162, 24);
            this.guestInfoLabel.TabIndex = 4;
            this.guestInfoLabel.Text = "Карточка гостя";
            // 
            // FioTextBox
            // 
            this.FioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioTextBox.Location = new System.Drawing.Point(70, 71);
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.ReadOnly = true;
            this.FioTextBox.Size = new System.Drawing.Size(252, 24);
            this.FioTextBox.TabIndex = 9;
            // 
            // FioLabel
            // 
            this.FioLabel.AutoSize = true;
            this.FioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioLabel.Location = new System.Drawing.Point(14, 73);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(50, 20);
            this.FioLabel.TabIndex = 8;
            this.FioLabel.Text = "ФИО";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayTextBox.Location = new System.Drawing.Point(161, 114);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.Size = new System.Drawing.Size(96, 24);
            this.birthdayTextBox.TabIndex = 11;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayLabel.Location = new System.Drawing.Point(14, 114);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(141, 20);
            this.birthdayLabel.TabIndex = 10;
            this.birthdayLabel.Text = "День рождения";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentTextBox.Location = new System.Drawing.Point(93, 160);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.ReadOnly = true;
            this.paymentTextBox.Size = new System.Drawing.Size(154, 24);
            this.paymentTextBox.TabIndex = 13;
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentTypeLabel.Location = new System.Drawing.Point(14, 162);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(73, 20);
            this.paymentTypeLabel.TabIndex = 12;
            this.paymentTypeLabel.Text = "Оплата";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysLabel.Location = new System.Drawing.Point(14, 201);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(157, 20);
            this.daysLabel.TabIndex = 14;
            this.daysLabel.Text = "Количество дней";
            // 
            // decreaseBtn
            // 
            this.decreaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decreaseBtn.Location = new System.Drawing.Point(183, 198);
            this.decreaseBtn.Name = "decreaseBtn";
            this.decreaseBtn.Size = new System.Drawing.Size(33, 29);
            this.decreaseBtn.TabIndex = 15;
            this.decreaseBtn.Text = "-";
            this.decreaseBtn.UseVisualStyleBackColor = true;
            this.decreaseBtn.Click += new System.EventHandler(this.decreaseBtn_Click);
            // 
            // increaseBtn
            // 
            this.increaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increaseBtn.Location = new System.Drawing.Point(289, 198);
            this.increaseBtn.Name = "increaseBtn";
            this.increaseBtn.Size = new System.Drawing.Size(33, 29);
            this.increaseBtn.TabIndex = 16;
            this.increaseBtn.Text = "+";
            this.increaseBtn.UseVisualStyleBackColor = true;
            this.increaseBtn.Click += new System.EventHandler(this.increaseBtn_Click);
            // 
            // daysTextBox
            // 
            this.daysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysTextBox.Location = new System.Drawing.Point(222, 200);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.ReadOnly = true;
            this.daysTextBox.Size = new System.Drawing.Size(61, 24);
            this.daysTextBox.TabIndex = 17;
            // 
            // animalInfoLabel
            // 
            this.animalInfoLabel.AutoSize = true;
            this.animalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalInfoLabel.Location = new System.Drawing.Point(12, 241);
            this.animalInfoLabel.Name = "animalInfoLabel";
            this.animalInfoLabel.Size = new System.Drawing.Size(122, 20);
            this.animalInfoLabel.TabIndex = 18;
            this.animalInfoLabel.Text = "С животными";
            // 
            // animalInfoTextBox
            // 
            this.animalInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalInfoTextBox.Location = new System.Drawing.Point(140, 241);
            this.animalInfoTextBox.Name = "animalInfoTextBox";
            this.animalInfoTextBox.ReadOnly = true;
            this.animalInfoTextBox.Size = new System.Drawing.Size(61, 24);
            this.animalInfoTextBox.TabIndex = 19;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(141, 505);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 32);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // GuestCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 549);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.animalInfoTextBox);
            this.Controls.Add(this.animalInfoLabel);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.increaseBtn);
            this.Controls.Add(this.decreaseBtn);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.FioTextBox);
            this.Controls.Add(this.FioLabel);
            this.Controls.Add(this.guestInfoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guestInfoLabel;
        private System.Windows.Forms.TextBox FioTextBox;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Button decreaseBtn;
        private System.Windows.Forms.Button increaseBtn;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Label animalInfoLabel;
        private System.Windows.Forms.TextBox animalInfoTextBox;
        private System.Windows.Forms.Button saveBtn;
    }
}