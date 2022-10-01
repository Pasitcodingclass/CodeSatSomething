using System;
public class Teacher: Person{
    private string employeeID;

    public Teacher(string Name, string address, string citizenID, string employeeID)
    : base(Name, address, citizenID){
        this.employeeID = employeeID;
    }
}