using ALE.TimeRegistration.Mob.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Mocking
{
    public class MockProjectsService : IMobProjectService
    {
        private static List<ProjectResponseDto> projectList = new List<ProjectResponseDto>
        {
                new ProjectResponseDto { Name = "Toyota Motor", Id = Guid.Parse("00000000-0000-0000-0000-000000000100") },
                new ProjectResponseDto { Name = "Colruyt", Id = Guid.Parse("00000000-0000-0000-0000-000000000101") },
                new ProjectResponseDto { Name = "Engie Electrabel", Id = Guid.Parse("00000000-0000-0000-0000-000000000102") },
                new ProjectResponseDto { Name = "Janssen Pharmaceutica", Id = Guid.Parse("00000000-0000-0000-0000-000000000103") },
                new ProjectResponseDto { Name = "Total Belgium", Id = Guid.Parse("00000000-0000-0000-0000-000000000104") },
                new ProjectResponseDto { Name = "BASF Antwerpen", Id = Guid.Parse("00000000-0000-0000-0000-000000000105") },
                new ProjectResponseDto { Name = "Delhaize De Leeuw", Id = Guid.Parse("00000000-0000-0000-0000-000000000106") },
                new ProjectResponseDto { Name = "Volvo Car Belgium", Id = Guid.Parse("00000000-0000-0000-0000-000000000107") },
                new ProjectResponseDto { Name = "ArcelorMittal Belgium", Id = Guid.Parse("00000000-0000-0000-0000-000000000108") },
                new ProjectResponseDto { Name = "Mastercard Europe", Id = Guid.Parse("00000000-0000-0000-0000-000000000109") },
                new ProjectResponseDto { Name = "Proximus", Id = Guid.Parse("00000000-0000-0000-0000-000000000110") },
                new ProjectResponseDto { Name = "AXA Belgium", Id = Guid.Parse("00000000-0000-0000-0000-000000000111") },
                new ProjectResponseDto { Name = "Allianz Benelux", Id = Guid.Parse("00000000-0000-0000-0000-000000000112") },
                new ProjectResponseDto { Name = "Daikin Europe", Id = Guid.Parse("00000000-0000-0000-0000-000000000113") },
                new ProjectResponseDto { Name = "bpost", Id = Guid.Parse("00000000-0000-0000-0000-000000000114") }
        };



        public async Task<ProjectResponseDto> GetById(Guid id)
        {
            var project = projectList.FirstOrDefault(p => p.Id == id);
            return await Task.FromResult(project);
        }

        public async Task<ICollection<ProjectResponseDto>> ListAll()
        {
            ICollection<ProjectResponseDto> projects = projectList.ToList();
            return await Task.FromResult(projects);
        }
    }
}
