using BP.Models.ViewModels;
using System.Collections.Generic;

namespace BP.Services.Field
{
    public interface IFieldService
    {
        List<FieldVM> GetListOfFields();
        List<FieldVM> GetFieldsByCity(string city);
        List<FieldVM> GetFieldsBySportNames(string sportTypeNames);
    }
}
