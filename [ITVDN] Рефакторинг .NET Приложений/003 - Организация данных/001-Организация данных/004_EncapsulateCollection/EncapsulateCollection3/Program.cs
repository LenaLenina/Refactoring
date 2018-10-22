using System;
using System.Diagnostics;
using System.Collections.Generic;

// Encapsulate Collection (Инкапсуляция коллекции). 217 -218 стр. 

namespace EncapsulateCollection
{
    class Course
    {
        string name;
        bool isAdvanced;

        public Course(string name, bool isAdvanced)
        {
            this.name = name;
            this.isAdvanced = isAdvanced;
        }

        public string GetName()
        {
            return name;
        }

        public bool IsAdvanced()
        {
            return isAdvanced;
        }
    }

    class Person
    {
        List<Course> courses = new List<Course>();

        public void AddCourse(Course arg)
        {
            courses.Add(arg);
        }

        public void RemoveCourse(Course arg)
        {
            courses.Remove(arg);
        }

        public IList<Course> GetCourses()
        {
            return courses.AsReadOnly(); // ReadOnlyCollection<Course>
        }

        public void InitializeCourses(List<Course> courses)
        {
            Trace.Assert(this.courses.Count == 0);
            this.courses.AddRange(courses);
        }       
    }

    class Program
    {
        static void Main()
        {
            Person kent = new Person();
            kent.AddCourse(new Course("Smalltalk Programming", false));
            kent.AddCourse(new Course("Appreciating Single Malts", true));
            kent.AddCourse(new Course("Refactoring", true));
            kent.AddCourse(new Course("Brutal Sarcasm", false));
                        
            foreach (Course item in kent.GetCourses())
            {
                if (item.IsAdvanced())
                    Console.WriteLine(item.GetName());
            }

            kent.InitializeCourses(new List<Course>());

            // Delay.
            Console.ReadKey();
        }
    }
}
