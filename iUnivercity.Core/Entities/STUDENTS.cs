using iUnivercity.Core.Entities.Base;
using iUnivercity.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iUnivercity.Core.Entities
{
    public class STUDENTS : Entity
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public GenderEnum Gender { get; set; }
        
        public int CurrentGradeLevel { get; set; }
        
        public int DepartmentId { get; set; }

        public CITIES CITIES { get; set; }
        
        public DEPARTMENTS DEPARTMENTS { get; set; }
    }
}
