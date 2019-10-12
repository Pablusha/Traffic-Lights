namespace Traffic_Lights
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalYellow = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.ovalYellow,
            this.ovalGreen,
            this.ovalRed});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 450);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalRed
            // 
            this.ovalRed.FillColor = System.Drawing.Color.Transparent;
            this.ovalRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalRed.Location = new System.Drawing.Point(94, 44);
            this.ovalRed.Name = "ovalRed";
            this.ovalRed.Size = new System.Drawing.Size(105, 99);
            // 
            // ovalGreen
            // 
            this.ovalGreen.FillColor = System.Drawing.Color.Transparent;
            this.ovalGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalGreen.Location = new System.Drawing.Point(100, 264);
            this.ovalGreen.Name = "ovalGreen";
            this.ovalGreen.Size = new System.Drawing.Size(105, 99);
            // 
            // ovalYellow
            // 
            this.ovalYellow.FillColor = System.Drawing.Color.Transparent;
            this.ovalYellow.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalYellow.Location = new System.Drawing.Point(95, 155);
            this.ovalYellow.Name = "ovalYellow";
            this.ovalYellow.Size = new System.Drawing.Size(105, 99);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(70, 21);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(162, 368);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalRed;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalYellow;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalGreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

