/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programaboboruim;
import java.util.Scanner;
/**
 *
 * @author aluno
 */
public class ProgramaBoboRuim {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       double Celsius, Temp;
       
       Scanner in = new Scanner (System.in);
       
       System.out.println("Insira a temperatura em Celsius: ");
       Celsius = in.nextInt();
       Temp = Celsius*1.8+32;
       System.out.println("A temperatura em Fahrenheit é de: " + ((int)Temp));
    }
    
}
