/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programajavabobo7;

/**
 *
 * @author aluno
 */
public class Aluno {
    private String n1;
    private String n2;
    private String n3;
    private String n4;
 
    public void setN1(String N1) {n1 = N1;}
    public void setN2(String N2) {n2 = N2;}
    public void setN3(String N3) {n3 = N3;}
    public void setN4(String N4) {n4 = N4;}
    
    public String getN1() {return n1;}
    public String getN2() {return n2;}
    public String getN3() {return n3;}
    public String getN4() {return n4;}
    
    public String calcNota() 
    {
        return "" + ((Float.parseFloat(n1) + Float.parseFloat(n2) + Float.parseFloat(n3) + Float.parseFloat(n4) )/4);
    }

}
