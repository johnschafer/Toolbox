using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppointmentSetter.Classes;
using AppointmentSetter.Exceptions;

namespace AppointmentSetter
{
    public class Setter
    {
        Appointment appt = new Appointment();

        /// <summary>
        /// Appointment Setters entry point.
        /// </summary>
        /// <param name="clientFirstName"></param>
        /// <param name="clientLastName"></param>
        /// <param name="clientDOB"></param>
        /// <param name="staffFirstName"></param>
        /// <param name="staffLastName"></param>
        /// <param name="specialty"></param>
        /// <param name="serviceStartDate"></param>
        /// <param name="serviceEndDate"></param>
        /// <param name="service"></param>
        /// <returns>An appointment</returns>
        public Appointment Main(string clientFirstName, string clientLastName, DateTime clientDOB, string staffFirstName, string staffLastName, string specialty,
                            DateTime serviceStartDate, DateTime serviceEndDate, string service)
        {
            CheckAge(clientDOB, specialty);
            appt.client.firstname = clientFirstName;
            appt.client.lastname = clientLastName;
            appt.client.DOB = clientDOB;
            appt.staff.firstname = staffFirstName;
            appt.staff.lastname = staffLastName;
            appt.staff.specialty = specialty;
            CheckMidnightCutoff(serviceStartDate, serviceEndDate, service);

            return appt;
        }
        /// <summary>
        /// Checks the clients age and if the client is over 70, ensures the specialty is geriatrics. 
        /// Will throw SpecialtyNotGeriatricsException if specialty is not geriatrics.
        /// </summary>
        /// <param name="clientDOB"></param>
        /// <param name="specialty"></param>
        public void CheckAge(DateTime clientDOB, string specialty)
        {
            DateTime overSeventy = DateTime.Now.AddYears(-70);
            string geriatricsSpecialty = "geriatrics";
            if(clientDOB < overSeventy)
            {
                if(specialty.ToLower() != geriatricsSpecialty)
                {
                    throw new SpecialtyNotGeriatricsException();
                }
            }
        }

        /// <summary>
        /// Splits service lines if they cross over midnight.
        /// </summary>
        /// <param name="serviceStartDate"></param>
        /// <param name="serviceEndDate"></param>
        /// <param name="service"></param>
        public void CheckMidnightCutoff(DateTime serviceStartDate, DateTime serviceEndDate, string service)
        {
            if(serviceStartDate.Date != serviceEndDate.Date)
            {
                // Add service line from start date to midnight
                appt.servicelines.Add(AddServiceLine(serviceStartDate, serviceEndDate.Date, service));
                
                // Add service line from midnight to end date
                appt.servicelines.Add(AddServiceLine(serviceEndDate.Date, serviceEndDate, service));
            }
            else
            {
                // Add service line if dates have same day
                appt.servicelines.Add(AddServiceLine(serviceStartDate, serviceEndDate, service));
            }
        }

        /// <summary>
        /// Generates a ServiceLine to add to an appointment
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="service"></param>
        /// <returns></returns>
        public ServiceLine AddServiceLine(DateTime startDate, DateTime endDate, string service)
        {
            ServiceLine serviceLine = new ServiceLine();

            serviceLine.startTime = startDate;
            serviceLine.endTime = endDate;
            serviceLine.service = service;

            return serviceLine;
        }
    }
}