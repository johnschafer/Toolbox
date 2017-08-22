using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppointmentSetter.Classes;
using System.Data;
using AppointmentSetter.Exceptions;

namespace AppointmentSetter
{
    public partial class AppointSetterForm : System.Web.UI.Page
    {
        string columnClientFirstname = "Client First Name";
        string columnClientLastName = "Client Last Name";
        string columnClientDOB = "Client DOB";
        string columnStaffFirstName = "Staff First Name";
        string columnStaffLastName = "Staff Last Name";
        string columnStaffSpecialty = "Staff Specialty";
        string columnServiceStartDate = "Service Start Date";
        string columnServiceEndDate = "Service End Date";
        string columnService = "Service";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAddAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment appt = new Appointment();
                Setter setter = new Setter();
                appt = setter.Main(txtClientFirstName.Text, txtClientLastName.Text, Convert.ToDateTime(txtDOB.Text), txtStaffFirstName.Text, txtStaffLastName.Text, txtSpecialty.Text,
                            Convert.ToDateTime(txtServiceStartDate.Text), Convert.ToDateTime(txtServiceEndDate.Text), txtService.Text);

                DataTable dt = new DataTable();
                dt.Columns.Add(columnClientFirstname, typeof(string));
                dt.Columns.Add(columnClientLastName, typeof(string));
                dt.Columns.Add(columnClientDOB, typeof(DateTime));
                dt.Columns.Add(columnStaffFirstName, typeof(string));
                dt.Columns.Add(columnStaffLastName, typeof(string));
                dt.Columns.Add(columnStaffSpecialty, typeof(string));
                dt.Columns.Add(columnServiceStartDate, typeof(DateTime));
                dt.Columns.Add(columnServiceEndDate, typeof(DateTime));
                dt.Columns.Add(columnService, typeof(string));

                foreach (ServiceLine sl in appt.servicelines)
                {
                    DataRow row = dt.NewRow();
                    row[columnClientFirstname] = appt.client.firstname;
                    row[columnClientLastName] = appt.client.lastname;
                    row[columnClientDOB] = appt.client.DOB;
                    row[columnStaffFirstName] = appt.staff.firstname;
                    row[columnStaffLastName] = appt.staff.lastname;
                    row[columnStaffSpecialty] = appt.staff.specialty;
                    row[columnServiceStartDate] = sl.startTime;
                    row[columnServiceEndDate] = sl.endTime;
                    row[columnService] = sl.service;
                    dt.Rows.Add(row);
                }

                gvAppointment.DataSource = dt;
                gvAppointment.DataBind();

            }
            catch(Exception)
            {
            }

        }
    }
}