// Michael Banko - CPS3330 Midterm SP24
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp4 {
    class LINQtoArray {
        static void Main(string[] args) {
            int[] array = {2, 6, 4, 12, 7, 8, 9, 13, 2};

            var orderedFilteredArray =
                 from element in array
                 where element < 7
                 orderby element
                 select element;

            PrintArray(orderedFilteredArray, "All values less than 7 and sorted:");

            KeanFaculty[] faculty = {
                new KeanFaculty("Smith", "John", 12345, "5 Bournbrook Rd", "A123", "Professor", 75000, new DateTime(2010, 5, 15)),
                new KeanFaculty("Brown", "Alan", 23412, "Dawlish Rd", "B234", "Assistant Professor", 60000, new DateTime(2015, 9, 20)),
                new KeanFaculty("Smith", "Colin", 41253, "23 Bristol Rd", "C345", "Associate Professor", 65000, new DateTime(2013, 3, 10)),
                new KeanFaculty("Hughes", "Richard", 52314, "18 Prichatts Rd", "D456", "Professor", 80000, new DateTime(2008, 7, 25)),
                new KeanFaculty("Murphy", "Paul", 16352, "37 College Rd", "E567", "Associate Professor", 70000, new DateTime(2017, 11, 30))
            };

            Array.Sort(faculty);
            PrintArray(faculty, "Faculty Sorted by Rank:");

            var salaryRange = 
                faculty.OrderBy(f => f.Salary);
            PrintArray(salaryRange, "Faculty sorted by Salary in ascending order:");
            
            var idRange =
                from f in faculty
                where f.ID > 19999 && f.ID <= 49999 
                select f;
            PrintArray(idRange, "Faculty with ID in Range 2000 to 49999");

            var nameSorted =
                from f in faculty
                orderby f.LastName, f.FirstName
                select f;
            PrintArray(nameSorted, "Faculty sorted in last name, first name order");

        }
        public static void PrintArray<T>(IEnumerable<T> arr, string message) {
            Console.WriteLine("{0}", message);

            foreach (var element in arr)
                Console.WriteLine(element);

            Console.WriteLine();
        }

    }
class KeanFaculty : IComparable<KeanFaculty> {
    public KeanFaculty(string ln, string fn, int id, string a, string office, string r, decimal sal, DateTime hireDate) {
        lastName = ln;
        firstName = fn;
        idNumber = id;
        address = a;
        officeNumber = office;
        rank = r;
        salary = sal;
        dateOfHire = hireDate;
    }
    public override string ToString() {
        return $"{firstName} {lastName} ({idNumber})\nAddress: {address}\nOffice: {officeNumber}\nRank: {rank}\nSalary: {salary:C}\nDate of Hire: {dateOfHire.ToShortDateString()}";
    }
    public string FirstName { get { return firstName; } }
    public string LastName { get { return lastName; } }
    public string Address { get { return address; } }
    public int ID { get { return idNumber; } }
    public string OfficeNumber { get { return officeNumber; } }
    public string Rank { get { return rank; } }
    public decimal Salary { get { return salary; } }
    public DateTime DateOfHire { get { return dateOfHire; } }
    private string firstName, lastName;
    private int idNumber;
    private string address;
    private string officeNumber;
    private string rank;
    private decimal salary;
    private DateTime dateOfHire;

    public int CompareTo(KeanFaculty other) {
        return string.Compare(this.Rank, other.Rank);
    }
}   

}
