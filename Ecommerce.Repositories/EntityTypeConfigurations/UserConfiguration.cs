using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecoomerce.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;


namespace Ecommerce.Repositories.EntityTypeConfigurations
{
    class UserConfiguration: EntityTypeConfigurations<User>
    {
    }
}
