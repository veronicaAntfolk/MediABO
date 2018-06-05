namespace MediABO
{
    partial class FrmRegNewDonation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegNewDonation));
            this.btnSaveDonation = new System.Windows.Forms.Button();
            this.btnCancelDonation = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.txtBirthDonation = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtDonation1 = new System.Windows.Forms.TextBox();
            this.txtDonation2 = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblDonarInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveDonation
            // 
            this.btnSaveDonation.BackColor = System.Drawing.Color.White;
            this.btnSaveDonation.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSaveDonation.FlatAppearance.BorderSize = 3;
            this.btnSaveDonation.ForeColor = System.Drawing.Color.Black;
            this.btnSaveDonation.Location = new System.Drawing.Point(571, 579);
            this.btnSaveDonation.Name = "btnSaveDonation";
            this.btnSaveDonation.Size = new System.Drawing.Size(200, 44);
            this.btnSaveDonation.TabIndex = 23;
            this.btnSaveDonation.Text = "Save";
            this.btnSaveDonation.UseVisualStyleBackColor = false;
            // 
            // btnCancelDonation
            // 
            this.btnCancelDonation.BackColor = System.Drawing.Color.White;
            this.btnCancelDonation.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancelDonation.FlatAppearance.BorderSize = 3;
            this.btnCancelDonation.ForeColor = System.Drawing.Color.Black;
            this.btnCancelDonation.Location = new System.Drawing.Point(787, 579);
            this.btnCancelDonation.Name = "btnCancelDonation";
            this.btnCancelDonation.Size = new System.Drawing.Size(200, 44);
            this.btnCancelDonation.TabIndex = 22;
            this.btnCancelDonation.Text = "Cancel";
            this.btnCancelDonation.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Namn";
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Location = new System.Drawing.Point(48, 68);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(77, 17);
            this.lblTimeStamp.TabIndex = 24;
            this.lblTimeStamp.Text = "Timestamp";
            // 
            // txtBirthDonation
            // 
            this.txtBirthDonation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDonation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBirthDonation.Location = new System.Drawing.Point(97, 167);
            this.txtBirthDonation.Multiline = true;
            this.txtBirthDonation.Name = "txtBirthDonation";
            this.txtBirthDonation.Size = new System.Drawing.Size(204, 34);
            this.txtBirthDonation.TabIndex = 26;
            this.txtBirthDonation.Text = "Fill in birthdate";
            this.txtBirthDonation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(345, 167);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(84, 34);
            this.btnEnter.TabIndex = 27;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // txtDonation1
            // 
            this.txtDonation1.Location = new System.Drawing.Point(97, 267);
            this.txtDonation1.Multiline = true;
            this.txtDonation1.Name = "txtDonation1";
            this.txtDonation1.Size = new System.Drawing.Size(332, 243);
            this.txtDonation1.TabIndex = 28;
            this.txtDonation1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDonation2
            // 
            this.txtDonation2.Location = new System.Drawing.Point(571, 171);
            this.txtDonation2.Multiline = true;
            this.txtDonation2.Name = "txtDonation2";
            this.txtDonation2.Size = new System.Drawing.Size(347, 327);
            this.txtDonation2.TabIndex = 29;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.White;
            this.lblNotes.Location = new System.Drawing.Point(567, 147);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(57, 21);
            this.lblNotes.TabIndex = 30;
            this.lblNotes.Text = "Notes";
            // 
            // lblDonarInfo
            // 
            this.lblDonarInfo.AutoSize = true;
            this.lblDonarInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDonarInfo.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonarInfo.ForeColor = System.Drawing.Color.White;
            this.lblDonarInfo.Location = new System.Drawing.Point(95, 239);
            this.lblDonarInfo.Name = "lblDonarInfo";
            this.lblDonarInfo.Size = new System.Drawing.Size(170, 21);
            this.lblDonarInfo.TabIndex = 31;
            this.lblDonarInfo.Text = "Donar\'s Information";
            // 
            // FrmRegNewDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 657);
            this.Controls.Add(this.lblDonarInfo);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtDonation2);
            this.Controls.Add(this.txtDonation1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtBirthDonation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTimeStamp);
            this.Controls.Add(this.btnSaveDonation);
            this.Controls.Add(this.btnCancelDonation);
            this.Name = "FrmRegNewDonation";
            this.Text = "FrmRegNewDonation";
            this.Load += new System.EventHandler(this.FrmRegNewDonation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDonation;
        private System.Windows.Forms.Button btnCancelDonation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.TextBox txtBirthDonation;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtDonation1;
        private System.Windows.Forms.TextBox txtDonation2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblDonarInfo;
    }
}