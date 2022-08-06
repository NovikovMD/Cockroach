
namespace lab5
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
            this.components = new System.ComponentModel.Container();
            this.Field = new System.Windows.Forms.Panel();
            this.Group = new System.Windows.Forms.Panel();
            this.Algorithm = new System.Windows.Forms.ListBox();
            this.timerAlgorithm = new System.Windows.Forms.Timer(this.components);
            this.UpBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.StepBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.ChngButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DelBtn = new System.Windows.Forms.Button();
            this.Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.AllowDrop = true;
            this.Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field.Location = new System.Drawing.Point(12, 12);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(451, 420);
            this.Field.TabIndex = 0;
            this.Field.DragDrop += new System.Windows.Forms.DragEventHandler(this.Field_DragDrop);
            this.Field.DragEnter += new System.Windows.Forms.DragEventHandler(this.Field_DragEnter);
            // 
            // Group
            // 
            this.Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Group.Controls.Add(this.DelBtn);
            this.Group.Controls.Add(this.ChngButton);
            this.Group.Controls.Add(this.NewBtn);
            this.Group.Controls.Add(this.RunBtn);
            this.Group.Controls.Add(this.ClearBtn);
            this.Group.Controls.Add(this.StepBtn);
            this.Group.Controls.Add(this.LeftBtn);
            this.Group.Controls.Add(this.DownBtn);
            this.Group.Controls.Add(this.RightBtn);
            this.Group.Controls.Add(this.UpBtn);
            this.Group.Location = new System.Drawing.Point(469, 12);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(146, 420);
            this.Group.TabIndex = 1;
            // 
            // Algorithm
            // 
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.Location = new System.Drawing.Point(621, 12);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(167, 420);
            this.Algorithm.TabIndex = 2;
            // 
            // timerAlgorithm
            // 
            this.timerAlgorithm.Tick += new System.EventHandler(this.timerAlgorithm_Tick);
            // 
            // UpBtn
            // 
            this.UpBtn.Enabled = false;
            this.UpBtn.Location = new System.Drawing.Point(14, 13);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(119, 28);
            this.UpBtn.TabIndex = 0;
            this.UpBtn.Text = "Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Enabled = false;
            this.RightBtn.Location = new System.Drawing.Point(14, 47);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(119, 28);
            this.RightBtn.TabIndex = 1;
            this.RightBtn.Text = "Right";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Enabled = false;
            this.DownBtn.Location = new System.Drawing.Point(14, 81);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(119, 28);
            this.DownBtn.TabIndex = 2;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.Enabled = false;
            this.LeftBtn.Location = new System.Drawing.Point(14, 115);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(119, 28);
            this.LeftBtn.TabIndex = 3;
            this.LeftBtn.Text = "Left";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // StepBtn
            // 
            this.StepBtn.Enabled = false;
            this.StepBtn.Location = new System.Drawing.Point(14, 149);
            this.StepBtn.Name = "StepBtn";
            this.StepBtn.Size = new System.Drawing.Size(119, 28);
            this.StepBtn.TabIndex = 4;
            this.StepBtn.Text = "Step";
            this.StepBtn.UseVisualStyleBackColor = true;
            this.StepBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(14, 377);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(119, 28);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RunBtn
            // 
            this.RunBtn.Enabled = false;
            this.RunBtn.Location = new System.Drawing.Point(14, 343);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(119, 28);
            this.RunBtn.TabIndex = 6;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(14, 202);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(119, 28);
            this.NewBtn.TabIndex = 7;
            this.NewBtn.Text = "New Hero";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // ChngButton
            // 
            this.ChngButton.Location = new System.Drawing.Point(14, 236);
            this.ChngButton.Name = "ChngButton";
            this.ChngButton.Size = new System.Drawing.Size(119, 28);
            this.ChngButton.TabIndex = 8;
            this.ChngButton.Text = "Change image";
            this.ChngButton.UseVisualStyleBackColor = true;
            this.ChngButton.Click += new System.EventHandler(this.ChngButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DelBtn
            // 
            this.DelBtn.Enabled = false;
            this.DelBtn.Location = new System.Drawing.Point(14, 270);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(119, 28);
            this.DelBtn.TabIndex = 9;
            this.DelBtn.Text = "Delete hero";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Field);
            this.Name = "Form1";
            this.Text = "Жучок";
            this.Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.Panel Group;
        private System.Windows.Forms.ListBox Algorithm;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button StepBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Timer timerAlgorithm;
        private System.Windows.Forms.Button ChngButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DelBtn;
    }
}

