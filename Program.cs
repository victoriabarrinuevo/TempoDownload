Console.WriteLine("---Tempo de download---");

Console.WriteLine("Digite o tamanho do seu arquivo em MB:");
double megabytes = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Agora, digite a velocidade da sua conexão em MBPS:");
double mbps = Convert.ToDouble(Console.ReadLine());

double minutos = megabytes * 8 / mbps / 60;

Console.WriteLine($"O tempo de download do seu arquivo é:{minutos:N1} Minutos");

Console.WriteLine("Obrigada!");


