﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SMS
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Student Menu:");
                Console.WriteLine("1: Add Student");
                Console.WriteLine("2: Update Student");
                Console.WriteLine("3: Delete Student");
                Console.WriteLine("4: Search Student");
                Console.WriteLine("5: Display All Students");
                Console.WriteLine("6: Exit");
                Console.Write("Enter your Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddStudent();
                        break;
                    case 2:
                        manager.UpdateStudent();
                        break;
                    case 3:
                        manager.DeleteStudent();
                        break;
                    case 4:
                        manager.SearchStudent();
                        break;
                    case 5:
                        manager.DisplayAllStudents();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid value, Try Again.......");
                        break;
                }
                Console.WriteLine("Press Any Key To Continue.......");
                Console.ReadLine();
            } while (choice != 6);
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ClassName { get; set; }
        public string ContactInfo { get; set; }
    }

    public class StudentManager
    {
        private List<Student> students = new List<Student>();
        private int nextID = 1;

        public void AddStudent()
        {
            Student student = new Student();
            student.ID = nextID++;
            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Class: ");
            student.ClassName = Console.ReadLine();
            Console.Write("Enter Contact Information: ");
            student.ContactInfo = Console.ReadLine();

            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        public void UpdateStudent()
        {
            Console.Write("Enter Student ID to edit: ");
            int id = int.Parse(Console.ReadLine());
            Student student = students.FirstOrDefault(s => s.ID == id);

            if (student != null)
            {
                Console.Write("Enter new Name (leave blank to keep current): ");
                string name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) student.Name = name;

                Console.Write("Enter new Age (leave blank to keep current): ");
                string ageInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(ageInput)) student.Age = int.Parse(ageInput);

                Console.Write("Enter new Class (leave blank to keep current): ");
                string className = Console.ReadLine();
                if (!string.IsNullOrEmpty(className)) student.ClassName = className;

                Console.Write("Enter new Contact Information (leave blank to keep current): ");
                string contactInfo = Console.ReadLine();
                if (!string.IsNullOrEmpty(contactInfo)) student.ContactInfo = contactInfo;

                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DeleteStudent()
        {
            Console.Write("Enter Student ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Student student = students.FirstOrDefault(s => s.ID == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void SearchStudent()
        {

        }



        private void DisplayStudents(List<Student> studentsList)
        {

        }
    }
}