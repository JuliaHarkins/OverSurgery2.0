﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery2
{
    public partial class AddPrescription : Form
    {
        #region Members
        MetaLayer ml = MetaLayer.Instance();
        MedicalStaff m_currentUser;
        List<Medication> m_medication;
        int  m_patientID;
#endregion
        public AddPrescription(Staff p_currentUser, int p_patientID)
        {
            m_currentUser = p_currentUser as MedicalStaff;
            m_patientID = p_patientID;
            m_medication = ml.getMedicationOnMedStaffID(m_currentUser.MedicalStaffID);
            InitializeComponent();

        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
#region hideExtention
            lb_dateOfNextIssue.Hide();
            dtp_dateOfNextExtention.Hide();
#endregion
#region LoadMedication
            lst_medication.Columns.Add("Medication", 125);
            lst_medication.Columns.Add("Dosage", 75);
            lst_medication.Columns.Add("Permission Level",95);

            loadList();

#endregion

        }
        

#region button
        private void btn_savePrescription_Click(object sender, EventArgs e)
        {
            Prescription p = new Prescription();

            int i = lst_medication.SelectedIndices[0];
            p.MedicationID =Convert.ToUInt16(m_medication[i].ID);
            p.PatientID = m_patientID;
            p.MedicalStaffID = Convert.ToInt16(m_currentUser.MedicalStaffID);
            p.Amount = Convert.ToInt16(nud_amount.Value);
            p.Extendable = cb_extenable.Checked;
            if (p.Extendable)
            {
                p.DateOfNextIssue = Convert.ToDateTime(dtp_dateOfNextExtention.Value);
            }
            p.Date = DateTime.Now;

            ml.AddPrescriptionToTheDatabase(p);
            this.Close();

        }
#endregion
#region list
        
        private void lst_medication_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
#endregion
#region lable
        private void lb_notes_Click(object sender, EventArgs e)
        {

        }
        private void lb_dateOfNextIssue_Click(object sender, EventArgs e)
        {

        }
        private void lb_patient_Click(object sender, EventArgs e)
        {

        }
#endregion
        private void dtp_dateOfNextExtention_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nud_amount_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void cb_extenable_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_extenable.Checked)
            {
                lb_dateOfNextIssue.Show();
                dtp_dateOfNextExtention.Show();
            }
            else
            {
                lb_dateOfNextIssue.Hide();
                dtp_dateOfNextExtention.Hide();
            }
        }


        private void loadList()
        {
            foreach (Medication m in m_medication)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.Name.ToString();
                lvi.SubItems.Add(m.Dosage.ToString());
                lvi.SubItems.Add(m.PermissionLevel.ToString());
                lst_medication.Items.Add(lvi);
            }
        }

    }
}
