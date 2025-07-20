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

        }
    }
}
