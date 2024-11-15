using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository reportRepository;
        public ReportService(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }

        public void Add(ReportModel reportModel)
        => reportRepository.Add(reportModel);

        public void Delete(Guid id)
        => reportRepository.Delete(id);

        public List<Report> GetAll()
        => reportRepository.GetAll();

        public Report GetById(Guid id)
        => reportRepository.GetById(id);

        public void Update(ReportModel reportModel)
        => reportRepository.Update(reportModel);
    }
}
