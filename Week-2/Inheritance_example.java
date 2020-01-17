import java.io.*;

class Department{
    private String dept;

    public void display_dept(){
        System.out.println(this.dept);
    }
    public Department(String dept){
        this.dept= dept;
    }
}

class Employee extends Department{
    private String name;
    private Integer UID;

    public void display_name(){
        System.out.println(this.name);
    }
    public void display_UID(){
        System.out.println(this.UID);
    }
    public Employee(String name,Integer UID, String dept){
        super(dept);
        this.name=name;
        this.UID=UID;
        
    }
}
public class Inheritance_example {
    public static void main(String args[]) {
        Employee e=new Employee("Praveen",56020,"RD");
        System.out.print("Employee Name :");
        e.display_name();
        System.out.println();

        System.out.print("Employee UID :");
        e.display_UID();
        System.out.println();

        System.out.print("Employee dept :");
        e.display_dept();
        System.out.println();
    }
}