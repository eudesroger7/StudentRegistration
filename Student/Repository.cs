using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Repository
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

        public void update(Student newStudent)
        {
            foreach(Student student in this.repository)
            {
                if(student.getMatriculation() == newStudent.getMatriculation())
                {
                    student.setName(newStudent.getName());
                    student.setSerie(newStudent.getSerie());
                    student.setClassId(newStudent.getClassId());
                    student.setTeacher(newStudent.getTeacher());
                    student.setNote1(newStudent.getNote1());
                    student.setNote2(newStudent.getNote2());
                    student.setNote3(newStudent.getNote3());
                    student.setNote4(newStudent.getNote4());
                    student.setFinalNote(newStudent.getFinalNote());
                }
            }
        }

        public String search(long matriculation)
        {   
            foreach(Student student in this.repository)
            {
                if(student.getMatriculation() == matriculation)
                {
                    string str = (
                        "\n------------------------\n" +
                        "Id: " + getIndex(student) +
                        "\nName: " + student.getName() +
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

                    return str;
                }
            }
            return null;
        }

        public string show()
        {
            string str = "";

            foreach (Student student in this.repository)
            {
                str = str + (
                    "\n------------------------\n" +
                    "Id: " + getIndex(student) +
                    "\nName: " + student.getName() +
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

        public int getIndex(Student student)
        {
            int index = this.repository.IndexOf(student);
            

            return index;
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

        public bool isEmpty()
        {
            if(this.repository.Count < 1) {return true;}
            else {return false;}
        }


    }
}
