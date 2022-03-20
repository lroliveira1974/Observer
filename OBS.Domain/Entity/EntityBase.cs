using System;
using FluentValidation.Results;

namespace OBS.Domain.Entity
{
    public abstract class EntityBase
    {

        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public int IdUsuarioAlteracao { get;set; }

        public ValidationResult ValidationResult { get; private set; }  



        protected EntityBase()
        {
            ValidationResult = new ValidationResult();            
        }


        public void InsertValidationError(string CodErro, string DescricaoErro)
        {
            ValidationResult.Errors.Add(new ValidationFailure(CodErro, DescricaoErro)); 
        }

    }
}
