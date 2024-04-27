using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
  public partial class frmAddEditContacts : Form
  {
    public enum enMode { AddNew =0, Update=1}
    private enMode _Mode;
    int _ContactID;
    clsContact _Contact;
    public frmAddEditContacts(int ContactID)
    {
      InitializeComponent();
      _ContactID = ContactID;

      if (ContactID == -1)
        _Mode = enMode.AddNew;
      else
        _Mode = enMode.Update;
    }

    private void _FillCountriesInComboBox()
    {
      DataTable dtCountries = clsCountry.ListAllCountries();
      foreach(DataRow row in dtCountries.Rows)
      {
        cmbCountry.Items.Add(row["CountryName"]);
      }
    }

    private void _LoadData()
    {
      _FillCountriesInComboBox();
      cmbCountry.SelectedIndex = 0;

      if(_Mode == enMode.AddNew)
      {
        lbContact.Text = "Add New Contact";
        _Contact = new clsContact();
        return;
      }

      _Contact = clsContact.Find(_ContactID);

      if(_Contact == null)
      {
        MessageBox.Show($" Sorry there is no Contact with this ID: {_ContactID}");
        this.Close();
        return;
      }
      lbContctID.Text = $"ContactID:  {_ContactID}";
      lbContact.Text = $"Contact ID= {_ContactID}";
      tbFirstName.Text = _Contact.FirstName;
      tbLastName.Text = _Contact.LastName;
      tbEmail.Text = _Contact.Email;
      tbPhone.Text = _Contact.Phone;
      dtDate.Value = _Contact.DateOfBirth;
      tbAddress.Text = _Contact.Address;

      if(_Contact.ImagePath != "")
      {
        pbImage.Load(_Contact.ImagePath);
      }

      lRemoveImg.Visible = (_Contact.ImagePath != "");

      cmbCountry.SelectedIndex = cmbCountry.FindString(clsCountry.FindCountryByID(_Contact.CountryID).CountryName);


    }

    


    private void pAddContact_Paint(object sender, PaintEventArgs e)
    {
     
    }

    private void FAddContacts_Load(object sender, EventArgs e)
    {

      _LoadData();
    }


    private void btnSave_Click(object sender, EventArgs e)
    {
      int CountryID = clsCountry.FindCountryByName(cmbCountry.Text).CountryID;

      _Contact.FirstName = tbFirstName.Text;
      _Contact.LastName = tbLastName.Text;
      _Contact.Email = tbEmail.Text;
      _Contact.Phone = tbPhone.Text;
      _Contact.Address = tbAddress.Text;
      _Contact.DateOfBirth = dtDate.Value;
      _Contact.CountryID = CountryID;
      if (pbImage.ImageLocation != null)
        _Contact.ImagePath = pbImage.ImageLocation;
      else
        _Contact.ImagePath = "";

      if (_Contact.Save())
        MessageBox.Show("Data Has been added Successfully");
      else
        MessageBox.Show("Erorr Somthing went wrong");

      _Mode = enMode.Update;
      lbContact.Text = $"Contact ID= {_ContactID}";
      lbContctID.Text = $"Contact ID= {_ContactID}";

    }

    struct CountryItem
    {
      public string Text;
      public int Value;
      public CountryItem(string Text, int Value)
      {
        this.Text = Text;
        this.Value = Value;
      }
    }
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
      
      this.Close();
    }
  }
}
