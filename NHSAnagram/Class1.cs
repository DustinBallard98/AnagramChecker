using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHSAnagram{
    class Anagramer{

        public bool AnagramCheck(string S1, string S2){
            int  index = 0;
            int [] Occ1 = new int [S1.Length];
            int [] Occ2 = new int [S2.Length];

        //Keep track of String 1

            foreach(char X in S1){

                if (S2.Contains(X) && S1.Contains(X)){
                    Occ1[index]++;
                } else {
                    return false;
                }//end if

                index++;
            }//end foreach

            index = 0;

        //keep track of String 2

             foreach (char X in S2) {

                 if (S1.Contains(X) && S2.Contains(X)){
                     Occ2[index]++;
                 }
                 else{
                     return false;
                 }//end if

                 index++;
             }//end foreach

            index = 0;

            if(S1.Length == S2.Length){

                foreach (int Pos in Occ1){

                    if(Pos == Occ2[index]){

                    }else{
                        return false;
                    }

                    index++;
                }//end foreach

            }else{

                return false;

            }//end if
            
            return true;

        }//end check method

    }//end class
}//end name