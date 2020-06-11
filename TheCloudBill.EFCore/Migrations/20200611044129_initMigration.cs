using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCloudBill.EFCore.Migrations
{
    public partial class initMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblBankTransaction",
                columns: table => new
                {
                    bnkTrnID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankID = table.Column<long>(nullable: false),
                    fromAccountID = table.Column<long>(nullable: false),
                    fromAccountTypeID = table.Column<long>(nullable: false),
                    ToAccountID = table.Column<long>(nullable: false),
                    ToAccountTypeID = table.Column<long>(nullable: false),
                    Amount = table.Column<long>(nullable: false),
                    trnDate = table.Column<DateTime>(nullable: false),
                    Narration = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBankTransaction", x => x.bnkTrnID);
                });

            migrationBuilder.CreateTable(
                name: "tblBillOfSupply",
                columns: table => new
                {
                    billInvoiceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    billInvoiceSeriesID = table.Column<long>(nullable: false),
                    billInvoiceNo = table.Column<string>(maxLength: 255, nullable: true),
                    deliveryNoteNo = table.Column<string>(maxLength: 255, nullable: true),
                    quotationNo = table.Column<string>(maxLength: 255, nullable: true),
                    challanNo = table.Column<string>(maxLength: 255, nullable: true),
                    orderNo = table.Column<string>(maxLength: 255, nullable: true),
                    modeTermOfPayment = table.Column<string>(maxLength: 255, nullable: true),
                    bDate = table.Column<string>(maxLength: 255, nullable: true),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    subTotal = table.Column<long>(nullable: false),
                    otherCrgID = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    Discount = table.Column<long>(nullable: false),
                    roundUp = table.Column<long>(nullable: false),
                    FinalTotal = table.Column<long>(nullable: false),
                    ewayBillNo = table.Column<string>(maxLength: 255, nullable: true),
                    transporterName = table.Column<string>(maxLength: 255, nullable: true),
                    transporterGSTNo = table.Column<string>(maxLength: 255, nullable: true),
                    transporterReceiptNo = table.Column<string>(maxLength: 255, nullable: true),
                    VehiceNo = table.Column<string>(maxLength: 255, nullable: true),
                    bOtherField1 = table.Column<string>(maxLength: 255, nullable: true),
                    bOtherField2 = table.Column<string>(maxLength: 255, nullable: true),
                    bOtherField3 = table.Column<string>(maxLength: 255, nullable: true),
                    note = table.Column<string>(nullable: true),
                    privateNote = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBillOfSupply", x => x.billInvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "tblBillOfSupplyProductDetail",
                columns: table => new
                {
                    billInvoiceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    productID = table.Column<long>(nullable: false),
                    QTY = table.Column<long>(nullable: false),
                    Rate = table.Column<long>(nullable: false),
                    discountPer = table.Column<long>(nullable: false),
                    discount = table.Column<long>(nullable: false),
                    CGSTPer = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGSTPer = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGSTPer = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    lineTotal = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBillOfSupplyProductDetail", x => x.billInvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "tblBillOfSupplySeries",
                columns: table => new
                {
                    billSeriesID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    billOfSupplyPrefix = table.Column<string>(maxLength: 255, nullable: true),
                    billOfSupplyPostfix = table.Column<string>(maxLength: 255, nullable: true),
                    printFormatID = table.Column<long>(nullable: false),
                    compID = table.Column<string>(maxLength: 255, nullable: true),
                    userID = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBillOfSupplySeries", x => x.billSeriesID);
                });

            migrationBuilder.CreateTable(
                name: "tblClientVendor",
                columns: table => new
                {
                    cvID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cvCompName = table.Column<string>(maxLength: 255, nullable: true),
                    cvCompLogoID = table.Column<string>(maxLength: 255, nullable: true),
                    cvPhone = table.Column<string>(maxLength: 255, nullable: true),
                    cvEmail = table.Column<string>(maxLength: 255, nullable: true),
                    cvFax = table.Column<string>(maxLength: 255, nullable: true),
                    cvWebsite = table.Column<string>(maxLength: 255, nullable: true),
                    cvCompType = table.Column<string>(maxLength: 255, nullable: true),
                    cvGSTNo = table.Column<string>(maxLength: 255, nullable: true),
                    cvPanNo = table.Column<string>(maxLength: 255, nullable: true),
                    cvAadharNo = table.Column<string>(maxLength: 255, nullable: true),
                    cvCreditLimit = table.Column<string>(maxLength: 255, nullable: true),
                    cvTermsPayment = table.Column<string>(maxLength: 255, nullable: true),
                    cvCategoryID = table.Column<long>(nullable: false),
                    clientVendor = table.Column<long>(nullable: false),
                    cvOpeningBalance = table.Column<long>(nullable: false),
                    crdr = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClientVendor", x => x.cvID);
                });

            migrationBuilder.CreateTable(
                name: "tblCompAccountSetup",
                columns: table => new
                {
                    compSetupID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    compID = table.Column<long>(nullable: false),
                    creditNotePrefix = table.Column<string>(maxLength: 255, nullable: true),
                    creditNotePostfix = table.Column<string>(maxLength: 255, nullable: true),
                    debitNotePrefix = table.Column<string>(maxLength: 255, nullable: true),
                    debitNotePostfix = table.Column<string>(maxLength: 255, nullable: true),
                    purchasePrefix = table.Column<string>(maxLength: 255, nullable: true),
                    purchasePostfix = table.Column<string>(maxLength: 255, nullable: true),
                    receiptPrefix = table.Column<string>(maxLength: 255, nullable: true),
                    receiptPostfix = table.Column<string>(maxLength: 255, nullable: true),
                    paymentPrefix = table.Column<string>(maxLength: 255, nullable: true),
                    paymentPostfix = table.Column<string>(maxLength: 255, nullable: true),
                    quotationPrefix = table.Column<string>(maxLength: 255, nullable: true),
                    quotationPostfix = table.Column<string>(maxLength: 255, nullable: true),
                    deliveryChallanPrefix = table.Column<string>(maxLength: 255, nullable: true),
                    deliveryChallanPostfix = table.Column<string>(maxLength: 255, nullable: true),
                    tempPurchasePrefix = table.Column<string>(maxLength: 255, nullable: true),
                    tempPurchasePostfix = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompAccountSetup", x => x.compSetupID);
                });

            migrationBuilder.CreateTable(
                name: "tblCompAddress",
                columns: table => new
                {
                    compAddID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    compID = table.Column<long>(nullable: false),
                    AddressName = table.Column<string>(maxLength: 255, nullable: true),
                    Add1 = table.Column<string>(maxLength: 255, nullable: true),
                    Add2 = table.Column<string>(maxLength: 255, nullable: true),
                    City = table.Column<string>(maxLength: 255, nullable: true),
                    Pincode = table.Column<string>(maxLength: 255, nullable: true),
                    State = table.Column<string>(maxLength: 255, nullable: true),
                    Nation = table.Column<string>(maxLength: 255, nullable: true),
                    AddressPhone = table.Column<string>(maxLength: 255, nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    isDafault = table.Column<string>(maxLength: 255, nullable: true),
                    addType = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompAddress", x => x.compAddID);
                });

            migrationBuilder.CreateTable(
                name: "tblCompany",
                columns: table => new
                {
                    compID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    compLogoId = table.Column<long>(nullable: false),
                    compName = table.Column<string>(maxLength: 255, nullable: true),
                    compBillAdd1 = table.Column<string>(maxLength: 255, nullable: true),
                    compBillAdd2 = table.Column<string>(maxLength: 255, nullable: true),
                    compBillCity = table.Column<string>(maxLength: 255, nullable: true),
                    compBillPincode = table.Column<string>(maxLength: 255, nullable: true),
                    compBillState = table.Column<string>(maxLength: 255, nullable: true),
                    compBillNation = table.Column<string>(maxLength: 255, nullable: true),
                    compBillPhoneNo = table.Column<string>(maxLength: 255, nullable: true),
                    compShipAdd1 = table.Column<string>(maxLength: 255, nullable: true),
                    compShipAdd2 = table.Column<string>(maxLength: 255, nullable: true),
                    compShipCity = table.Column<string>(maxLength: 255, nullable: true),
                    compShipPincode = table.Column<string>(maxLength: 255, nullable: true),
                    compShipState = table.Column<string>(maxLength: 255, nullable: true),
                    compShipNation = table.Column<string>(maxLength: 255, nullable: true),
                    compShipPhoneNo = table.Column<string>(maxLength: 255, nullable: true),
                    compGSTReg = table.Column<string>(maxLength: 255, nullable: true),
                    compGSTNo = table.Column<string>(maxLength: 255, nullable: true),
                    compEmail = table.Column<string>(maxLength: 255, nullable: true),
                    compPhone = table.Column<string>(maxLength: 255, nullable: true),
                    compWebsite = table.Column<string>(maxLength: 255, nullable: true),
                    compFacebook = table.Column<string>(maxLength: 255, nullable: true),
                    compInstagram = table.Column<string>(maxLength: 255, nullable: true),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompany", x => x.compID);
                });

            migrationBuilder.CreateTable(
                name: "tblCompanyBank",
                columns: table => new
                {
                    compBankID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    compID = table.Column<long>(nullable: false),
                    compBankName = table.Column<string>(maxLength: 255, nullable: true),
                    compBankIFSC = table.Column<string>(maxLength: 255, nullable: true),
                    compBankAC = table.Column<string>(maxLength: 255, nullable: true),
                    compBankBranch = table.Column<string>(maxLength: 255, nullable: true),
                    compBankOPBal = table.Column<string>(maxLength: 255, nullable: true),
                    isPrimaryBank = table.Column<string>(maxLength: 255, nullable: true),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanyBank", x => x.compBankID);
                });

            migrationBuilder.CreateTable(
                name: "tblCompPreference",
                columns: table => new
                {
                    compID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    compTerms1 = table.Column<string>(nullable: true),
                    compTerms2 = table.Column<string>(nullable: true),
                    compTerms3 = table.Column<string>(nullable: true),
                    compDateFormat = table.Column<string>(maxLength: 255, nullable: true),
                    compDecimal = table.Column<string>(maxLength: 255, nullable: true),
                    compOnlineAPI = table.Column<string>(maxLength: 255, nullable: true),
                    compOnlineUserName = table.Column<string>(maxLength: 255, nullable: true),
                    compOnlinePassword = table.Column<string>(maxLength: 255, nullable: true),
                    nightMode = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true),
                    userID = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompPreference", x => x.compID);
                });

            migrationBuilder.CreateTable(
                name: "tblCompUser",
                columns: table => new
                {
                    userID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    compID = table.Column<long>(nullable: false),
                    userName = table.Column<string>(maxLength: 255, nullable: true),
                    userPhone = table.Column<string>(maxLength: 255, nullable: true),
                    userEmail = table.Column<string>(maxLength: 255, nullable: true),
                    userFB = table.Column<string>(maxLength: 255, nullable: true),
                    userInsta = table.Column<string>(maxLength: 255, nullable: true),
                    userRole = table.Column<string>(maxLength: 255, nullable: true),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompUser", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "tblCounterSale",
                columns: table => new
                {
                    counterSaleID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    counterSaleSeriesID = table.Column<long>(nullable: false),
                    counterSaleNo = table.Column<string>(maxLength: 255, nullable: true),
                    modeTermOfPayment = table.Column<string>(maxLength: 255, nullable: true),
                    cDate = table.Column<string>(maxLength: 255, nullable: true),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    subTotal = table.Column<long>(nullable: false),
                    otherCrgID = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    Discount = table.Column<long>(nullable: false),
                    roundUp = table.Column<long>(nullable: false),
                    FinalTotal = table.Column<long>(nullable: false),
                    cOtherField1 = table.Column<string>(maxLength: 255, nullable: true),
                    cOtherField2 = table.Column<string>(maxLength: 255, nullable: true),
                    cOtherField3 = table.Column<string>(maxLength: 255, nullable: true),
                    note = table.Column<string>(nullable: true),
                    privateNote = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCounterSale", x => x.counterSaleID);
                });

            migrationBuilder.CreateTable(
                name: "tblCounterSaleProductDetail",
                columns: table => new
                {
                    counterSaleID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    productID = table.Column<long>(nullable: false),
                    QTY = table.Column<long>(nullable: false),
                    Rate = table.Column<long>(nullable: false),
                    discountPer = table.Column<long>(nullable: false),
                    discount = table.Column<long>(nullable: false),
                    CGSTPer = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGSTPer = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGSTPer = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    lineTotal = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCounterSaleProductDetail", x => x.counterSaleID);
                });

            migrationBuilder.CreateTable(
                name: "tblCounterSaleSeries",
                columns: table => new
                {
                    counterSeriesID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    counterPrefix = table.Column<string>(maxLength: 255, nullable: true),
                    counterPostfix = table.Column<string>(maxLength: 255, nullable: true),
                    printFormatID = table.Column<long>(nullable: false),
                    compID = table.Column<string>(maxLength: 255, nullable: true),
                    userID = table.Column<string>(maxLength: 255, nullable: true),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCounterSaleSeries", x => x.counterSeriesID);
                });

            migrationBuilder.CreateTable(
                name: "tblCreditNote",
                columns: table => new
                {
                    cdID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cdNo = table.Column<string>(maxLength: 255, nullable: true),
                    cdInvoiceID = table.Column<long>(nullable: false),
                    cdInvoiceFrom = table.Column<long>(nullable: false),
                    cdCustID = table.Column<long>(nullable: false),
                    cdDate = table.Column<string>(maxLength: 255, nullable: true),
                    reason = table.Column<string>(maxLength: 255, nullable: true),
                    subTotal = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    otherCrgsPer = table.Column<long>(nullable: false),
                    otherCrgs = table.Column<long>(nullable: false),
                    roundUp = table.Column<long>(nullable: false),
                    finalTotal = table.Column<long>(nullable: false),
                    note = table.Column<string>(nullable: true),
                    privateNote = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCreditNote", x => x.cdID);
                });

            migrationBuilder.CreateTable(
                name: "tblCreditNoteLite",
                columns: table => new
                {
                    cdID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    custID = table.Column<long>(nullable: false),
                    custFromTbl = table.Column<long>(nullable: false),
                    productID = table.Column<long>(nullable: false),
                    QTY = table.Column<long>(nullable: false),
                    Rate = table.Column<long>(nullable: false),
                    CGSTPer = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGSTPer = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGSTPer = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    discountPer = table.Column<long>(nullable: false),
                    discount = table.Column<long>(nullable: false),
                    lineTotal = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCreditNoteLite", x => x.cdID);
                });

            migrationBuilder.CreateTable(
                name: "tblCVaddress",
                columns: table => new
                {
                    cvAddID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cvID = table.Column<long>(nullable: false),
                    cvAddressName = table.Column<string>(maxLength: 255, nullable: true),
                    cvAdd1 = table.Column<string>(maxLength: 255, nullable: true),
                    cvAdd2 = table.Column<string>(maxLength: 255, nullable: true),
                    cvCity = table.Column<string>(maxLength: 255, nullable: true),
                    cvPincode = table.Column<string>(maxLength: 255, nullable: true),
                    cvState = table.Column<string>(maxLength: 255, nullable: true),
                    cvNation = table.Column<string>(maxLength: 255, nullable: true),
                    cvAddressPhone = table.Column<string>(maxLength: 255, nullable: true),
                    cvEmail = table.Column<string>(maxLength: 255, nullable: true),
                    isDafault = table.Column<string>(maxLength: 255, nullable: true),
                    addType = table.Column<long>(nullable: false),
                    narration = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCVaddress", x => x.cvAddID);
                });

            migrationBuilder.CreateTable(
                name: "tblCVBanks",
                columns: table => new
                {
                    cvBankID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cvID = table.Column<long>(nullable: false),
                    bankName = table.Column<string>(maxLength: 255, nullable: true),
                    bankAC = table.Column<string>(maxLength: 255, nullable: true),
                    bankBranch = table.Column<string>(maxLength: 255, nullable: true),
                    bankISFC = table.Column<string>(maxLength: 255, nullable: true),
                    isDefault = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCVBanks", x => x.cvBankID);
                });

            migrationBuilder.CreateTable(
                name: "tblCVCategory",
                columns: table => new
                {
                    cvCategoryID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cvCategoryName = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCVCategory", x => x.cvCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "tblCVcontact",
                columns: table => new
                {
                    cvContID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cvID = table.Column<long>(nullable: false),
                    salutation = table.Column<string>(maxLength: 255, nullable: true),
                    fName = table.Column<string>(maxLength: 255, nullable: true),
                    mName = table.Column<string>(maxLength: 255, nullable: true),
                    lName = table.Column<string>(maxLength: 255, nullable: true),
                    position = table.Column<string>(maxLength: 255, nullable: true),
                    email = table.Column<string>(maxLength: 255, nullable: true),
                    phone = table.Column<string>(maxLength: 255, nullable: true),
                    mobile = table.Column<string>(maxLength: 255, nullable: true),
                    cAdd1 = table.Column<string>(maxLength: 255, nullable: true),
                    cAdd2 = table.Column<string>(maxLength: 255, nullable: true),
                    cCity = table.Column<string>(maxLength: 255, nullable: true),
                    cPincode = table.Column<string>(maxLength: 255, nullable: true),
                    cState = table.Column<string>(maxLength: 255, nullable: true),
                    cNation = table.Column<string>(maxLength: 255, nullable: true),
                    isDefault = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStamp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCVcontact", x => x.cvContID);
                });

            migrationBuilder.CreateTable(
                name: "tblDebitNote",
                columns: table => new
                {
                    dnID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dnNo = table.Column<string>(maxLength: 255, nullable: true),
                    dnInvoiceID = table.Column<long>(nullable: false),
                    dnInvoiceFrom = table.Column<long>(nullable: false),
                    dnCustID = table.Column<long>(nullable: false),
                    dnDate = table.Column<string>(maxLength: 255, nullable: true),
                    reason = table.Column<string>(maxLength: 255, nullable: true),
                    subTotal = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    otherCrgsPer = table.Column<long>(nullable: false),
                    otherCrgs = table.Column<long>(nullable: false),
                    roundUp = table.Column<long>(nullable: false),
                    finalTotal = table.Column<long>(nullable: false),
                    note = table.Column<string>(nullable: true),
                    privateNote = table.Column<string>(nullable: true),
                    docURL = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDebitNote", x => x.dnID);
                });

            migrationBuilder.CreateTable(
                name: "tblDebitNoteLine",
                columns: table => new
                {
                    dnID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    custID = table.Column<long>(nullable: false),
                    custFromTbl = table.Column<long>(nullable: false),
                    productID = table.Column<long>(nullable: false),
                    QTY = table.Column<long>(nullable: false),
                    Rate = table.Column<long>(nullable: false),
                    CGSTPer = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGSTPer = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGSTPer = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    discountPer = table.Column<long>(nullable: false),
                    discount = table.Column<long>(nullable: false),
                    lineTotal = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDebitNoteLine", x => x.dnID);
                });

            migrationBuilder.CreateTable(
                name: "tblDeliveryChallan",
                columns: table => new
                {
                    delChallanID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    delChallanNo = table.Column<string>(maxLength: 255, nullable: true),
                    orderNo = table.Column<string>(maxLength: 255, nullable: true),
                    dcDate = table.Column<string>(maxLength: 255, nullable: true),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    transporterName = table.Column<string>(maxLength: 255, nullable: true),
                    transporterGSTNo = table.Column<string>(maxLength: 255, nullable: true),
                    transporterReceiptNo = table.Column<string>(maxLength: 255, nullable: true),
                    VehiceNo = table.Column<string>(maxLength: 255, nullable: true),
                    dcOtherField1 = table.Column<string>(maxLength: 255, nullable: true),
                    dcOtherField2 = table.Column<string>(maxLength: 255, nullable: true),
                    dcOtherField3 = table.Column<string>(maxLength: 255, nullable: true),
                    note = table.Column<string>(nullable: true),
                    privateNote = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDeliveryChallan", x => x.delChallanID);
                });

            migrationBuilder.CreateTable(
                name: "tblDeliveryChallanProductDetail",
                columns: table => new
                {
                    delChallanID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    productID = table.Column<long>(nullable: false),
                    QTY = table.Column<long>(nullable: false),
                    Rate = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDeliveryChallanProductDetail", x => x.delChallanID);
                });

            migrationBuilder.CreateTable(
                name: "tblExpences",
                columns: table => new
                {
                    expID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expNo = table.Column<string>(maxLength: 255, nullable: true),
                    expNameID = table.Column<long>(nullable: false),
                    expDate = table.Column<string>(maxLength: 255, nullable: true),
                    expName = table.Column<string>(maxLength: 255, nullable: true),
                    expAmount = table.Column<double>(nullable: false),
                    expCGST = table.Column<double>(nullable: false),
                    expSGST = table.Column<double>(nullable: false),
                    expIGST = table.Column<double>(nullable: false),
                    expTotal = table.Column<double>(nullable: false),
                    expNarration = table.Column<string>(nullable: true),
                    IsPaid = table.Column<long>(nullable: false),
                    expMyBankID = table.Column<string>(maxLength: 255, nullable: true),
                    expMyBankTrnID = table.Column<long>(nullable: false),
                    eOther1 = table.Column<string>(maxLength: 255, nullable: true),
                    eOther2 = table.Column<string>(maxLength: 255, nullable: true),
                    eOther3 = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblExpences", x => x.expID);
                });

            migrationBuilder.CreateTable(
                name: "tblFiles",
                columns: table => new
                {
                    fileID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileGroupId = table.Column<long>(nullable: false),
                    filePath = table.Column<string>(maxLength: 255, nullable: true),
                    fileSecurityKey = table.Column<string>(nullable: true),
                    type = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFiles", x => x.fileID);
                });

            migrationBuilder.CreateTable(
                name: "tblLedgerGroup",
                columns: table => new
                {
                    lgID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lgName = table.Column<string>(maxLength: 255, nullable: true),
                    narration = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLedgerGroup", x => x.lgID);
                });

            migrationBuilder.CreateTable(
                name: "tblLedgers",
                columns: table => new
                {
                    legID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    legName = table.Column<string>(maxLength: 255, nullable: true),
                    legGroupID = table.Column<long>(nullable: false),
                    openingBalance = table.Column<long>(nullable: false),
                    crDr = table.Column<string>(maxLength: 255, nullable: true),
                    add1 = table.Column<string>(maxLength: 255, nullable: true),
                    add2 = table.Column<string>(maxLength: 255, nullable: true),
                    city = table.Column<string>(maxLength: 255, nullable: true),
                    pinCode = table.Column<string>(maxLength: 255, nullable: true),
                    state = table.Column<string>(maxLength: 255, nullable: true),
                    nation = table.Column<string>(maxLength: 255, nullable: true),
                    phone = table.Column<string>(maxLength: 255, nullable: true),
                    mobile = table.Column<string>(maxLength: 255, nullable: true),
                    email = table.Column<string>(maxLength: 255, nullable: true),
                    gstNo = table.Column<string>(maxLength: 255, nullable: true),
                    lOther1 = table.Column<string>(maxLength: 255, nullable: true),
                    lOther2 = table.Column<string>(maxLength: 255, nullable: true),
                    lOther3 = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLedgers", x => x.legID);
                });

            migrationBuilder.CreateTable(
                name: "tblOtherCrgs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otherCrgID = table.Column<long>(nullable: false),
                    invID = table.Column<long>(nullable: false),
                    invType = table.Column<long>(nullable: false),
                    otherCrgTypeID = table.Column<long>(nullable: false),
                    otherCrgs = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOtherCrgs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblOtherCrgsTypes",
                columns: table => new
                {
                    otherCrgTypeID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otherCrgName = table.Column<string>(maxLength: 255, nullable: true),
                    otherCrgTaxPer = table.Column<long>(nullable: false),
                    narration = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOtherCrgsTypes", x => x.otherCrgTypeID);
                });

            migrationBuilder.CreateTable(
                name: "tblPaymentMade",
                columns: table => new
                {
                    paymentMadeID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentMadeNo = table.Column<string>(maxLength: 255, nullable: true),
                    paymentMadeDate = table.Column<string>(maxLength: 255, nullable: true),
                    paymentMadeMyBankID = table.Column<long>(nullable: false),
                    paymentMadeMyBankTrnID = table.Column<long>(nullable: false),
                    customerID = table.Column<long>(nullable: false),
                    paymentMadeAmount = table.Column<long>(nullable: false),
                    paymentMadeNarration = table.Column<string>(maxLength: 255, nullable: true),
                    docURL = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPaymentMade", x => x.paymentMadeID);
                });

            migrationBuilder.CreateTable(
                name: "tblPaymentMadeLine",
                columns: table => new
                {
                    paymentMadeLineID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentMadeID = table.Column<long>(nullable: false),
                    paymentMadeBillID = table.Column<long>(nullable: false),
                    paymentMadeBillTypeID = table.Column<long>(nullable: false),
                    paymentMadeAmount = table.Column<double>(nullable: false),
                    paymentBankID = table.Column<long>(nullable: false),
                    paymenrBankTrnID = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPaymentMadeLine", x => x.paymentMadeLineID);
                });

            migrationBuilder.CreateTable(
                name: "tblPaymentReceive",
                columns: table => new
                {
                    receiveID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    receiveDate = table.Column<string>(maxLength: 255, nullable: true),
                    receiveMyBankID = table.Column<long>(nullable: false),
                    receiveBankTrnID = table.Column<long>(nullable: false),
                    customerID = table.Column<long>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    receiveNarration = table.Column<string>(maxLength: 255, nullable: true),
                    receiveBankID = table.Column<long>(nullable: false),
                    docURL = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPaymentReceive", x => x.receiveID);
                });

            migrationBuilder.CreateTable(
                name: "tblPaymentReceiveLine",
                columns: table => new
                {
                    paymentReceiveID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentReceiveInvoiceID = table.Column<long>(nullable: false),
                    paymentReceiveInvoiceTypeID = table.Column<long>(nullable: false),
                    paymentReceiveAmount = table.Column<double>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPaymentReceiveLine", x => x.paymentReceiveID);
                });

            migrationBuilder.CreateTable(
                name: "tblPriceList",
                columns: table => new
                {
                    productID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pMRP = table.Column<double>(nullable: false),
                    pRateA = table.Column<double>(nullable: false),
                    pRateB = table.Column<double>(nullable: false),
                    pRateC = table.Column<double>(nullable: false),
                    pDiscA = table.Column<double>(nullable: false),
                    pDiscB = table.Column<double>(nullable: false),
                    pDiscC = table.Column<double>(nullable: false),
                    purRate = table.Column<double>(nullable: false),
                    pGroupID = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPriceList", x => x.productID);
                });

            migrationBuilder.CreateTable(
                name: "tblProdductCategory",
                columns: table => new
                {
                    pCategoryID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pCategory = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProdductCategory", x => x.pCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                columns: table => new
                {
                    productID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pImageGroupId = table.Column<long>(nullable: false),
                    pName = table.Column<string>(maxLength: 255, nullable: true),
                    pDetail = table.Column<string>(maxLength: 255, nullable: true),
                    pHSNNo = table.Column<string>(maxLength: 255, nullable: true),
                    pUnit = table.Column<string>(maxLength: 255, nullable: true),
                    pCode = table.Column<string>(maxLength: 255, nullable: true),
                    pBarcode = table.Column<string>(maxLength: 255, nullable: true),
                    CGSTper = table.Column<double>(nullable: false),
                    SGSTPer = table.Column<double>(nullable: false),
                    IGSTPer = table.Column<double>(nullable: false),
                    pMinQTY = table.Column<double>(nullable: false),
                    pMaxQTY = table.Column<double>(nullable: false),
                    pNegative = table.Column<string>(maxLength: 255, nullable: true),
                    pOpeningStockQTY = table.Column<double>(nullable: false),
                    pOpeningStockRs = table.Column<double>(nullable: false),
                    pGroupID = table.Column<long>(nullable: false),
                    pCategoryID = table.Column<long>(nullable: false),
                    pShowInPoster = table.Column<long>(nullable: false),
                    pNameOnPoster = table.Column<string>(maxLength: 255, nullable: true),
                    pDescriptionPoster = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduct", x => x.productID);
                });

            migrationBuilder.CreateTable(
                name: "tblProductGroup",
                columns: table => new
                {
                    pGroupID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pGroupName = table.Column<string>(maxLength: 255, nullable: true),
                    pGroupColor = table.Column<string>(maxLength: 255, nullable: true),
                    pGroupDiscount = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductGroup", x => x.pGroupID);
                });

            migrationBuilder.CreateTable(
                name: "tblPUnits",
                columns: table => new
                {
                    pUnitID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unit = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPUnits", x => x.pUnitID);
                });

            migrationBuilder.CreateTable(
                name: "tblPurchase",
                columns: table => new
                {
                    purInvoiceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purInvoiceNo = table.Column<string>(maxLength: 255, nullable: true),
                    deliveryNoteNo = table.Column<string>(maxLength: 255, nullable: true),
                    quotationNo = table.Column<string>(maxLength: 255, nullable: true),
                    challanNo = table.Column<string>(maxLength: 255, nullable: true),
                    orderNo = table.Column<string>(maxLength: 255, nullable: true),
                    modeTermOfPayment = table.Column<string>(maxLength: 255, nullable: true),
                    pDate = table.Column<string>(maxLength: 255, nullable: true),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    subTotal = table.Column<long>(nullable: false),
                    otherCrgID = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    Discount = table.Column<long>(nullable: false),
                    roundUp = table.Column<long>(nullable: false),
                    FinalTotal = table.Column<long>(nullable: false),
                    ewayBillNo = table.Column<string>(maxLength: 255, nullable: true),
                    transporterName = table.Column<string>(maxLength: 255, nullable: true),
                    transporterGSTNo = table.Column<string>(maxLength: 255, nullable: true),
                    transporterReceiptNo = table.Column<string>(maxLength: 255, nullable: true),
                    VehiceNo = table.Column<string>(maxLength: 255, nullable: true),
                    pOtherField1 = table.Column<string>(maxLength: 255, nullable: true),
                    pOtherField2 = table.Column<string>(maxLength: 255, nullable: true),
                    pOtherField3 = table.Column<string>(maxLength: 255, nullable: true),
                    note = table.Column<string>(nullable: true),
                    privateNote = table.Column<string>(nullable: true),
                    docURL = table.Column<string>(maxLength: 255, nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPurchase", x => x.purInvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "tblPurchaseProductDetail",
                columns: table => new
                {
                    purInvoiceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    productID = table.Column<long>(nullable: false),
                    QTY = table.Column<long>(nullable: false),
                    Rate = table.Column<long>(nullable: false),
                    discountPer = table.Column<long>(nullable: false),
                    discount = table.Column<long>(nullable: false),
                    CGSTPer = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGSTPer = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGSTPer = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    lineTotal = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPurchaseProductDetail", x => x.purInvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "tblQuotation",
                columns: table => new
                {
                    quotationID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quotationNo = table.Column<string>(maxLength: 255, nullable: true),
                    orderNo = table.Column<string>(maxLength: 255, nullable: true),
                    modeTermOfPayment = table.Column<string>(maxLength: 255, nullable: true),
                    qDate = table.Column<string>(maxLength: 255, nullable: true),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    subTotal = table.Column<long>(nullable: false),
                    otherCrgID = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    Discount = table.Column<long>(nullable: false),
                    roundUp = table.Column<long>(nullable: false),
                    FinalTotal = table.Column<long>(nullable: false),
                    qOtherField1 = table.Column<string>(maxLength: 255, nullable: true),
                    qOtherField2 = table.Column<string>(maxLength: 255, nullable: true),
                    qOtherField3 = table.Column<string>(maxLength: 255, nullable: true),
                    note = table.Column<string>(nullable: true),
                    privateNote = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblQuotation", x => x.quotationID);
                });

            migrationBuilder.CreateTable(
                name: "tblQuotationProductDetail",
                columns: table => new
                {
                    quotationID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    productID = table.Column<long>(nullable: false),
                    QTY = table.Column<long>(nullable: false),
                    Rate = table.Column<long>(nullable: false),
                    discountPer = table.Column<long>(nullable: false),
                    discount = table.Column<long>(nullable: false),
                    CGSTPer = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGSTPer = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGSTPer = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    lineTotal = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblQuotationProductDetail", x => x.quotationID);
                });

            migrationBuilder.CreateTable(
                name: "tblTaxInvoice",
                columns: table => new
                {
                    taxInvoiceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taxInvoiceSeriesID = table.Column<long>(nullable: false),
                    taxInvoiceNo = table.Column<string>(maxLength: 255, nullable: true),
                    deliveryNoteNo = table.Column<string>(maxLength: 255, nullable: true),
                    quotationNo = table.Column<string>(maxLength: 255, nullable: true),
                    challanNo = table.Column<string>(maxLength: 255, nullable: true),
                    orderNo = table.Column<string>(maxLength: 255, nullable: true),
                    modeTermOfPayment = table.Column<string>(maxLength: 255, nullable: true),
                    tDate = table.Column<string>(maxLength: 255, nullable: true),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    subTotal = table.Column<long>(nullable: false),
                    otherCrgID = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    Discount = table.Column<long>(nullable: false),
                    roundUp = table.Column<long>(nullable: false),
                    FinalTotal = table.Column<long>(nullable: false),
                    ewayBillNo = table.Column<string>(maxLength: 255, nullable: true),
                    transporterName = table.Column<string>(maxLength: 255, nullable: true),
                    transporterGSTNo = table.Column<string>(maxLength: 255, nullable: true),
                    transporterReceiptNo = table.Column<string>(maxLength: 255, nullable: true),
                    VehiceNo = table.Column<string>(maxLength: 255, nullable: true),
                    tOtherField1 = table.Column<string>(maxLength: 255, nullable: true),
                    tOtherField2 = table.Column<string>(maxLength: 255, nullable: true),
                    tOtherField3 = table.Column<string>(maxLength: 255, nullable: true),
                    note = table.Column<string>(nullable: true),
                    privateNote = table.Column<string>(nullable: true),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTaxInvoice", x => x.taxInvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "tblTaxInvoiceProductDetail",
                columns: table => new
                {
                    taxInvoiceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<long>(nullable: false),
                    custFromtbl = table.Column<long>(nullable: false),
                    productID = table.Column<long>(nullable: false),
                    QTY = table.Column<long>(nullable: false),
                    Rate = table.Column<long>(nullable: false),
                    discountPer = table.Column<long>(nullable: false),
                    discount = table.Column<long>(nullable: false),
                    CGSTPer = table.Column<long>(nullable: false),
                    CGST = table.Column<long>(nullable: false),
                    SGSTPer = table.Column<long>(nullable: false),
                    SGST = table.Column<long>(nullable: false),
                    IGSTPer = table.Column<long>(nullable: false),
                    IGST = table.Column<long>(nullable: false),
                    lineTotal = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTaxInvoiceProductDetail", x => x.taxInvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "tblTaxInvoiceSeries",
                columns: table => new
                {
                    taxSeriesID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    texInvoicePrefix = table.Column<string>(maxLength: 255, nullable: true),
                    texInvoicePostfix = table.Column<string>(maxLength: 255, nullable: true),
                    printFormatID = table.Column<long>(nullable: false),
                    compID = table.Column<long>(nullable: false),
                    userID = table.Column<long>(nullable: false),
                    timeStemp = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTaxInvoiceSeries", x => x.taxSeriesID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tblBankTransaction");

            migrationBuilder.DropTable(
                name: "tblBillOfSupply");

            migrationBuilder.DropTable(
                name: "tblBillOfSupplyProductDetail");

            migrationBuilder.DropTable(
                name: "tblBillOfSupplySeries");

            migrationBuilder.DropTable(
                name: "tblClientVendor");

            migrationBuilder.DropTable(
                name: "tblCompAccountSetup");

            migrationBuilder.DropTable(
                name: "tblCompAddress");

            migrationBuilder.DropTable(
                name: "tblCompany");

            migrationBuilder.DropTable(
                name: "tblCompanyBank");

            migrationBuilder.DropTable(
                name: "tblCompPreference");

            migrationBuilder.DropTable(
                name: "tblCompUser");

            migrationBuilder.DropTable(
                name: "tblCounterSale");

            migrationBuilder.DropTable(
                name: "tblCounterSaleProductDetail");

            migrationBuilder.DropTable(
                name: "tblCounterSaleSeries");

            migrationBuilder.DropTable(
                name: "tblCreditNote");

            migrationBuilder.DropTable(
                name: "tblCreditNoteLite");

            migrationBuilder.DropTable(
                name: "tblCVaddress");

            migrationBuilder.DropTable(
                name: "tblCVBanks");

            migrationBuilder.DropTable(
                name: "tblCVCategory");

            migrationBuilder.DropTable(
                name: "tblCVcontact");

            migrationBuilder.DropTable(
                name: "tblDebitNote");

            migrationBuilder.DropTable(
                name: "tblDebitNoteLine");

            migrationBuilder.DropTable(
                name: "tblDeliveryChallan");

            migrationBuilder.DropTable(
                name: "tblDeliveryChallanProductDetail");

            migrationBuilder.DropTable(
                name: "tblExpences");

            migrationBuilder.DropTable(
                name: "tblFiles");

            migrationBuilder.DropTable(
                name: "tblLedgerGroup");

            migrationBuilder.DropTable(
                name: "tblLedgers");

            migrationBuilder.DropTable(
                name: "tblOtherCrgs");

            migrationBuilder.DropTable(
                name: "tblOtherCrgsTypes");

            migrationBuilder.DropTable(
                name: "tblPaymentMade");

            migrationBuilder.DropTable(
                name: "tblPaymentMadeLine");

            migrationBuilder.DropTable(
                name: "tblPaymentReceive");

            migrationBuilder.DropTable(
                name: "tblPaymentReceiveLine");

            migrationBuilder.DropTable(
                name: "tblPriceList");

            migrationBuilder.DropTable(
                name: "tblProdductCategory");

            migrationBuilder.DropTable(
                name: "tblProduct");

            migrationBuilder.DropTable(
                name: "tblProductGroup");

            migrationBuilder.DropTable(
                name: "tblPUnits");

            migrationBuilder.DropTable(
                name: "tblPurchase");

            migrationBuilder.DropTable(
                name: "tblPurchaseProductDetail");

            migrationBuilder.DropTable(
                name: "tblQuotation");

            migrationBuilder.DropTable(
                name: "tblQuotationProductDetail");

            migrationBuilder.DropTable(
                name: "tblTaxInvoice");

            migrationBuilder.DropTable(
                name: "tblTaxInvoiceProductDetail");

            migrationBuilder.DropTable(
                name: "tblTaxInvoiceSeries");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
