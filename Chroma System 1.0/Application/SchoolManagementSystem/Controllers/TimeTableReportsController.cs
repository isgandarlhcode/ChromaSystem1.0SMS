﻿using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class TimeTableReportsController : Controller
    {
        private SchoolMgtDbEntities db = new SchoolMgtDbEntities();
        // GET: TimeTableReports
        public ActionResult TeacherReport(int? id)
        {
            var teacherclas = db.TimeTblTables.Where(t => t.StaffID == id && t.IsActive == true).OrderByDescending(e => e.TimeTableID);
            return View(teacherclas);
        }

        public ActionResult TeacherWiseReport()
        {
            var teacherclas = db.TimeTblTables.Where(t=>t.IsActive == true).OrderBy(e => e.StaffID);
            return View(teacherclas);
        }

        public ActionResult StudentReport(int? id)
        {
            var classid = db.StudentPromotTables.Where(p => p.StudentID == id && p.IsActive == true).FirstOrDefault().ClassID;
           // var classsubjectids = db.ClassSubjectTables.Where(cls => cls.ClassID == classid && cls.IsActive == true);
            //List<TimeTblTable> timetable = new List<TimeTblTable>();
            //foreach (var clssubjectid in classsubjectids)
            //{
            //    var subjectime = db.TimeTblTables.Where(t => t.ClassSubjectTable.ClassID ==  ClassSubjectID == clssubjectid.ClassSubjectID && t.IsActive == true).FirstOrDefault();
            //    timetable.Add(new TimeTblTable
            //    {
            //        ClassSubjectID = subjectime.ClassSubjectID,
            //        Day = subjectime.Day,
            //        ClassSubjectTable = subjectime.ClassSubjectTable,
            //        EndTime = subjectime.EndTime,
            //        IsActive = subjectime.IsActive,
            //        StaffID = subjectime.StaffID,
            //        StaffTable = subjectime.StaffTable,
            //        StartTime = subjectime.StartTime,
            //        TimeTableID = subjectime.TimeTableID,
            //        UserID = subjectime.UserID,
            //        UserTable = subjectime.UserTable
            //    });

            //}
            var subjectime = db.TimeTblTables.Where(t => t.ClassSubjectTable.ClassID == classid && t.IsActive == true);
            return View(subjectime);
        }
    }
}