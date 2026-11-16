public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach(string s in tokens){
            if(!(s.Equals("+") ||
                s.Equals("-") ||
                s.Equals("*") ||
                s.Equals("/"))){

                stack.Push(Convert.ToInt32(s));
            }
            else{
                int a = stack.Pop();
                int b = stack.Pop();

                if(s.Equals("+")) stack.Push(b + a);
                if(s.Equals("-")) stack.Push(b - a);
                if(s.Equals("*")) stack.Push(b * a);
                if(s.Equals("/")) stack.Push(b / a);
            }
        }

        return stack.Pop();
    }
}
