namespace ComputerVision.ParameterForms
{
    partial class CannyParametersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.trackBarThresholdLink = new System.Windows.Forms.TrackBar();
            this.btnApplyCanny = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelThreshValue = new System.Windows.Forms.Label();
            this.labelThreshLinkValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdLink)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Threshold Link";
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.Location = new System.Drawing.Point(202, 27);
            this.trackBarThreshold.Maximum = 255;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(192, 45);
            this.trackBarThreshold.TabIndex = 2;
            this.trackBarThreshold.Value = 20;
            this.trackBarThreshold.Scroll += new System.EventHandler(this.trackBarThreshold_Scroll);
            // 
            // trackBarThresholdLink
            // 
            this.trackBarThresholdLink.Location = new System.Drawing.Point(202, 68);
            this.trackBarThresholdLink.Maximum = 255;
            this.trackBarThresholdLink.Name = "trackBarThresholdLink";
            this.trackBarThresholdLink.Size = new System.Drawing.Size(192, 45);
            this.trackBarThresholdLink.TabIndex = 3;
            this.trackBarThresholdLink.Value = 50;
            // 
            // btnApplyCanny
            // 
            this.btnApplyCanny.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.btnApplyCanny.Location = new System.Drawing.Point(213, 135);
            this.btnApplyCanny.Name = "btnApplyCanny";
            this.btnApplyCanny.Size = new System.Drawing.Size(91, 32);
            this.btnApplyCanny.TabIndex = 4;
            this.btnApplyCanny.Text = "Apply";
            this.btnApplyCanny.UseVisualStyleBackColor = true;
            this.btnApplyCanny.Click += new System.EventHandler(this.btnApplyCanny_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.btnCancel.Location = new System.Drawing.Point(324, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelThreshValue
            // 
            this.labelThreshValue.AutoSize = true;
            this.labelThreshValue.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.labelThreshValue.Location = new System.Drawing.Point(399, 26);
            this.labelThreshValue.Name = "labelThreshValue";
            this.labelThreshValue.Size = new System.Drawing.Size(36, 26);
            this.labelThreshValue.TabIndex = 6;
            this.labelThreshValue.Text = "20";
            // 
            // labelThreshLinkValue
            // 
            this.labelThreshLinkValue.AutoSize = true;
            this.labelThreshLinkValue.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.labelThreshLinkValue.Location = new System.Drawing.Point(399, 68);
            this.labelThreshLinkValue.Name = "labelThreshLinkValue";
            this.labelThreshLinkValue.Size = new System.Drawing.Size(36, 26);
            this.labelThreshLinkValue.TabIndex = 7;
            this.labelThreshLinkValue.Text = "50";
            // 
            // CannyParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 179);
            this.Controls.Add(this.labelThreshLinkValue);
            this.Controls.Add(this.labelThreshValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApplyCanny);
            this.Controls.Add(this.trackBarThresholdLink);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CannyParametersForm";
            this.Text = "Canny Edge Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.TrackBar trackBarThresholdLink;
        private System.Windows.Forms.Button btnApplyCanny;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelThreshValue;
        private System.Windows.Forms.Label labelThreshLinkValue;
    }
}