/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programaboboruim3;

import java.util.Scanner;

/**
 *
 * @author aluno
 */
public class ProgramaBoboRuim3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      double V1, V2, V3, V4, M ;
       
       Scanner in = new Scanner (System.in);
       
       System.out.println("Insira nota 1: ");
       V1 = in.nextInt();
       
       System.out.println("Insira nota 2: ");
       V2 = in.nextInt();
       
       System.out.println("Insira nota 3: ");
       V3 = in.nextInt();
       
       System.out.println("Insira nota 4: ");
       V4 = in.nextInt();
       
       M = (V1+V2+V3+V4)/4;
       
       if(M>=6)
           System.out.println("Aprovado");
       else
       {
           if(M<3)
              System.out.println("Reprovado");
           else
               System.out.println("ALuno esta de exame");
      }
           
       
       System.out.println("A média geométrica é de: " + M );
    }
    
}
