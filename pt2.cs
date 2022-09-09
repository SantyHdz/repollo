// se nombra una clase
public class Friteria_de_fritos{
    // el main da inicio al algoritmo
	public static void Main(string[] args){
        // se crea una nueva instancia
		fritos Carimañola=new fritos ();
        // se crea una nueva instancia
		fritos Empanada=new fritos ();

        // se le agregan valores al atributo
		Carimañola.setsalsita("Suero con pique");
        // se le agregan valores al atributo
		Carimañola.settipofrito("Carimañola");
        // se le agregan valores al atributo
		Carimañola.setvalor(1500);
        // se le agregan valores al atributo
		Carimañola.setcantkal(3500);
        // se llama al atributo tostring
        Carimañola.tostring();

		// se le agregan valores al atributo
        Empanada.setsalsita("Salsa de tomate");
        // se le agregan valores al atributo
		Empanada.settipofrito("Empanada");
        // se le agregan valores al atributo
		Empanada.setvalor(1200);
        // se le agregan valores al atributo
		Empanada.setcantkal(2800);
        // se llama al atributo tostring
        Empanada.tostring();

// inicia el condicional IF estableciendo las reglas
             	if (Carimañola.getcantkal() >= Empanada.getcantkal()) {
                    // Establece la accion que se hace si la afirmacion es verdadera
                	Console.WriteLine ("La carimañola tiene mas calorias");
            	}
		else {
            // Establece la accion para la afirmación falsa
                	Console.WriteLine ("La empanada tiene mas calorias");
            	}
// fin condicional
	}
    // fin algoritmo
}