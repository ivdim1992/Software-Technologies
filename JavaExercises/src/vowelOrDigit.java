import java.util.Scanner;

public class vowelOrDigit {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String character = scanner.nextLine();

        if (character.equals("a") || character.equals("e")|| character.equals("i") ||
        character.equals("o") || character.equals("u")){
            System.out.println("vowel");
        }else if (character.equals("1") || character.equals("2") || character.equals("3")
                || character.equals("4") || character.equals("5") || character.equals("6")
                || character.equals("7") || character.equals("8") || character.equals("9")){
            System.out.printf("digit");
        }
        else {
            System.out.println("other");
        }
    }
}
