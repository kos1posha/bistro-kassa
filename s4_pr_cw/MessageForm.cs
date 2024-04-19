using System;
using System.Drawing;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        public static DialogResult Show(string message)
            => Show("", message, MessageBoxButtons.OK);
        public static DialogResult Show(string caption, string message)
            => Show(caption, message, MessageBoxButtons.OK);
        public static DialogResult Show(string message, MessageBoxButtons messageType)
            => Show("", message, messageType);
        public static DialogResult Show(string caption, string message, MessageBoxButtons messageType)
        {
            MessageBox messageBox = new MessageBox();
            messageBox.captionLabel.Text = caption;
            messageBox.messageLabel.Text = message;
            messageBox.Size = new Size(337, 125 + (message.Length / 44 * 20));
            switch (messageType)
            {
                case MessageBoxButtons.OK:
                    messageBox.cancelButton.Hide();
                    messageBox.okButton.Location = new Point(175, messageBox.okButton.Location.Y);
                    break;
            }
            messageBox.ShowDialog();
            return messageBox.DialogResult;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Dispose();
        }
    }
}
