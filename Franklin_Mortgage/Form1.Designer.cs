namespace Franklin_Mortgage
{
    partial class Mortgage
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.rdo15 = new System.Windows.Forms.RadioButton();
            this.rdo30 = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.lblInterest = new System.Windows.Forms.Label();
            this.cmbOther = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.lblPrinError = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblOtherError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(38, 42);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(87, 20);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal: ";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(38, 79);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(122, 20);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "Term In Years";
            // 
            // rdo15
            // 
            this.rdo15.AutoSize = true;
            this.rdo15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo15.Location = new System.Drawing.Point(42, 117);
            this.rdo15.Name = "rdo15";
            this.rdo15.Size = new System.Drawing.Size(90, 24);
            this.rdo15.TabIndex = 2;
            this.rdo15.TabStop = true;
            this.rdo15.Text = "15 Year";
            this.rdo15.UseVisualStyleBackColor = true;
            // 
            // rdo30
            // 
            this.rdo30.AutoSize = true;
            this.rdo30.Checked = true;
            this.rdo30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo30.Location = new System.Drawing.Point(42, 151);
            this.rdo30.Name = "rdo30";
            this.rdo30.Size = new System.Drawing.Size(90, 24);
            this.rdo30.TabIndex = 3;
            this.rdo30.TabStop = true;
            this.rdo30.Text = "30 Year";
            this.rdo30.UseVisualStyleBackColor = true;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOther.Location = new System.Drawing.Point(42, 188);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(87, 24);
            this.rdoOther.TabIndex = 4;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other...";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdoOther_CheckedChanged);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(42, 241);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(72, 20);
            this.lblInterest.TabIndex = 5;
            this.lblInterest.Text = "Interest";
            // 
            // cmbOther
            // 
            this.cmbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOther.FormattingEnabled = true;
            this.cmbOther.Items.AddRange(new object[] {
            "0",
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cmbOther.Location = new System.Drawing.Point(130, 233);
            this.cmbOther.Name = "cmbOther";
            this.cmbOther.Size = new System.Drawing.Size(49, 28);
            this.cmbOther.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(55, 280);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(209, 52);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Payment";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(55, 351);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 54);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(177, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 55);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(136, 186);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(128, 26);
            this.txtOther.TabIndex = 5;
            this.txtOther.Visible = false;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.Location = new System.Drawing.Point(132, 36);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(132, 26);
            this.txtPrincipal.TabIndex = 1;
            // 
            // lblPrinError
            // 
            this.lblPrinError.AutoSize = true;
            this.lblPrinError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinError.Location = new System.Drawing.Point(85, 62);
            this.lblPrinError.Name = "lblPrinError";
            this.lblPrinError.Size = new System.Drawing.Size(234, 17);
            this.lblPrinError.TabIndex = 10;
            this.lblPrinError.Text = "Please enter valid Principal amount.";
            this.lblPrinError.Visible = false;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(2, 439);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(0, 20);
            this.lblPayment.TabIndex = 11;
            // 
            // lblOtherError
            // 
            this.lblOtherError.AutoSize = true;
            this.lblOtherError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherError.Location = new System.Drawing.Point(127, 213);
            this.lblOtherError.Name = "lblOtherError";
            this.lblOtherError.Size = new System.Drawing.Size(165, 17);
            this.lblOtherError.TabIndex = 12;
            this.lblOtherError.Text = "Please enter a valid term";
            this.lblOtherError.Visible = false;
            // 
            // Mortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(367, 495);
            this.Controls.Add(this.lblOtherError);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblPrinError);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbOther);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.rdo30);
            this.Controls.Add(this.rdo15);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblPrincipal);
            this.MaximizeBox = false;
            this.Name = "Mortgage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Will Franklin: Mortgage ...";
            this.Load += new System.EventHandler(this.Mortgage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.RadioButton rdo15;
        private System.Windows.Forms.RadioButton rdo30;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.ComboBox cmbOther;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label lblPrinError;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblOtherError;
    }
}

