import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        boolean[][] chess = new boolean[8][8];
        for (int i = 0; i < n; i++) {
            int row = scanner.nextInt() - 1;
            int col = scanner.nextInt() - 1;
            chess[row][col] = true;
        }
        int result = 0;
        for (int i = 0; i < 8; i++) {
            for (int j = 0; j < 8; j++) {
                if (chess[i][j]) {
                    if (i == 0 || !chess[i - 1][j]) result++;
                    if (i == 7 || !chess[i + 1][j]) result++;
                    if (j == 0 || !chess[i][j - 1]) result++;
                    if (j == 7 || !chess[i][j + 1]) result++;
                }
            }
        }
        System.out.println(result);
    }
}
