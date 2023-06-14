namespace TCP_SERVER
{
    partial class Sever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sever));
            this.label1 = new System.Windows.Forms.Label();
            this.IP_TxtBox = new System.Windows.Forms.TextBox();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.Info_TxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Send_Btn = new System.Windows.Forms.Button();
            this.Msg_TxtBox = new System.Windows.Forms.TextBox();
            this.Client_IP_List = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP:";
            // 
            // IP_TxtBox
            // 
            this.IP_TxtBox.BackColor = System.Drawing.Color.White;
            this.IP_TxtBox.Location = new System.Drawing.Point(117, 32);
            this.IP_TxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IP_TxtBox.Multiline = true;
            this.IP_TxtBox.Name = "IP_TxtBox";
            this.IP_TxtBox.ReadOnly = true;
            this.IP_TxtBox.Size = new System.Drawing.Size(529, 33);
            this.IP_TxtBox.TabIndex = 1;
            // 
            // Start_Btn
            // 
            this.Start_Btn.Location = new System.Drawing.Point(536, 569);
            this.Start_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(112, 35);
            this.Start_Btn.TabIndex = 2;
            this.Start_Btn.Text = "Start";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // Info_TxtBox
            // 
            this.Info_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Info_TxtBox.Location = new System.Drawing.Point(117, 77);
            this.Info_TxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Info_TxtBox.Multiline = true;
            this.Info_TxtBox.Name = "Info_TxtBox";
            this.Info_TxtBox.ReadOnly = true;
            this.Info_TxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Info_TxtBox.Size = new System.Drawing.Size(529, 430);
            this.Info_TxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 523);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message:";
            // 
            // Send_Btn
            // 
            this.Send_Btn.Location = new System.Drawing.Point(417, 569);
            this.Send_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Send_Btn.Name = "Send_Btn";
            this.Send_Btn.Size = new System.Drawing.Size(112, 35);
            this.Send_Btn.TabIndex = 2;
            this.Send_Btn.Text = "Send";
            this.Send_Btn.UseVisualStyleBackColor = true;
            this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
            // 
            // Msg_TxtBox
            // 
            this.Msg_TxtBox.Location = new System.Drawing.Point(117, 518);
            this.Msg_TxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Msg_TxtBox.Multiline = true;
            this.Msg_TxtBox.Name = "Msg_TxtBox";
            this.Msg_TxtBox.Size = new System.Drawing.Size(529, 39);
            this.Msg_TxtBox.TabIndex = 5;
            // 
            // Client_IP_List
            // 
            this.Client_IP_List.FormattingEnabled = true;
            this.Client_IP_List.ItemHeight = 20;
            this.Client_IP_List.Location = new System.Drawing.Point(658, 77);
            this.Client_IP_List.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Client_IP_List.Name = "Client_IP_List";
            this.Client_IP_List.Size = new System.Drawing.Size(312, 524);
            this.Client_IP_List.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client\'s IP";
            // 
            // Sever
            // 
            this.AcceptButton = this.Send_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 628);
            this.Controls.Add(this.Client_IP_List);
            this.Controls.Add(this.Msg_TxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Info_TxtBox);
            this.Controls.Add(this.Send_Btn);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.IP_TxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Sever";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP SERVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP_TxtBox;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.TextBox Info_TxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Send_Btn;
        private System.Windows.Forms.TextBox Msg_TxtBox;
        private System.Windows.Forms.ListBox Client_IP_List;
        private System.Windows.Forms.Label label3;
    }
}

