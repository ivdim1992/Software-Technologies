import java.io.IOException;
import java.util.Scanner;

public class reverseCharacters {
    public static void main(String[] args) throws IOException {

        Scanner sc = new Scanner(System.in);
        StringBuilder result = new StringBuilder();
       for (int i =0;i < 3;i++){
           String letter = sc.nextLine();
           result.append(letter);
       }
       result.reverse();
        System.out.println(result);
    }
}
