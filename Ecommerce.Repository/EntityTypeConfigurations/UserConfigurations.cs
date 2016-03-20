using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Ecoomerce.Domain.Entities;

namespace Ecommerce.Repository.EntityTypeConfigurations
{
    class UserConfigurations: EntityTypeConfiguration<User>
    {

    }
}
