using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Interface
{
    public interface IReportRepository
    {
        public List<Report> GetAll();
        public Report GetById(Guid id);
        public void Add(ReportModel reportModel);
        public void Update(ReportModel reportModel);
        public void Delete(Guid id);
    }
}
