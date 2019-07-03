using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendEmailAttachment
{
    public partial class SendEmailAttchment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFrom.Focus();
        }

        public void SendEmail(string from, string to, string message, string subject, 
            string host, int port, string password)
        {
            // path save file to server
            var pathServer = "~/EmailAttachment";

            // create new object MailMessage
            var email = new MailMessage();
            // create new object MailAddress
            email.From = new MailAddress(from);
            // subject email
            email.Subject = subject;
            // body email
            email.Body = message;

            // create new object SmtpClient with host and port
            var smtp = new SmtpClient(host, port);

            smtp.UseDefaultCredentials = false;
            var nc = new NetworkCredential(from, password);
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            email.IsBodyHtml = true;

            // Add mail to
            email.To.Add(to);

            // email.CC.Add(to);
            // email.BCC.Add(to);

            if (fileAttach.PostedFiles != null)
            {
                // list file attachment
                var attchmentList = fileAttach.PostedFiles;
                foreach (var attachment in attchmentList)
                {
                    // get lenght file
                    var FileLength = attachment.ContentLength;
                    if (FileLength > 0)
                    {
                        var fileName = Path.GetFileName(attachment.FileName);
                        fileAttach.PostedFile.SaveAs(Path.Combine(Server.MapPath(pathServer), fileName));
                        var attachment_get = new Attachment(Path.Combine(Server.MapPath(pathServer), fileName));
                        email.Attachments.Add(attachment_get);
                    }
                }
            }
            smtp.Send(email);

        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = string.Empty;
                var from = txtFrom.Text.Trim();
                var to = txtTo.Text.Trim();
                var message = txtMessage.Text.Trim();
                var subject = txtSubject.Text.Trim();
                var host = "smtp.gmail.com";
                var port = 587;
                var password = txtPassword.Text.Trim();

                SendEmail(from, to, message, subject, host, port, password);

                ResetValue();

                lblError.Text = "Send Email Successfully";
                lblError.ForeColor = Color.Blue;

                txtFrom.Focus();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error Send Email. Please try again!";
                lblError.ForeColor = Color.Red;
            }
        }

        public void ResetValue()
        {
            txtFrom.Text = string.Empty;
            txtMessage.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtTo.Text = string.Empty;
            lblError.Text = string.Empty;
        }
    }
}