using System;
namespace StringExercise {
    public class StudentInput {
        public string[] NewArray() {
            string [] students = {"Emily","Harry","Rupert","Clara","Lily","Michael"};
            foreach(string student in students ){
                Console.WriteLine("Have you seen "+ student +" ?");
            }
                Console.WriteLine("------------------------");
            for(int i = students.Length -1 ; i >= 0; i--){
                Console.WriteLine("Have you seen "+ students[i] +" ?");
            }
           return students;
        }
    }
    class Program{
        static void Main (string [] args){
            StudentInput school = new StudentInput();
            string[] student = school.NewArray();
        }
    }
}
