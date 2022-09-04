using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public string Name { get; }
        public string Id { get; }
        public string PhoneNumber { get; }
        public DateTime Date { get; }
        public string AppoinmentPlace { get; }
        public string DoctorName { get; }
        public AppointmentService(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Date = date;
            this.AppoinmentPlace = appoinmentPlace;
            this.DoctorName = doctorName;
            StringBuilder stringBuilder = new StringBuilder("");
            Boolean isValid = true;

        }
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }
        public static string NameValidator(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }
            return stringBuilder.ToString();
        }
    }
}
//No se.