using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsBusinessLayer;
using System.Windows.Forms;

namespace ContactApp
{
  public partial class ContactForm : Form
  {
    public ContactForm()
    {
      InitializeComponent();
    }

    private void _FillDataGridContact()
    {
      DgvContacts.DataSource = clsContact.GetAllContacts();
    }

    private void _RefreshContactsList()
    {
      _FillDataGridContact();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      _RefreshContactsList();
    }

    private void btnAddContact_Click(object sender, EventArgs e)
    {
      frmAddEditContacts AddForm = new frmAddEditContacts(-1);
      AddForm.ShowDialog();
      _RefreshContactsList();
    }

    private void tsmEdit_Click(object sender, EventArgs e)
    {
      frmAddEditContacts edit = new frmAddEditContacts((int)DgvContacts.CurrentRow.Cells[0].Value);
      edit.ShowDialog();
      _RefreshContactsList();
    }

    private void tsmDelete_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show("Are you sure to delete this contact?", "Confirm",
        MessageBoxButtons.OKCancel);
       if( result == DialogResult.OK)
       {
         clsContact.DeleteContact((int)DgvContacts.CurrentRow.Cells[0].Value);
         MessageBox.Show("Contact has been Deleted");
        _RefreshContactsList();

       }
      

    }

    
  }
}
