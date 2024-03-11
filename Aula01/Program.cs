    // Exercício 08/03/2024
    // Repositorio: https://unipead-my.sharepoint.com/personal/flavio_alves19_docente_unip_br/_layouts/15/onedrive.aspx?ga=1&id=%2Fpersonal%2Fflavio%5Falves19%5Fdocente%5Funip%5Fbr%2FDocuments%2FOrienta%C3%A7%C3%A3o%20a%20Objetos%2FProgram%2Ecs&parent=%2Fpersonal%2Fflavio%5Falves19%5Fdocente%5Funip%5Fbr%2FDocuments%2FOrienta%C3%A7%C3%A3o%20a%20Objetos

    MensagemBoasVindas();
    Separador();
    List <string> listaDisciplinas = [];
    Menu();
        
    void MensagemBoasVindas()
    {
    Console.WriteLine(@"
 
░█████╗░██████╗░░██████╗  ██╗░░░██╗███╗░░██╗██╗██████╗░  ██████╗░░█████╗░██████╗░░░██╗██╗
██╔══██╗██╔══██╗██╔════╝  ██║░░░██║████╗░██║██║██╔══██╗  ╚════██╗██╔══██╗╚════██╗░██╔╝██║
███████║██║░░██║╚█████╗░  ██║░░░██║██╔██╗██║██║██████╔╝  ░░███╔═╝██║░░██║░░███╔═╝██╔╝░██║
██╔══██║██║░░██║░╚═══██╗  ██║░░░██║██║╚████║██║██╔═══╝░  ██╔══╝░░██║░░██║██╔══╝░░███████║
██║░░██║██████╔╝██████╔╝  ╚██████╔╝██║░╚███║██║██║░░░░░  ███████╗╚█████╔╝███████╗╚════██║
╚═╝░░╚═╝╚═════╝░╚═════╝░  ░╚═════╝░╚═╝░░╚══╝╚═╝╚═╝░░░░░  ╚══════╝░╚════╝░╚══════╝░░░░░╚═╝");

    Separador();
    Console.Write("Olá, tudo bem? Por favor, informe seu nome: ");
    string nomeAluno = Console.ReadLine();
    Console.WriteLine();
    string mensagem = "Boas vindas a disciplina de ORIENTAÇÃO A OBJETOS, ";
    Console.WriteLine(mensagem + nomeAluno + "!");
    
    
}

    void Separador()
    {
        Console.WriteLine(@"------------------------------------------------------------------------------------------");
    }

    void RegistrarDisciplina()
    {
    Console.Clear();
    Console.WriteLine(@"
███████████████████████████████████████████▀████████████████████████████
█▄─▀█▄─▄█─▄▄─█▄─█─▄█─▄▄─███▄─▄▄▀█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄▀█─▄▄─█
██─█▄▀─██─██─██▄▀▄██─██─████─▄─▄██─▄█▀█─██▄─██─██▄▄▄▄─███─████─▄─▄█─██─█
▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▀▄▀▀▀▄▄▄▄▀▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▀");
    Separador();
    Console.Write("Digite o nome da disciplina: ");
    string disciplina = Console.ReadLine();
    listaDisciplinas.Add(disciplina);
    Console.Clear();
    Console.Write(@"DESEJA CADASTRAR OUTRA DISCIPLINA?
    1 - SIM
    2 - NÃO 
    OPÇÃO ESCOLHIDA: ");
    int registro = int.Parse(Console.ReadLine());
    if (registro < 2)
    {
        RegistrarDisciplina();
    }
    else
    {
        Console.Clear();
        Menu();
    }
    }

    void ListarDisciplinas()
    {
        Console.Clear();
        Console.WriteLine("LISTANDO SUAS DISCIPLINAS........");
        Thread.Sleep(3000);
        Console.Clear();
        if (listaDisciplinas.Count == 0)
    {
        Console.WriteLine("NENHUM DADO ENCONTRADO NA BASE. VOLTANDO AO MENU INICIAL.....");
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
    }
        Console.WriteLine("DISCIPLINAS CADASTRADAS: ");
        foreach (string disciplina in listaDisciplinas)
        {
        int posicaoItem = listaDisciplinas.IndexOf(disciplina) + 1;
            Console.WriteLine(posicaoItem + " - "+ disciplina);
        }
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
        
    }

    void LimparDisciplinas() 
    {
        listaDisciplinas.Clear();
        Console.Clear();
        Console.WriteLine("LIMPANDO A BASE DE DADOS..........");
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
    }

    void Despedida()
    {
    Console.Clear();
    Console.WriteLine(@"
░█████╗░████████╗███████╗  ███╗░░░███╗░█████╗░██╗░██████╗  ██╗
██╔══██╗╚══██╔══╝██╔════╝  ████╗░████║██╔══██╗██║██╔════╝  ██║
███████║░░░██║░░░█████╗░░  ██╔████╔██║███████║██║╚█████╗░  ██║
██╔══██║░░░██║░░░██╔══╝░░  ██║╚██╔╝██║██╔══██║██║░╚═══██╗  ╚═╝
██║░░██║░░░██║░░░███████╗  ██║░╚═╝░██║██║░░██║██║██████╔╝  ██╗
╚═╝░░╚═╝░░░╚═╝░░░╚══════╝  ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝╚═════╝░  ╚═╝");
    }

    void Menu()
    {
        Console.WriteLine(@"
    ░█▀▄▀█ ░█▀▀▀ ░█▄─░█ ░█─░█ 
    ░█░█░█ ░█▀▀▀ ░█░█░█ ░█─░█ 
    ░█──░█ ░█▄▄▄ ░█──▀█ ─▀▄▄▀");
        Console.WriteLine();
        Console.WriteLine("Digite 1 para REGISTRAR uma disciplina");
        Console.WriteLine("Digite 2 para MOSTRAR todas as disciplinas");
        Console.WriteLine("Digite 3 para LIMPAR todas as disciplinas");
        Console.WriteLine("Digite 0 para sair");
        Console.WriteLine();
        Console.Write("Digite sua opção: ");
        int opcaoEscolhida = int.Parse(Console.ReadLine());

        switch (opcaoEscolhida)
        {
            case 0: 
                Despedida();
                break;
            case 1:
                RegistrarDisciplina();
                break;
            case 2:
                ListarDisciplinas();
                break;
            case 3:
                LimparDisciplinas();
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Opção Inválida!");
                Separador();
                Menu();
                break;
        }
    }