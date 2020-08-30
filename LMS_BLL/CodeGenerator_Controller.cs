using System;
using System.Collections.Generic;
using System.Text;
using LMS_DAL;

namespace LMS_BLL
{
    public class CodeGenerator_Controller
    {
        CodeGenerator_DataAccess dataaccess;

        public CodeGenerator_Controller()
        {
            dataaccess = new CodeGenerator_DataAccess();
        }

        public long Select_MemberCode()
        {
            return dataaccess.Select_MemberCode();
        }

        public long Select_BookCode(int CategoryId)
        {
            return dataaccess.Select_BookCode(CategoryId);
        }
    }
}
