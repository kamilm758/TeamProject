using FormGenerator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Infrastructure.Enums;
using TeamProject.Models.FieldFieldDependencyModels;

namespace TeamProject.DTOs.FieldDependency
{
    public class CreateDependencyDTO
    {
        public string SuperiorFieldName { get; set; }
        public string DependencyType { get; set; }
        public string ActivationValue { get; set; }
        public List<Field> RelatedFields { get; set; } = new List<Field>();
        public string CurrentFieldName { get; set; }
        public string CurrentFieldType { get; set; }
        public string AllIndependentFieldsName { get; set; }

        public void UpdateIndependentFieldsList(IFieldDependenciesRepository repository, FormGeneratorContext context)
        {
            var allDependFields = repository.GetAllDependFields();
            var allIndependedFields = context.Field
                .ToList()
                .Where(f=> {
                    return (!allDependFields.Contains(f)) && (f.Name!=SuperiorFieldName) 
                        && (!RelatedFields.Contains(f));
                });

            AllIndependentFieldsName = JsonConvert.SerializeObject(allIndependedFields.Select(f => f.Name).ToList());
        }

        public void AddRelatedField(Field field)
        {
            if (!RelatedFields.Contains(field))
            {
                RelatedFields.Add(field);
            }
        }

        public string Valid()
        {
            if(DependencyType=="FieldDuplication" && !int.TryParse(ActivationValue,out _))
            {
                return "Maksymalna wartość musi być liczbą! Popraw błędy";
            }

            if (RelatedFields.FirstOrDefault(f => f.Name == SuperiorFieldName) != null)
            {
                return "Pole nadrzędne nie może być polem podrzędnym w jednej relacji!";
            }
            return null;
        }
    }
}
