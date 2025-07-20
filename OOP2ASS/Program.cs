using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace OOP2ASS
{
    #region Q1
    //struct Rectangle
    //{
    //        #region Attributes 
    //        private double widht;
    //        private double height;
    //        #endregion

    //        #region Properties
    //        public double Widht
    //        {
    //            get { return widht; }

    //            set {
    //            if (value >0)
    //               widht = value;
    //            else 
    //                Console.WriteLine("Invalid width value");
    //            }
    //        }

    //        public double Height
    //        {
    //            get { return height; }
    //            set
    //            {
    //            if (value > 0)
    //                height = value;
    //            else
    //                Console.WriteLine("Invalid height value");
    //            }
    //        }

    //        public double Area
    //        {
    //           get { return widht * height; }
    //        }
    //    #endregion

    //        #region Methods
    //    public void DisplayInfo()
    //    { 
    //     Console.WriteLine ($"InfoOfRectangle \n Width:{widht},Height:{height}\n Area : {Area}");
    //    }
    //    #endregion
    //}
    #endregion

    #region Q2
    //#region Enums
    //     enum GenderType
    //     {
    //        Male,Female
    //     }

    //     enum SecurityPrivileges 
    //     {
    //        guest, Developer, secretary , DBA
    //     }
    //    #endregion
    //class Employee
    //{
    //    #region Attributes
    //    private int id;
    //    private string? name;
    //    private double salary;
    //    private DateTime hireDate;
    //    private GenderType gender;
    //    private SecurityPrivileges securityLevel;

    //    #endregion

    //    #region Properties
    //    public int Id { set {id = value; }  get {return id; }}
    //    public string? Name { set { name = value; } get { return name; } }
    //    public double Salary
    //    {
    //        set
    //        {
    //            if (value > 0)
    //                salary = value;
    //            else
    //                Console.WriteLine("Invalid salary value");

    //        }
    //        get { return salary; }
    //    }
    //    public DateTime HireDate { set { hireDate = value; } get { return hireDate; } }

    //    public GenderType Gender { 
    //        set
    //        {
    //            gender = value; 
    //        } 

    //        get { return gender; }
    //    }
    //    public SecurityPrivileges SecurityLevel { set { securityLevel =value; } get {return securityLevel; } }




    //    #endregion

    //    #region Methods
    //    override public string ToString()
    //    {
    //       return $"Employee Info:\n" +
    //              $"ID: {id}\n" +
    //              $"Name: {name}\n" +
    //              $"Security Level: {securityLevel}\n" +
    //              $"Salary: {string.Format("{0:C}", salary)}\n" +
    //              $"Hire Date: {hireDate.ToShortDateString()}\n" +
    //              $"Gender: {gender}";
    //    }

    //    #endregion

    //}
    #endregion

    #region Q3
    //class HireDate
    //{
    //    //#region Attributes
    //    //private int day;
    //    //private int month;
    //    //private int year;
    //    //#endregion

    //    //#region Properties
    //    //public int Day
    //    //{
    //    //    get { return day; }
    //    //    set
    //    //    {
    //    //        if (value >=1 && value <=31 )
    //    //            day = value;
    //    //        else
    //    //            Console.WriteLine("Invalid day value");
    //    //    }

    //    //}
    //    //public int Month
    //    //{
    //    //    get { return month; }
    //    //    set
    //    //    {
    //    //        if (value >= 1 && value <= 12)
    //    //            month = value;
    //    //        else
    //    //            Console.WriteLine("Invalid month value");
    //    //    }

    //    //}
    //    //public int Year
    //    //{
    //    //    get { return year; }
    //    //    set
    //    //    {
    //    //        if (value > 1900 && value <= DateTime.Now.Year)
    //    //            year = value;
    //    //        else
    //    //            Console.WriteLine("Invalid year value");
    //    //    }
    //    //}
    //    //#endregion

    //    //#region Methods
    //    //override public string ToString()
    //    //{
    //    //    return $"{day:D2}/{month:D2}/{year}";
    //    //}
    //    //#endregion


    //}
    #endregion

    #region Q4
    //#region Enums
    //[Flags]
    //enum Permission
    //{
    //    Read = 1,
    //    Write = 2,
    //    Execute = 4,
    //    Delete = 8,
    //}
    //enum SecurityLevel
    //{
    //    DBA, Guest, SecurityOfficer
    //}
    //#endregion
    //class Employee
    //{
    //    #region Attributes
    //    private int id;
    //    private string? name;
    //    private double salary;
    //    private DateTime hireDate;
    //    private SecurityLevel securityLevel;
    //    private Permission permissions;
    //    #endregion

    //    #region Setters and Getters
    //    public void SetId(int id)
    //    {
    //        this.id = id;
    //    }
    //    public int GetId()
    //    {
    //        return id;
    //    }
    //    public void SetName(string name)
    //    {
    //        this.name = name;
    //    }
    //    public string? GetName()
    //    {
    //        return name;
    //    }
    //    public void SetSalary(double salary)
    //    {
    //        this.salary = salary;
    //    }
    //    public double GetSalary()
    //    {
    //        return salary;
    //    }
    //    public void SetHireDate(DateTime hireDate)
    //    {
    //        this.hireDate = hireDate;
    //    }
    //    public DateTime GetHireDate()
    //    {
    //        return hireDate;
    //    }
    //    public void SetSecurityLevel(SecurityLevel securityLevel)
    //    {
    //        this.securityLevel = securityLevel;
    //    }
    //    public SecurityLevel GetSecurityLevel()
    //    {
    //        return securityLevel;
    //    }
    //    public void SetPermissions(Permission permissions)
    //    {
    //        this.permissions = permissions;
    //    }
    //    public Permission GetPermissions()
    //    {
    //        return permissions;
    //    }

    //    #endregion

    //    #region Constructors

    //    public Employee()
    //    {
    //        id = 0;
    //        name = "";
    //        salary = 0.0;
    //        hireDate = DateTime.Now;
    //        securityLevel = 0;
    //        permissions = 0;
    //    }
    //    public Employee(int id, string name, double salary, DateTime hireDate, SecurityLevel securityLevel, Permission permissions)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.salary = salary;
    //        this.hireDate = hireDate;
    //        this.securityLevel = securityLevel;
    //        this.permissions = permissions;
    //    }
    //    #endregion

    //    #region properties
    //    public int Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }
    //    public string? Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //    public double Salary
    //    {
    //        get { return salary; }
    //        set
    //        {
    //            if (value > 0)
    //                salary = value;
    //            else
    //                Console.WriteLine("Invalid salary value");
    //        }
    //    }
    //    public DateTime HireDate
    //    {
    //        get { return hireDate; }
    //        set { hireDate = value; }
    //    }
    //    public SecurityLevel SecurityLevel
    //    {
    //        get { return securityLevel; }
    //        set { securityLevel = value; }
    //    }
    //    public Permission Permissions
    //    {
    //        get { return permissions; }
    //        set { permissions = value; }
    //    }
    //    #endregion

    //    #region Methods
    //    public override string ToString()
    //    {
    //        return $"Employee Info:\n" +
    //               $"ID: {id}\n" +
    //               $"Name: {name}\n" +
    //               $"Security Level: {securityLevel}\n" +
    //               $"Salary: {string.Format("{0:C}", salary)}\n" +
    //               $"Hire Date: {hireDate.ToShortDateString()}\n" +
    //               $"Permissions: {permissions}";
    //    }
    //    #endregion

    //}
    #endregion

    #region Q6
    //class Book
    //{
    //    public string? Title { get; set; }
    //    public string? Author { get; set; }
    //    public string? ISBN { get; set; }

    //    public Book(string Title,string Author,string ISBN) 
    //    {
    //        this.Title = Title;
    //        this.Author = Author;   
    //        this.ISBN = ISBN;
    //    }
    //    public virtual void DisplayInfo()
    //    {
    //        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}");
    //    }

    //}
    //class EBook : Book
    //{ 
    // public double FileSize { get; set; }
     
    // public EBook(string Title, string Author, string ISBN, double FileSize) :base(Title,Author,ISBN)
    // {
    //        this.FileSize = FileSize;
    // }
    // public override void DisplayInfo()
    // {
    //        base.DisplayInfo();
    //        Console.WriteLine($"File Size: {FileSize} MB");
    // }

    //}
    //class PrintedBook : Book
    //{
    //    public int PageCount { get; set; }
    //    public PrintedBook(string Title, string Author, string ISBN, int PageCount) : base(Title, Author, ISBN)
    //    {
    //        this.PageCount = PageCount;
    //    }
    //    public override void DisplayInfo()
    //    {
    //        base.DisplayInfo();
    //        Console.WriteLine($"Page Count: {PageCount}");
    //    }
    //}
    #endregion


    internal class Program
    {

        static void Main(string[] args)
        {
            #region CallQ1
            //Rectangle rectangle = new Rectangle();
            //rectangle.Widht = 12;
            //rectangle.Height = 6;
            //rectangle.DisplayInfo();
            #endregion

            #region CallQ2
            //Employee emp = new Employee();
            //emp.Id = 1;
            //emp.Name = "Karim Abdelghani";
            //emp.Salary = 50.000;
            //emp.HireDate = new DateTime(2004, 6, 23);
            //emp.Gender = GenderType.Male;
            //emp.SecurityLevel = SecurityPrivileges.Developer;

            //Console.WriteLine(emp);

            #endregion

            #region CallQ3
            //HireDate hireDate = new HireDate();
            //hireDate.Day = 23;
            //hireDate.Month = 6;
            //hireDate.Year = 2004;
            //Console.WriteLine($"Hire Date: {hireDate}");
            #endregion

            #region CallQ4 & CallQ5
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(1, "Karim", 50000, new DateTime(2023, 1, 1), SecurityLevel.SecurityOfficer, Permission.Read | Permission.Write | Permission.Execute | Permission.Delete);
            //EmpArr[1] = new Employee(2, "Salma", 60000, new DateTime(2021, 2, 2), SecurityLevel.DBA, Permission.Read | Permission.Write);
            //EmpArr[2] = new Employee(3, "Hoda", 70000, new DateTime(2022, 3, 3), SecurityLevel.Guest, Permission.Read);

            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //    Console.WriteLine();
            //}

            //#region Q5
            //Array.Sort(EmpArr, (e1, e2) => e1.HireDate.CompareTo(e2.HireDate));
            //Console.WriteLine("After Sorting by Hire Date:\n");
            //foreach (var emp in EmpArr)
            //    Console.WriteLine(emp + "\n");
            //#endregion
            #endregion

            #region CallQ6
            //EBook eBook = new EBook("C# Programming", "John Doe", "123-4567890123", 5.5);
            //PrintedBook printedBook = new PrintedBook("Learning OOP", "Jane Smith", "987-6543210987", 300);
            //Console.WriteLine("EBook Information:");
            //eBook.DisplayInfo();
            //Console.WriteLine("\nPrinted Book Information:");
            //printedBook.DisplayInfo();
            #endregion

        }
    }
}
