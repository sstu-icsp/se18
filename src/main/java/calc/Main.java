package calc;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in =new Scanner(System.in);
        String str = in.next();
        Calculator calc=new Calculator();
        try {
           System.out.println(calc.max_three_numbers(str).toString());
            //System.out.println(calc.unlimited_number_count(str).toString());
        }catch (IllegalArgumentException e){
            System.out.println(e.getMessage());
        }

    }
}
