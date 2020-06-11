using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheCloudBill.Core.Entities;
using TheCloudBill.Core.Models;

namespace TheCloudBill.EFCore.EntityFrameworkCore.TenantDb
{
    class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<tblBankTransaction> tblBankTransaction { get; set; }
        public DbSet<tblBillOfSupply> tblBillOfSupply { get; set; }
        public DbSet<tblBillOfSupplyProductDetail> tblBillOfSupplyProductDetail { get; set; }
        public DbSet<tblBillOfSupplySeries> tblBillOfSupplySeries { get; set; }
        public DbSet<tblClientVendor> tblClientVendor { get; set; }
        public DbSet<tblCompAccountSetup> tblCompAccountSetup { get; set; }
        public DbSet<tblCompAddress> tblCompAddress { get; set; }
        public DbSet<tblCompany> tblCompany { get; set; }
        public DbSet<tblCompanyBank> tblCompanyBank { get; set; }
        public DbSet<tblCompPreference> tblCompPreference { get; set; }
        public DbSet<tblCompUser> tblCompUser { get; set; }
        public DbSet<tblCounterSale> tblCounterSale { get; set; }
        public DbSet<tblCounterSaleProductDetail> tblCounterSaleProductDetail { get; set; }
        public DbSet<tblCounterSaleSeries> tblCounterSaleSeries { get; set; }
        public DbSet<tblCreditNote> tblCreditNote { get; set; }
        public DbSet<tblCreditNoteLite> tblCreditNoteLite { get; set; }
        public DbSet<tblCVaddress> tblCVaddress { get; set; }
        public DbSet<tblCVBanks> tblCVBanks { get; set; }
        public DbSet<tblCVCategory> tblCVCategory { get; set; }
        public DbSet<tblCVcontact> tblCVcontact { get; set; }
        public DbSet<tblDebitNote> tblDebitNote { get; set; }
        public DbSet<tblDebitNoteLine> tblDebitNoteLine { get; set; }
        public DbSet<tblDeliveryChallan> tblDeliveryChallan { get; set; }
        public DbSet<tblDeliveryChallanProductDetail> tblDeliveryChallanProductDetail { get; set; }
        public DbSet<tblExpences> tblExpences { get; set; }
        public DbSet<tblFiles> tblFiles { get; set; }
        public DbSet<tblLedgerGroup> tblLedgerGroup { get; set; }
        public DbSet<tblLedgers> tblLedgers { get; set; }
        public DbSet<tblOtherCrgs> tblOtherCrgs { get; set; }
        public DbSet<tblOtherCrgsTypes> tblOtherCrgsTypes { get; set; }
        public DbSet<tblPaymentMade> tblPaymentMade { get; set; }
        public DbSet<tblPaymentMadeLine> tblPaymentMadeLine { get; set; }
        public DbSet<tblPaymentReceive> tblPaymentReceive { get; set; }
        public DbSet<tblPaymentReceiveLine> tblPaymentReceiveLine { get; set; }
        public DbSet<tblPriceList> tblPriceList { get; set; }

        public DbSet<tblProductCategory> tblProdductCategory { get; set; }

        public DbSet<tblProduct> tblProduct { get; set; }
        public DbSet<tblProductGroup> tblProductGroup { get; set; }
        public DbSet<tblPUnits> tblPUnits { get; set; }
        public DbSet<tblPurchase> tblPurchase { get; set; }
        public DbSet<tblPurchaseProductDetail> tblPurchaseProductDetail { get; set; }
        public DbSet<tblQuotation> tblQuotation { get; set; }
        public DbSet<tblQuotationProductDetail> tblQuotationProductDetail { get; set; }
        public DbSet<tblTaxInvoice> tblTaxInvoice { get; set; }
        public DbSet<tblTaxInvoiceProductDetail> tblTaxInvoiceProductDetail { get; set; }
        public DbSet<tblTaxInvoiceSeries> tblTaxInvoiceSeries { get; set; } 



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
