using iUnivercity.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iUnivercity.Core.Entities
{
    public class TEACHERS_SUBJECTS : Entity
    {
      public int  TeacherId { get; set; }
      public int SubjectId { get; set; }

      public SUBJECTS SUBJECTS { get; set; } 
        
      public TEACHERS TEACHERS { get; set; }
        
    }
}
