using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Instructor:IEntity
    {
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorSurname { get; set; }



		//add-migration mig_initDatabase
		//update-database
	}
}
