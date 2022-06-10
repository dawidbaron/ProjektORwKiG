using BP.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BP.Services.Field
{

    public class FieldService  : IFieldService
    {
        private readonly DbContext _dbContext;
        public FieldService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<FieldVM> GetFieldsByCity(string city)
        {
            var fields = (from f in _dbContext.Set<Models.Fields.Field>()
                          where f.City.ToLower().Contains(city.ToLower())
                          select new FieldVM
                          {
                              FieldId = f.FieldId,
                              Name = f.FieldName,
                              OpenTime = f.OpenTime,
                              CloseTime = f.CloseTime,
                              City = f.City,
                              Address = f.Address,
                              Description = f.Description,
                              ImgUrl = f.ImgUrl,
                              PathUrl = f.PathUrl,
                              PriceHour = f.PriceHour,
                              DefaultPlayerLimit = f.DefaultPlayerLimit,
                              Payable = f.Payable,
                              FieldContactName = f.FieldContactName,
                              FieldContactEmail = f.FieldContactEmail,
                              FieldContactPhoneNumber = f.FieldContactPhoneNumber,
                              FieldTypeName = f.FieldTypeName,
                              SportTypeNames = f.SportTypeNames,
                              Dimensions=f.Dimensions
                          }).ToList();


            return fields;
        }

        public List<FieldVM> GetFieldsBySportNames(string sportTypeNames)
        {
            var fields = (from f in _dbContext.Set<Models.Fields.Field>()
                          where f.SportTypeNames.ToLower().Contains(sportTypeNames.ToLower())
                          select new FieldVM
                          {
                              FieldId = f.FieldId,
                              Name = f.FieldName,
                              OpenTime = f.OpenTime,
                              CloseTime = f.CloseTime,
                              City = f.City,
                              Address = f.Address,
                              Description = f.Description,
                              ImgUrl = f.ImgUrl,
                              PathUrl = f.PathUrl,
                              PriceHour = f.PriceHour,
                              DefaultPlayerLimit = f.DefaultPlayerLimit,
                              Payable = f.Payable,
                              FieldContactName = f.FieldContactName,
                              FieldContactEmail = f.FieldContactEmail,
                              FieldContactPhoneNumber = f.FieldContactPhoneNumber,
                              FieldTypeName = f.FieldTypeName,
                              SportTypeNames = f.SportTypeNames,
                              Dimensions = f.Dimensions
                          }).ToList();


            return fields;
        }

        public  List<FieldVM> GetListOfFields()
        {
            var listOfFields = (from f in _dbContext.Set<Models.Fields.Field>()
                                select new FieldVM
                                {
                                    FieldId = f.FieldId,
                                    Name = f.FieldName,
                                    OpenTime = f.OpenTime,
                                    CloseTime = f.CloseTime,
                                    City=f.City,
                                    Address=f.Address,
                                    Description=f.Description,
                                    ImgUrl = f.ImgUrl,
                                    PathUrl = f.PathUrl,
                                    PriceHour = f.PriceHour,
                                    DefaultPlayerLimit=f.DefaultPlayerLimit,
                                    Payable=f.Payable,
                                    FieldContactName=f.FieldContactName,
                                    FieldContactEmail = f.FieldContactEmail,
                                    FieldContactPhoneNumber = f.FieldContactPhoneNumber,
                                    FieldTypeName=f.FieldTypeName,
                                    SportTypeNames = f.SportTypeNames,
                                    Dimensions = f.Dimensions
                                }).ToList();
            return  listOfFields;
        }

    }
}
