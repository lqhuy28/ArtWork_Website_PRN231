
using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class ArtistAccountDAO
    {
        private readonly IApplicationDbContext _context;
        public ArtistAccountDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        public ArtistAccountDAO()
        {
            
        }

        // get all ArtistAccount, check isDeleted = false, sort by Name
        public List<ArtistAccount> GetAll()
        {
            try
            {
                List<ArtistAccount> artistAccounts
                    = (List<ArtistAccount>)_context.Get<ArtistAccount>()
                    .Include(x => x.ApplicationUser).Where(x => x.IsDeleted == false)
                    .OrderBy(x => x.ApplicationUser.UserName).ToList();             
                return artistAccounts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get ArtistAccount by id
        public ArtistAccount GetById(Guid id)
        {
            try
            {
                return _context.Get<ArtistAccount>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add ArtistAccount
        public void Add(ArtistAccount artistAccount)
        {
            try
            {
                _context.Get<ArtistAccount>().Add(artistAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update ArtistAccount
        public void Update(ArtistAccount artistAccount)
        {
            try
            {
                _context.Get<ArtistAccount>().Update(artistAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete ArtistAccount
        public void Delete(ArtistAccount artistAccount)
        {
            try
            {
                artistAccount.IsDeleted = true;
                _context.Get<ArtistAccount>().Update(artistAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
