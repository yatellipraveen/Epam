
class Planet{
    private String planet_name;
    private Integer Planet_size;

    public void display_details(){
        System.out.println(this.planet_name);
        System.out.println(this.Planet_size);
    }
}

public class Default_Constructor{
    public static void main(String args[]){
        Planet p=new Planet();
        p.display_details();
    }
}