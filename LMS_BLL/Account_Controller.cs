using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using LMS_DAL;
using LMS_INFO;

namespace LMS_BLL
{
    public class Account_Controller
    {
        Account_DataAccess data_access;

        public enum Status
        {
            ActiveTrueAdmin, ActiveTrue, Active_False, NotExist, Ban
        }

        public Account_Controller()
        {
            data_access = new Account_DataAccess();
        }

        public Account_Collection Select_Account()
        {
            Account_Collection collection = new Account_Collection();
            Account_Info info;
            IDataReader reader = data_access.SelectAccount();

            while (reader.Read())
            {
                info = new Account_Info();

                info.Accountid = Convert.ToString(reader["accountid"]);
                info.Username = Convert.ToString(reader["username"]);

                collection.Add(info);
            }
            reader.Close();

            return collection;
        }

        public Status CheckAccount(string accountid, string password)
        {
            Account_Info info = new Account_Info();
            IDataReader reader = data_access.CheckAccount(accountid, password);

            if (reader.Read())
            {
                if ((Convert.ToString(reader["AccountStatus"]).Equals("yes")) && (Convert.ToString(reader["AccountType"]).Equals("Admin")))
                {
                    reader.Close();
                    return Status.ActiveTrueAdmin;
                }
                else if (Convert.ToString(reader["AccountStatus"]).Equals("yes"))
                {
                    reader.Close();
                    return Status.ActiveTrue;
                }
                else if (Convert.ToString(reader["AccountStatus"]).Equals("ban"))
                {
                    reader.Close();
                    return Status.Ban;
                }
                else
                {
                    reader.Close();
                    return Status.Active_False;
                }
            }
            else
            {
                reader.Close();
                return Status.NotExist;
            }
        }

        public Account_Info SelectAccountInfo(string accountid)
        {
            Account_Info info = new Account_Info();
            IDataReader reader = data_access.SelectAccountInfo(accountid);

            if (reader.Read())
            {
                info.Accountid = Convert.ToString(reader["accountid"]);
                info.Username = Convert.ToString(reader["username"]);
                info.Password = Convert.ToString(reader["password"]);
                info.Accounttype = Convert.ToString(reader["accounttype"]);
                info.Accountstatus = Convert.ToString(reader["accountstatus"]);
                info.Librarianid = Convert.ToInt32(reader["Librarianid"]);
            }
            reader.Close();

            return info;
        }

        public void UpdatePassword(string accountid, string password)
        {
            data_access.UpdatePassword(accountid, password);
        }

    }

    public class Account_Collection : Collection<Account_Info>
    {

    }
}
