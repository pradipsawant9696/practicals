using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssigmentNo9iv
{
    public partial class Form1 : Form
    {
        private int _charLimit = 256;

        // Call this in your Form constructor after InitializeComponent()
        private void InitEmailForm()
        {
            // initial limit
            ApplyCharLimit(_charLimit);

            // wire events (if not wired in designer)
            rtbBody.TextChanged += rtbBody_TextChanged;
            nudCharLimit.ValueChanged += nudCharLimit_ValueChanged;
            btnSend.Click += btnSend_Click;
            btnClear.Click += btnClear_Click;

            // Set NumericUpDown initial value
            nudCharLimit.Minimum = 1;
            nudCharLimit.Maximum = 10000;
            nudCharLimit.Value = _charLimit;
        }

        private void ApplyCharLimit(int limit)
        {
            _charLimit = Math.Max(1, limit);
            rtbBody.MaxLength = _charLimit;

            // If the current text exceeds the limit, truncate and restore caret
            if (rtbBody.Text.Length > _charLimit)
            {
                int sel = rtbBody.SelectionStart;
                rtbBody.Text = rtbBody.Text.Substring(0, _charLimit);
                rtbBody.SelectionStart = Math.Min(sel, rtbBody.Text.Length);
            }

            UpdateRemainingLabel();
        }

        public Form1()
        {
            InitializeComponent();
            InitEmailForm();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRemaining_Click(object sender, EventArgs e)
        {

        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateRemainingLabel()
        {
            int remaining = _charLimit - rtbBody.Text.Length;
            if (remaining < 0) remaining = 0;
            lblRemaining.Text = $"Remaining: {remaining} / {_charLimit}";
        }

        private bool ValidateEmailList(string addressList, out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(addressList))
            {
                error = "Recipient (To) address is required.";
                return false;
            }

            var separators = new[] { ',', ';' };
            var parts = addressList.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(p => p.Trim())
                                   .ToArray();
            if (parts.Length == 0)
            {
                error = "Enter at least one valid email address.";
                return false;
            }

            foreach (var p in parts)
            {
                try
                {
                    var ma = new MailAddress(p); // throws on invalid
                }
                catch
                {
                    error = $"Invalid email address: {p}";
                    return false;
                }
            }
            return true;
        }

        private void rtbBody_TextChanged(object sender, EventArgs e)
        {
            if (rtbBody.Text.Length > _charLimit)
            {
                int selStart = rtbBody.SelectionStart;
                rtbBody.Text = rtbBody.Text.Substring(0, _charLimit);
                rtbBody.SelectionStart = Math.Min(selStart, rtbBody.Text.Length);
            }
            UpdateRemainingLabel();
        }

        private void nudCharLimit_ValueChanged(object sender, EventArgs e)
        {
            ApplyCharLimit((int)nudCharLimit.Value);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string toList = txtTo.Text.Trim();
            string subject = txtSubject.Text.Trim();
            string body = rtbBody.Text ?? string.Empty;

            // Validation
            if (!ValidateEmailList(toList, out string validationError))
            {
                MessageBox.Show(validationError, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (body.Length > _charLimit)
            {
                MessageBox.Show($"Message body exceeds the limit of {_charLimit} characters.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm send with short preview
            var preview = new StringBuilder();
            preview.AppendLine("To: " + toList);
            preview.AppendLine("Subject: " + subject);
            preview.AppendLine();
            preview.AppendLine(body.Length <= 500 ? body : body.Substring(0, 500) + " ...");

            if (MessageBox.Show("Send this email?\n\n" + preview.ToString(), "Confirm send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                SendEmailUsingGmail(toList, subject, body);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTo.Clear();
            txtSubject.Clear();
            rtbBody.Clear();
            // keep limit unchanged
            UpdateRemainingLabel();
        }

        private void SendEmailUsingGmail(string toAddresses, string subject, string body)
        {
            // Config - replace values or load from secure config
            string smtpHost = "smtp.gmail.com";
            int smtpPort = 587;
            string fromAddress = "yashomunim@gmail.com"; // must be the Gmail address where the app password was created
            string displayName = "Yash Pansare";
            string smtpUser = fromAddress;

            // IMPORTANT: Prefer reading the app password from an environment variable or secure store.
            // Example: set environment variable GMAIL_APP_PASSWORD with your google app password.
            string appPassword = Environment.GetEnvironmentVariable("GMAIL_APP_PASSWORD");
            //string appPassword = "";
            // Fallback for dev only (not recommended) — replace or remove:
            if (string.IsNullOrEmpty(appPassword))
            {
                // OPTIONALLY: you can prompt the user, read from settings, or throw.
                // For safety, throw an explanatory exception so developer doesn't accidentally commit credentials.
                throw new InvalidOperationException(
                    "Gmail app password not found. Set the environment variable GMAIL_APP_PASSWORD with your app password.");
            }

            // Build message
            using (var msg = new MailMessage())
            {
                msg.From = new MailAddress(fromAddress, displayName);

                // Add recipients (support comma/semicolon separated)
                var recipients = toAddresses.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var r in recipients) msg.To.Add(r.Trim());

                msg.Subject = subject ?? string.Empty;
                msg.Body = body ?? string.Empty;
                msg.IsBodyHtml = false; // set true if sending html

                // Send
                using (var client = new SmtpClient(smtpHost, smtpPort))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(smtpUser, appPassword);

                    // Note: SmtpClient.Send is synchronous. For UI responsiveness you can call SendMailAsync from a Task.
                    client.Send(msg);
                }
            }
        }
    }
}