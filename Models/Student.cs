using System.Reflection.Metadata.Ecma335;

namespace Management.Models;

public class Student : Person
{
    public string EnrollmentStundent { get; set; }
    public string CurrentClass { get; set; }
    public decimal GradeHistory { get; set; }
    public DateTime? Frequency { get; set; }

    public Student()
    {
        
    }
    
    public Student(string name, string? socialSecurityNumber, DateTime dateBirth, string address )
    {
        Name = name;
        SocialSecurityNumber = socialSecurityNumber;
        DateBirth = dateBirth;
        Address = address;
    }
    
    public Student(string enrollmentStundent, string currentClass, decimal gradeHistory, DateTime frequency)
    {
        EnrollmentStundent = enrollmentStundent;
        CurrentClass = currentClass;
        GradeHistory = gradeHistory;
        Frequency = frequency;
    }

    // public decimal StudentGradePointAverage()
    // {
    //        
    // }

    public enum Status
    {
        Active = 1,
        Inactive = 2,
        Transferred = 3
    }
    
    public void StatusStudent()
    {
        Status statusActive = Status.Active;
        Status statusInactive = Status.Inactive;
        Status statusTransferred = Status.Transferred;
        //Como eu faria para atribuir esses status para alunos?
        Console.WriteLine("DIGITE: 1 - ATIVO | 2 - INATIVO | 3 - TRANSFERIDO");
        Status myStatus = Enum.Parse<Status>(Console.ReadLine());
        switch (myStatus)
        {
            case Status.Active:
                Console.WriteLine("Status Active");
                break;
            case Status.Inactive:
                Console.WriteLine("Status Inactive");
                break;
            case Status.Transferred:
                Console.WriteLine("Status Transferred");
                break;
        }

    }
    
    
    public Student GetByMatricula(string enrollment)
    {
        throw new NotImplementedException();
    }
}