class Vehicle{
    private String vehicle_name;
    private String category;
    private Integer price;

    public void set_vechicle_name(String name){
        this.vehicle_name=name;
    }

    public void set_category(String category){
        this.category=category;
    }

    public void set_price(Integer price){
        this.price=price;
    }

    public String get_vehicle_name(){
        return this.vehicle_name;
    }

    public String get_category(){
        return this.category;
    }

    public Integer get_price(){
        return this.price;
    }

    public Vehicle(){
        System.out.println("Public Constructor called");
    }

}

public class Public_Constructor{
    public static void main(String args[]){
        Vehicle v= new Vehicle();
        v.set_vechicle_name("Swift");
        v.set_category("car");
        v.set_price(600000);

        System.out.println(v.get_vehicle_name());
        System.out.println(v.get_category());
        System.out.println(v.get_price());
    } 
}