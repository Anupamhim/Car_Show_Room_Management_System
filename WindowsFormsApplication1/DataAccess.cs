using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using LinqToSqlShared;
using System.IO;

namespace WindowsFormsApplication1
{
    class DataAccess
    {
        CarShowRoomDataContext con = new CarShowRoomDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");

        public DataAccess()
        {


        }

        public void insertBankPolicy(TextBox id, TextBox bankName, TextBox bankBranch, TextBox bankAddress, TextBox bankImage)
        {

            BankPolicy bp = new BankPolicy();

            bp.Id = int.Parse(id.Text);
            bp.BankName = bankName.Text;
            bp.Branch = bankBranch.Text;
            bp.Address = bankAddress.Text;
            bp.Image = bankImage.Text;
            con.BankPolicies.InsertOnSubmit(bp);
            con.SubmitChanges();
        }


        public void insertBranch(TextBox id, TextBox branchName, TextBox branchAddress, TextBox mobile, TextBox city)
        {

            Branch b = new Branch();


            b.Id = int.Parse(id.Text);
            b.BranchName= branchName.Text;
            b.Address = branchAddress.Text;
            b.Mobile = mobile.Text;
            b.City = city.Text;

            con.Branches.InsertOnSubmit(b);
            con.SubmitChanges();
        }

        public void insertDealer(TextBox id,TextBox fname, TextBox lname, TextBox email, TextBox mobile, TextBox address, TextBox Brand, TextBox company,TextBox image)
        {

            Dealer d = new Dealer();

            d.Id = int.Parse(id.Text);
            d.F_Name = fname.Text;
            d.L_Name = lname.Text;
            d.Email = email.Text;
            d.Mobile = mobile.Text;
            d.Address = address.Text;
            d.Brand = Brand.Text;
            d.Company = company.Text;
            d.Image = image.Text;

            con.Dealers.InsertOnSubmit(d);
            con.SubmitChanges();
        }


        public void insertCar(TextBox id, TextBox dealerId, TextBox brand, TextBox model, TextBox color, TextBox engineNo, TextBox price,TextBox image)
        {
            Car c = new Car();

            c.Id = int.Parse(id.Text);
            c.DealerId = int.Parse(dealerId.Text);
            c.Brand = brand.Text;
            c.Model = model.Text;
            c.Color = color.Text;
            c.EngineNo = engineNo.Text;
            c.Price = float.Parse(price.Text);
            c.Image = image.Text;

            con.Cars.InsertOnSubmit(c);
            con.SubmitChanges();
        }

        public void insertCustomer(TextBox id, TextBox fname, TextBox lname, TextBox email, TextBox mobile, TextBox address, TextBox carid, DateTimePicker bdate)
        {
            Customer cus = new Customer();

            cus.Id = int.Parse(id.Text);
            cus.F_Name = fname.Text;
            cus.L_Name = lname.Text;
            cus.Email = email.Text;
            cus.Mobile = mobile.Text;
            cus.Address = address.Text;
            cus.CarId = int.Parse(carid.Text);
            string Date = bdate.Value.Date.ToString("dd.MM.yyyy");
            cus.Buying_Date = Date;


            con.Customers.InsertOnSubmit(cus);
            con.SubmitChanges();
        }

        public void insertEmployee(TextBox id, TextBox fname, TextBox lname, TextBox email, DateTimePicker joinDate, TextBox mobile, DateTimePicker dateofBirth, TextBox address, TextBox salary, TextBox jobType, TextBox image)
        {
            Emp e = new Emp();

            e.Id = int.Parse(id.Text);
            e.F_Name = fname.Text;
            e.L_Name = lname.Text;
            e.Email = email.Text;
            string jD = joinDate.Value.Date.ToString("dd.MM.yyyy");
            e.JoinDate = jD;
            e.Mobile = mobile.Text;
            string doB = dateofBirth.Value.Date.ToString("dd.MM.yyyy");
            e.DateofBirth = doB;
            
            e.Address = address.Text;
            e.Salary = float.Parse(salary.Text);
            e.JobType = jobType.Text;
            e.Image = image.Text;

            con.Emps.InsertOnSubmit(e);
            con.SubmitChanges();
        }


        
        //update code


        public void updateBranch(TextBox id, TextBox bname, TextBox address, TextBox mobile, TextBox city)
        {
            var str = from a in con.Branches
                      where a.Id == int.Parse(id.Text)
                      select a;
            Branch b = str.First();
            b.BranchName = bname.Text;
            b.Address = bname.Text;
            b.Mobile = bname.Text;
            b.City = bname.Text;

            con.SubmitChanges();
        }

        public void updateBankPolicy(TextBox id, TextBox bname, TextBox branch, TextBox address, TextBox image)
        {
            var str = from a in con.BankPolicies
                      where a.Id == int.Parse(id.Text)
                      select a;
            BankPolicy b = str.First();
            b.BankName = bname.Text;
            b.Branch = branch.Text;
            b.Address = address.Text;
            b.Image = image.Text;

            con.SubmitChanges();

        }

        public void updateCar(TextBox id, TextBox brand, TextBox model, TextBox color, TextBox engineNo, TextBox price,TextBox image)
        {
            var str = from a in con.Cars
                      where a.Id == int.Parse(id.Text)
                      select a;

            Car c = str.First();
            c.Brand = brand.Text;
            c.Model = model.Text;
            c.Color = color.Text;
            c.EngineNo = engineNo.Text;
            c.Price = float.Parse(price.Text);
            c.Image = image.Text;

            con.SubmitChanges();
        }

        public void updateDealer(TextBox id, TextBox fname, TextBox lname, TextBox email, TextBox mobile, TextBox address, TextBox brand, TextBox company, TextBox image)
        {
            var str = from a in con.Dealers
                      where a.Id == int.Parse(id.Text)
                      select a;

            Dealer d = str.First();
            d.F_Name = fname.Text;
            d.L_Name = lname.Text;
            d.Email = email.Text;
            d.Mobile = mobile.Text;
            d.Address = address.Text;
            d.Brand = brand.Text;
            d.Company = company.Text;
            d.Image = image.Text;

            con.SubmitChanges();
        }

        public void updateCustomer(TextBox id, TextBox fname, TextBox lname, TextBox email, TextBox mobile, TextBox address, TextBox carId, DateTimePicker byingDate)
        {
            var str = from a in con.Customers
                      where a.Id == int.Parse(id.Text)
                      select a;

            Customer cus = str.First();
            cus.F_Name = fname.Text;
            cus.L_Name = lname.Text;
            cus.Email = email.Text;
            cus.Mobile = mobile.Text;
            cus.Address = address.Text;
            string bdate = byingDate.Value.Date.ToString("dd.MM.yyyy");
            cus.Buying_Date = bdate;

            con.SubmitChanges();
        }

        public void updateEmp(TextBox id, TextBox fname, TextBox lname, TextBox email, DateTimePicker joinDate, TextBox mobile, DateTimePicker dateofBirth, TextBox address, TextBox salary, TextBox jobType, TextBox image)
        {
            var str = from a in con.Emps
                      where a.Id == int.Parse(id.Text)
                      select a;
            Emp e = str.First();
            e.F_Name = fname.Text;
            e.L_Name = lname.Text;
            e.Email = email.Text;
            string jD = joinDate.Value.Date.ToString("dd.MM.yyyy");
            e.JoinDate = jD;
            e.Mobile = mobile.Text;
            string doB = dateofBirth.Value.Date.ToString("dd.MM.yyyy");
            e.DateofBirth = doB;
            e.Address = address.Text;
            e.Salary = float.Parse(salary.Text);
            e.JobType = jobType.Text;
            e.Image = image.Text;
            con.SubmitChanges();

        }

        public void updateProfile(TextBox id, TextBox pass)
        {
            var str = from a in con.LogIns
                      where a.UserId == int.Parse(id.Text)
                      select a;

            LogIn cus = str.First();
            cus.Password = pass.Text;
            con.SubmitChanges();
        }


        //Show detail


        public void showBankPolicy(DataGridView d)
        {
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  Id, BankName, Branch, Image, Address FROM BankPolicy", conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();
            /*var results = from DataRow myRow in dt.Rows
                          select myRow;
            d.DataSource = results;
            */

        }

        public void showEmployees(DataGridView d)
        {
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  * FROM Emp", conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();
            

        }

        public void showDealers(DataGridView d)
        {
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\aaj+kerC#\Car-Showroom Management System15\Car-Showroom Management System3\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  * FROM Dealer", conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();
         

        }

        public void showCustomers(DataGridView d)
        {
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  * FROM Customer", conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();
           

        }

        public void showCars(DataGridView d)
        {
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  * FROM Car", conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();
           

        }

        public void showBranch(DataGridView d)
        {
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  * FROM Branch", conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();
          

        }


        //Login Code'

        public bool logInVerifi(TextBox id, TextBox pass)
        {

           
            bool i = false;
            /*string str = (from a in con.LogIns
                         where a.UserId == int.Parse(id.Text) && a.Password == pass.Text
                         select a.Password).First().ToString();
             * */
            if (pass.Text == (from a in con.LogIns
                         where a.UserId == int.Parse(id.Text) && a.Password == pass.Text
                         select a.Password).First().ToString())
            {
                i = true;
            }
            else
            {
                i = false;
            }
            return i;
        }  






        //delete code******************************
        public void deleteCustomer(TextBox id)
        {
            var str = from a in con.Customers
                      where a.Id == int.Parse(id.Text)
                      select a;
            Customer c = str.First();
            con.Customers.DeleteOnSubmit(c);
            con.SubmitChanges();
        }

        public void deleteBankPolicy(TextBox id)
        {
            var str = from a in con.BankPolicies
                      where a.Id == int.Parse(id.Text)
                      select a;
            BankPolicy c = str.First();
            con.BankPolicies.DeleteOnSubmit(c);
            con.SubmitChanges();
        }

        public void deleteBranch(TextBox id)
        {
            var str = from a in con.Branches
                      where a.Id == int.Parse(id.Text)
                      select a;
            Branch c = str.First();
            con.Branches.DeleteOnSubmit(c);
            con.SubmitChanges();
        }

        public void deleteCar(TextBox id)
        {
            var str = from a in con.Cars
                      where a.Id == int.Parse(id.Text)
                      select a;
            Car c = str.First();
            con.Cars.DeleteOnSubmit(c);
            con.SubmitChanges();
        }

        public void deleteDealer(TextBox id)
        {
            var str = from a in con.Dealers
                      where a.Id == int.Parse(id.Text)
                      select a;
            Dealer c = str.First();
            con.Dealers.DeleteOnSubmit(c);
            con.SubmitChanges();
        }

        public void deleteEmployee(TextBox id)
        {
            var str = from a in con.Emps
                      where a.Id == int.Parse(id.Text)
                      select a;
            Emp c = str.First();
            con.Emps.DeleteOnSubmit(c);
            con.SubmitChanges();
        }




        //*********************picture

        public void retrieveBankPolicy(PictureBox p, TextBox id, DataGridView d)
        {
            var str = from a in con.BankPolicies
                      where a.Id == int.Parse(id.Text)
                      select a;
            BankPolicy b = str.First();
            string s = b.Image;
            string ipath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @s);
            p.Image = System.Drawing.Image.FromFile(ipath);


            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  Id, BankName, Branch, Image, Address FROM BankPolicy where Id ="+id.Text, conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();
            
        }


        public void retrieveDealer(PictureBox p, TextBox id, DataGridView d)
        {
            var str = from a in con.Dealers
                      where a.Id == int.Parse(id.Text)
                      select a;
            Dealer b = str.First();
            string s = b.Image;
            string ipath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @s);
            p.Image = System.Drawing.Image.FromFile(ipath);


            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  Id, F_Name,L_Name,Email,Mobile, Address , Brand, Company,Image FROM Dealer where Id =" + id.Text, conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();

        }

        public void retrieveEmp(PictureBox p, TextBox id, DataGridView d)
        {
            var str = from a in con.Emps
                      where a.Id == int.Parse(id.Text)
                      select a;
            Emp b = str.First();
            string s = b.Image;
            string ipath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @s);
            p.Image = System.Drawing.Image.FromFile(ipath);


            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  * FROM Emp where Id =" + id.Text, conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();

        }

        public void retrieveCar(PictureBox p, TextBox id, DataGridView d)
        {
            var str = from a in con.Cars
                      where a.Id == int.Parse(id.Text)
                      select a;
            Car b = str.First();
            string s = b.Image;
            string ipath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @s);
            p.Image = System.Drawing.Image.FromFile(ipath);


            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\varsity\C#\Car-Showroom Management System\WindowsFormsApplication1\CarShowDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT  * FROM Car where Id =" + id.Text, conc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            d.DataSource = dt;
            conc.Close();

        }






        /*public bool loginVarify(string UserName , string  PassWord){
           var sql="Select count(*) from Login where UserName = '" + UserName + "'and PassWord = '" + PassWord + "'";
           //string sql = "select * from Login";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
         
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else return false;
        
        }*/
    }
}

