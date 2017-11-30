﻿using SchoolJounal.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJounal.Data
{
    public class AppContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<SchoolClassSubject> SchoolClassSubjects { get; set; }
        public DbSet<TeacherSchoolClass> TeacherSchoolClasses { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
    }
}