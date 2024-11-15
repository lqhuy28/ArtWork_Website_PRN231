using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_DAO;
using AWS_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly ReportDAO _reportDAO;
        public ReportRepository(ReportDAO reportDAO)
        {
            _reportDAO = reportDAO;
        }

        public void Add(ReportModel reportModel)
        => _reportDAO.Add(reportModel);

        public void Delete(Guid id)
        => _reportDAO.Delete(id);

        public List<Report> GetAll()
        => _reportDAO.GetAll();

        public Report GetById(Guid id)
        => _reportDAO.GetById(id);

        public void Update(ReportModel reportModel)
        => _reportDAO.Update(reportModel);
    }
}
