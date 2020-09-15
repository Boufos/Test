package lb_2;

public class WorkRobot {
	
	private String workStr;
    private int number;
    public WorkRobot(String workStr, int number)
    {
        this.workStr = workStr;
        this.number = number;
    }
    public void workBegin()
    {
    	StringBuffer sb = new StringBuffer(workStr);
        sb.insert(number, " ");
        System.out.println(sb);
    }

}
