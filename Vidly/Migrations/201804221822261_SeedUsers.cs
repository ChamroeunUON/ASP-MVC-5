namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
//            Sql(@"
//INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cd3878bd-26dc-45f0-827b-67f76fcbf154', N'uonchamroeun@hotmail.com', 0, N'AGF8HbAyjVxYo+lCjNKeZjo0JLIxHFvTJ8KyEInGXVNOZFi99lJS47TE99WsVt9pfw==', N'c66f1842-aabd-4aeb-b699-54a1de278e8d', NULL, 0, 0, NULL, 1, 0, N'uonchamroeun@hotmail.com')
//INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f045677d-2751-4139-88a6-b2c35fc633cc', N'admin@vidly.com', 0, N'APig/QCzyKBp3a7HIYzrCIZbav7WDUn6myemg+4lwVI+/jBcG0ngSiGnHQe1Rt4/lw==', N'ec644006-68a7-492f-ad50-3d7d56a70faa', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
//INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b14642b5-f762-425e-94ac-159b7ea7c953', N'CanManageMovies')
//INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f045677d-2751-4139-88a6-b2c35fc633cc', N'b14642b5-f762-425e-94ac-159b7ea7c953')
//");
        }

    public override void Down()
        {
        }
    }
}
