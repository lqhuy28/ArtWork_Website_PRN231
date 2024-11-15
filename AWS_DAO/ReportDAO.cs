using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class ReportDAO
    {
        private readonly IApplicationDbContext _context;
        public ReportDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        public ReportDAO()
        {
        }

        // get all reports, validate and try catch, isDeleted = false, sort by Created
        public List<Report> GetAll()
        {
            try
            {
                List<Report> reports
                    = (List<Report>)_context.Get<Report>().Where(x => x.IsDeleted == false).OrderByDescending(x => x.Created)
                    .ToList();
                return reports;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get report by id, validate and try catch
        public Report GetById(Guid id)
        {
            try
            {
                return _context.Get<Report>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add report, validate and try catch
        public void Add(ReportModel reportModel)
        {
            try
            {
                Report report = new Report();
                report.Id = new Guid();
                report.UserAccountID = reportModel.UserAccountID;
                report.UserAccountIDReport = reportModel.UserAccountIDReport;
                report.Description = reportModel.Description;
                report.Created = DateTime.Now;
                report.IsDeleted = false;
                // check reportId, if found throw exception
                var checkId = GetById(report.Id);
                if (checkId != null)
                {
                    throw new Exception("Report already exists");
                }
                _context.Get<Report>().Add(report);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update report, validate and try catch
        public void Update(ReportModel reportModel)
        {
            try
            {
                // check reportId, throw not found exception if not found
                var checkId = GetById(reportModel.Id);
                if (checkId == null)
                {
                    throw new NotFoundException("Report not found");
                }
                var report = checkId;
                report.UserAccountID = reportModel.UserAccountID;
                report.UserAccountIDReport = reportModel.UserAccountIDReport;
                report.Description = reportModel.Description;
                _context.Get<Report>().Update(report);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete report, validate and try catch, isDelete = true   
        public void Delete(Guid id)
        {
            try
            {
                // check reportId, throw not found exception if not found
                var checkId = GetById(id);
                if (checkId == null)
                {
                    throw new NotFoundException("Report not found");
                }
                checkId.IsDeleted = true;
                _context.Get<Report>().Update(checkId);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
