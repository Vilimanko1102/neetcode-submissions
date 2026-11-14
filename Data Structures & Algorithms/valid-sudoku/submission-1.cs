public class Solution {
    public bool IsValidSudoku(char[][] board) {
        List<HashSet<char>> columnHashes = new List<HashSet<char>>(9);
        List<HashSet<char>> rowHashes = new List<HashSet<char>>(9);
        List<HashSet<char>> squareHashes = new List<HashSet<char>>(9);

        for(int k=0;k<9;k++){
            columnHashes.Add(new HashSet<char>(9));
            rowHashes.Add(new HashSet<char>(9));
            squareHashes.Add(new HashSet<char>(9));
        }

        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                if(board[i][j] == '.') continue;

                if(!rowHashes[j].Add(board[i][j])) return false;
                if(!columnHashes[i].Add(board[i][j])) return false;
                if(!squareHashes[i/3 * 3 + j/3].Add(board[i][j])) return false;
            }
        }

        return true;
    }
}
