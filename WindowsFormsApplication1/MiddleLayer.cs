using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MiddleLayer
    {
        public MiddleLayer()
        { 
        }

        public void addBankPolicy(TextBox id, TextBox bankName, TextBox bankBranch, TextBox bankAddress, TextBox bankImage)
        {
            DataAccess da = new DataAccess();
            da.insertBankPolicy(id, bankName, bankBranch,bankAddress ,bankImage);
            MessageBox.Show("Successfully saved");
        }

        public void addBranch(TextBox id, TextBox branchName, TextBox branchAddress, TextBox mobile, TextBox city)
        {
            DataAccess da = new DataAccess();
            da.insertBranch(id, branchName, branchAddress, mobile, city);
            MessageBox.Show("Successfully saved");
        }

        public void addCar(TextBox id, TextBox dealerId, TextBox brand, TextBox model, TextBox color, TextBox engineNo, TextBox price,TextBox image)
        {
            DataAccess da = new DataAccess();
            da.insertCar(id, dealerId, brand, model, color, engineNo, price,image);
            MessageBox.Show("Successfully saved");
        }

        public void addDealer(TextBox id, TextBox fname, TextBox lname, TextBox email, TextBox mobile, TextBox address, TextBox Brand, TextBox company, TextBox image)
        {
            DataAccess da = new DataAccess();
            da.insertDealer(id,fname, lname, email,mobile, address, Brand,company,image);
            MessageBox.Show("Successfully saved");
        }

        public void addCustomer(TextBox id, TextBox fname, TextBox lname, TextBox email, TextBox mobile, TextBox address, TextBox carid, DateTimePicker bdate)
        {
            DataAccess da = new DataAccess();
            da.insertCustomer(id, fname, lname, email, mobile, address, carid, bdate);
            MessageBox.Show("Successfully saved");
        }

        public void addEmp(TextBox id, TextBox fname, TextBox lname, TextBox email, DateTimePicker joinDate, TextBox mobile, DateTimePicker dateofBirth, TextBox address, TextBox salary, TextBox jobType, TextBox image)
        {
            DataAccess da = new DataAccess();
            da.insertEmployee(id, fname, lname, email,joinDate , mobile, dateofBirth, address,salary,jobType,image);
            MessageBox.Show("Successfully saved");
        }


        //Edit Employee
        public void editBranch(TextBox id, TextBox bname, TextBox address, TextBox mobile, TextBox city)
        {
            DataAccess da = new DataAccess();
            da.updateBranch(id,bname,address,mobile,city);
            MessageBox.Show("Successfully Updated");
        }

        public void editBankPolicy(TextBox id, TextBox bname, TextBox branch, TextBox address, TextBox image)
        {
            DataAccess da = new DataAccess();
            da.updateBankPolicy(id, bname, branch, address, image);
            MessageBox.Show("Successfully Updated");
        }
        public void editEmp(TextBox id, TextBox fname, TextBox lname, TextBox email, DateTimePicker joinDate, TextBox mobile, DateTimePicker dateofBirth, TextBox address, TextBox salary, TextBox jobType, TextBox image)
        {
            DataAccess da = new DataAccess();
            da.updateEmp(id, fname, lname, email, joinDate, mobile, dateofBirth, address, salary, jobType, image);
            MessageBox.Show("Successfully Updated");
        }


        public void editCar(TextBox id, TextBox brand, TextBox model, TextBox color, TextBox engineNo, TextBox price,TextBox image)
        {
            DataAccess da = new DataAccess();
            da.updateCar(id, brand, model, color,engineNo, price,image);
            MessageBox.Show("Successfully Updated");
        }


        public void editDealer(TextBox id, TextBox fname, TextBox lname, TextBox email, TextBox mobile, TextBox address, TextBox brand, TextBox company, TextBox image)
        {
            DataAccess da = new DataAccess();
            da.updateDealer(id, fname, lname, email, mobile, address, brand, company, image);
            MessageBox.Show("Successfully Updated");
        }


        public void editCustomer(TextBox id, TextBox fname, TextBox lname, TextBox email, TextBox mobile, TextBox address, TextBox carId, DateTimePicker byingDate)
        {
            DataAccess da = new DataAccess();
            da.updateCustomer(id, fname, lname, email, mobile, address, carId, byingDate);
            MessageBox.Show("Successfully Updated");
        }


         public void editProfile(TextBox id, TextBox pass)
        {
            DataAccess da = new DataAccess();
            da.updateProfile(id, pass);
            MessageBox.Show("Successfully Updated");
        }


        


        //************************show Detail

        public void viewBankPolicy(DataGridView d)
        {
            DataAccess da = new DataAccess();
            da.showBankPolicy(d);
            //MessageBox.Show("");

        }

        public void viewEmployee(DataGridView d)
        {
            DataAccess da = new DataAccess();
            da.showEmployees(d);
            //MessageBox.Show("");

        }
        public void viewDealer(DataGridView d)
        {
            DataAccess da = new DataAccess();
            da.showDealers(d);
            //MessageBox.Show("");

        }
        public void viewCustomer(DataGridView d)
        {
            DataAccess da = new DataAccess();
            da.showCustomers(d);
            //MessageBox.Show("");

        }
        public void viewBranch(DataGridView d)
        {
            DataAccess da = new DataAccess();
            da.showBranch(d);
            //MessageBox.Show("");

        }
        public void viewCar(DataGridView d)
        {
            DataAccess da = new DataAccess();
            da.showCars(d);
            //MessageBox.Show("");

        }


        //login*****************
        public bool fd(TextBox id, TextBox pass)
        {
            DataAccess da = new DataAccess();
            bool i = da.logInVerifi(id, pass);
            return i;
        }




        //delete*****************
        public void delCustomer(TextBox id)
        {
            DataAccess da = new DataAccess();
            da.deleteCustomer(id);
            MessageBox.Show("Deleted Successfully");

        }

        public void delBankPolicy(TextBox id)
        {
            DataAccess da = new DataAccess();
            da.deleteBankPolicy(id);
            MessageBox.Show("Deleted Successfully");

        }

        public void delBranch(TextBox id)
        {
            DataAccess da = new DataAccess();
            da.deleteBranch(id);
            MessageBox.Show("Deleted Successfully");

        }

        public void delCar(TextBox id)
        {
            DataAccess da = new DataAccess();
            da.deleteCar(id);
            MessageBox.Show("Deleted Successfully");

        }

        public void delDealer(TextBox id)
        {
            DataAccess da = new DataAccess();
            da.deleteDealer(id);
            MessageBox.Show("Deleted Successfully");

        }

        public void delEmployee(TextBox id)
        {
            DataAccess da = new DataAccess();
            da.deleteEmployee(id);
            MessageBox.Show("Deleted Successfully");

        }

        //***********************picture

        public void retBankPolicy(PictureBox p,TextBox t, DataGridView dd)
        {
            DataAccess da = new DataAccess();
            da.retrieveBankPolicy(p,t,dd);
 
        }

        public void retDealer(PictureBox p, TextBox t, DataGridView dd)
        {
            DataAccess da = new DataAccess();
            da.retrieveDealer(p, t, dd);

        }

        public void retEmp(PictureBox p, TextBox t, DataGridView dd)
        {
            DataAccess da = new DataAccess();
            da.retrieveEmp(p, t, dd);

        }


        public void retCar(PictureBox p, TextBox t, DataGridView dd)
        {
            DataAccess da = new DataAccess();
            da.retrieveCar(p, t, dd);

        }
       /* public void retBankPolicy(PictureBox p, TextBox t, DataGridView dd)
        {
            DataAccess da = new DataAccess();
            da.retrieveBankPolicy(p, t, dd);

        }*/


    }
        
    
}
