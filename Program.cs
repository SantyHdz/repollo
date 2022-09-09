//creacion de clase frito con los atributos especificos
public class fritos{
    // establece atributos de seguridad privada tipo texto de la clase fritos
    private string tipofrito, salsita;
    // establece atributos de seguridad privada tipo entero de la clase fritos
    private int valor, cantkal;

//obtiene el valor de un atributo 
    public string gettipofrito(){
        // retorna la promesa
        return (this.tipofrito);
    }
//Le asigna el valor a un atributo
public void settipofrito(string nombref){
    // retorna la promesa
        this.tipofrito=nombref;
}
//obtiene el valor de un atributo 
    public string getsalsita(){
        // retorna la promesa
        return (this.salsita);
    }
//Le asigna el valor a un atributo
public void setsalsita(string nombresal){
    // retorna la promesa
        this.salsita=nombresal;
}
//obtiene el valor de un atributo 
    public int getvalor(){
        // retorna la promesa
        return (this.valor);
    }
//Le asigna el valor a un atributo
public void setvalor(int valort){
    // retorna la promesa
        this.valor=valort;
}
//obtiene el valor de un atributo 
    public int getcantkal(){
        // retorna la promesa
        return this.cantkal;
    }
//Le asigna el valor a un atributo
public void setcantkal(int npagi){
    // retorna la promesa
        this.cantkal=npagi;
}
//Convierte a cadena de texto los atributos de la clase
public void tostring(){ 
    // muestra en pantalla la concantenacion de los valores
    Console.WriteLine("El frito "+this.tipofrito+" con valor de "+this.valor+" con "+this.salsita+" tiene "+this.cantkal+" Calorias.");
    // Fin
}
// Fin
}
