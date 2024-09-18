namespace AutoService
{
    partial class Form1
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
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.lbMechanic = new System.Windows.Forms.Label();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.btnAddMechanic = new System.Windows.Forms.Button();
            this.btnRemoveMechanic = new System.Windows.Forms.Button();
            this.btnEditMechanic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(43, 71);
            this.cmbMechanic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(232, 50);
            this.cmbMechanic.TabIndex = 0;
            this.cmbMechanic.SelectedValueChanged += new System.EventHandler(this.cmbMechanic_SelectedValueChanged);
            // 
            // lbMechanic
            // 
            this.lbMechanic.AutoSize = true;
            this.lbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMechanic.Location = new System.Drawing.Point(43, 16);
            this.lbMechanic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMechanic.Name = "lbMechanic";
            this.lbMechanic.Size = new System.Drawing.Size(107, 31);
            this.lbMechanic.TabIndex = 1;
            this.lbMechanic.Text = "Мастер";
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBoxAvatar.Location = new System.Drawing.Point(341, 71);
            this.picBoxAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(160, 148);
            this.picBoxAvatar.TabIndex = 2;
            this.picBoxAvatar.TabStop = false;
            this.picBoxAvatar.Click += new System.EventHandler(this.picBoxAvatar_Click);
            // 
            // btnAddMechanic
            // 
            this.btnAddMechanic.Location = new System.Drawing.Point(43, 129);
            this.btnAddMechanic.Name = "btnAddMechanic";
            this.btnAddMechanic.Size = new System.Drawing.Size(125, 23);
            this.btnAddMechanic.TabIndex = 3;
            this.btnAddMechanic.Text = "Добавить";
            this.btnAddMechanic.UseVisualStyleBackColor = true;
            this.btnAddMechanic.Click += new System.EventHandler(this.btnAddMechanic_Click);
            // 
            // btnRemoveMechanic
            // 
            this.btnRemoveMechanic.Location = new System.Drawing.Point(43, 159);
            this.btnRemoveMechanic.Name = "btnRemoveMechanic";
            this.btnRemoveMechanic.Size = new System.Drawing.Size(125, 23);
            this.btnRemoveMechanic.TabIndex = 4;
            this.btnRemoveMechanic.Text = "Удалить";
            this.btnRemoveMechanic.UseVisualStyleBackColor = true;
            this.btnRemoveMechanic.Click += new System.EventHandler(this.btnRemoveMechanic_Click);
            // 
            // btnEditMechanic
            // 
            this.btnEditMechanic.Location = new System.Drawing.Point(43, 189);
            this.btnEditMechanic.Name = "btnEditMechanic";
            this.btnEditMechanic.Size = new System.Drawing.Size(125, 23);
            this.btnEditMechanic.TabIndex = 5;
            this.btnEditMechanic.Text = "Редактировать";
            this.btnEditMechanic.UseVisualStyleBackColor = true;
            this.btnEditMechanic.Click += new System.EventHandler(this.btnEditMechanic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnEditMechanic);
            this.Controls.Add(this.btnRemoveMechanic);
            this.Controls.Add(this.btnAddMechanic);
            this.Controls.Add(this.picBoxAvatar);
            this.Controls.Add(this.lbMechanic);
            this.Controls.Add(this.cmbMechanic);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Label lbMechanic;
		private System.Windows.Forms.PictureBox picBoxAvatar;
        private System.Windows.Forms.Button btnAddMechanic;
        private System.Windows.Forms.Button btnRemoveMechanic;
        private System.Windows.Forms.Button btnEditMechanic;
    }
}

