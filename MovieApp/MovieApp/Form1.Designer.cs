
namespace MovieApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPrevius = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BU HAFTA VIZYONDAKI FILMLER";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(246, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 29);
            this.lblDate.TabIndex = 1;
            // 
            // btnPrevius
            // 
            this.btnPrevius.Enabled = false;
            this.btnPrevius.Location = new System.Drawing.Point(12, 35);
            this.btnPrevius.Name = "btnPrevius";
            this.btnPrevius.Size = new System.Drawing.Size(166, 32);
            this.btnPrevius.TabIndex = 2;
            this.btnPrevius.Text = "<=PREVIUS";
            this.btnPrevius.UseVisualStyleBackColor = true;
            this.btnPrevius.Click += new System.EventHandler(this.btnPrevius_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1002, 37);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(168, 36);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "NEXT=>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevius);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPrevius;
        private System.Windows.Forms.Button btnNext;
    }
}

