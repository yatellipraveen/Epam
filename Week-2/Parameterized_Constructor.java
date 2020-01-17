
class Planet{
    private String planet_name;
    private Double planet_size;

    public String get_planet_name(){
        return planet_name;
    }

    public Double get_planet_size(){
        return planet_size;
    }

    public Planet(String planet_name,Double planet_size){
        this.planet_name=planet_name;
        this.planet_size=planet_size;
    }
}

public class Parameterized_Constructor{
    public static void main(String args[]){
        Planet p=new Planet("Earth",3600.0);
        System.out.println("Planet name :"+ p.get_planet_name());
        System.out.println("Planet size :"+ p.get_planet_size());
    }
}