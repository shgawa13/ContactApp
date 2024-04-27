namespace ContactApp
{
  partial class frmAddEditContacts
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
      this.pAddContact = new System.Windows.Forms.Panel();
      this.lRemoveImg = new System.Windows.Forms.LinkLabel();
      this.btnSetImage = new System.Windows.Forms.Button();
      this.pbImage = new System.Windows.Forms.PictureBox();
      this.cmbCountry = new System.Windows.Forms.ComboBox();
      this.dtDate = new System.Windows.Forms.DateTimePicker();
      this.tbAddress = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.tbPhone = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbEmail = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbLastName = new System.Windows.Forms.TextBox();
      this.lbLastName = new System.Windows.Forms.Label();
      this.lbContctID = new System.Windows.Forms.Label();
      this.tbFirstName = new System.Windows.Forms.TextBox();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.lbContact = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.pAddContact.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
      this.SuspendLayout();
      // 
      // pAddContact
      // 
      this.pAddContact.AutoScroll = true;
      this.pAddContact.Controls.Add(this.lRemoveImg);
      this.pAddContact.Controls.Add(this.btnSetImage);
      this.pAddContact.Controls.Add(this.pbImage);
      this.pAddContact.Controls.Add(this.cmbCountry);
      this.pAddContact.Controls.Add(this.dtDate);
      this.pAddContact.Controls.Add(this.tbAddress);
      this.pAddContact.Controls.Add(this.label5);
      this.pAddContact.Controls.Add(this.label6);
      this.pAddContact.Controls.Add(this.label7);
      this.pAddContact.Controls.Add(this.tbPhone);
      this.pAddContact.Controls.Add(this.label3);
      this.pAddContact.Controls.Add(this.tbEmail);
      this.pAddContact.Controls.Add(this.label2);
      this.pAddContact.Controls.Add(this.tbLastName);
      this.pAddContact.Controls.Add(this.lbLastName);
      this.pAddContact.Controls.Add(this.lbContctID);
      this.pAddContact.Controls.Add(this.tbFirstName);
      this.pAddContact.Controls.Add(this.lbFirstName);
      this.pAddContact.Location = new System.Drawing.Point(12, 62);
      this.pAddContact.Name = "pAddContact";
      this.pAddContact.Size = new System.Drawing.Size(719, 298);
      this.pAddContact.TabIndex = 0;
      this.pAddContact.Paint += new System.Windows.Forms.PaintEventHandler(this.pAddContact_Paint);
      // 
      // lRemoveImg
      // 
      this.lRemoveImg.AutoSize = true;
      this.lRemoveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lRemoveImg.Location = new System.Drawing.Point(396, 30);
      this.lRemoveImg.Name = "lRemoveImg";
      this.lRemoveImg.Size = new System.Drawing.Size(100, 16);
      this.lRemoveImg.TabIndex = 15;
      this.lRemoveImg.TabStop = true;
      this.lRemoveImg.Text = "Remove Image";
      // 
      // btnSetImage
      // 
      this.btnSetImage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSetImage.Location = new System.Drawing.Point(399, 223);
      this.btnSetImage.Name = "btnSetImage";
      this.btnSetImage.Size = new System.Drawing.Size(244, 35);
      this.btnSetImage.TabIndex = 8;
      this.btnSetImage.Text = "Chose Image";
      this.btnSetImage.UseVisualStyleBackColor = true;
      // 
      // pbImage
      // 
      this.pbImage.Location = new System.Drawing.Point(392, 58);
      this.pbImage.Name = "pbImage";
      this.pbImage.Size = new System.Drawing.Size(258, 144);
      this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbImage.TabIndex = 14;
      this.pbImage.TabStop = false;
      // 
      // cmbCountry
      // 
      this.cmbCountry.FormattingEnabled = true;
      this.cmbCountry.Location = new System.Drawing.Point(121, 264);
      this.cmbCountry.Name = "cmbCountry";
      this.cmbCountry.Size = new System.Drawing.Size(199, 21);
      this.cmbCountry.TabIndex = 6;
      // 
      // dtDate
      // 
      this.dtDate.Location = new System.Drawing.Point(126, 223);
      this.dtDate.Name = "dtDate";
      this.dtDate.Size = new System.Drawing.Size(194, 20);
      this.dtDate.TabIndex = 5;
      // 
      // tbAddress
      // 
      this.tbAddress.Location = new System.Drawing.Point(113, 306);
      this.tbAddress.Multiline = true;
      this.tbAddress.Name = "tbAddress";
      this.tbAddress.Size = new System.Drawing.Size(207, 49);
      this.tbAddress.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(15, 321);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(68, 18);
      this.label5.TabIndex = 13;
      this.label5.Text = "Address";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(15, 262);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 18);
      this.label6.TabIndex = 11;
      this.label6.Text = "Country";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(15, 223);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(98, 18);
      this.label7.TabIndex = 9;
      this.label7.Text = "DateOfBirth";
      // 
      // tbPhone
      // 
      this.tbPhone.Location = new System.Drawing.Point(126, 182);
      this.tbPhone.Name = "tbPhone";
      this.tbPhone.Size = new System.Drawing.Size(194, 20);
      this.tbPhone.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(15, 183);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 18);
      this.label3.TabIndex = 7;
      this.label3.Text = "Phone";
      // 
      // tbEmail
      // 
      this.tbEmail.Location = new System.Drawing.Point(126, 142);
      this.tbEmail.Name = "tbEmail";
      this.tbEmail.Size = new System.Drawing.Size(194, 20);
      this.tbEmail.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(15, 143);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 18);
      this.label2.TabIndex = 5;
      this.label2.Text = "Email";
      // 
      // tbLastName
      // 
      this.tbLastName.Location = new System.Drawing.Point(126, 97);
      this.tbLastName.Name = "tbLastName";
      this.tbLastName.Size = new System.Drawing.Size(194, 20);
      this.tbLastName.TabIndex = 2;
      // 
      // lbLastName
      // 
      this.lbLastName.AutoSize = true;
      this.lbLastName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbLastName.Location = new System.Drawing.Point(15, 98);
      this.lbLastName.Name = "lbLastName";
      this.lbLastName.Size = new System.Drawing.Size(83, 18);
      this.lbLastName.TabIndex = 3;
      this.lbLastName.Text = "LastName";
      // 
      // lbContctID
      // 
      this.lbContctID.AutoSize = true;
      this.lbContctID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbContctID.Location = new System.Drawing.Point(15, 18);
      this.lbContctID.Name = "lbContctID";
      this.lbContctID.Size = new System.Drawing.Size(114, 18);
      this.lbContctID.TabIndex = 2;
      this.lbContctID.Text = "ContactID ???";
      // 
      // tbFirstName
      // 
      this.tbFirstName.Location = new System.Drawing.Point(126, 58);
      this.tbFirstName.Name = "tbFirstName";
      this.tbFirstName.Size = new System.Drawing.Size(194, 20);
      this.tbFirstName.TabIndex = 1;
      // 
      // lbFirstName
      // 
      this.lbFirstName.AutoSize = true;
      this.lbFirstName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFirstName.Location = new System.Drawing.Point(15, 59);
      this.lbFirstName.Name = "lbFirstName";
      this.lbFirstName.Size = new System.Drawing.Size(86, 18);
      this.lbFirstName.TabIndex = 0;
      this.lbFirstName.Text = "FirstName";
      // 
      // lbContact
      // 
      this.lbContact.AutoSize = true;
      this.lbContact.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbContact.Location = new System.Drawing.Point(312, 23);
      this.lbContact.Name = "lbContact";
      this.lbContact.Size = new System.Drawing.Size(125, 18);
      this.lbContact.TabIndex = 1;
      this.lbContact.Text = "Contact ID = ";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Location = new System.Drawing.Point(204, 390);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(167, 48);
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(393, 390);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(167, 48);
      this.btnSave.TabIndex = 9;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // frmAddEditContacts
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.lbContact);
      this.Controls.Add(this.pAddContact);
      this.Name = "frmAddEditContacts";
      this.Text = "AddContacts";
      this.Load += new System.EventHandler(this.FAddContacts_Load);
      this.pAddContact.ResumeLayout(false);
      this.pAddContact.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pAddContact;
    private System.Windows.Forms.Label lbContact;
    private System.Windows.Forms.TextBox tbPhone;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbEmail;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbLastName;
    private System.Windows.Forms.Label lbLastName;
    private System.Windows.Forms.Label lbContctID;
    private System.Windows.Forms.TextBox tbFirstName;
    private System.Windows.Forms.Label lbFirstName;
    private System.Windows.Forms.TextBox tbAddress;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DateTimePicker dtDate;
    private System.Windows.Forms.ComboBox cmbCountry;
    private System.Windows.Forms.PictureBox pbImage;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnSetImage;
    private System.Windows.Forms.LinkLabel lRemoveImg;
  }
}