using System;
using System.Data.Entity;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Yeni bir öğrenci oluştur
                var student = new Student()
                {
                    FirstName = "Ahmet",
                    LastName = "Yılmaz",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    StudentNumber = "2024001"
                };

                // Öğrenciyi veritabanına ekle
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Öğrenci başarıyla eklendi!");
                Console.WriteLine($"Eklenen öğrenci: {student.FirstName} {student.LastName}");
                Console.ReadLine();
            }
        }
    }
} 