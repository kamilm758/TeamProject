using FormGenerator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.DTOs.FieldDependency;
using TeamProject.Infrastructure.Enums;

namespace TeamProject.Models.FieldDependencyModels
{
    public class FieldFieldDependency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDependency { get; set; } //id zależności
        public int Id { get; set; } //id pola którego dotyczy zależność
        public Field ThisField { get; set; } //instancja pola którego dotyczy zależność
        public FieldFieldDependencyType DependencyType { get; set; } //typ zależności
        public List<Field> RelatedFields { get; set; } = new List<Field>(); //pola zależne od wartości pola
        public string ActivationValue { get; set; } //wartość pola która aktywuje zależność

        public FieldFieldDependency(Field thisField, FieldFieldDependencyType dependencyType, string activationValue)
        {
            this.ThisField = thisField;
            Id = thisField.Id;
            DependencyType = dependencyType;
            ActivationValue = activationValue;
        }
        public FieldFieldDependency() { }

        public void Build(CreateDependencyDTO createDependency, FormGeneratorContext _context)
        {
            if(createDependency.DependencyType== "FieldDuplication")
            {
                for(int i = 0; i < Convert.ToInt32(createDependency.ActivationValue); i++)
                {
                    Field field = new Field { Name = createDependency.CurrentFieldName + $" {i + 1}", Type = "text" };
                    this.RelatedFields.Add(field);
                }
            }
            this.ThisField = _context.Field.AsNoTracking().FirstOrDefault(f => f.Name == this.ThisField.Name);
            this.Id = this.ThisField.Id;
        }
    }
}