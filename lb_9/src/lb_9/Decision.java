package lb_9;

public class Decision {

	public void FirstDecision(int x, int y, int n)
	{
		System.out.print("Formula answer:\n");
		double answer=0.0;
		int y1=1;
		int x1=1;
		for(int i=1; i<=Math.max(y, x);i++) {
			
			answer+= (Math.cos(Math.pow(n, x1))+y1)/(x1*y1);
			if(y1!=y) y1++;
			if(x1!=x) x1++;
		}
		
		System.out.print("Mathematical view: "+answer+"\n");
		System.out.print("Rounded view: "+Math.ceil(answer)+"\n");
	}
}
