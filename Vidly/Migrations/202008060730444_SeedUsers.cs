namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3f24650e-ea0f-4376-a28e-8a2e3a4b2273', N'admin@vidly.com', 0, N'AL/YQV/qo86FvZbew+VeOPAKyPn71N2iy4dCWS1tINwVYTF9SUKwhOp8WxyxLAz1Kw==', N'42b5f55d-c564-4089-81f7-baf9afd3cd36', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a0eae5d2-7f02-4956-bda6-f57aa26082ef', N'guest@vidly.com', 0, N'AAt0b02yi8wd44s1SW4bdzWhbkwa89YsvGw69Zbz5yVUdksJL1neZeId8AwaqKmEGA==', N'd7b9a26a-7d05-4152-90a0-d86f0e24e2db', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a154c60a-2644-4a76-901a-911c3f162e43', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3f24650e-ea0f-4376-a28e-8a2e3a4b2273', N'a154c60a-2644-4a76-901a-911c3f162e43')
");
        }
        
        public override void Down()
        {
        }
    }
}
