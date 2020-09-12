package lb_6;

public class Goods {
	
	private String[] array;
	public Goods(int size)
	{
		array = new String[size];
		for (int i=0;i<size;i++)
		{
			array[i] = ((i+1) +" goods");
		}
	}
	
	public String[] getArray()
	{
		return array;
	}
    public <T> void print(T[] items){
        for(T item: items){
            System.out.println(item);
        }
    }

}
