namespace ShipmentLocator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtWaybill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrack = new System.Windows.Forms.Button();
            this.txtLocationDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWaybill
            // 
            this.txtWaybill.Location = new System.Drawing.Point(92, 25);
            this.txtWaybill.Name = "txtWaybill";
            this.txtWaybill.Size = new System.Drawing.Size(175, 20);
            this.txtWaybill.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wayill number:";
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(192, 51);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(75, 23);
            this.btnTrack.TabIndex = 2;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.BtnTrack_Click);
            // 
            // txtLocationDetails
            // 
            this.txtLocationDetails.Location = new System.Drawing.Point(92, 89);
            this.txtLocationDetails.Multiline = true;
            this.txtLocationDetails.Name = "txtLocationDetails";
            this.txtLocationDetails.Size = new System.Drawing.Size(175, 92);
            this.txtLocationDetails.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 193);
            this.Controls.Add(this.txtLocationDetails);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWaybill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWaybill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.TextBox txtLocationDetails;
    }
}

