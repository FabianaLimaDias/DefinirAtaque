namespace EstudosDIO
{
     class JogoDIO
    {

        public string nome { get; set; }
        public string idade{ get; set; }
        public string ataque { get; set; }
        public string TipoGuerreiro { get; set; }

        public JogoDIO()
        {

        }

        public JogoDIO (string nome, string idade, string ataque,string tipoGuerreiro)
        {
            this.nome = nome;
            this.idade = idade;
            this.ataque = ataque;
            this.TipoGuerreiro = tipoGuerreiro;
        }


        public void Atacar()
        {

                Console.WriteLine("Escolha o tipo do jogador: ");
                Console.WriteLine("1. Mago");
                Console.WriteLine("2. Guerreiro");
                Console.WriteLine("3. Monge");
                Console.WriteLine("4. Ninja");


            int escolhaGuerreiro = Convert.ToInt32(Console.ReadLine ());

            switch (escolhaGuerreiro)
            {
                case 1:
                    TipoGuerreiro = "Mago";
                    ataque = "Magia";
                    break;

                case 2:
                    TipoGuerreiro = "Guerreiro";
                    ataque = "Espada";
                    break;

                case 3:
                    TipoGuerreiro = "Monge";
                    ataque = "Artes Marciais";
                    break;

                case 4:
                    TipoGuerreiro = "Ninja";
                    ataque = "Shuriken";
                    break;

                default:
                    Console.WriteLine("Invalido");
                    return;

            
            }

            Console.WriteLine($" O {TipoGuerreiro} atacou usando o {ataque}");

        }
    }

}
