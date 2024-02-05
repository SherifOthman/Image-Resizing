using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace Image_Converter
{
    internal class Tools
    {

        public static DialogResult ShowMessage(string caption, string text,Form parentForm )
        {
            Guna2MessageDialog guna2MessageDialog = new Guna2MessageDialog();
            guna2MessageDialog.Caption = caption;
            guna2MessageDialog.Text = text;
            guna2MessageDialog.Icon = MessageDialogIcon.Information;
            guna2MessageDialog.Parent = parentForm;
            guna2MessageDialog.Style = MessageDialogStyle.Light;
            guna2MessageDialog.Buttons =  MessageDialogButtons.OK;

            return guna2MessageDialog.Show();
        }

        public static DialogResult ShowWarningMessage(string caption, string text, Form parentForm)
        {
            Guna2MessageDialog guna2MessageDialog = new Guna2MessageDialog();
            guna2MessageDialog.Caption = caption;
            guna2MessageDialog.Text = text;
            guna2MessageDialog.Parent = parentForm;
            guna2MessageDialog.Icon = MessageDialogIcon.Warning;
            guna2MessageDialog.Style = MessageDialogStyle.Light;
            guna2MessageDialog.Buttons = MessageDialogButtons.OKCancel;

            return guna2MessageDialog.Show();
        }

        public static DialogResult ShowErrorMessage(string caption, string text, Form parentForm)
        {
            Guna2MessageDialog guna2MessageDialog = new Guna2MessageDialog();
            guna2MessageDialog.Caption = caption;
            guna2MessageDialog.Text = text;
            guna2MessageDialog.Parent = parentForm;
            guna2MessageDialog.Icon = MessageDialogIcon.Error;
            guna2MessageDialog.Style = MessageDialogStyle.Light;
            guna2MessageDialog.Buttons = MessageDialogButtons.OK;

            return guna2MessageDialog.Show();
        }



    }
}
