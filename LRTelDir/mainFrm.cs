/*
 * Please read the following terms and conditions carefully
 * before using this software or this source code.
 * Use of this software (source code) indicates you accept 
 * the terms of this license agreement and warranty.
 * 
 * 1. Disclaimer of Warranty
 * 
 * LR Telephone Directory (this software or source code) is provided "as-is" 
 * and without warranty of any kind, express, implied or otherwise, 
 * including without limitation, any warranty of merchantability or 
 * fitness for a particular purpose. 
 * 
 * In no event shall the author of this software (source code) be held liable for 
 * data loss, damages, loss of profits or any other kind of loss while 
 * using or misusing this software.
 * 
 * 2. License
 * 
 * LR Telephone Directory is provided as FREEWARE for private (non-commercial) or
 * educational (including non-profit organization) use. In these cases,
 * you are granted the right to use and to make an unlimited number of 
 * copies of this software (source code). Distribution of this software (source code) 
 * is allowed as long as you have to distribute everything that you got with it.
 * 
 * 3. Restrictions on Use 
 * 
 * If you want to copy something, you've got to give the author the credit.
 * If you modified it, you have to give the author the credit for the base code.
 * 
 * Copyright (C) 2014 LameRock Dev. All rights reserved.
 * 
 * Author: Gerard James B. Paglingayen
 * Credits:
 *          <insert your name here>
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;


namespace LRTelDir
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void showExisting(string lrSQL)
        {
            dgvTelDir.Rows.Clear();
            int idxRow = 0;
            OleDbConnection conDB = new OleDbConnection();
            conDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dbTelDir.accdb;";
            try
            {
                conDB.Open();
                OleDbCommand cmdDB = new OleDbCommand(lrSQL, conDB);
                OleDbDataReader rdrDB = cmdDB.ExecuteReader();

                while (rdrDB.Read())
                {
                    dgvTelDir.Rows.Add();
                    dgvTelDir.Rows[idxRow].Cells[0].Value = rdrDB["phoneID"].ToString();
                    dgvTelDir.Rows[idxRow].Cells[1].Value = rdrDB["fldLastname"].ToString();
                    dgvTelDir.Rows[idxRow].Cells[2].Value = rdrDB["fldFirstname"].ToString();
                    dgvTelDir.Rows[idxRow].Cells[3].Value = rdrDB["fldMiddlename"].ToString();
                    dgvTelDir.Rows[idxRow].Cells[4].Value = rdrDB["fldAddress"].ToString();
                    dgvTelDir.Rows[idxRow].Cells[5].Value = rdrDB["fldPhoneNumber"].ToString();
                    dgvTelDir.Rows[idxRow].Cells[6].Value = rdrDB["fldNotes"].ToString();
                    idxRow++;
                }
                rdrDB.Close();
                rdrDB.Dispose();
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                defaultState();
                return;
            }
            lblNumRecords.Text = "Number of Records: " + dgvTelDir.Rows.Count.ToString();
            dgvTelDir.Refresh();
            dgvTelDir.Refresh();
            
        }

        private void defaultState()
        {
            grpInformation.Enabled = false;
            grpSearch.Enabled = true;
            btnNewSave.Enabled = true;
            btnEditUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvTelDir.Enabled = true;

            btnNewSave.Text = "&New";
            btnEditUpdate.Text = "&Edit";
            btnDelete.Text = "&Delete";
            btnCloseCancel.Text = "&Close";
            
            txtPhoneID.Text = "";
            txtLastname.Text = "";
            txtFirstname.Text = "";
            txtMiddlename.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtNotes.Text = "";

            txtSearchKey.Text = "";

            btnNewSave.Focus();
           
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            cbxSearchBy.Items.Add("Phone ID");
            cbxSearchBy.Items.Add("Last Name");
            cbxSearchBy.Items.Add("First Name");
            cbxSearchBy.Items.Add("Middle Name");
            cbxSearchBy.Items.Add("Address");
            cbxSearchBy.Items.Add("Phone Number");
            cbxSearchBy.Text = "Phone ID";

            dgvTelDir.ColumnCount = 7;
            dgvTelDir.Columns[0].Name = "Phone ID";
            dgvTelDir.Columns[1].Name = "Last Name";
            dgvTelDir.Columns[2].Name = "First Name";
            dgvTelDir.Columns[3].Name = "Middle Name";
            dgvTelDir.Columns[4].Name = "Address";
            dgvTelDir.Columns[5].Name = "Phone Number";
            dgvTelDir.Columns[6].Name = "Notes";

            dgvTelDir.Columns[0].Visible = false;
            dgvTelDir.Columns[1].Width = 100;
            dgvTelDir.Columns[2].Width = 110;
            dgvTelDir.Columns[3].Width = 120;
            dgvTelDir.Columns[4].Width = 120;
            dgvTelDir.Columns[5].Width = 120;
            dgvTelDir.Columns[6].Width = 120;

            defaultState();
            showExisting("SELECT * FROM tblDirectory");
        }

        private void btnCloseCancel_Click(object sender, EventArgs e)
        {
            if (btnCloseCancel.Text == "&Close")
            {
                this.Close();
                this.Dispose();
            }
            else
            {
                defaultState();
            }
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (btnEditUpdate.Text == "&Edit")
            {
                grpInformation.Enabled = true;
                grpSearch.Enabled = false;
                btnNewSave.Enabled = false;
                btnDelete.Enabled = false;
                dgvTelDir.Enabled = false;

                btnEditUpdate.Text = "&Update";
                btnCloseCancel.Text = "&Cancel";

                txtLastname.Focus();
                System.Windows.Forms.SendKeys.Send("{HOME}+{END}");

               
            }
            else
            {
                if (txtLastname.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLastname.Focus();
                    return;
                }
                if (txtFirstname.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFirstname.Focus();
                    return;
                }
                if (txtPhoneNumber.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPhoneNumber.Focus();
                    return;
                }
                if (txtAddress.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddress.Focus();
                    return;
                }

                showExisting("SELECT * FROM tblDirectory WHERE phoneID ='" + txtPhoneID.Text +
                    "' AND fldLastname = '" + txtLastname.Text +
                    "' AND fldFirstname = '" + txtFirstname.Text +
                    "' AND fldMiddlename = '" + txtMiddlename.Text +
                    "' AND fldAddress = '" + txtAddress.Text +
                    "' AND fldPhoneNumber = '" + txtPhoneNumber.Text +
                    "' AND fldNotes = '" + txtNotes.Text + "'");
                if (dgvTelDir.Rows.Count == 0)
                {
                    OleDbConnection conDB = new OleDbConnection();
                    conDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dbTelDir.accdb;";
                    try
                    {
                        conDB.Open();

                        OleDbCommand cmdDB = new OleDbCommand("UPDATE tblDirectory SET fldLastname ='" + txtLastname.Text +
                            "', fldFirstname = '" + txtFirstname.Text +
                            "', fldMiddlename = '" + txtMiddlename.Text +
                            "', fldAddress = '" + txtAddress.Text +
                            "', fldPhoneNumber = '" + txtPhoneNumber.Text +
                            "', fldNotes = '" + txtNotes.Text +
                            "' WHERE phoneID = '" + txtPhoneID.Text +
                            "'", conDB);
                        cmdDB.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        defaultState();
                        return;
                    }
                    MessageBox.Show("User's Information was successfully updated.", "Information Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    defaultState();
                    showExisting("SELECT * FROM tblDirectory");
                }
                else
                {
                    MessageBox.Show("This entry already exist.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLastname.Focus();
                    System.Windows.Forms.SendKeys.Send("{HOME}+{END}");
                    return;
                }
            }
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            string tempStr = "";
            int tempInt = 0;

            if (btnNewSave.Text == "&New")
            {

                btnNewSave.Text = "&Save";
                btnCloseCancel.Text = "&Cancel";

                grpInformation.Enabled = true;
                grpSearch.Enabled = false;
                dgvTelDir.Enabled = false;

                txtLastname.Focus();
               
                OleDbConnection conDB = new OleDbConnection();
                conDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dbTelDir.accdb;";
                try
                {
                    conDB.Open();
                    OleDbCommand cmdDB = new OleDbCommand("SELECT phoneID FROM tblDirectory", conDB);
                    OleDbDataReader rdrDB = cmdDB.ExecuteReader();

                    while (rdrDB.Read())
                    {
                        tempStr = rdrDB["phoneID"].ToString();

                    }
                    rdrDB.Close();
                    rdrDB.Dispose();

                    /***** [START] Increment ID *****/
                    int tempLength = tempStr.Length - 6;

                    tempStr = tempStr.Substring(tempLength);

                    tempInt = Convert.ToInt32(tempStr);
                    tempInt += 1;
                    string ids = tempInt.ToString();
                    for (var countID = ids.Length; countID <= 5; countID++)
                    {
                        ids = "0" + ids;
                    }
                    tempStr = "ID-" + ids;
                    txtPhoneID.Text = tempStr;
                    /***** [END] Increment ID *****/

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    defaultState();
                    return;
                }
            }
            else
            {
                if (txtPhoneID.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPhoneID.Focus();
                    return;
                }
                if (txtLastname.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLastname.Focus();
                    return;
                }
                if (txtFirstname.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFirstname.Focus();
                    return;
                }
                if (txtAddress.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddress.Focus();
                    return;
                }
                if (txtPhoneNumber.Text.Length == 0)
                {
                    MessageBox.Show("Textbox contains no data.", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPhoneNumber.Focus();
                    return;
                }

                showExisting("SELECT * FROM tblDirectory " 
                    + " WHERE fldLastname='" + txtLastname.Text 
                    + "' AND  fldFirstname='" + txtFirstname.Text 
                    + "'");
                
                if (dgvTelDir.Rows.Count == 0)
                {
                    OleDbConnection conDB = new OleDbConnection();
                    conDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dbTelDir.accdb;";
                    try
                    {
                        conDB.Open();

                        OleDbCommand cmdDB = new OleDbCommand("INSERT INTO tblDirectory (phoneID, fldLastname, fldFirstname, fldMiddlename, fldAddress, fldPhoneNumber, fldNotes) VALUES ('"
                            + txtPhoneID.Text.ToString() + "','"
                            + txtLastname.Text.ToString() + "','"
                            + txtFirstname.Text.ToString() + "','"
                            + txtMiddlename.Text.ToString() + "','"
                            + txtAddress.Text.ToString() + "','"
                            + txtPhoneNumber.Text.ToString() + "','"
                            + txtNotes.Text.ToString() + "')", conDB);
                        cmdDB.ExecuteNonQuery();




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        defaultState();
                        return;
                    }

                    MessageBox.Show("New entry was successfully added.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showExisting("SELECT * FROM tblDirectory");
                    defaultState();
                    return;

                }
                else
                {
                    MessageBox.Show("This entry already exist.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLastname.Focus();
                    System.Windows.Forms.SendKeys.Send("{HOME}+{END}");
                    return;
                }
                
            }
            showExisting("SELECT * FROM tblDirectory");
            //defaultState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPhoneID.Text == "ID-000001")
            {
                MessageBox.Show("This entry cannot be deleted.", "Default Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                defaultState();
                showExisting("SELECT * FROM tblDirectory");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbConnection conDB = new OleDbConnection();
                conDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dbTelDir.accdb;";
                try
                {
                    conDB.Open();
                    OleDbCommand cmdDB = new OleDbCommand("DELETE FROM tblDirectory WHERE phoneID='" + txtPhoneID.Text + "'", conDB);
                    cmdDB.ExecuteNonQuery();
                    MessageBox.Show("Entry was deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    defaultState();
                    showExisting("SELECT * FROM tblDirectory");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    defaultState();
                }
            }
            else
            {
                return;
            }
        }

   

        private void dgvTelDir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /** Column Sorting Fix **/
            if (e.RowIndex < 0) return;

            btnNewSave.Enabled = false;
            btnEditUpdate.Enabled = true;
            btnDelete.Enabled = true;

            btnCloseCancel.Text = "&Cancel";

            /** Transfer data from database to their respective textboxes **/
            txtPhoneID.Text = dgvTelDir.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLastname.Text = dgvTelDir.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFirstname.Text = dgvTelDir.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMiddlename.Text = dgvTelDir.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvTelDir.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPhoneNumber.Text = dgvTelDir.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNotes.Text = dgvTelDir.Rows[e.RowIndex].Cells[6].Value.ToString();
            
        }

        private void txtSearchKey_TextChanged(object sender, EventArgs e)
        {
            string lrSQL = null;
                        
            switch (cbxSearchBy.Text)
            {
                case "Phone ID":
                    lrSQL = "SELECT * FROM tblDirectory WHERE phoneID LIKE '" + txtSearchKey.Text + "%'";
                    showExisting(lrSQL);
                    break;
                case "Last Name":
                    lrSQL = "SELECT * FROM tblDirectory WHERE fldLastname LIKE '" + txtSearchKey.Text + "%'";
                    showExisting(lrSQL);
                    break;
                case "First Name":
                    lrSQL = "SELECT * FROM tblDirectory WHERE fldFirstname LIKE '" + txtSearchKey.Text + "%'";
                    showExisting(lrSQL);
                    break;
                case "Middle Name":
                    lrSQL = "SELECT * FROM tblDirectory WHERE fldMiddlename LIKE '" + txtSearchKey.Text + "%'";
                    showExisting(lrSQL);
                    break;
                case "Address":
                    lrSQL = "SELECT * FROM tblDirectory WHERE fldAddress LIKE '" + txtSearchKey.Text + "%'";
                    showExisting(lrSQL);
                    break;
                case "Phone Number":
                    lrSQL = "SELECT * FROM tblDirectory WHERE fldPhoneNumber LIKE '" + txtSearchKey.Text + "%'";
                    showExisting(lrSQL);
                    break;
            }
        }


    }
}
