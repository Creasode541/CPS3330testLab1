// Michael Banko - CPS3330 Lab 5
// we can use LINQ to sort an array of StudentInfo objects
using System.Xml.Linq;

var students = new[]
{
    new StudentInfo { ID = 2, FirstName = "Jane", LastName = "Doe", GradeLevel = 3 },
    new StudentInfo { ID = 1, FirstName = "John", LastName = "Doe", GradeLevel = 1 },
    new StudentInfo { ID = 50001, FirstName = "Yulia", LastName = "Kumar", GradeLevel = 6 },
    new StudentInfo { ID = 1228548, FirstName = "Michael", LastName = "Banko", GradeLevel = 16}
};

// LINQ query to order students by grade level
var orderedStudents = 
    from s in students
    where s.ID >= 50000
    orderby s.ID
    select s;

foreach (var student in orderedStudents)
    Console.WriteLine($"{student.FirstName} has an ID number of {student.ID}");

var numbers = new List<int> {1, 2, 2, 8, 5, 4, 8};

Console.WriteLine($"Does the list have any numbers? {numbers.Any()}");
Console.WriteLine($"Total count of numbers: {numbers.Count()}");
Console.WriteLine($"First number: {numbers.First()}");
Console.WriteLine($"Last number: {numbers.Last()}");


IEnumerable<int> distinctNumbers = numbers.Distinct();
foreach (int number in distinctNumbers)
    Console.WriteLine(number);

List<StudentInfo> studentList = new List<StudentInfo>
{
    students[0],
    students[1],
    students[2],
    students[3]
};
studentList.Insert(2, students[0]);

studentList.ForEach(s => Console.WriteLine(s.FirstName));
studentList.Count();
studentList.TrimExcess();
studentList.Remove(students[2]);


var studentList2 = studentList; // Assuming studentList is the list of students

var sortedStudents = from student in studentList2
                     let upperLastName = student.LastName.ToUpper()
                     orderby upperLastName descending
                     select new { student.FirstName, UpperLastName = upperLastName };

sortedStudents.ToList().ForEach(s => Console.WriteLine($"{s.FirstName},{s.UpperLastName}"));



        XElement studentInfo = new XElement("studentInfo",
            new XElement("name", "Dr. Yulia Kumar"),
            new XElement("enrollmentDay", "March 2 2024"),
            new XElement("courses",
                new XElement("courseInfo",
                    new XElement("code", "3330"),
                    new XElement("courseTitle", "Software Development with Frameworks"),
                    new XElement("degree", "CPS")
                ),
                new XElement("courseInfo",
                    new XElement("code", "4982"),
                    new XElement("courseTitle", "Special Topics in IT"),
                    new XElement("degree", "IT")
                )
            ),
            new XElement("address", "1000 Morris avenue")
        );

        XDocument studentDocument = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            studentInfo
        );

        Console.WriteLine(studentDocument);
try { 
string filePath = @"/Users/michaelbanko/Documents/VSC/LINQLab"; // Replace with yours
string xmlString = File.ReadAllText(filePath);
Console.WriteLine(xmlString);
XDocument doc = XDocument.Parse(xmlString); // Parse the XML string into an XDocument

// Use LINQ to retrieve specific information
var studentName = doc.Descendants("name").First().Value;
var enrollmentDay = (DateTime)doc.Descendants("enrollmentDay").First();
var courseCodes = doc.Descendants("code").Select(c => c.Value).ToList();
var courseTitles = doc.Descendants("courseTitle").Select(ct => ct.Value).ToList();
var courseDegrees = doc.Descendants("degree").Select(d => d.Value).ToList();
var address = doc.Descendants("address").First().Value;

// Display the information
Console.WriteLine("Student Name: " + studentName);
Console.WriteLine("Enrollment Day: " + enrollmentDay.ToString("yyyy-MM-dd"));
for (int i = 0; i < courseTitles.Count; i++)
{
    Console.WriteLine("Course Code: " + courseCodes[i]);
    Console.WriteLine("Course Title: " + courseTitles[i]);
    Console.WriteLine("Degree: " + courseDegrees[i]);
}
Console.WriteLine("Address: " + address);
}
catch (Exception ex)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(ex.Message);
}

public class StudentInfo : IComparable<StudentInfo> {
    public int ID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int GradeLevel { get; set; }

    // Implement the CompareTo method
    public int CompareTo(StudentInfo other)
    {
        // sorts students by their grade level 
        return this.GradeLevel.CompareTo(other.GradeLevel);
    }
}
