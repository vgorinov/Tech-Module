import java.util.Scanner;

public class DaysOfTheWeek_01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int number = Integer.parseInt(sc.nextLine());

        String[] dayOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
        };

        if (number < 1 || number > 7) {
            System.out.println("Invalid day!");
            return;
        }

        System.out.println(dayOfWeek[number - 1]);
    }
}
