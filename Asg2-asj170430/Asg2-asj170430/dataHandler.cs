using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Asg2_asj170430
{
    class dataHandler
    {
        //checks whether the field is empty
        public string isDataEmpty(GetterSetterClass data)
        {
            string err = "";
            if (data.firstName == ""){err += "Please enter First name";}
            if (data.middleInitial == "") { err += "Please enter Middle name Initial"; }
            if (data.lastName == "") { err += "Please enter Last name"; }
            if (data.gender == "") { err += "Please enter Gender"; }
            if (data.phone == "") { err += "Please enter Phone number"; }
            if (data.email == "") { err += "Please enter email"; }
            if (data.address1 == "") { err += "Please enter address details"; }
            if (data.city == "") { err += "Please enter city"; }
            if (data.state == "") { err += "Please enter state of residence"; }
            if (data.zipcode == "") { err += "Please enter your zipcode"; }
            if (data.date == "") { err += "Please enter date of recieved"; }
            if (data.purchase == "") { err += "Please enter wether you have attached the proof of purchase"; }
            return err;

        }
        //checks regex for numerical phone and zip numbers
        public string isDataValid(GetterSetterClass data)
        {
            string err = "";
            Regex phoneCheck = new Regex(@"^\d{10}$");
            Regex zipCheck = new Regex(@"^\d{5}$");

            if(zipCheck.IsMatch(data.zipcode) == false) { err += "zipcode should be numerical 5 digit \n"; }
            if(phoneCheck.IsMatch(data.phone) == false) { err += "Phone number should be numerical 10 digit \n"; }
            if(data.gender != "M" && data.gender != "F"){ err += "Gender should be M/F"; }
            if(data.purchase != "YES" && data.purchase != "NO") { err += "Please provide YES/NO wether proof of purchase is attached";}
            try{var email = new System.Net.Mail.MailAddress(data.email);}catch (Exception){ err += "Invalid email"; }
            try {
                if(Convert.ToDateTime(data.date).Date > DateTime.Now.Date){err += "Invalid date";}
            }
            catch (Exception) { err += "Invalid date [DD/MM/YYYY]"; }
            return err;
        }

        //save data into file addbtn click event
        public bool saveFileData(GetterSetterClass data)
        {
            string writeData = "";
            string entireName;
            string phoneNumber;
            int isModify = 0;

            try
            {
                using (StreamReader reader = new StreamReader("CS6326Asg2.txt"))
                {
                    var oldData = new List<listSavedData>();
                    string record = reader.ReadLine();
                    while (record != null)
                    {
                        string[] dt = record.Split('\t');
                        entireName = dt[0] + " " + dt[2];
                        phoneNumber = dt[3];

                        if(entireName.ToLower() == (data.firstName.ToLower() + " " + data.lastName.ToLower()) || phoneNumber == data.phone)
                        {
                            isModify = 1;
                        }
                        record = reader.ReadLine();
                    }
                }

                if(isModify != 1)
                {
                    using(StreamWriter writer = File.AppendText("CS6326Asg2.txt"))
                    {
                        writeData = data.firstName + "\t" + data.middleInitial + "\t" + data.lastName + "\t" +
                            data.phone + "\t" + data.email + "\t" +
                            data.address1 + "\t" + data.address2 + "\t" + data.city + "\t" + data.state + "\t" + data.zipcode + "\t" +
                            data.gender + "\t" + data.purchase + "\t" + data.date + "\t" + data.firstClick + "\t" + data.addBtn + "\t" +
                            data.backSpace;
                        writer.WriteLine(writeData);
                    }
                    return true;
                }
                else { return false; }

            }
            catch(Exception)
            {
                using (StreamWriter writer = File.AppendText("CS6326Asg2.txt"))
                {
                    writeData = data.firstName + "\t" + data.middleInitial + "\t" + data.lastName + "\t" +
                        data.phone + "\t" + data.email + "\t" +
                        data.address1 + "\t" + data.address2 + "\t" + data.city + "\t" + data.state + "\t" + data.zipcode + "\t" +
                        data.gender + "\t" + data.purchase + "\t" + data.date + "\t" +data.firstClick + "\t" + data.addBtn + "\t" +
                        data.backSpace;
                    writer.WriteLine(writeData);
                }
                return true;
            }
        }

        //modify data firstly checks wether data exists if so updates the backSpace and new data
        public bool modifyFileData(GetterSetterClass data)
        {
            string oldData = data.firstName + "\t" + data.middleInitial + "\t" + data.lastName + "\t" +
                        data.phone + "\t" + data.email + "\t" +
                        data.address1 + "\t" + data.address2 + "\t" + data.city + "\t" + data.state + "\t" + data.zipcode + "\t" +
                        data.gender + "\t" + data.purchase + "\t" + data.date;
            string updateData = "";
            using (StreamReader reader= new StreamReader("CS6326Asg2.txt"))
            {
                string record = reader.ReadLine();
                while(record != "")
                {
                    string[] dt = record.Split('\t');
                    string entireName = dt[0] + " " + dt[2];
                    if (entireName.ToLower() == (data.firstName.ToLower() + " " + data.lastName.ToLower()))
                    {
                        oldData += "\t" + dt[13] + "\t" + dt[14] + "\t" + dt[15];
                        updateData = record;
                        break;
                    }
                    record = reader.ReadLine();
                }
            }
            try
            {
                string line = File.ReadAllText("CS6326Asg2.txt");
                line = line.Replace(updateData, oldData);
                File.WriteAllText("CS6326Asg2.txt", line);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        //deletion
        //creates new file 'FileTemp.txt' and copies that to original file
        //inspired from stackoverflow

        public bool deleteFileData(GetterSetterClass data)
        {
            try
            {
                using(StreamReader reader = new StreamReader("CS6326Asg2.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("FileTemp.txt"))
                    {
                        string record = reader.ReadLine();
                        while (record != null)
                        {
                            string[] dt = record.Split('\t');
                            string entireName = dt[0] + " " + dt[2];
                            if (entireName.ToLower() != (data.firstName.ToLower() + " " + data.lastName.ToLower()))
                            {
                                writer.WriteLine(record);
                            }
                            record = reader.ReadLine();
                        }
                    }
                }
                File.Delete("CS6326Asg2.txt");
                File.Move("FileTemp.txt", "CS6326Asg2.txt");
                return true;
            }catch(Exception)
            {
                return false;
            }
        }

        //datapopulate for listview item click

        public GetterSetterClass dataPopulate(string input)
        {
            using(StreamReader reader = new StreamReader("CS6326Asg2.txt"))
            {
                GetterSetterClass updateData = new GetterSetterClass();
                string[] inputDt = input.Split(' ');
                var oldData = new List<listSavedData>();
                string record = reader.ReadLine();
                while(record != null)
                {
                    string[] dt = record.Split('\t');
                    if(dt[0] == inputDt[0] && dt[2] == inputDt[1])
                    {
                        updateData.firstName = dt[0];
                        updateData.middleInitial = dt[1];
                        updateData.lastName = dt[2];
                        updateData.phone = dt[3];
                        updateData.email = dt[4];
                        updateData.address1 = dt[5];
                        updateData.address2 = dt[6];
                        updateData.city = dt[7];
                        updateData.state = dt[8];
                        updateData.zipcode = dt[9];
                        updateData.gender = dt[10];
                        updateData.purchase = dt[11];
                        updateData.date = dt[12];
                        break;
                    }
                    record = reader.ReadLine();
                }
                return updateData;
            } 
        }

        //list view updated list
        public List<listSavedData> updateListRecord()
        {
            try
            {
                using(StreamReader reader = new StreamReader("CS6326Asg2.txt"))
                {
                    Console.WriteLine("read file");
                    var oldData = new List<listSavedData>();
                    string record = reader.ReadLine();
                    while (record != null)
                    {
                       
                        string[] dt = record.Split('\t');
                        oldData.Add(new listSavedData
                        {
                            entireName = dt[0] + " " + dt[2],
                            phoneNumber = dt[3]
                        });
                        record = reader.ReadLine();
                    }
                    
                    return oldData;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occurred for file read");
                return new List<listSavedData>(); 
            }
        }
    }
}
