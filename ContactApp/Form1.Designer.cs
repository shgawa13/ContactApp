namespace ContactApp
{
  partial class ContactForm
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
      this.components = new System.ComponentModel.Container();
      this.DgvContacts = new System.Windows.Forms.DataGridView();
      this.cmContacts = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.btnAddContact = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DgvContacts)).BeginInit();
      this.cmContacts.SuspendLayout();
      this.SuspendLayout();
      // 
      // DgvContacts
      // 
      this.DgvContacts.AllowUserToAddRows = false;
      this.DgvContacts.AllowUserToDeleteRows = false;
      this.DgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DgvContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.DgvContacts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
      this.DgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DgvContacts.ContextMenuStrip = this.cmContacts;
      this.DgvContacts.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.DgvContacts.Location = new System.Drawing.Point(0, 115);
      this.DgvContacts.Name = "DgvContacts";
      this.DgvContacts.ReadOnly = true;
      this.DgvContacts.Size = new System.Drawing.Size(800, 335);
      this.DgvContacts.TabIndex = 0;
      // 
      // cmContacts
      // 
      this.cmContacts.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.cmContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.tsmDelete});
      this.cmContacts.Name = "cmContacts";
      this.cmContacts.Size = new System.Drawing.Size(108, 48);
      this.cmContacts.Text = "Operation";
      // 
      // tsmEdit
      // 
      this.tsmEdit.Name = "tsmEdit";
      this.tsmEdit.Size = new System.Drawing.Size(107, 22);
      this.tsmEdit.Text = "Edit ";
      this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
      // 
      // tsmDelete
      // 
      this.tsmDelete.Name = "tsmDelete";
      this.tsmDelete.Size = new System.Drawing.Size(107, 22);
      this.tsmDelete.Text = "Delete";
      this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
      // 
      // btnAddContact
      // 
      this.btnAddContact.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddContact.Location = new System.Drawing.Point(675, 29);
      this.btnAddContact.Name = "btnAddContact";
      this.btnAddContact.Size = new System.Drawing.Size(109, 58);
      this.btnAddContact.TabIndex = 1;
      this.btnAddContact.Text = "Add New Contact";
      this.btnAddContact.UseVisualStyleBackColor = true;
      this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
      // 
      // ContactForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnAddContact);
      this.Controls.Add(this.DgvContacts);
      this.Name = "ContactForm";
      this.Text = "Contacts ";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DgvContacts)).EndInit();
      this.cmContacts.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView DgvContacts;
    private System.Windows.Forms.Button btnAddContact;
    private System.Windows.Forms.ContextMenuStrip cmContacts;
    private System.Windows.Forms.ToolStripMenuItem tsmEdit;
    private System.Windows.Forms.ToolStripMenuItem tsmDelete;
  }
}

