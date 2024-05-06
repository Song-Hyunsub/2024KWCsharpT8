namespace oss_rythm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.slot1 = new System.Windows.Forms.Panel();
            this.slot2 = new System.Windows.Forms.Panel();
            this.slot3 = new System.Windows.Forms.Panel();
            this.slot4 = new System.Windows.Forms.Panel();
            this.bar1 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.bar3 = new System.Windows.Forms.Panel();
            this.bar4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPerfectCount = new System.Windows.Forms.Label();
            this.lblGoodCount = new System.Windows.Forms.Label();
            this.lblBadCount = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stop.png");
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStop.BackgroundImage = global::oss_rythm.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(1047, 33);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 36);
            this.btnStop.TabIndex = 0;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // slot1
            // 
            this.slot1.BackColor = System.Drawing.SystemColors.Info;
            this.slot1.Location = new System.Drawing.Point(30, 545);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(100, 30);
            this.slot1.TabIndex = 2;
            // 
            // slot2
            // 
            this.slot2.BackColor = System.Drawing.SystemColors.Info;
            this.slot2.Location = new System.Drawing.Point(140, 545);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(100, 30);
            this.slot2.TabIndex = 3;
            // 
            // slot3
            // 
            this.slot3.BackColor = System.Drawing.SystemColors.Info;
            this.slot3.Location = new System.Drawing.Point(250, 545);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(100, 30);
            this.slot3.TabIndex = 4;
            // 
            // slot4
            // 
            this.slot4.BackColor = System.Drawing.SystemColors.Info;
            this.slot4.Location = new System.Drawing.Point(360, 545);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(100, 30);
            this.slot4.TabIndex = 5;
            // 
            // bar1
            // 
            this.bar1.Location = new System.Drawing.Point(30, 45);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(100, 500);
            this.bar1.TabIndex = 6;
            // 
            // bar2
            // 
            this.bar2.Location = new System.Drawing.Point(140, 45);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(100, 500);
            this.bar2.TabIndex = 7;
            // 
            // bar3
            // 
            this.bar3.Location = new System.Drawing.Point(250, 45);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(100, 500);
            this.bar3.TabIndex = 8;
            // 
            // bar4
            // 
            this.bar4.Location = new System.Drawing.Point(360, 45);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(100, 500);
            this.bar4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Perfect :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Good :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Accuracy :";
            // 
            // lblPerfectCount
            // 
            this.lblPerfectCount.AutoSize = true;
            this.lblPerfectCount.Location = new System.Drawing.Point(600, 50);
            this.lblPerfectCount.Name = "lblPerfectCount";
            this.lblPerfectCount.Size = new System.Drawing.Size(18, 18);
            this.lblPerfectCount.TabIndex = 14;
            this.lblPerfectCount.Text = "0";
            // 
            // lblGoodCount
            // 
            this.lblGoodCount.AutoSize = true;
            this.lblGoodCount.Location = new System.Drawing.Point(600, 100);
            this.lblGoodCount.Name = "lblGoodCount";
            this.lblGoodCount.Size = new System.Drawing.Size(18, 18);
            this.lblGoodCount.TabIndex = 15;
            this.lblGoodCount.Text = "0";
            // 
            // lblBadCount
            // 
            this.lblBadCount.AutoSize = true;
            this.lblBadCount.Location = new System.Drawing.Point(600, 150);
            this.lblBadCount.Name = "lblBadCount";
            this.lblBadCount.Size = new System.Drawing.Size(18, 18);
            this.lblBadCount.TabIndex = 16;
            this.lblBadCount.Text = "0";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(600, 200);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(18, 18);
            this.lblAccuracy.TabIndex = 17;
            this.lblAccuracy.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.lblBadCount);
            this.Controls.Add(this.lblGoodCount);
            this.Controls.Add(this.lblPerfectCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar4);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.slot4);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.btnStop);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Panel slot1;
        private System.Windows.Forms.Panel slot2;
        private System.Windows.Forms.Panel slot3;
        private System.Windows.Forms.Panel slot4;
        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.Panel bar3;
        private System.Windows.Forms.Panel bar4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPerfectCount;
        private System.Windows.Forms.Label lblGoodCount;
        private System.Windows.Forms.Label lblBadCount;
        private System.Windows.Forms.Label lblAccuracy;
    }
}
