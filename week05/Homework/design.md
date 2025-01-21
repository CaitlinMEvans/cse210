Class Design for Harry Potter Themed Homework Assignments

1. Assignment (Base Class)
   ---------------------------------
   Attributes:
   - _studentName : string
   - _topic : string
   - _classType : string (Potions, Charms, DADA, etc.)
   - _dueDate : string (e.g., "01/31/2025")

   Methods:
   - GetSummary() : string
     Returns the student's name, topic, and class type.

2. MathAssignment (Derived Class)
   ---------------------------------
   Attributes:
   - _textbookSection : string (e.g., "7.3")
   - _problems : string (e.g., "3-10, 20-21")

   Methods:
   - GetHomeworkList() : string
     Returns the textbook section and problems.
   - GetSummary() : string
     Overrides the base method to include math-specific details.

3. WritingAssignment (Derived Class)
   ---------------------------------
   Attributes:
   - _title : string (e.g., "The History of House-Elf Rights")

   Methods:
   - GetWritingInformation() : string
     Returns the title and student's name.
   - GetSummary() : string
     Overrides the base method to include writing-specific details.

4. dadaAssignment (Derived Class)
    -------------------------------
    Attributes:
    - _lessonName: string
    Methods:
    - dadaAssignment(string studentName, string topic, string classType, DateTime dueDate, string lessonName)
    - GetLessonDetails(): string
    - GetSummary(): string

Example Output:
---------------------------------
Hermione Granger - Arithmancy (Potions)
Section 3.4 Problems 1-10 (Due: 02/01/2025)

Harry Potter - Defense Against the Dark Arts (Defense)
The History of House-Elf Rights by Harry Potter (Due: 02/03/2025)
