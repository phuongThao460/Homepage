﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homepage.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookshopEntity : DbContext
    {
        public BookshopEntity()
            : base("name=BookshopEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ANHBIA> ANHBIAs { get; set; }
        public virtual DbSet<ANHFEEDBACK> ANHFEEDBACKs { get; set; }
        public virtual DbSet<BANGGIA> BANGGIAs { get; set; }
        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual DbSet<DIEUKIENKHUYENMAI> DIEUKIENKHUYENMAIs { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<FEEDBACK> FEEDBACKs { get; set; }
        public virtual DbSet<HINHANHKHUYENMAI> HINHANHKHUYENMAIs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<LOAITAIKHOAN> LOAITAIKHOANs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<SANPHAMKHUYENMAI> SANPHAMKHUYENMAIs { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<TAIKHOANKHACHHANG> TAIKHOANKHACHHANGs { get; set; }
        public virtual DbSet<TAIKHOANNGANHANG> TAIKHOANNGANHANGs { get; set; }
        public virtual DbSet<TAIKHOANQUANTRIVIEN> TAIKHOANQUANTRIVIENs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<THONGTINKHACHHANG> THONGTINKHACHHANGs { get; set; }
        public virtual DbSet<TRANGTHAIDONHANG> TRANGTHAIDONHANGs { get; set; }
    }
}