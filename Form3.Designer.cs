namespace roomms
{
    partial class room
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rStatustxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rCapacitytxt = new System.Windows.Forms.TextBox();
            this.rCleaningtxt = new System.Windows.Forms.TextBox();
            this.mNumtxt = new System.Windows.Forms.TextBox();
            this.rNumtxt = new System.Windows.Forms.TextBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(50, 47);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 27;
            this.DataGridView1.Size = new System.Drawing.Size(646, 478);
            this.DataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "방 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "방 상태";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "수용 인원";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "청소 여부";
            // 
            // rStatustxt
            // 
            this.rStatustxt.Location = new System.Drawing.Point(868, 108);
            this.rStatustxt.Name = "rStatustxt";
            this.rStatustxt.Size = new System.Drawing.Size(112, 25);
            this.rStatustxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "기계 번호";
            // 
            // rCapacitytxt
            // 
            this.rCapacitytxt.Location = new System.Drawing.Point(868, 170);
            this.rCapacitytxt.Name = "rCapacitytxt";
            this.rCapacitytxt.Size = new System.Drawing.Size(112, 25);
            this.rCapacitytxt.TabIndex = 7;
            // 
            // rCleaningtxt
            // 
            this.rCleaningtxt.Location = new System.Drawing.Point(868, 234);
            this.rCleaningtxt.Name = "rCleaningtxt";
            this.rCleaningtxt.Size = new System.Drawing.Size(112, 25);
            this.rCleaningtxt.TabIndex = 8;
            // 
            // mNumtxt
            // 
            this.mNumtxt.Location = new System.Drawing.Point(868, 300);
            this.mNumtxt.Name = "mNumtxt";
            this.mNumtxt.Size = new System.Drawing.Size(112, 25);
            this.mNumtxt.TabIndex = 9;
            // 
            // rNumtxt
            // 
            this.rNumtxt.Location = new System.Drawing.Point(868, 44);
            this.rNumtxt.Name = "rNumtxt";
            this.rNumtxt.Size = new System.Drawing.Size(112, 25);
            this.rNumtxt.TabIndex = 10;
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(750, 453);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(80, 37);
            this.Editbtn.TabIndex = 11;
            this.Editbtn.Text = "수정";
            this.Editbtn.UseVisualStyleBackColor = true;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(900, 418);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(80, 37);
            this.Savebtn.TabIndex = 12;
            this.Savebtn.Text = "저장";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // Delbtn
            // 
            this.Delbtn.Location = new System.Drawing.Point(900, 488);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(80, 37);
            this.Delbtn.TabIndex = 13;
            this.Delbtn.Text = "삭제";
            this.Delbtn.UseVisualStyleBackColor = true;
            // 
            // room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 578);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.rNumtxt);
            this.Controls.Add(this.mNumtxt);
            this.Controls.Add(this.rCleaningtxt);
            this.Controls.Add(this.rCapacitytxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rStatustxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "room";
            this.Text = "room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.room_FormClosed);
            this.Load += new System.EventHandler(this.room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rStatustxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rCapacitytxt;
        private System.Windows.Forms.TextBox rCleaningtxt;
        private System.Windows.Forms.TextBox mNumtxt;
        private System.Windows.Forms.TextBox rNumtxt;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Delbtn;
    }
}