   
# 2;
   public string solution(int[] T) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int largest = int.MinValue;
        int second = int.MinValue;
        
        foreach(int i in T)
        {
            if(i > largest)
            {
                second = largest;
                largest = i;
            }
            else if(i > second)
            {
                second = i;
            }
        }
        
        return (largest - second).ToString();
    }
	
	
	
	question # 1;
	
	 // write your code in C# 6.0 with .NET 4.5 (Mono)
         int diff = A[0] - A[1];
          
          for(int i = 0; i < A.Length; i++)
          {
              for(int j = 0; j < A.Length; j++)
              {
                  if((A[j] - A[i]) > diff)
                  {
                      diff = A[j] - A[i];
                  }
              }
          }
          
          return diff;