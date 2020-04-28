public class Solution {
    public bool IsHappy(int n) {
        
        int slow;
        int fast;
        
        slow = fast = n;
        
        do{
            slow = NumSquareSum(slow);
            fast = NumSquareSum(NumSquareSum(fast));
        }while(slow!=fast);
        
        return (slow == 1);
        
    }
    
   public int NumSquareSum(int num){
       int sum = 0;
       
       while(num!=0){
           sum = sum + (num % 10) * (num % 10);
           num = num / 10;
       }
       return sum;
   }
}
