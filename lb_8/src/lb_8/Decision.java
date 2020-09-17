package lb_8;

public class Decision {

	public void FirstDecision(int f, int x, int n)
	{
		System.out.print("Answer according to the first formula: ");
		double k = -f/2.0;
		double answer =0;
		int inX =1;
		int inF=2;
		int z=2;
		int inZ=3;
		for(int i=0;i<n;i++)
		{
			if(i%2==0)
			{
				z*=inZ;
				answer+= (Math.pow(x, inX)*Math.pow(f, inF))/z;
				inX++;
				inF++;
				inZ++;
			}
			if(i%2!=0)
			{
				z*=inZ;
				answer-= (Math.pow(x, inX)*Math.pow(f, inF))/z;
				inX++;
				inF++;
				inZ++;
			}
			
		}
		System.out.print(answer+k);
		
	}
	public void SecondDecision(int y, int x, int n)
	{
		System.out.print("\nAnswer according to the second formula: ");
		double answer=0.0;
		int y1=1;
		int x1=1;
		for(int i=1; i<=Math.max(y, x);i++) {
			
			answer+= (n*(x1+y1))/(x1*(x1+2.0));
			if(y1!=y) y1++;
			if(x1!=x) x1++;
		}
		
		System.out.print(answer);
	}
}
