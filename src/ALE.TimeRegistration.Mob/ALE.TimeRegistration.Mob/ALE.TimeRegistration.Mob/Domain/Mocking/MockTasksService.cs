using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Mob.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Mocking
{
    public class MockTasksService : ITaskService
    {
        private static List<AppTask> taskList = new List<AppTask>
        {
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000200"), Info = "Create API Items", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000100"), TaskName = "Create API", UploadDate = DateTime.Parse("14/10/2018 08:30:12"), WorkTime = new TimeSpan(1, 18, 20) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000201"), Info = "Fix issues Items API", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000100"), TaskName = "API issues", UploadDate = DateTime.Parse("15/10/2018 11:30:12"), WorkTime = new TimeSpan(2, 19, 28) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000202"), Info = "Create new properties Item object", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000100"), TaskName = "Create properties", UploadDate = DateTime.Parse("18/10/2018 09:30:12"), WorkTime = new TimeSpan(0, 28, 30) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000203"), Info = "Link Item to new API vendor", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000100"), TaskName = "API vendor link", UploadDate = DateTime.Parse("19/10/2018 08:35:12"), WorkTime = new TimeSpan(0, 8, 40) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000204"), Info = "Migrate objects to database", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000101"), TaskName = "migrate objects", UploadDate = DateTime.Parse("14/08/2019 08:30:12"), WorkTime = new TimeSpan(2, 35, 50) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000205"), Info = "Create all API's for website", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000101"), TaskName = "create API's", UploadDate = DateTime.Parse("15/08/2019 08:30:12"), WorkTime = new TimeSpan(4, 30, 20) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000206"), Info = "Create full working website", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000101"), TaskName = "Website", UploadDate = DateTime.Parse("20/09/2019 10:30:12"), WorkTime = new TimeSpan(21, 44, 30) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000207"), Info = "Finish website", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000101"), TaskName = "finish website", UploadDate = DateTime.Parse("23/09/2019 08:30:12"), WorkTime = new TimeSpan(3, 18, 10) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000208"), Info = "Automate pricing and promo", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000101"), TaskName = "automate", UploadDate = DateTime.Parse("02/10/2019 08:30:12"), WorkTime = new TimeSpan(5, 5, 0) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000209"), Info = "Upload data for demo", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000102"), TaskName = "demodata", UploadDate = DateTime.Parse("20/02/2020 08:30:12"), WorkTime = new TimeSpan(0, 31, 50) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000210"), Info = "Migrate data Electrabel to database", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000102"), TaskName = "migrate data", UploadDate = DateTime.Parse("21/02/2020 08:30:12"), WorkTime = new TimeSpan(8, 41, 30) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000211"), Info = "Fix issues website selling page", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000103"), TaskName = "fix website issues", UploadDate = DateTime.Parse("13/05/2020 08:30:12"), WorkTime = new TimeSpan(2, 15, 30) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000212"), Info = "Rebuild itempage website and link new products", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000103"), TaskName = "itempage", UploadDate = DateTime.Parse("15/05/2020 08:30:12"), WorkTime = new TimeSpan(5, 7, 40) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000213"), Info = "Automate selling process and work with new API's", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000103"), TaskName = "automation", UploadDate = DateTime.Parse("17/05/2020 08:30:12"), WorkTime = new TimeSpan(6, 39, 50) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000214"), Info = "Finish all processes and link to website", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000103"), TaskName = "finish automation", UploadDate = DateTime.Parse("18/05/2020 08:30:12"), WorkTime = new TimeSpan(4, 55, 10) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000215"), Info = "Create new website and link to database", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000104"), TaskName = "create website", UploadDate = DateTime.Parse("20/03/2018 08:30:12"), WorkTime = new TimeSpan(22, 10, 25) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000216"), Info = "Update al items in database", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000104"), TaskName = "update items", UploadDate = DateTime.Parse("25/03/2018 08:30:12"), WorkTime = new TimeSpan(1, 8, 41) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000217"), Info = "Automate promo's and guid for admin", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000104"), TaskName = "promo's", UploadDate = DateTime.Parse("26/03/2018 08:30:12"), WorkTime = new TimeSpan(2, 1, 35) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000218"), Info = "Upload data and create database", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000105"), TaskName = "upload data", UploadDate = DateTime.Parse("14/08/2018 08:30:12"), WorkTime = new TimeSpan(3, 0, 12) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000219"), Info = "Upload data and create database", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000106"), TaskName = "upload data", UploadDate = DateTime.Parse("12/07/2020 08:30:12"), WorkTime = new TimeSpan(4, 47, 8) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000220"), Info = "Link API's to new database", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000106"), TaskName = "link API's", UploadDate = DateTime.Parse("13/07/2020 08:30:12"), WorkTime = new TimeSpan(0, 35, 38) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000221"), Info = "Fix issues with order page on website", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000107"), TaskName = "order page", UploadDate = DateTime.Parse("13/10/2020 08:30:12"), WorkTime = new TimeSpan(1, 26, 45) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000222"), Info = "Create link order page and new billing page customer and automate proces", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000107"), TaskName = "link order page", UploadDate = DateTime.Parse("15/10/2020 08:30:12"), WorkTime = new TimeSpan(2, 45, 10) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000223"), Info = "Fix issue billing page", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000107"), TaskName = "issue billing", UploadDate = DateTime.Parse("16/10/2020 08:30:12"), WorkTime = new TimeSpan(0, 51, 42) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000224"), Info = "Create new order page for customers Europe", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000108"), TaskName = "order page", UploadDate = DateTime.Parse("05/11/2019 08:30:12"), WorkTime = new TimeSpan(1, 8, 42) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000225"), Info = "Create API for database to link with order page", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000108"), TaskName = "API orderpage", UploadDate = DateTime.Parse("06/11/2019 08:30:12"), WorkTime = new TimeSpan(3, 6, 5) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000226"), Info = "Create new page for customer portal", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000109"), TaskName = "customer portal", UploadDate = DateTime.Parse("08/11/2019 08:30:12"), WorkTime = new TimeSpan(2, 19, 8) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000227"), Info = "Fix issues customer portal", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000109"), TaskName = "issues customer portal", UploadDate = DateTime.Parse("10/11/2019 08:30:12"), WorkTime = new TimeSpan(0, 20, 45) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000228"), Info = "Create API Items and link to database", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000110"), TaskName = "API items", UploadDate = DateTime.Parse("10/02/2020 08:30:12"), WorkTime = new TimeSpan(3, 24, 6) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000229"), Info = "Fix app issues for customer login page", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000110"), TaskName = "app issues", UploadDate = DateTime.Parse("08/04/2019 08:30:12"), WorkTime = new TimeSpan(2, 35, 41) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000230"), Info = "Create full working website", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000111"), TaskName = "Website", UploadDate = DateTime.Parse("20/06/2020 08:30:12"), WorkTime = new TimeSpan(7, 41, 20) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000231"), Info = "Create full working website", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000112"), TaskName = "Website", UploadDate = DateTime.Parse("15/11/2019 08:30:12"), WorkTime = new TimeSpan(10, 35, 41) },
            new AppTask { Id = Guid.Parse("00000000-0000-0000-0000-000000000232"), Info = "Create full working website", ProjectId = Guid.Parse("00000000-0000-0000-0000-000000000113"), TaskName = "Website", UploadDate = DateTime.Parse("10/10/2018 08:30:12"), WorkTime = new TimeSpan(11, 31, 50) }
        };

        public async Task<AppTask> GetById(Guid id)
        {
            var task = taskList.FirstOrDefault(t => t.Id == id);
            return await Task.FromResult(task);
        }

        public async Task<IQueryable<AppTask>> ListAllTasks()
        {
            var tasks = taskList.AsQueryable();
            return await Task.FromResult(tasks);
        }
    }
}
