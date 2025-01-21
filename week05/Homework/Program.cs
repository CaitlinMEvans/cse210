// Added Creativity: dueDate
// Class Design is in the design.md file

using System;

// Base Class
public class Assignment
{
    // Base attributes shared by all assignments
    private string _studentName;
    private string _topic;
    private string _classType;
    private DateTime _dueDate;

    // Base constructor to initialize common attributes
    public Assignment(string studentName, string topic, string classType, DateTime dueDate)
    {
        _studentName = studentName;
        _topic = topic;
        _classType = classType;
        _dueDate = dueDate;
    }

    // Provides a brief summary of the assignment
    public virtual string GetSummary()
    {
        return $"{_studentName} - {_topic} ({_classType})";
    }

    // Accessor for the due date
    public DateTime GetDueDate()
    {
        return _dueDate;
    }
}

// Derived Class: MathAssignment
public class MathAssignment : Assignment
{
    // Attributes specific to math assignments
    private string _textbookSection;
    private string _problems;

    // Constructor initializing both base and math-specific attributes
    public MathAssignment(string studentName, string topic, string classType, DateTime dueDate, string textbookSection, string problems)
        : base(studentName, topic, classType, dueDate)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Provides detailed math homework instructions
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

// Derived Class: WritingAssignment
public class WritingAssignment : Assignment
{
    // Attribute for writing assignment title
    private string _title;

    // Constructor for writing assignments
    public WritingAssignment(string studentName, string topic, string classType, DateTime dueDate, string title)
        : base(studentName, topic, classType, dueDate)
    {
        _title = title;
    }

    // Provides information specific to writing assignments
    public string GetWritingInformation()
    {
        return $"{_title} by {GetSummary().Split(' ')[0]}";
    }
}

// Derived Class: dadaAssignment
public class dadaAssignment : Assignment
{
    // Unique attribute for lesson name
    private string _lessonName;

    // Constructor for DADA assignments
    public dadaAssignment(string studentName, string topic, string classType, DateTime dueDate, string lessonName)
        : base(studentName, topic, classType, dueDate)
    {
        _lessonName = lessonName;
    }

    // Provides lesson-specific details
    public string GetLessonDetails()
    {
        return $"Lesson: {_lessonName}";
    }

    // Overrides the base GetSummary() to include lesson details
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - {GetLessonDetails()}";
    }
}

// Program Entry Point
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hogwarts Assignments!");

        // Create Math Assignment
        var mathAssignment = new MathAssignment(
            "Hermione Granger",
            "Advanced Arithmancy Equations",
            "Arithmancy",
            new DateTime(2025, 2, 10),
            "7.3",
            "3-10, 20-21"
        );

        // Create Writing Assignment
        var writingAssignment = new WritingAssignment(
            "Harry Potter",
            "The History of Horcruxes",
            "Defense Against the Dark Arts",
            new DateTime(2025, 2, 15),
            "The Dark Artifacts"
        );

        // Create Defense Against the Dark Arts Assignment
        var dadaAssignment = new dadaAssignment(
            "Draco Malfoy",
            "Blocking Advanced Motions",
            "Defense Against the Dark Arts",
            new DateTime(2025, 2, 8),
            "Advanced Blocking Part 1"
        );

        // Display Math Assignment Details
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine($"Due Date: {mathAssignment.GetDueDate():MM/dd/yyyy}\n");

        // Display Writing Assignment Details
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine($"Due Date: {writingAssignment.GetDueDate():MM/dd/yyyy}\n");

        // Display Defense Against the Dark Arts Assignment Details
        Console.WriteLine(dadaAssignment.GetSummary());
        Console.WriteLine($"Due Date: {dadaAssignment.GetDueDate():MM/dd/yyyy}\n");
    }
}