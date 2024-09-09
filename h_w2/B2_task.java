import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] line = scanner.nextLine().split(" ");
        int n = Integer.parseInt(line[0]);
        int k = Integer.parseInt(line[1]);
        int[] nPrices = new int[n];
        int maxPrice = 0;
        String[] nPriceeeeeeee = scanner.nextLine().split(" ");
        for (int i = 0; i < n; i++) {
            nPrices[i] = Integer.parseInt(nPriceeeeeeee[i]);
        }
        for (int i = 0; i < n; i++) {
            int buy = nPrices[i];
            for (int j = i + 1; j - i <= k && j < n; j++)
            {
                maxPrice = Math.max(maxPrice, nPrices[j]-buy);
            }
        }
        System.out.println(maxPrice);
    }
}