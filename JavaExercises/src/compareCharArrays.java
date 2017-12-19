



import java.util.Scanner;

public class compareCharArrays {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String arr1 = sc.nextLine();
        String arr2 = sc.nextLine();

        char[] charArray1 = arr1.replace(" ","").toCharArray();
        char[] charArray2 = arr2.replace(" ","").toCharArray();

        for (int i = 0; i < charArray1.length; i++){
            if (charArray1[i] <= charArray2[i]){
                System.out.println(charArray1);
                System.out.println(charArray2);
                break;
            }
            else{
                System.out.println(charArray2);
                System.out.println(charArray1);
                break;
            }

        }
        //System.out.println(charArray1);
    }
}
