import java.util.*;
public class Chatbot
{
    public static void main(String[] args)
    {
        Scanner sc=new Scanner(System.in);
        System.out.println("Hey! there I am AI");
        boolean running=true;
        String input;
        while(running==true)
        {
            System.out.println( " " );
            input=sc.nextLine();
            if(input.equals("Hi"))
            {
                System.out.println("Hi! User");
            }
            else if(input.equals("Bye"))
            {
                System.out.println("Bye! User");
                running = false;
            }
            else if(input.equals("Tell me the weather today"))
            {
                System.out.println("Extreme Hot DANGER! Run");
            }
            else
            {
                System.out.println("Speak properly!");
            }
        }
    }
}
                
            
            
        
    
    
    
                
        