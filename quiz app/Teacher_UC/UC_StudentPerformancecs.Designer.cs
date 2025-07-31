namespace quiz_app.Teacher_UC
{
    partial class UC_StudentPerformancecs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            trackBar1 = new TrackBar();
            guna2vTrackBar1 = new Guna.UI2.WinForms.Guna2VTrackBar();
            guna2hScrollBar1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(309, 34);
            label1.TabIndex = 0;
            label1.Text = "Student Performance";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(53, 91);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(283, 45);
            trackBar1.TabIndex = 1;
            // 
            // guna2vTrackBar1
            // 
            guna2vTrackBar1.Location = new Point(703, 36);
            guna2vTrackBar1.Name = "guna2vTrackBar1";
            guna2vTrackBar1.Size = new Size(23, 280);
            guna2vTrackBar1.TabIndex = 4;
            guna2vTrackBar1.ThumbColor = Color.FromArgb(160, 113, 255);
            // 
            // guna2hScrollBar1
            // 
            guna2hScrollBar1.InUpdate = false;
            guna2hScrollBar1.LargeChange = 10;
            guna2hScrollBar1.Location = new Point(321, 52);
            guna2hScrollBar1.Name = "guna2hScrollBar1";
            guna2hScrollBar1.ScrollbarSize = 18;
            guna2hScrollBar1.Size = new Size(300, 18);
            guna2hScrollBar1.TabIndex = 5;
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.FillColor = Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = Color.White;
            guna2CircleProgressBar1.Location = new Point(392, 130);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = Color.Green;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(130, 130);
            guna2CircleProgressBar1.TabIndex = 6;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // UC_StudentPerformancecs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CircleProgressBar1);
            Controls.Add(guna2hScrollBar1);
            Controls.Add(guna2vTrackBar1);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Name = "UC_StudentPerformancecs";
            Size = new Size(918, 689);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2VTrackBar guna2vTrackBar1;
        private TrackBar trackBar1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2HScrollBar guna2hScrollBar1;
    }
}
