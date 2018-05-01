namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'35785110-6352-4129-87a3-946de96c93f0', N'guest@vidly.com', 0, N'AE+KKEHawfafci/PpdaKIfusT0h/Rx76OY+gXnQr9Dj+flCajDm11KB0RgpMK/pfQw==', N'2f95a580-d01c-45e8-81dd-f8a44a86ab5b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e8826ef0-05eb-444e-9d90-3fbd5e32b5e5', N'admin@vidly.com', 0, N'AOzsQx1rKfVh7O3AzX1h1R3s5fBp3i0molaBot0wrJb+QYm0JwXSEL0wXbtXwzs5sA==', N'1060de14-0f15-46f6-aee1-b06d838aa23c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'464e5a59-de5e-490e-ad90-00e980c6ada2', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e8826ef0-05eb-444e-9d90-3fbd5e32b5e5', N'464e5a59-de5e-490e-ad90-00e980c6ada2')

");
        }
        
        public override void Down()
        {
        }
    }
}
