using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using _1.DAL.Reposytorys;
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

namespace _3.PL.View
{
    public partial class FrmTimKiem : Form
    {
        INhanVienReps _INvRp;
        int otp;
        Random rd = new Random();
        public FrmTimKiem()
        {
            _INvRp = new NhanVienReps();
            InitializeComponent();
        }

        private void anButtons1_Click(object sender, EventArgs e)
        {
            NhanVien nv = _INvRp.GetCheck(tb_email.Text);
            if (nv == null)
            {
                MessageBox.Show("Khong co tai khoan nao duoc lien ket voi email");
            }
            else
            {
                try
                {
                    otp = rd.Next(100000, 1000000);
                    var fromadress = new MailAddress("nhamtuandat.first@gmail.com");//mail gửi
                    var toaddress = new MailAddress(tb_email.ToString());//mail nhận
                    const string frompass = "qpoagvokegkkfbhb";//mã xác thực 2 lớp
                    const string subject = "Mã xác thực";
                    string body = otp.ToString();
                    var stmp = new SmtpClient()
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromadress.Address, frompass),
                        Timeout = 20000,
                    };
                    using (
                        var message = new MailMessage(fromadress, toaddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                    {
                        stmp.Send(message);
                    }
                    MessageBox.Show($"Mã xác thực OTP đã được gửi tới email:{tb_email.Text}", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void anButtons2_Click(object sender, EventArgs e)
        {
            NhanVien nv = _INvRp.GetCheck(tb_email.Text);
            if (otp != Convert.ToInt32(tb_otp.Text))
            {
                MessageBox.Show("Ma OTP khong chinh xac");
            }
            else
            {
                MessageBox.Show("Xac thuc thanh cong");
                FrmQuenMatKhau frmqmk = new FrmQuenMatKhau();
                frmqmk._nv = nv;
                frmqmk.ShowDialog();
            }
        }
    }
}
