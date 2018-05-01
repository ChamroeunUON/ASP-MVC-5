namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
         Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4731c5fb-7960-45b5-8a51-62971b66485c', N'admin@vidly.com', 0, N'AC0qnApJi+E4e1FtoBx7pgRGwQTB0xRpA2XT8o6gU3LNQra1KSZJFQKItmocbVpnGA==', N'0318878b-831c-4b56-ad18-6ac387e4176d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fec7eeae-c79f-4009-8238-a6c904a3e093', N'guest@vidly.com', 0, N'AP+LcD95KabgMH4rW/uf1ocMqi646OhuF7JCAq7zW9BQnjYZEWEkWVd66lnMt3ctIg==', N'90bf1bcf-721b-4bf9-8fbe-091ba5b58baa', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c7deffd6-4552-4097-b64a-87d2b4dae5a2', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4731c5fb-7960-45b5-8a51-62971b66485c', N'c7deffd6-4552-4097-b64a-87d2b4dae5a2')

");
        }

        public override void Down()
        {
        }
    }
}
