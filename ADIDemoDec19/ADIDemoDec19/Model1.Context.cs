﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADIDemoDec19
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database1Entities : DbContext
    {
        public Database1Entities()
            : base("name=Database1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<FeedbackType> FeedbackTypes { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectAssessment> SubjectAssessments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<WordCloud> WordClouds { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<AssessmentType> AssessmentTypes { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
