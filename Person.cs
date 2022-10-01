using System;
public abstract class Person{
private string Name;
private string address;
private string citizenID;

public Person (string Name, string address, string citizenID){
    this.Name = Name;
    this.address = address;
    this.citizenID = citizenID;
}

public string GetName (){
    return this.Name;
}
public string Getaddress(){
    return this.address;
}
public string GetcititzenID(){
    return this.citizenID;
}


}