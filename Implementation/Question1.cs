using System.Collections;

public class Question1
{
    public static ArrayList ReverseArrayList(ArrayList arrayListToBeReversed)
    {


        int left = 0;
        int right = arrayListToBeReversed.Count -1 ;

        while(left < right)
        {
            var temp = arrayListToBeReversed[left];
            arrayListToBeReversed[left] = arrayListToBeReversed[right];
            arrayListToBeReversed[right] = temp;
            left++;
            right--;
        }
        return arrayListToBeReversed;
    }
}