// See https://aka.ms/new-console-template for more information
using List_Example2_Srk;

//Console.WriteLine("Hello, World!");
//ListMethods obj = new ListMethods();
//obj.AddMethod();
//obj.SearchMethod();
//obj.RemoveMethod();
//obj.InsterMethod();
//obj.RemoveAtMethod();
//obj.DisplayAllRecords();
//obj.CountMethod();
//SwitchCase objSwitchCase =  new SwitchCase();
//objSwitchCase.SwitchCaseMethod();


    SwitchCase objSwitchCase = new SwitchCase();
 EmployeeDetails:
objSwitchCase.SwitchCaseMethod();
Console.WriteLine("Do you want to repeat  again if yes enter Y ,if you dont want to enter any letter except y");
string n=Console.ReadLine();
if (n.ToLower() == "y")
{
    goto EmployeeDetails;
}
else
    Console.WriteLine("the loop is not repeated");
     

  

