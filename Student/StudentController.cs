using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentController
    {
        private Repository repository;

        public StudentController()
        {
            this.repository = new Repository();
        }
        
        public string create(Student student)
        {
            if (this.repository.exist(student.getMatriculation()))
            {
                return "Student is already registered!";
            }
            else
            {
                this.repository.insert(student);
                return "Student successfully registered!";
            }
        }

        public string modify(Student student)
        {
            if (!this.repository.exist(student.getMatriculation()))
            {
                return "Student does not exist!";
            } else
            {
                this.repository.update(student);
                return "Information was updated";
            }
        }

        public string delete(Student student)
        {
            if (!this.repository.exist(student.getMatriculation()))
            {
                return "Student does not exist!";
            }
            else
            {
                this.repository.remove(student);
                return "Deleted student!";
            }
        }

        public string search(long matriculation)
        {
            if (!this.repository.exist(matriculation))
            {
                return "Student does not exist!";
            }
            else
            {
                return this.repository.search(matriculation);
            }
        }

        public string show()
        {
            if (this.repository.isEmpty())
            {
                return "Empty repository!";
            }
            else
            {
                return this.repository.show();
            }
        }
    }
}
