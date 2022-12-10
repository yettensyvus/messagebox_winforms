using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox
{
    public partial class frm_messagebox : Form
    {
        public frm_messagebox()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return picture_box.Image; }
            set { picture_box.Image = value; }
        }

        public string Message
        {
            get { return lbl_message.Text; }
            set { lbl_message.Text = value; }
        }

        public static void data(string type, System.Windows.Forms.MessageBoxButtons button, frm_messagebox f)
        {
            if (button == MessageBoxButtons.YesNo)
            {
                f.btn_confirm.Hide();
                f.btn_yes.Show();
                f.btn_no.Show();
            }
            else
            {
                f.btn_confirm.Show();
                f.btn_yes.Hide();
                f.btn_no.Hide();
            }

            switch (type)
            {
                case "success":

                    f.btn_confirm.Text = "Continue";
                    f.btn_confirm.ForeColor = Color.FromArgb(42, 171, 160);
                    f.lbl_title.ForeColor = Color.FromArgb(42, 171, 160);

                    break;

                case "info":

                    f.lbl_title.ForeColor = Color.FromArgb(71, 169, 248);

                    break;

                case "error":

                    f.btn_confirm.Text = "Try Again";
                    f.btn_confirm.ForeColor = Color.FromArgb(255, 121, 70);
                    f.lbl_title.ForeColor = Color.FromArgb(255, 121, 70);

                    break;

                case "warning":

                    f.btn_confirm.Text = "OK";
                    f.btn_confirm.ForeColor = Color.FromArgb(255, 121, 70);
                    f.lbl_title.ForeColor = Color.FromArgb(255, 121, 70);

                    break;
            }
        }

        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlg_result = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (frm_messagebox f = new frm_messagebox())
                    {
                        f.Text = caption;
                        f.Message = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information: //success
                                f.MessageIcon = Properties.Resources.done_64px;
                                data("success", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: //info
                                f.MessageIcon = Properties.Resources.info_64px;
                                data("info", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: //errorr
                                f.MessageIcon = Properties.Resources.cancel_64px;
                                data("error", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: //warning
                                f.MessageIcon = Properties.Resources.error_64px;
                                data("warning", button, f);
                                break;
                        }
                        dlg_result = f.ShowDialog();
                    }
                    break;

                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (frm_messagebox f = new frm_messagebox())
                    {
                        f.Text = caption;
                        f.Message = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information: //success
                                f.MessageIcon = Properties.Resources.done_64px;
                                data("success", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: //info
                                f.MessageIcon = Properties.Resources.info_64px;
                                data("info", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: //errorr
                                f.MessageIcon = Properties.Resources.cancel_64px;
                                data("error", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: //warning
                                f.MessageIcon = Properties.Resources.error_64px;
                                data("warning", button, f);
                                break;
                        }
                        dlg_result = f.ShowDialog();
                    }
                    break;


                case System.Windows.Forms.MessageBoxButtons.RetryCancel:
                    using (frm_messagebox f = new frm_messagebox())
                    {
                        f.Text = caption;
                        f.Message = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information: //success
                                f.MessageIcon = Properties.Resources.done_64px;
                                data("success", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: //info
                                f.MessageIcon = Properties.Resources.info_64px;
                                data("info", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: //errorr
                                f.MessageIcon = Properties.Resources.cancel_64px;
                                data("error", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: //warning
                                f.MessageIcon = Properties.Resources.error_64px;
                                data("warning", button, f);
                                break;
                        }
                        dlg_result = f.ShowDialog();
                    }
                    break;


                case System.Windows.Forms.MessageBoxButtons.OKCancel:
                    using (frm_messagebox f = new frm_messagebox())
                    {
                        f.Text = caption;
                        f.Message = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information: //success
                                f.MessageIcon = Properties.Resources.done_64px;
                                data("success", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: //info
                                f.MessageIcon = Properties.Resources.info_64px;
                                data("info", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: //errorr
                                f.MessageIcon = Properties.Resources.cancel_64px;
                                data("error", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: //warning
                                f.MessageIcon = Properties.Resources.error_64px;
                                data("warning", button, f);
                                break;
                        }
                        dlg_result = f.ShowDialog();
                    }
                    break;
            }
            return dlg_result;
        }
    }
}
