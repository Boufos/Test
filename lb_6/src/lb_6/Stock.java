package lb_6;

class Stock<T>{
    
    private T id;
    private String city;
     
    Stock(T id, String city){
        this.id = id;
        this.city = city;
    }
     
    public T getId() { return id; }
    public String getCity() { return city; }
    public void getInfo() {
    	if (id instanceof String)System.out.printf("%s-warehouse is located in %s\n\n",id,city);
    	else System.out.printf("Warehouse by coordinates %s is located in %s\n\n",id,city);
    	}
}