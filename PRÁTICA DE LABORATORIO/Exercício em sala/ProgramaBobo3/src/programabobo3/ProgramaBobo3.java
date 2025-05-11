/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programabobo3;
import java.util.Scanner;
/**
 *
 * @author aluno
 */
public class ProgramaBobo3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      
       double V1, V2, V3, V4, M ;
       
       Scanner in = new Scanner (System.in);
       
       System.out.println("Insira o primeiro valor: ");
       V1 = in.nextInt();
       
       System.out.println("Insira o segundo valor: ");
       V2 = in.nextInt();
       
       System.out.println("Insira o terceiro valor: ");
       V3 = in.nextInt();
       
       System.out.println("Insira o quarto valor: ");
       V4 = in.nextInt();
       
       M = (V1*V2*V3*V4);
       
       System.out.print("O resultado da média geometrica é de: "+ Math.pow(M,(float)1/4 ));
    }
    
}
