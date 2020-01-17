class Planet{
    private String planet_name;
    private Double Planet_size;

    public void display_details(){
        System.out.println(this.planet_name);
        System.out.println(this.Planet_size);
    }

    public Planet(){
        this.planet_name="none";
        this.Planet_size=0.0;
    }
}

public class Noargs_Constructor{
    public static void main(String args[]){
        Planet p=new Planet();
        p.display_details();
    }
}