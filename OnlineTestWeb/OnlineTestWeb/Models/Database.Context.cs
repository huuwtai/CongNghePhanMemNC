﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineTestWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_HeThongThiTracNghiemEntities : DbContext
    {
        public QL_HeThongThiTracNghiemEntities()
            : base("name=QL_HeThongThiTracNghiemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bài_Làm> Bài_Làm { get; set; }
        public virtual DbSet<Câu_Hỏi> Câu_Hỏi { get; set; }
        public virtual DbSet<Đề_Thi> Đề_Thi { get; set; }
        public virtual DbSet<Đoạn_Văn> Đoạn_Văn { get; set; }
        public virtual DbSet<Giáo_Viên> Giáo_Viên { get; set; }
        public virtual DbSet<Học_Sinh> Học_Sinh { get; set; }
        public virtual DbSet<Khoá_Học> Khoá_Học { get; set; }
        public virtual DbSet<Loại_Đề> Loại_Đề { get; set; }
        public virtual DbSet<Lớp> Lớp { get; set; }
        public virtual DbSet<Môn_Học> Môn_Học { get; set; }
        public virtual DbSet<Nhóm_Câu_Hỏi> Nhóm_Câu_Hỏi { get; set; }
        public virtual DbSet<Phân_Quyền> Phân_Quyền { get; set; }
        public virtual DbSet<Tài_Khoản> Tài_Khoản { get; set; }
    }
}