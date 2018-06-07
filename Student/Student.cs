using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string name;
        private long matriculation;
        private char serie;
        private char classId;
        private string teacher;
        private double note1;
        private double note2;
        private double note3;
        private double note4;
        private double finalNote;
        
        //constructor
        public Student()
        {
            this.name = null;
            this.matriculation = 0;
            this.serie = ' ';
            this.classId = ' ';
            this.teacher = null;
            this.note1 = 0;
            this.note2 = 0;
            this.note3 = 0;
            this.note4 = 0;
            this.finalNote = 0;
        }

        //getters
        public string getName() { return this.name; }
        public long getMatriculation() { return this.matriculation; }
        public char getSerie() { return this.serie; }
        public char getClassId() { return this.classId; }
        public string getTeacher() { return this.teacher; }
        public double getNote1() { return this.note1; }
        public double getNote2() { return this.note2; }
        public double getNote3() { return this.note3; }
        public double getNote4() { return this.note4; }
        public double getFinalNote() { return this.finalNote; }

        //setters
        public void setName(string name) { this.name = name; }
        public void setMatriculation(long matriculation) { this.matriculation = matriculation; }
        public void setSerie(char serie) { this.serie = serie; }
        public void setClassId(char classId) { this.classId = classId; }
        public void setTeacher(string teacher) { this.teacher = teacher; }
        public void setNote1(double note) { this.note1 = note; }
        public void setNote2(double note) { this.note2 = note; }
        public void setNote3(double note) { this.note3 = note; }
        public void setNote4(double note) { this.note4 = note; }
        public void setFinalNote(double note) { this.finalNote = note; }

    }
}
