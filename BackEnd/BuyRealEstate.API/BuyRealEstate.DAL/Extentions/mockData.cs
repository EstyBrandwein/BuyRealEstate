using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Extentions
{
    public static class MockDataSeeder
    {
        public static void SeedMockData(this ModelBuilder modelBuilder)
        {
            // Mock Users
            modelBuilder.Entity<DevelopmentStatus>().HasData(
        new DevelopmentStatus { Status = "הפיתוח בעיצומו", Id = 1 },
        new DevelopmentStatus { Status = "הפיתוח הושלם", Id = 2 }
      );
            modelBuilder.Entity<Document>().HasData(
               new Document { ID = 1, FileType = ".pdf", PamentID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, IsRecipt = true, InsertUser = 1, UpdateUser = 1, DocumentDescription = "הודעה על נאמנות שמחי", DocumentData = File.ReadAllBytes("C:\\Users\\USER\\Documents\\BuyRealEstate\\מסמכים\\מסמכי נאמנות שמחי.pdf") },
               new Document { ID = 2, FileType = ".pdf", PamentID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, IsRecipt = true, InsertUser = 1, UpdateUser = 1, DocumentDescription = "אישור ניהול חשבון", DocumentData = File.ReadAllBytes("C:\\Users\\USER\\Documents\\BuyRealEstate\\מסמכים\\אישור ניהול חשבון חירן 2024 (1) (4) (1).pdf") },
               new Document { ID = 3, FileType = ".pdf", PamentID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, IsRecipt = false, InsertUser = 1, UpdateUser = 1, DocumentDescription = "אישור נאמן לצורך העברת כספים", DocumentData = File.ReadAllBytes("C:\\Users\\USER\\Documents\\BuyRealEstate\\מסמכים\\אישור לרובין.pdf") },
               new Document { ID = 4, FileType = ".pdf", PamentID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, IsRecipt = false, InsertUser = 1, UpdateUser = 1, DocumentDescription = "אישור ניהול חשבון", DocumentData = File.ReadAllBytes("C:\\Users\\USER\\Documents\\BuyRealEstate\\מסמכים\\אישור ניהול חשבון ברנדויין אליהו וחיה.pdf") }


                );

            modelBuilder.Entity<Image>().HasData(
               new Image { ID = 1, FileType = ".jpg", ProjectID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, InsertUser = 1, UpdateUser = 1, ImageDescription = "מיגרשים", ImageData = File.ReadAllBytes("C:\\Users\\USER\\Documents\\BuyRealEstate\\תמונות\\1.jpg") },
               new Image { ID = 2, FileType = ".jpg", ProjectID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, InsertUser = 1, UpdateUser = 1, ImageDescription = "הבית שלך", ImageData = File.ReadAllBytes("C:\\Users\\USER\\Documents\\BuyRealEstate\\תמונות\\2.jpg") },
               new Image { ID = 3, FileType = ".jpg", ProjectID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, InsertUser = 1, UpdateUser = 1, ImageDescription = "המגרש שלך", ImageData = File.ReadAllBytes("C:\\Users\\USER\\Documents\\BuyRealEstate\\תמונות\\3.jpg") },
               new Image { ID = 4, FileType = ".jpg", ProjectID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, InsertUser = 1, UpdateUser = 1, ImageDescription = "חירן", ImageData = File.ReadAllBytes("C:\\Users\\USER\\Documents\\BuyRealEstate\\תמונות\\4.jpg") }
                );
            modelBuilder.Entity<LegalStatus>().HasData(
                new LegalStatus { Id = 1, Status = "בשלבי רכישה", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
                new LegalStatus { Id = 2, Status = "הושלמה על שם הנאמן", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
                new LegalStatus { Id = 3, Status = "בתהליכי רישום ברשות המיסים", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
                new LegalStatus { Id = 4, Status = "העסקה רשומה על שימכם", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
                );
            modelBuilder.Entity<Payment>().HasData(
                new Payment { ID = 1, ProfessionalId = 4, PaymentStatusId = 1, Detiels = "hello", Surplus = 12000, dose = "9997", movement = "חובה", HNagainst = "100001", ToWhere = "לקנות נדלן", DataValue = DateTime.Now, Datereference = DateTime.Now, Amount = 360000, PaymentExecutionMethodID = 1, Title = "פתיחת תיק", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, LastPaymentDate = DateTime.Now, State = true },
                new Payment { ID = 2, ProfessionalId = 4, PaymentStatusId = 2, Detiels = "hello", Surplus = 13000, dose = "9997", movement = "חובה", HNagainst = "189002", ToWhere = "נאמנות", DataValue = DateTime.Now, Datereference = DateTime.Now, Amount = 420000, PaymentExecutionMethodID = 1, Title = "דמי נאמנות", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, LastPaymentDate = DateTime.Now, State = true },
                new Payment { ID = 3, ProfessionalId = 4, PaymentStatusId = 3, Detiels = "hello", Surplus = 14000, dose = "9997", movement = "זכות", HNagainst = "127682", ToWhere = "עורך דין", DataValue = DateTime.Now, Datereference = DateTime.Now, Amount = 260000, PaymentExecutionMethodID = 1, Title = "רשות המיסים", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, LastPaymentDate = DateTime.Now, State = true }
                );
            modelBuilder.Entity<PaymentExecutionMethod>().HasData(
               new PaymentExecutionMethod { ID = 1, Description = "אשראי", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new PaymentExecutionMethod { ID = 2, Description = "העברה בנקאית", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new PaymentExecutionMethod { ID = 3, Description = "ציק", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new PaymentExecutionMethod { ID = 4, Description = "מזומן", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
            );
            modelBuilder.Entity<PaymentStatus>().HasData(
                new PaymentStatus { Id = 1, Status = "לא שולם", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
                new PaymentStatus { Id = 2, Status = "מחכה לאישור", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
                new PaymentStatus { Id = 3, Status = "שולם", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
            );
            modelBuilder.Entity<Permission>().HasData(
               new Permission { Id = 1, permission = "מנהל", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new Permission { Id = 2, permission = "מזכירה", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new Permission { Id = 3, permission = "לקוח", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new Permission { Id = 4, permission = "איש קשר", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
          );
            modelBuilder.Entity<Plot>().HasData(
               new Plot { ID = 1,UserId = 1, PlotCost = 580000, MonthlyFundingCost = 10000, MonthsForFundingCost = 10, PlotValue = 600000, PlotSize = 120, PlotNumber = 12, ProjectId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new Plot { ID = 2, UserId = 1, PlotCost = 580000, MonthlyFundingCost = 10000, MonthsForFundingCost = 10, PlotValue = 600000, PlotSize = 138, PlotNumber = 11, ProjectId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new Plot { ID = 3, UserId = 1, PlotCost = 580000, MonthlyFundingCost = 10000, MonthsForFundingCost = 10, PlotValue = 600000, PlotSize = 110, PlotNumber = 13, ProjectId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
          );
            modelBuilder.Entity<Professional>().HasData(
               new Professional { ID = 4,IsVerified =true,VerificationCode = "", FirstName = "רשות", LastName = "המיסים", Email = "ghj@hjj", Password = "123456", FirstPhone = "050141155", PermissionId = 4, Username = "רשות המיסים", Professtion = "מיסים", WebsiteAddress = "https://www.efshar-nadlan.co.il", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
               new Professional { ID = 5, IsVerified = true, VerificationCode = "", WebsiteAddress = "", FirstName = "רועי", LastName = "גרילק", Email = "royi@grilak", Password = "123456", FirstPhone = "0556565626", PermissionId = 4, Username = "עורך דין", Professtion = "עריכת דין", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
              );
            modelBuilder.Entity<Project>().HasData(
               new Project { ID = 1, ProjectName = "כרמית 11", ProjectAddress = "כרמית", LegalStatusId = 1, ProjectManagerID = 1, DeveloperStatusID = 1, GrossProfit = 12000, LinkToLead2 = "https://www.efshar-nadlan.co.il/", ProjectType = true, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }

                );
            modelBuilder.Entity<RelationshipCustomersPlots>().HasData(
               new RelationshipCustomersPlots { ID = 1, PlotID = 1, UserID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
                );
            modelBuilder.Entity<RelationshipPaymentsPlots>().HasData(
               new RelationshipPaymentsPlots { ID = 1, PlotID = 1, PaymentID = 1, paymentStutusID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
                );
            modelBuilder.Entity<RelationshipPaymentsProjects>().HasData(
               new RelationshipPaymentsProjects { ID = 1, ProjectID = 1, PaymentID = 1, paymentStutusID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
                );
            modelBuilder.Entity<User>().HasData(
                new User { ID = 1, IsVerified = true, VerificationCode = "", FirstName = "חיה", LastName = "ברנדויין", Email = "chayamalot@gmail.com", Password = "CB5328152", FirstPhone = "0504101585", Username = "ChayaB", PermissionId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
                );
             modelBuilder.Entity<Guarantees>().HasData(
                new Guarantees { Id = 1, Amount = 87643, DateOfPayment = DateTime.Now,GuaranteeUssued=true,IsPaid=false,Note="עוד לא שולם",VoucherNumber=4, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
                new Guarantees { Id = 2, Amount = 673829, DateOfPayment = DateTime.Now, GuaranteeUssued = false, IsPaid = false, Note = "עוד לא שולם", VoucherNumber = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }, 
                new Guarantees { Id = 3, Amount = 3572, DateOfPayment = DateTime.Now, GuaranteeUssued = true, IsPaid = true, Note = "שולם", VoucherNumber = 3, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
    );
        }
    }

}
