namespace UpdateAbeBook
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDivideBy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddPrecentage = new System.Windows.Forms.TextBox();
            this.txtInitialWeightAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInitialWeightPrecentage = new System.Windows.Forms.TextBox();
            this.txtCostinitialAdd = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInitialCostPrecentage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkIsbn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.chkIncludeImage = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblUpload = new System.Windows.Forms.Label();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "/";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDivideBy);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAddPrecentage);
            this.groupBox2.Controls.Add(this.txtInitialWeightAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtInitialWeightPrecentage);
            this.groupBox2.Controls.Add(this.txtCostinitialAdd);
            this.groupBox2.Controls.Add(this.lblSum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtInitialCostPrecentage);
            this.groupBox2.Location = new System.Drawing.Point(32, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(796, 109);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            this.groupBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Add With";
            // 
            // txtDivideBy
            // 
            this.txtDivideBy.Location = new System.Drawing.Point(366, 66);
            this.txtDivideBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDivideBy.Name = "txtDivideBy";
            this.txtDivideBy.Size = new System.Drawing.Size(61, 26);
            this.txtDivideBy.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Cost + Postage = ";
            // 
            // txtAddPrecentage
            // 
            this.txtAddPrecentage.Location = new System.Drawing.Point(255, 66);
            this.txtAddPrecentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddPrecentage.Name = "txtAddPrecentage";
            this.txtAddPrecentage.Size = new System.Drawing.Size(61, 26);
            this.txtAddPrecentage.TabIndex = 64;
            // 
            // txtInitialWeightAdd
            // 
            this.txtInitialWeightAdd.Location = new System.Drawing.Point(615, 18);
            this.txtInitialWeightAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitialWeightAdd.Name = "txtInitialWeightAdd";
            this.txtInitialWeightAdd.Size = new System.Drawing.Size(61, 26);
            this.txtInitialWeightAdd.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Pages * ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Weight = ";
            // 
            // txtInitialWeightPrecentage
            // 
            this.txtInitialWeightPrecentage.Location = new System.Drawing.Point(520, 20);
            this.txtInitialWeightPrecentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitialWeightPrecentage.Name = "txtInitialWeightPrecentage";
            this.txtInitialWeightPrecentage.Size = new System.Drawing.Size(61, 26);
            this.txtInitialWeightPrecentage.TabIndex = 59;
            // 
            // txtCostinitialAdd
            // 
            this.txtCostinitialAdd.Location = new System.Drawing.Point(208, 17);
            this.txtCostinitialAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostinitialAdd.Name = "txtCostinitialAdd";
            this.txtCostinitialAdd.Size = new System.Drawing.Size(61, 26);
            this.txtCostinitialAdd.TabIndex = 58;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(180, 23);
            this.lblSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(18, 20);
            this.lblSum.TabIndex = 57;
            this.lblSum.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Pages * ";
            // 
            // txtInitialCostPrecentage
            // 
            this.txtInitialCostPrecentage.Location = new System.Drawing.Point(100, 18);
            this.txtInitialCostPrecentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitialCostPrecentage.Name = "txtInitialCostPrecentage";
            this.txtInitialCostPrecentage.Size = new System.Drawing.Size(61, 26);
            this.txtInitialCostPrecentage.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Book Type : ";
            this.label1.Visible = false;
            // 
            // txtBookType
            // 
            this.txtBookType.Location = new System.Drawing.Point(153, 334);
            this.txtBookType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.Size = new System.Drawing.Size(148, 26);
            this.txtBookType.TabIndex = 82;
            this.txtBookType.Text = "LB";
            this.txtBookType.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Title : ";
            this.label2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 338);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 91;
            this.label11.Text = "Quantity : ";
            this.label11.Visible = false;
            // 
            // chkIsbn
            // 
            this.chkIsbn.AutoSize = true;
            this.chkIsbn.Location = new System.Drawing.Point(44, 185);
            this.chkIsbn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsbn.Name = "chkIsbn";
            this.chkIsbn.Size = new System.Drawing.Size(129, 24);
            this.chkIsbn.TabIndex = 83;
            this.chkIsbn.Text = "Include ISBN";
            this.chkIsbn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Description : ";
            this.label3.Visible = false;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Location = new System.Drawing.Point(694, 134);
            this.chkDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(87, 24);
            this.chkDefault.TabIndex = 93;
            this.chkDefault.Text = "Default";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // chkIncludeImage
            // 
            this.chkIncludeImage.AutoSize = true;
            this.chkIncludeImage.Location = new System.Drawing.Point(44, 137);
            this.chkIncludeImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIncludeImage.Name = "chkIncludeImage";
            this.chkIncludeImage.Size = new System.Drawing.Size(136, 24);
            this.chkIncludeImage.TabIndex = 92;
            this.chkIncludeImage.Text = "Include Image";
            this.chkIncludeImage.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(444, 334);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 26);
            this.txtQuantity.TabIndex = 90;
            this.txtQuantity.Text = "25";
            this.txtQuantity.Visible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(153, 377);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(673, 26);
            this.txtTitle.TabIndex = 86;
            this.txtTitle.Text = "Cast(title As Nvarchar(2000))+\' \'+ Cast(subtitle As Nvarchar(2000)) + \' \'+ Cast(d" +
    "ate as nvarchar(100)) + \'[Leather Bound]\'";
            this.txtTitle.Visible = false;
            // 
            // txtImageURL
            // 
            this.txtImageURL.Location = new System.Drawing.Point(192, 134);
            this.txtImageURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(400, 26);
            this.txtImageURL.TabIndex = 81;
            this.txtImageURL.TabStop = false;
            this.txtImageURL.Text = "https://www.gyanbooks.com/books/pics";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(596, 85);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersWidth = 62;
            this.dataGrid1.Size = new System.Drawing.Size(52, 17);
            this.dataGrid1.TabIndex = 8;
            this.dataGrid1.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(657, 40);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(112, 35);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(24, 46);
            this.lblUpload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(99, 20);
            this.lblUpload.TabIndex = 6;
            this.lblUpload.Text = "Browse File :";
            // 
            // txtUpload
            // 
            this.txtUpload.Enabled = false;
            this.txtUpload.Location = new System.Drawing.Point(147, 43);
            this.txtUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(358, 26);
            this.txtUpload.TabIndex = 5;
            this.txtUpload.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(528, 40);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(112, 35);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Browse";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGrid1);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.lblUpload);
            this.groupBox1.Controls.Add(this.txtUpload);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(801, 111);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import File";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(153, 420);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(674, 159);
            this.txtDescription.TabIndex = 88;
            this.txtDescription.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkIsbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.chkIncludeImage);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtImageURL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescription);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDivideBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddPrecentage;
        private System.Windows.Forms.TextBox txtInitialWeightAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInitialWeightPrecentage;
        private System.Windows.Forms.TextBox txtCostinitialAdd;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInitialCostPrecentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkIsbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.CheckBox chkIncludeImage;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtImageURL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.TextBox txtUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

