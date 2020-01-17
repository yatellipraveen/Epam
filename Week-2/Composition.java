import java.io.*;

class Department{
    private String dept;

    // public void set_dept(String dept){
    //     this.dept=dept;
    // }

    public String get_dept(){
        return this.dept;
    }

    public Department(String dept){
        this.dept=dept;
    }
}

class Employee{
    private String name;
    private Department d;
    // public void set_name(String name){
    //     this.name=name;
    // }

    // public void set_dept()

    public void display_details(){
        System.out.println(this.name);
        System.out.println(d.get_dept());
    }

    public Employee(String name,String dept){
        this.d = new Department(dept);
        this.name=name;
    }

}

public class Composition{
    public static void main(String args[]){
        Employee emp=new Employee("Praveen","RD");
        //emp.set_name("Praveen");
        //emp.set_dept("RD");

        emp.display_details();
    }
}