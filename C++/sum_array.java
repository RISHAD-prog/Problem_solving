import java.util.*;
import java.util.Scanner;
import java.util.Arrays;

public class sum_array {
    static long sum() {
        int input;
        Scanner sc = new Scanner(System.in);
        input = sc.nextInt();
        int[] arr = new int[input];
        long sum = 0;

        for (int i = 0; i < input; i++) {
            arr[i] = sc.nextInt();
            sum = sum + arr[i];
        }
        return sum;
    }

    public static void main(String args[]) {

        System.out.println(sum());

    }
}
