using ClassLib.DataAccess;
using System;

namespace ClassLib.BussinessLogic
{

    public class Business
    {

        public static int FormProcessor(string firstname, string lastname, string title, string company,
            string email, string telephone, string subject, string messagebody)
        {
            FormEntry frm = new FormEntry
            {

            Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            FirstName = firstname,
            LastName = lastname,
            Title = title,
            Company = company,
            Email = email,
            Telephone = telephone,
            Subject = subject,
            MessageBody = messagebody

            };

            if (string.IsNullOrEmpty(frm.Title))
            {
                frm.Title = "Not provided";
            }

            if (string.IsNullOrEmpty(frm.Company))
            {
                frm.Company = "Not provided";
            }

            string sql = @"INSERT INTO Client(Date, Name, Surname, Title, Company, Email, Telephone, Subject, Message_Body)
            VALUES(@Datetime,@FirstName, @lastName, @Title, @Company,@Email,@Telephone,@Subject,@MessageBody)";

            return SQLConn.SaveData(sql,frm);
        }
    }
}