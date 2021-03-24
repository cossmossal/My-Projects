import java.util.Scanner;
public class GuessingGame
{
    public static void main(String[] args)
    {
        Scanner sc=new Scanner(System.in);
        String secretword="SSC Tuatara";
        String guess=" ";
        while(!guess.equals(secretword))
        {
            System.out.print("Guess the name of the fastest car in the world");
            guess=sc.nextLine();
        }
        System.out.println("You Win!");
    }
}