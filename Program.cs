using System;
enum Menu{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPerson
}
class Program{
    static PersonList personlist;
    static void Main(string[]args){
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
    }
    static void PrintMenuScreen(){
        Console.Clear();

        PrintListMenu();
        InputMenuFromKeyboard();

    }
    static void InputMenuFromKeyboard(){
        Console.WriteLine("Please input menu:");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }

    static void PresentMenu(Menu menu){
        switch(menu){
            case Menu.RegisterNewStudent:
                showInputRegistrationNewStudentScreen();
                break;
            case Menu.RegisterNewTeacher:
                showInputRegistrationNewTeacherScreen();
                break;
            case Menu.GetListPerson:
                showPerson();
                break;
            default:
                break;
        }
    }
    static void showInputRegistrationNewStudentScreen(){
        Console.Clear();

        PrintHeaderRegisterStudent();

        int totalstudent = TotalNewStudent();

        InputNewStudentfromKeyboard(totalstudent);
    }
    static void showInputRegistrationNewTeacherScreen(){
        Console.Clear();

        PrintHeaderRegisterTeacher();

        int totalteacher = TotalNewTeacher();

        InputNewTeacherfromKeyboard(totalteacher);
    }
    static void showPerson(){
        Console.WriteLine("Show Person");
        Console.WriteLine("***********");

        Program.personlist.FetchPersonList();
    }
    static void PrintHeaderRegisterStudent(){
         Console.WriteLine("Register New student");
        Console.WriteLine("********************");
    }
    static void PrintHeaderRegisterTeacher(){
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("********************");
    }

    static void InputNewStudentfromKeyboard(int totalNewStudent){
        for(int i = 0; i < totalNewStudent; i++){
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(InputName(),InputAddress(),InputCitizenID(),InputStudentID());

            Program.personlist.AddNewPerson(student);
        }

        BacktoMainMenu();
    }
    static void InputNewTeacherfromKeyboard(int totalNewTeacher){
        for(int i = 0; i < totalNewTeacher; i++){
            Console.Clear();
            PrintHeaderRegisterTeacher();

            Teacher teacher = new Teacher(InputName(),InputAddress(),InputCitizenID(),InputemployeeID());

            Program.personlist.AddNewPerson(teacher);
        }

        BacktoMainMenu();
    }
    static void BacktoMainMenu(){
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static string InputName(){
        Console.WriteLine("Name:");

        return Console.ReadLine();
    }

    static string InputStudentID(){
        Console.WriteLine("StudentID:");

        return Console.ReadLine();
    }

    static string InputAddress(){
        Console.WriteLine("Input address:");

        return Console.ReadLine();
    }

    static string InputCitizenID(){
        Console.WriteLine("input citizen id");

        return Console.ReadLine();
    }
    static string InputemployeeID(){
        Console.WriteLine("input employee id");

        return Console.ReadLine();
    }


    
    static int TotalNewStudent(){
        Console.WriteLine("input total new student:");

        return int.Parse(Console.ReadLine());
    }
    static int TotalNewTeacher(){
        Console.WriteLine("input total new Teacher");

        return int.Parse(Console.ReadLine());
    }


    static void PreparePersonListWhenProgramIsLoad(){
        Program.personlist = new PersonList();
    }
    static void PrintListMenu(){
        Console.WriteLine("Welcome to registration new user school application");
        Console.WriteLine("**************************************");
        Console.WriteLine("1.Registration new student");
        Console.WriteLine("2.Registration new Teacher");
        Console.WriteLine("3.Get list Persons");
        Console.WriteLine("*************************************");
    }
}
