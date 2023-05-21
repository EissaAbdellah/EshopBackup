using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Migrations
{
    public partial class Add_adminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name]) VALUES (N'b9aa2c88-8d3d-4c3a-9671-6faa0ef6112f', N'admin@admin.com', N'ADMIN@ADMIN.COM', N'admin@admin.com', N'ADMIN@ADMIN.COM', 0, N'AQAAAAEAACcQAAAAEAq06/FadDBJh1Ad5DrT9ud0w6VEUpXSks+BhRdxLMG68QkG9ebA9zBgihErtFb1XA==', N'CTXFJURO6QRJYSUAC36BUTBOEKNO2MLW', N'a5f93e2b-a934-4d04-b4af-6e41d33f4100', NULL, 0, 0, NULL, 1, 0, N'Admin')\r\n");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = 'b9aa2c88-8d3d-4c3a-9671-6faa0ef6112f'");
        }
    }
}
