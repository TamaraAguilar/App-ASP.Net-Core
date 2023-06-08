using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class CursoInstructor
    {
        [Key]
        public int InstructorId {get; set;}
        [Key]
        public int CursoId {get; set;}
        public Curso Curso {get; set;}
        public Instructor Instructor {get; set;}
    
    }
}