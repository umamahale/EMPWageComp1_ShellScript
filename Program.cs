using Day4.UC_final_solution;
using Day4.UC10;
using Day4.UC9;
using System;

namespace Day4
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UC1_EmployeeAttendance.GetAttendance();
            //UC2_EmpWage. EmpWage();
            //UC3_PartTimeEmpWage. PartTimeEmpWage();
            //UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            //UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            //UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            //UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            //UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("xyz", 10, 3, 21);
           // #region UC9
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            //#endregion
            //#region UC10
            UC10.EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            // #endregion
            #region FinalSolution
            EmpWageBuilder empWageBuild = new EmpWageBuilder();
            empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuild.computeEmpWage();
            #endregion
            Console.ReadKey();
        }

    }
} 
