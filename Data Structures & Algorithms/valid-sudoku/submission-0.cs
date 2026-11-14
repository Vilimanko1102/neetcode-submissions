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

                if(i/3 == 0 && j/3 == 0)
                    if(!squareHashes[0].Add(board[i][j])) return false;
                if(i/3 == 0 && j/3 == 1)
                    if(!squareHashes[1].Add(board[i][j])) return false;
                if(i/3 == 0 && j/3 == 2)
                    if(!squareHashes[2].Add(board[i][j])) return false;
                if(i/3 == 1 && j/3 == 0)
                    if(!squareHashes[3].Add(board[i][j])) return false;
                if(i/3 == 1 && j/3 == 1)
                    if(!squareHashes[4].Add(board[i][j])) return false;
                if(i/3 == 1 && j/3 == 2)
                    if(!squareHashes[5].Add(board[i][j])) return false;
                if(i/3 == 2 && j/3 == 0)
                    if(!squareHashes[6].Add(board[i][j])) return false;
                if(i/3 == 2 && j/3 == 1)
                    if(!squareHashes[7].Add(board[i][j])) return false;
                if(i/3 == 2 && j/3 == 2)
                    if(!squareHashes[8].Add(board[i][j])) return false;
            }
        }

        return true;
    }
}
