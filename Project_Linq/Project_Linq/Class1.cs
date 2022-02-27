using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Linq
{
    internal class Class1
    {
        public static void Main(string [] args)
        {
            // Create a data source by using a collection initializer.
             List<Student> students = new List<Student>
{
    new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
    new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
    new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
    new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
    new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
    new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
    new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
    new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
    new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
    new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
    new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
    new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}
};
            // Create the query.
            // The first line could also be written as "var studentQuery ="
           ///* IEnumerable<Student>*/var  studentQuery =
           //     from student in students
           //     where student.Scores[0] > 90
           //     orderby student.Scores[0] ascending
           //     //orderby student.First ascending
           //     select student;

           // // Execute the query.
           // // var could be used here also.
           // foreach (var item in studentQuery)
           // {
           //     //Console.WriteLine("{0}, {1}", student.Last, student.First);
           //     //Console.WriteLine();
           //     Console.WriteLine($"{item.First} {item.Last} {item.ID} {item.Scores[0]}");
           // }

            // Output:
            // Omelchenko, Svetlana
            // Garcia, Cesar
            // Fakhouri, Fadi
            // Feng, Hanying
            // Garcia, Hugo
            // Adams, Terry
            // Zabokritski, Eugene
            // Tucker, Michael

            // studentQuery2 is an IEnumerable<IGrouping<char, Student>>
            var studentQuery2 =
                from student in students
                group student by student.Last[1];

            // studentGroup is a IGrouping<char, Student>
            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup)
                {
                    Console.WriteLine($"{student.Last} {student.First}");
                }
            }

            // Output:
            // O
            //   Omelchenko, Svetlana
            //   O'Donnell, Claire
            // M
            //   Mortensen, Sven
            // G
            //   Garcia, Cesar
            //   Garcia, Debra
            //   Garcia, Hugo
            // F
            //   Fakhouri, Fadi
            //   Feng, Hanying
            // T
            //   Tucker, Lance
            //   Tucker, Michael
            // A
            //   Adams, Terry
            // Z
            //   Zabokritski, Eugene
        }
    }
}
