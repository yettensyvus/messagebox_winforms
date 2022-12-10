using System.Drawing;
using System.Windows.Forms;

namespace messagebox
{
    public partial class frm_messagebox : Form
    {
        public frm_messagebox()
        {
            InitializeComponent();
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
                case "information":

                    f.picture_box.Image = Properties.Resources.done_64px;
                    f.btn_confirm.Text = "Continue";
                    f.lbl_title.ForeColor = Color.FromArgb(42, 171, 160);
                    f.btn_confirm.BackColor = Color.FromArgb(42, 171, 160);

                    break;

                case "question":

                    f.picture_box.Image = Properties.Resources.info_64px;
                    f.btn_confirm.Text = "OK";
                    f.lbl_title.ForeColor = Color.FromArgb(71, 169, 248);
                    f.btn_confirm.BackColor = Color.FromArgb(71, 169, 248);

                    break;

                case "error":

                    f.picture_box.Image = Properties.Resources.cancel_64px;
                    f.btn_confirm.Text = "Retry";
                    f.lbl_title.ForeColor = Color.FromArgb(255, 121, 70);
                    f.btn_confirm.BackColor = Color.FromArgb(255, 121, 70);

                    break;

                case "warning":

                    f.picture_box.Image = Properties.Resources.error_64px;
                    f.btn_confirm.Text = "OK";
                    f.lbl_title.ForeColor = Color.FromArgb(255, 121, 70);
                    f.btn_confirm.BackColor = Color.FromArgb(255, 121, 70);

                    break;
            }
        }

        public static System.Windows.Forms.DialogResult Show(string message, string title, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlg = System.Windows.Forms.DialogResult.None;

            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (frm_messagebox f = new frm_messagebox())
                    {
                        f.lbl_title.Text = title;
                        f.lbl_message.Text = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                data("information", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: 
                                data("question", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: 
                                data("error", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: 
                                data("warning", button, f);
                                break;
                        }
                        dlg = f.ShowDialog();
                    }
                    break;

                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (frm_messagebox f = new frm_messagebox())
                    {
                        f.lbl_title.Text = title;
                        f.lbl_message.Text = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                data("information", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: 
                                data("question", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: 
                                data("error", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: 
                                data("warning", button, f);
                                break;
                        }
                        dlg = f.ShowDialog();
                    }
                    break;


                case System.Windows.Forms.MessageBoxButtons.RetryCancel:
                    using (frm_messagebox f = new frm_messagebox())
                    {
                        f.lbl_title.Text = title;
                        f.lbl_message.Text = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information: 
                                data("information", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: 
                                data("question", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: 
                                data("error", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: 
                                data("warning", button, f);
                                break;
                        }
                        dlg = f.ShowDialog();
                    }
                    break;


                case System.Windows.Forms.MessageBoxButtons.OKCancel:
                    using (frm_messagebox f = new frm_messagebox())
                    {
                        f.lbl_title.Text = title;
                        f.lbl_message.Text = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                data("information", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question: 
                                data("question", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error: 
                                data("error", button, f);
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning: 
                                data("warning", button, f);
                                break;
                        }
                        dlg = f.ShowDialog();
                    }
                    break;
            }
            return dlg;
        }
    }
}