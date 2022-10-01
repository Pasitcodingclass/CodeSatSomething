public class Student: Person{
    private string studentID;

public Student (string Name, string address, string citizenID, string studentID)
: base(Name, address, citizenID){

    this.studentID = studentID;
}

}