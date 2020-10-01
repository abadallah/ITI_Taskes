using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq3
{
    class Program
    {
        static Company sd = new Company();


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome in Company Manger");

            while (true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("To insert New Empolyee Enter 1");
                Console.WriteLine("To insert New Department Enter 2");
                Console.WriteLine("To list All Empolyee Enter 3");
                Console.WriteLine("To list All Department Enter 4");
                Console.WriteLine("To Delete a Department Enter 5");
                Console.WriteLine("To  Delete an Employee Enter 6");
                Console.WriteLine("To  Update a Department Enter 7");
                Console.WriteLine("To  Update an Employee Enter 8");
                Console.WriteLine("Go Out 9");

                Console.WriteLine("------------------------------------");
                Console.Write("Enter The Number : ");
                int OPNum = int.Parse(Console.ReadLine());
                if (OPNum == 9) { Console.WriteLine("Bye"); break; }//go out
                else if (OPNum == 1) //insert emp
                {
                    Console.WriteLine("------");

                    Console.Write("Enter Name : ");
                    string Name = Console.ReadLine();

                    Console.Write("Enter Salery : ");
                    int Salery = int.Parse(Console.ReadLine());

                    Console.Write("Enter Dep Number : ");
                    int DpNum = int.Parse(Console.ReadLine());
                    if (ChkDep(DpNum) == null) { Console.WriteLine("this Dep dosn't exist"); DpNum = 0; };

                    Employee Newemp = new Employee()
                    {
                        Em_Name = Name,
                        Salery = Salery,
                        Department = DpNum == 0 ? (int?)null : DpNum
                    };
                    InsertEmplyee(Newemp);
                    Console.WriteLine("");
                    Console.WriteLine("press Again to Back");
                } //insert emp
                else if (OPNum == 2)
                {

                    Console.WriteLine("------");

                    Console.Write("Enter Dep Name : ");
                    string DepName = Console.ReadLine();
                    Department NewDep = new Department()
                    {
                        Dep_Name = DepName

                    };

                    InsertDepartment(NewDep);
                    Console.WriteLine("");
                    Console.WriteLine("press Again to Back");

                } //insert dep
                else if (OPNum == 3)
                {
                    sd.Employees.ToList().ForEach(a => { Console.WriteLine($"ID :{a.ID} name : {a.Em_Name} salery : {a.Salery}  Dep : {a?.Department1?.Dep_Name}"); });
                    Console.WriteLine("");
                    Console.WriteLine("press Again to Back");
                } //List All Dep
                else if (OPNum == 4)
                {
                    Console.WriteLine("");
                    sd.Departments.ToList().ForEach(a => { Console.WriteLine($"ID :{a.ID} name : {a.Dep_Name}"); });
                    Console.WriteLine("");
                    Console.WriteLine("press Again to Back");

                } //List All Emp
                else if (OPNum == 5)//Delete a Dep
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter Dep Id : ");
                    int DepID = int.Parse(Console.ReadLine());
                    DelteAllEmpinDep(DepID);
                    DelteDep(DepID);

                } //Delete Department
                else if (OPNum == 6)//Delete a Emp
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter Emp Id : ");
                    int EmpID = int.Parse(Console.ReadLine());
                    DelteEmp(EmpID);

                } //Delete Emp
                else if (OPNum == 7)
                {
                    Console.WriteLine("");
                    Console.Write("Enter Dep ID : ");
                    int DepID = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------");
                    Console.WriteLine("Old Value ");
                    var Dep = ChkDep(DepID);
                    if (Dep != null)
                    {
                        Console.WriteLine($" ID : {Dep.ID} Name {Dep.Dep_Name} ");
                        Console.WriteLine("");
                        Console.WriteLine("Enter New Values");
                        Console.Write("Enter Dep Name : ");
                        string DepName = Console.ReadLine();
                        UpdateDepartment(DepName, DepID);
                    }
                    else
                    {
                        Console.WriteLine("This Department Dosen't Exist");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("press Again to Back");
                } //Update Dep
                else if (OPNum == 8)
                {
                    Console.WriteLine("");
                    Console.Write("Enter Emp ID : ");
                    int DepID = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------");
                    Console.WriteLine("Old Value ");
                    var Emp = ChkEmp(DepID);
                    if (Emp != null)
                    {
                        Console.WriteLine($" ID : {Emp.ID}  Name : {Emp.Em_Name} Salery : {Emp.Salery}  Dep : {Emp.Department1?.Dep_Name}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter New Values");
                        Console.Write("Enter Name : ");
                        string Name = Console.ReadLine();

                        Console.Write("Enter Salery : ");
                        int Salery = int.Parse(Console.ReadLine());

                        Console.Write("Enter Dep Number : ");
                        int DpNum = int.Parse(Console.ReadLine());
                        if (ChkDep(DpNum) == null) { Console.WriteLine("this Dep dosn't exist"); DpNum = 0; };

                        Employee Newemp = new Employee()
                        {
                            Em_Name = Name,
                            Salery = Salery,
                            Department = DpNum == 0 ? (int?)null : DpNum
                        };
                        UpdateEmplyee(Newemp, DepID);
                        Console.WriteLine("");
                        Console.WriteLine("press Again to Back");
                    }
                    else
                    {
                        Console.WriteLine("This Emp Dosen't Exist");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("press Again to Back");
                } //Update Emp

                Console.ReadKey();
                Console.Clear();


            }

        }

        static void InsertDepartment(Department Dep)
        {
            sd.Departments.Add(Dep);
            sd.SaveChanges();
        }
        static void InsertEmplyee(Employee emp)
        {

            sd.Employees.Add(emp);
            sd.SaveChanges();
        }

        static Department ChkDep(int DepId)
        {
            return sd.Departments.FirstOrDefault(a => a.ID == DepId);
        }
        static Employee ChkEmp(int EmpID)
        {
            return sd.Employees.FirstOrDefault(a => a.ID == EmpID);
        }




        static void DelteDep(int ID)
        {


            var dep = ChkDep(ID);
            if (dep != null)
            {
                sd.Departments.Remove(dep);
                sd.SaveChanges();

            }

        }
        static void DelteEmp(int ID)
        {


            var dep = ChkEmp(ID);
            if (dep != null)
            {


                sd.Employees.Remove(dep);
                sd.SaveChanges();

            }

        }
        static void DelteAllEmpinDep(int DepId)
        {

            sd.Employees.RemoveRange(sd.Employees.Where(a => a.Department == DepId));
            sd.SaveChanges();



        }

        static void UpdateDepartment(string Name, int ID)
        {
            var Dep = ChkDep(ID);
            Dep.Dep_Name = Name;
            sd.SaveChanges();
        }
        static void UpdateEmplyee(Employee emp, int Id)
        {

            var Emp = ChkEmp(Id);
            if (Emp != null)
            {
                Emp.Em_Name = emp.Em_Name;
                Emp.Salery = emp.Salery;
                Emp.Department = emp.Department;
            }
            sd.SaveChanges();
        }
    }
}
