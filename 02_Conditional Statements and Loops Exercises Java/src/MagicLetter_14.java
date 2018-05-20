import java.util.Scanner;

public class MagicLetter_14 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        char firstLetter = sc.nextLine().charAt(0);
        char secondLetter = sc.nextLine().charAt(0);
        String thirdLetter = sc.nextLine();

        String result = "";

        for (char d1 = firstLetter; d1 <= secondLetter; d1++) {
            for (char d2 = firstLetter; d2 <= secondLetter; d2++) {
                for (char d3 = firstLetter; d3 <= secondLetter; d3++) {
                    result = String.format("%c%c%c", d1, d2, d3);

                    if (!result.contains(thirdLetter)) {
                        System.out.print(result + " ");
                    }
                }
            }
        }
    }
}


