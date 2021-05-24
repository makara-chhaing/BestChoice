using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace BoxOfCoins
{
    public class BoxOfCoins
    {
        private static List<int> cindy;
        private static List<int> alex;
        private static int left=0, right;
        private static int alexSum=0, cindySum=0;

        public static int Solve(int[] boxes)
        {
            cindy = new List<int>();
            alex = new List<int>();
            left = 0;
            right = boxes.Length - 1;
            alexSum=0;
            cindySum=0;
            int count=boxes.Length;

            while(right >= left && count > 0){
                AlexChoose(boxes);
                count--;
                if(count > 0){
                    CindyChoose(boxes);
                    count--;
                }
                
            }
            SumAlex();
            SumCindy();
            
           
           int result = alexSum - cindySum;
           Console.WriteLine("alex result: " + alexSum);
           Console.WriteLine("cindy result: " + cindySum);
           Console.WriteLine("Makara result: " + result);
           return result;
        }

        private static void reset(){
            alexSum=0;
            cindySum=0;
        }

        private static void AlexChoose(int[] boxes){

            if(boxes[left] >= boxes[right]){
                alex.Add(boxes[left]);
                left++;
            }else{
                alex.Add(boxes[right]);
                right--;
            }
        }

        private static void CindyChoose(int[] boxes){
            if(boxes[left] >= boxes[right]){
                cindy.Add(boxes[left]);
                left++;
            }else{
                cindy.Add(boxes[right]);
                right--;
            }
        }

        private static void SumAlex(){
            foreach(int i in alex){
                alexSum += i;
            }
        }
        private static void SumCindy(){
            foreach(int i in cindy){
                cindySum += i;
            }
        }
        
    }

}