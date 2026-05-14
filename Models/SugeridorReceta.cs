namespace TP02DanaPoniachikGrinblat.Models;

public class SugeridorReceta{

    public string Nombre{get; set;}
    public DateTime FechaNacimiento{get; set;}
    public string TipoComida{get; set;}
    public double Presupuesto{get; set;}
    public int CantComensales{get; set;}

    public int CalcularEdad() {

        int edad = 0;
        DateTime fechaActual = DateTime.Today;
        if (FechaNacimiento.Month < fechaActual.Month) {

            edad = FechaNacimiento.Year - fechaActual.Year;

        }
        else if (FechaNacimiento.Month > fechaActual.Month) {

            edad = FechaNacimiento.Year - fechaActual.Year - 1;

        }
        else {

            if (FechaNacimiento.Day <= fechaActual.Day) {

                edad = FechaNacimiento.Year - fechaActual.Year;

            }
            else {

                edad = FechaNacimiento.Year - fechaActual.Year - 1;

            }

        }
        return edad;

    }
    public string DeterminarPlato() {

        string plato = "";
        if (TipoComida == "Caliente") {

            if (Presupuesto < 3000) {

                plato = "Fideos con manteca";

            }
            else if (Presupuesto > 7000) {

                plato = "Pollo al horno con guarnicion";

            }
            else {

                plato = "Arroz con verduras salteadas";

            }

        }
        else {

            if (Presupuesto < 3000) {

                plato = "Ensalada simple";

            }
            else if (Presupuesto > 7000) {

                plato = "Ensalada completa con proteina";

            }
            else {

                plato = "Tabla de fiambres y quesos";

            }

        }
        return plato;

    }
    public string DeterminarDificultad() {

        string dificultad = "Principiante";
        if (CantComensales <= 3 && Presupuesto < 3000) {

            dificultad = "Principiante";

        }
        else if ((CantComensales <= 3 && Presupuesto < 7000) || (CantComensales >= 4 && CantComensales <= 7 && Presupuesto < 7000) || (CantComensales < 7000 && Presupuesto > 7000)) {

            dificultad = "Intermedio";

        }
        else if (CantComensales >= 8) {

            dificultad = "Avanzado";

        }
        return dificultad;
    }
    public int CalcularTiempo() {

        int minutos = 0;
        if (TipoComida == "Caliente") {

            if (CantComensales < 4) {

                minutos = 20;

            }
            else if (CantComensales >= 8) {

                minutos = 80;

            }
            else {

                minutos = 40;

            }

        }
        else {

            if (CantComensales < 4) {

                minutos = 10;

            }
            else if (CantComensales >= 8) {

                minutos = 30;

            }
            else {

                minutos = 40;

            }

        }
        return minutos;

    }
    public string GenerarSaludo() {

        DateTime fechaActual = DateTime.Today;
        string saludo = "";
        if (fechaActual.Hour > 6 && fechaActual.Hour < 14) {

             saludo = "¡Buenos Dias!";

        }
        else if (fechaActual.Hour >= 14 && fechaActual.Hour < 20) {

            saludo = "¡Buenas Tardes!";

        }
        else {

            saludo = "¡Buenas Noches!";

        }
        return saludo;

    }
    public string GenerarTip() {

        string tip = "";
        if (CalcularEdad() < 18) {

            tip = "No te olvides las cosas del restaurante y tene cuidado al salir.";

        }
        else if (CalcularEdad() > 60) {

            tip = "Que tenga un hermoso día señor/a";

        }
        else {

            tip = "¡Dale que hoy va a ser un dia muy lindo!";

        }
        return tip;

    }

}