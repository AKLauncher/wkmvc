﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<COM_CONTENT> COM_CONTENT { get; set; }
        public virtual DbSet<COM_DAILYS> COM_DAILYS { get; set; }
        public virtual DbSet<COM_UPLOAD> COM_UPLOAD { get; set; }
        public virtual DbSet<COM_WORKATTENDANCE> COM_WORKATTENDANCE { get; set; }
        public virtual DbSet<MAIL_ATTACHMENT> MAIL_ATTACHMENT { get; set; }
        public virtual DbSet<MAIL_INBOX> MAIL_INBOX { get; set; }
        public virtual DbSet<MAIL_OUTBOX> MAIL_OUTBOX { get; set; }
        public virtual DbSet<PRO_PROJECT_FILES> PRO_PROJECT_FILES { get; set; }
        public virtual DbSet<PRO_PROJECT_MESSAGE> PRO_PROJECT_MESSAGE { get; set; }
        public virtual DbSet<PRO_PROJECT_STAGES> PRO_PROJECT_STAGES { get; set; }
        public virtual DbSet<PRO_PROJECT_TEAMS> PRO_PROJECT_TEAMS { get; set; }
        public virtual DbSet<PRO_PROJECTS> PRO_PROJECTS { get; set; }
        public virtual DbSet<SYS_BUSSINESSCUSTOMER> SYS_BUSSINESSCUSTOMER { get; set; }
        public virtual DbSet<SYS_CHATMESSAGE> SYS_CHATMESSAGE { get; set; }
        public virtual DbSet<SYS_CODE> SYS_CODE { get; set; }
        public virtual DbSet<SYS_CODE_AREA> SYS_CODE_AREA { get; set; }
        public virtual DbSet<SYS_DEPARTMENT> SYS_DEPARTMENT { get; set; }
        public virtual DbSet<SYS_LOG> SYS_LOG { get; set; }
        public virtual DbSet<SYS_MODULE> SYS_MODULE { get; set; }
        public virtual DbSet<SYS_PERMISSION> SYS_PERMISSION { get; set; }
        public virtual DbSet<SYS_POST> SYS_POST { get; set; }
        public virtual DbSet<SYS_POST_DEPARTMENT> SYS_POST_DEPARTMENT { get; set; }
        public virtual DbSet<SYS_POST_USER> SYS_POST_USER { get; set; }
        public virtual DbSet<SYS_ROLE> SYS_ROLE { get; set; }
        public virtual DbSet<SYS_ROLE_PERMISSION> SYS_ROLE_PERMISSION { get; set; }
        public virtual DbSet<SYS_SYSTEM> SYS_SYSTEM { get; set; }
        public virtual DbSet<SYS_USER> SYS_USER { get; set; }
        public virtual DbSet<SYS_USER_DEPARTMENT> SYS_USER_DEPARTMENT { get; set; }
        public virtual DbSet<SYS_USER_ONLINE> SYS_USER_ONLINE { get; set; }
        public virtual DbSet<SYS_USER_PERMISSION> SYS_USER_PERMISSION { get; set; }
        public virtual DbSet<SYS_USER_ROLE> SYS_USER_ROLE { get; set; }
        public virtual DbSet<SYS_USERINFO> SYS_USERINFO { get; set; }
    }
}