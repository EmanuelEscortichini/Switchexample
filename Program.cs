// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int creditos = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";

System.Random random = new System.Random();


//Blackjack, juntar 21 pidiendo, en caso de pasarte de 21 pierdes. cartas o en caso de tener menos de 21 igual tener mayor puntuacion que el grupier;
while (true){

    Console.WriteLine("Welcome to C A S I N O ");
    Console.WriteLine("¿cuantos creditos deseas? \n" +
        "ingresa un numero entero \n" + 
        "Recuerda que necesitas uno por ronda de juego");

    creditos = int.Parse(Console.ReadLine());
    for (int i = 0; i < creditos; i++)

    {    
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":
            
                Console.WriteLine("Escriba 21' para jugar al 21");
                switchControl = Console.ReadLine();                
                i = i - 1;

                break;
            case "21":
                do
                { 
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta, jugador,");
                    Console.WriteLine($"Te salio el numero: {num} ");
                    Console.WriteLine("¿deseas otra carta?");
                    controlOtraCarta = Console.ReadLine();

                } 
                
                while (controlOtraCarta == "Si" ||
                controlOtraCarta == "si" ||
                controlOtraCarta == "yes");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"El dealer tiene {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "venciste al dealer, felicidades";
                    switchControl = "menu";
                }
                else if (totalJugador >= 21)
                {
                    message = "Perdiste vs el dealer, lo siento, te pasaste de 21";
                    switchControl = "menu";
                }

                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs el dealer, lo siento";
                    switchControl = "menu";
                }
                else
                {
                    message = "consicion no valida";
                }

                Console.WriteLine(message);
                break;
                default:
                Console.WriteLine("valor ingresado no valido en el C A S I N O");
                break;
            }
        }
     }