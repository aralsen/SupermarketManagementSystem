﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperMarketManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class managementDBEntities1 : DbContext
    {
        public managementDBEntities1()
            : base("name=managementDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bills> bills { get; set; }
        public virtual DbSet<categories> categories { get; set; }
        public virtual DbSet<employees> employees { get; set; }
        public virtual DbSet<job_types> job_types { get; set; }
        public virtual DbSet<products> products { get; set; }
    
        public virtual int sp_add_bill(Nullable<int> bill_id, Nullable<int> employee_id, string bill_date, Nullable<int> total_amount)
        {
            var bill_idParameter = bill_id.HasValue ?
                new ObjectParameter("bill_id", bill_id) :
                new ObjectParameter("bill_id", typeof(int));
    
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("employee_id", employee_id) :
                new ObjectParameter("employee_id", typeof(int));
    
            var bill_dateParameter = bill_date != null ?
                new ObjectParameter("bill_date", bill_date) :
                new ObjectParameter("bill_date", typeof(string));
    
            var total_amountParameter = total_amount.HasValue ?
                new ObjectParameter("total_amount", total_amount) :
                new ObjectParameter("total_amount", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_bill", bill_idParameter, employee_idParameter, bill_dateParameter, total_amountParameter);
        }
    
        public virtual int sp_add_category(Nullable<int> category_id, string category_name, string description)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            var category_nameParameter = category_name != null ?
                new ObjectParameter("category_name", category_name) :
                new ObjectParameter("category_name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_category", category_idParameter, category_nameParameter, descriptionParameter);
        }
    
        public virtual int sp_add_employee(Nullable<int> employee_id, string email, string name, string phone, Nullable<int> age, Nullable<int> job_id, string password)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("employee_id", employee_id) :
                new ObjectParameter("employee_id", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var job_idParameter = job_id.HasValue ?
                new ObjectParameter("job_id", job_id) :
                new ObjectParameter("job_id", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_employee", employee_idParameter, emailParameter, nameParameter, phoneParameter, ageParameter, job_idParameter, passwordParameter);
        }
    
        public virtual int sp_add_product(Nullable<int> product_id, string product_name, Nullable<int> stock, Nullable<int> price, Nullable<int> category_id)
        {
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var product_nameParameter = product_name != null ?
                new ObjectParameter("product_name", product_name) :
                new ObjectParameter("product_name", typeof(string));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("stock", stock) :
                new ObjectParameter("stock", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_product", product_idParameter, product_nameParameter, stockParameter, priceParameter, category_idParameter);
        }
    
        public virtual int sp_delete_bill(Nullable<int> bill_id)
        {
            var bill_idParameter = bill_id.HasValue ?
                new ObjectParameter("bill_id", bill_id) :
                new ObjectParameter("bill_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_bill", bill_idParameter);
        }
    
        public virtual int sp_delete_category(Nullable<int> category_id)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_category", category_idParameter);
        }
    
        public virtual int sp_delete_employee(Nullable<int> employee_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("employee_id", employee_id) :
                new ObjectParameter("employee_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_employee", employee_idParameter);
        }
    
        public virtual int sp_delete_product(Nullable<int> product_id)
        {
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_product", product_idParameter);
        }
    
        public virtual ObjectResult<sp_display_categories_Result> sp_display_categories()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_display_categories_Result>("sp_display_categories");
        }
    
        public virtual ObjectResult<sp_display_managers_Result> sp_display_managers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_display_managers_Result>("sp_display_managers");
        }
    
        public virtual ObjectResult<sp_display_products_Result> sp_display_products()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_display_products_Result>("sp_display_products");
        }
    
        public virtual ObjectResult<sp_display_salespersons_Result> sp_display_salespersons()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_display_salespersons_Result>("sp_display_salespersons");
        }
    
        public virtual ObjectResult<sp_get_bills_Result> sp_get_bills()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_get_bills_Result>("sp_get_bills");
        }
    
        public virtual ObjectResult<string> sp_get_category_names()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_get_category_names");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_get_employee(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_get_employee", emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<sp_get_product_namepricequantity_Result> sp_get_product_namepricequantity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_get_product_namepricequantity_Result>("sp_get_product_namepricequantity");
        }
    
        public virtual ObjectResult<sp_get_product_namepricequantity_by_category_Result> sp_get_product_namepricequantity_by_category(string category_name)
        {
            var category_nameParameter = category_name != null ?
                new ObjectParameter("category_name", category_name) :
                new ObjectParameter("category_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_get_product_namepricequantity_by_category_Result>("sp_get_product_namepricequantity_by_category", category_nameParameter);
        }
    
        public virtual ObjectResult<string> sp_get_product_names()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_get_product_names");
        }
    
        public virtual ObjectResult<sp_get_products_by_category_Result> sp_get_products_by_category(string category_name)
        {
            var category_nameParameter = category_name != null ?
                new ObjectParameter("category_name", category_name) :
                new ObjectParameter("category_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_get_products_by_category_Result>("sp_get_products_by_category", category_nameParameter);
        }
    
        public virtual int sp_update_category(Nullable<int> category_id, string category_name, string description)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            var category_nameParameter = category_name != null ?
                new ObjectParameter("category_name", category_name) :
                new ObjectParameter("category_name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_category", category_idParameter, category_nameParameter, descriptionParameter);
        }
    
        public virtual int sp_update_employee(Nullable<int> employee_id, string email, string name, string phone, Nullable<int> age, Nullable<int> job_id, string password)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("employee_id", employee_id) :
                new ObjectParameter("employee_id", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var job_idParameter = job_id.HasValue ?
                new ObjectParameter("job_id", job_id) :
                new ObjectParameter("job_id", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_employee", employee_idParameter, emailParameter, nameParameter, phoneParameter, ageParameter, job_idParameter, passwordParameter);
        }
    
        public virtual int sp_update_product(Nullable<int> product_id, string product_name, Nullable<int> stock, Nullable<int> price, Nullable<int> category_id)
        {
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var product_nameParameter = product_name != null ?
                new ObjectParameter("product_name", product_name) :
                new ObjectParameter("product_name", typeof(string));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("stock", stock) :
                new ObjectParameter("stock", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_product", product_idParameter, product_nameParameter, stockParameter, priceParameter, category_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_get_category_id(string category_name)
        {
            var category_nameParameter = category_name != null ?
                new ObjectParameter("category_name", category_name) :
                new ObjectParameter("category_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_get_category_id", category_nameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_get_employee_id(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_get_employee_id", nameParameter);
        }
    }
}