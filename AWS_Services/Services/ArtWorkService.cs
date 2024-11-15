using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Exceptions;
using AWS_Repository.Identity;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class ArtWorkService : IArtWorkService
    {
        private readonly IArtWorkRepository _artWorkRepository;
        public ArtWorkService(IArtWorkRepository artWorkRepository)
        {
            _artWorkRepository = artWorkRepository;
        }
        public void Add(ArtWorkModel artWork)
        {
            try
            {
                _artWorkRepository.Add(artWork);
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            //throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            try
            {
                _artWorkRepository.Delete(id);
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
                      
            //throw new NotImplementedException();
        }

        public List<ArtWork> GetAll()
        {
            try
            {
                return _artWorkRepository.GetAll();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
                     
        }

        public ArtWork GetById(Guid id)
        {
            try
            {
                return _artWorkRepository.GetById(id);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void Update(ArtWork artWork)
        {
            try
            {
                _artWorkRepository.Update(artWork);
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
                       
        }
    }
}
