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
            if (repository.exist(student.getMatriculation()))
            {
                return "Student is already registered!";
            }
            else
            {
                repository.insert(student);
                return "Student successfully registered!";
            }
        }

        public string modify(Student student)
        {
            if (!repository.exist(student.getMatriculation()))
            {
                return "Student does not exist!";
            } else
            {
                repository.update(student);
                return "Information was updated";
            }
        }

        public string delete(Student student)
        {
            if (!repository.exist(student.getMatriculation()))
            {
                return "Student does not exist!";
            }
            else
            {
                repository.remove(student);
                return "Deleted student!";
            }
        }

        public string search(Student student)
        {
            if (!repository.exist(student.getMatriculation()))
            {
                return "Student does not exist!";
            }
            else
            {
                return repository.search(student.getMatriculation());
            }
        }

        public string show()
        {
            if (repository.isEmpty())
            {
                return "Empty repository!";
            }
            else
            {
                return repository.show();
            }
        }
    }
}
