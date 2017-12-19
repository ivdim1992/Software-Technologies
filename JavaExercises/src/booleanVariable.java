import com.sun.org.apache.xpath.internal.operations.Bool;

import java.util.Scanner;

public class booleanVariable {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String text = sc.nextLine();

        if (text.equals("True")){
            System.out.println("Yes");
        }else {
            System.out.println("No");
        }

    }
}
