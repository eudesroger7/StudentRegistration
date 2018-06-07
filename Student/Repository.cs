using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Repository
    {
        private ArrayList repository;

        public Repository()
        {
            this.repository = new ArrayList();
        }

        public void insert(Student student)
        {
            this.repository.Add(student);
        }

        public void remove(Student student)
        {
            this.repository.Remove(student);
        }

        public void update(Student student, int index)
        {
            this.repository.Insert(index, student);
        }

        public Student search(long matriculation)
        {   
            foreach(Student student in this.repository)
            {
                if(student.getMatriculation() == matriculation)
                {
                    return student;
                }
            }
            return null;
        }

        public bool exist(long matriculation)
        {
            bool exist = false;

            foreach (Student student in this.repository)
            {
                if (student.getMatriculation() == matriculation)
                {
                    exist = true;
                }
            }

            return exist;
        }

        public string show()
        {
            string str = "";

            foreach (Student student in this.repository)
            {
                str = str + (
                    "\n------------------------\n" +
                    "Name: " + student.getName() +
                    "\nMatriculation: " + student.getMatriculation() +
                    "\nSerie: " + student.getSerie() +
                    "\nClass: " + student.getClassId() +
                    "\nTeacher: " + student.getTeacher() +
                    "\nNote 1: " + student.getNote1() +
                    "\nNote 2: " + student.getNote2() +
                    "\nNote 3: " + student.getNote3() +
                    "\nNote 4: " + student.getNote4() +
                    "\nFinal Note: " + student.getFinalNote() +
                    "\n------------------------\n"
                 );
            }

            return str;
        }
    }
}
