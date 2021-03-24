import java.io.*;
public class KBCquiz
{
    public void disp() throws IOException
    {
        BufferedReader r=new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Press (1)START");
        System.out.println("Press (2)How to Play");
        System.out.println("Press (3)EXIT");
        int S=Integer.parseInt(r.readLine());
        if(S==1)
        {
        System.out.println("Enter your nickname");
        String a=r.readLine();
        System.out.println("Accessing the quiz");
        {
            System.out.println("Q1-What is the Name of 5th roop of Vishnu?");
            System.out.println("1.Rama");
            System.out.println("2.Narasima");
            System.out.println("3.Vamana");
            System.out.println("4.Krishna");
            int S1=Integer.parseInt(r.readLine());
            if(S1==1||S1==2||S1==4)
            System.out.println("Revise again!");
            else if(S1==3)
            System.out.println("Correct guess!");
            else
            System.out.println("Not applicable here");
        }
        {
            System.out.println("Q2-What was the name of Madhuri Dixit in the Movie Devdas?");
            System.out.println("1.Kaushalya");
            System.out.println("2.Parvati");
            System.out.println("3.Badima");
            System.out.println("4.Chandramukhi");
            int S2=Integer.parseInt(r.readLine());
            if(S2==1||S2==2||S2==3)
            System.out.println("Revise again!");
            else if(S2==4)
            System.out.println("You are indeed a Madhuri Dixit!");
            else
            System.out.println("Not applicable here");
        }
        {
            System.out.println("Q3-Who is the author of the epic 'Meghdoot'?");
            System.out.println("1.Vishakadatta");
            System.out.println("2.Valmiki");
            System.out.println("3.Banabhatta");
            System.out.println("4.Kalidas");
            int S3=Integer.parseInt(r.readLine());
            if(S3==1||S3==2||S3==3)
            System.out.println("Revise again!");
            else if(S3==4)
            System.out.println("All correct answers!");
            else
            System.out.println("Not applicable here");
        }
    }
    else if(S==2)
    {
        System.out.println("Press any numbers from 1,2,3,4 options");
    }
    else if(S==3)
    {
        System.out.println("Tata Bye-Bye , end for the day!");
    }
}
}
        
    
        
        