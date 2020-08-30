using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LMS_INFO;

namespace LMS_DAL
{
    public class Member_DataAccess : MyConnection
    {
        public void Insert_Member(Member_Info info)
        {
            sqlString = "spdMemberInsert";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@membertypeid", info.Membertypeid);
            command.Parameters.AddWithValue("@memberimage", info.Memberimagebyte);
            command.Parameters.AddWithValue("@memberbarcode", info.Memberbarcode);
            command.Parameters.AddWithValue("@Membername", info.Membername);
            command.Parameters.AddWithValue("@occupationid", info.Occupationid);
            command.Parameters.AddWithValue("@nrc", info.Nrc);
            command.Parameters.AddWithValue("@street", info.Street);
            command.Parameters.AddWithValue("@homeno", info.Homeno);
            command.Parameters.AddWithValue("@villageid", info.Villageid);
            command.Parameters.AddWithValue("@phoneno", info.Phoneno);
            command.Parameters.AddWithValue("@educationid", info.Educationid);
            command.Parameters.AddWithValue("@gender", info.Gender);
            command.Parameters.AddWithValue("@guarantor", info.Guarantor);
            command.Parameters.AddWithValue("@guarantoroccupation", info.Guarantoroccupation);
            command.Parameters.AddWithValue("@guarantornrc", info.Guarantornrc);
            command.Parameters.AddWithValue("@guarantoraddress", info.Guarantoraddress);
            command.Parameters.AddWithValue("@addedby", info.Addedby);
            command.Parameters.AddWithValue("@dateofbirth", info.Dateofbirth);
            command.Parameters.AddWithValue("@addeddate", info.Addeddate);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Member(Member_Info info)
        {
            sqlString = "spdMemberUpdate";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@memberid", info.Memberid);
            command.Parameters.AddWithValue("@membertypeid", info.Membertypeid);
            command.Parameters.AddWithValue("@memberimage", info.Memberimagebyte);
            command.Parameters.AddWithValue("@Membername", info.Membername);
            command.Parameters.AddWithValue("@occupationid", info.Occupationid);
            command.Parameters.AddWithValue("@nrc", info.Nrc);
            command.Parameters.AddWithValue("@street", info.Street);
            command.Parameters.AddWithValue("@homeno", info.Homeno);
            command.Parameters.AddWithValue("@villageid", info.Villageid);
            command.Parameters.AddWithValue("@phoneno", info.Phoneno);
            command.Parameters.AddWithValue("@educationid", info.Educationid);
            command.Parameters.AddWithValue("@gender", info.Gender);
            command.Parameters.AddWithValue("@guarantor", info.Guarantor);
            command.Parameters.AddWithValue("@guarantoroccupation", info.Guarantoroccupation);
            command.Parameters.AddWithValue("@guarantornrc", info.Guarantornrc);
            command.Parameters.AddWithValue("@guarantoraddress", info.Guarantoraddress);
            command.Parameters.AddWithValue("@addedby", info.Addedby);
            command.Parameters.AddWithValue("@memberstatus", info.Memberstatus);
            command.Parameters.AddWithValue("@dateofbirth", info.Dateofbirth);
            command.Parameters.AddWithValue("@addeddate", info.Addeddate);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IDataReader Select_Member(int selectType, string barcode, string name)
        {
            sqlString = "spdMemberSelect"; 
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@selectType", selectType);
            command.Parameters.AddWithValue("@memberbarcode", barcode);
            command.Parameters.AddWithValue("@membername", "%"+name+"%");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_MemberBasicInfo(string barcode, int selectType)
        {
            sqlString = "spdMemberBasicInfoSelect"; 
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@memberbarcode", barcode);
            command.Parameters.AddWithValue("@selectType", selectType);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_MemberForExpired()
        {
            sqlString = "spdMember";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public IDataReader Select_QtyOfMember()
        {
            sqlString = "spdQtyOfMember";
            command = new SqlCommand(sqlString, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_QtyOfMemberByAge()
        {
            sqlString = "SELECT DateOfBirth FROM tblMember WHERE MemberStatus='act' ";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_QtyOfMemberByOccupation()
        {
            sqlString = @"SELECT     TOP (100) PERCENT dbo.tblOccupation.Occupation, COUNT(dbo.tblMember.MemberId) AS qtyOfMember
FROM         dbo.tblOccupation INNER JOIN
                      dbo.tblMember ON dbo.tblOccupation.OccupationId = dbo.tblMember.OccupationId
WHERE     (dbo.tblMember.MemberStatus = 'act')
GROUP BY dbo.tblOccupation.Occupation
ORDER BY dbo.tblOccupation.Occupation";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_QtyOfMemberByEducation()
        {
            sqlString = @"SELECT     TOP (100) PERCENT dbo.tblEducation.Education, COUNT(dbo.tblMember.MemberId) AS qtyOfMember
FROM         dbo.tblEducation INNER JOIN
                      dbo.tblMember ON dbo.tblEducation.EducationId = dbo.tblMember.EducationId
WHERE     (dbo.tblMember.MemberStatus = 'act')
GROUP BY dbo.tblEducation.Education
ORDER BY dbo.tblEducation.Education";
            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_QtyMemberByState(int stateid)
        {
            sqlString = @"SELECT     COUNT(tblMember.MemberId) AS QtyOfMember
FROM         tblStateDivision INNER JOIN
                      tblTownship ON tblStateDivision.StateId = tblTownship.StateId INNER JOIN
                      tblVillage ON tblTownship.TownshipId = tblVillage.TownshipId INNER JOIN
                      tblMember ON tblVillage.VillageId = tblMember.VillageId
WHERE     (tblMember.MemberStatus = 'act') AND (tblStateDivision.StateId = @stateid)";

            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@stateid", stateid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_QtyMemberByTownship(int stateid)
        {
            sqlString = @"SELECT     tblTownship.Township, COUNT(tblMember.MemberId) AS QtyOfMember
FROM         tblTownship INNER JOIN
                      tblVillage ON tblTownship.TownshipId = tblVillage.TownshipId INNER JOIN
                      tblMember ON tblVillage.VillageId = tblMember.VillageId
WHERE     (tblMember.MemberStatus = 'act') AND (tblTownship.StateId = @stateid)
GROUP BY tblTownship.Township
ORDER BY tblTownship.Township";

            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@stateid", stateid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_QtyMemberByVillage(int townshipid)
        {
            sqlString = @"SELECT     tblVillage.Village, COUNT(tblMember.MemberId) AS QtyOfMember
FROM         tblVillage INNER JOIN
                      tblMember ON tblVillage.VillageId = tblMember.VillageId
WHERE     (tblMember.MemberStatus = 'act') AND (tblVillage.TownshipId = @townshipid)
GROUP BY tblVillage.Village";

            command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@townshipid", townshipid);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader Select_QtyMemberByType()
        {
            sqlString = @"SELECT     COUNT(MemberId) AS qtyOfMember, dbo.tblMemberType.MemberType
FROM         dbo.tblMemberType INNER JOIN
                      dbo.tblMember ON dbo.tblMemberType.MemberTypeId = dbo.tblMember.MemberTypeId
WHERE     (dbo.tblMember.MemberStatus = 'act')
GROUP BY dbo.tblMember.MemberTypeId, dbo.tblMemberType.MemberType";

            command = new SqlCommand(sqlString, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
