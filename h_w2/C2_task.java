import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int[] numbers = new int[n];
        String[] r = sc.nextLine().split(" ");
        int maxS = Integer.MIN_VALUE;
        int sum = 0;
        int result = 0;
        for (int i =0;i<n;i++){
            numbers[i] = Integer.parseInt(r[i]);
            maxS = Math.max(numbers[i],maxS);
            sum+=numbers[i];
        }
        if (sum-maxS>=maxS){
            result = sum;
        }
        else{
            result = maxS - (sum-maxS);
        }
        System.out.println(result);
    }
}