import java.util.Scanner;

public class integerToHexAndBinary {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());

        System.out.println(Integer.toHexString(n).toUpperCase());
        System.out.println(Integer.toBinaryString(n));

    }

}
