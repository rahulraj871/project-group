using group;
using project;
using student;
using System;

namespace project_group
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Assigning project to group
            Project p1 = new Project
            {
                Name = "proj1",
                Description = "ATS",
                Status = true
            };
            Project p2 = new Project
            {
                Name = "proj2",
                Description = "Metal",
                Status = true
            };
            Project p3 = new Project
            {
                Name = "proj3",
                Description = "Rec",
                Status = true
            };
         
            Group gmedium = new Group
            {
                GroupName = "medium",
                Numberofstudents = 10,
                ProjectName = p1
            };
            Group gadvance = new Group
            {
                GroupName = "advance",
                Numberofstudents = 11,
                ProjectName = p2
            };
            Group gsmall = new Group
            {
                GroupName = "small",
                Numberofstudents = 12,
                ProjectName = p3
            };
            Student s = new Student
            {
                ID = 1,
                Name = "Gautam Bhindi",
                Studentgroup = gmedium
            };

            Console.WriteLine(gsmall.Numberofstudents);
            Console.WriteLine(gmedium.Numberofstudents);
            Console.WriteLine(gadvance.Numberofstudents);
            Console.WriteLine(s.ID);
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Studentgroup.GroupName);
            Console.WriteLine(s.Studentgroup.ProjectName.Name);



        }
    }
}
