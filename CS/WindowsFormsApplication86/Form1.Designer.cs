namespace WindowsFormsApplication86 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tokenEdit1 = new MyTokenEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tokenEdit1
            // 
            this.tokenEdit1.Location = new System.Drawing.Point(12, 24);
            this.tokenEdit1.Name = "tokenEdit1";
            this.tokenEdit1.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEdit1.Properties.Tokens.AddRange(new DevExpress.XtraEditors.TokenEditToken[] {
            new DevExpress.XtraEditors.TokenEditToken("One", "One"),
            new DevExpress.XtraEditors.TokenEditToken("Two", "Two"),
            new DevExpress.XtraEditors.TokenEditToken("Three", "Three")});
            this.tokenEdit1.Size = new System.Drawing.Size(283, 20);
            this.tokenEdit1.TabIndex = 0;
            this.tokenEdit1.UseOptimizedRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 231);
            this.Controls.Add(this.tokenEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyTokenEdit tokenEdit1;
    }
}

