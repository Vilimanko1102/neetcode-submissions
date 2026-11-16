public class Solution {
    public bool IsValid(string s) {
        Stack<char> parStack = new Stack<char>();

        foreach(char c in s){
            if(c == '(' || c == '[' || c == '{'){
                parStack.Push(c);
            }
            else{
                if(parStack.Count() == 0) return false;
                if(c != ')' && c != ']' && c != '}') return false;
                char temp = parStack.Pop();
                if(c == ')' && (temp == '[' || temp == '{')) return false;
                if(c == ']' && (temp == '(' || temp == '{')) return false;
                if(c == '}' && (temp == '(' || temp == '[')) return false;
            }
        }

        return parStack.Count() == 0;
    }
}
