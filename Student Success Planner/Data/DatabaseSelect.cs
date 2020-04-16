﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Student_Success_Planner.Data
{
    public class DatabaseSelect
    {
        DBConnector Connector = new DBConnector();

        private string Statement = "";

        //Selects all College table information from the database
        public IEnumerable<System.Data.IDataRecord> SelectColleges()
        {
            Statement = "SELECT * FROM College";

            return Connector.QueryDatabase(Statement);
        }

        //Selects all Department table information with a CollegeID
        public IEnumerable<System.Data.IDataRecord> SelectDepartments(int CID)
        {
            Statement = "Select * FROM Department WHERE CollegeID =" + CID;

            return Connector.QueryDatabase(Statement);
        }

        //Selects all Program table information with a DepartmentID
        public IEnumerable<System.Data.IDataRecord> SelectProgram(int DID)
        {
            Statement = "Select * FROM Program WHERE DeptID =" + DID;

            return Connector.QueryDatabase(Statement);
        }

        //Selects all SuccessMap table information with a ProgramID
        public IEnumerable<System.Data.IDataRecord> SelectSuccessMap(int PID)
        {
            Statement = "Select * FROM SuccessMap WHERE PrgmID =" + PID;

            return Connector.QueryDatabase(Statement);
        }

        //Objective ID to select Objective info
        public IEnumerable<System.Data.IDataRecord> SelectObjective(int OID)
        {
            Statement = "Select * FROM Objective WHERE ObjectiveID =" + OID;

            return Connector.QueryDatabase(Statement);
        }

        //Select all years
        public IEnumerable<System.Data.IDataRecord> SelectAllYears()
        {
            Statement = "Select * FROM Year";

            return Connector.QueryDatabase(Statement);
        }

        //Year to select Year info
        public IEnumerable<System.Data.IDataRecord> SelectYear(int Yr)
        {
            Statement = "Select * FROM Year WHERE Year =" + Yr;

            return Connector.QueryDatabase(Statement);
        }

        //Year to select semesters
        public IEnumerable<System.Data.IDataRecord> SelectSemester(int Yr)
        {
            Statement = "Select * FROM  Semester WHERE Year =" + Yr;

            return Connector.QueryDatabase(Statement);
        }

        //Success Category ID to select Success Category info
        public IEnumerable<System.Data.IDataRecord> SelectCategory(int CID)
        {
            Statement = "Select * FROM SuccessCategory WHERE CategoryID =" + CID;

            return Connector.QueryDatabase(Statement);
        }

        //Objective ID to select Success Objective map
        public IEnumerable<System.Data.IDataRecord> SelectSuccessObjMapObjective(int OID)
        {
            Statement = "Select * FROM SuccessObjectiveMapping WHERE ObjID =" + OID;

            return Connector.QueryDatabase(Statement);
        }

        //Semester ID to select Success Objective map
        public IEnumerable<System.Data.IDataRecord> SelectSuccessObjMapSemester(int SID)
        {
            Statement = "Select * FROM SuccessObjectiveMapping WHERE SMID =" + SID;

            return Connector.QueryDatabase(Statement);
        }

    }
}