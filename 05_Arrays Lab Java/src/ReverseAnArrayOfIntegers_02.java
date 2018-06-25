import java.util.Scanner;

public class ReverseAnArrayOfIntegers_02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int number = Integer.parseInt(sc.nextLine());

        int[] array = new int[number];

        for (int i = 0; i < number; i++) {
            array[i] = Integer.parseInt(sc.nextLine());
        }

        for (int i = array.length-1; i >= 0 ; i--) {
            System.out.print(array[i] + " ");
        }
    }
}
