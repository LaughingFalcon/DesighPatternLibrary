using DesighPatternLibrary.Adapter;
using DesighPatternLibrary.Bridge;
using DesighPatternLibrary.Builder;
using DesighPatternLibrary.ChainOfResponsibility;
using DesighPatternLibrary.Command;
using DesighPatternLibrary.Composite;
using DesighPatternLibrary.Decorator;
using DesighPatternLibrary.Facade;
using DesighPatternLibrary.Factory;
using DesighPatternLibrary.Interpreter;
using DesighPatternLibrary.Mediator;
using DesighPatternLibrary.Memento;
using DesighPatternLibrary.NullObject;
using DesighPatternLibrary.Observer;
using DesighPatternLibrary.Prototype;
using DesighPatternLibrary.Repository;
using DesighPatternLibrary.Singleton;
using DesighPatternLibrary.State;
using DesighPatternLibrary.Strategy;
using DesighPatternLibrary.Template;
using DesignPattern.Event;
using DesignPattern.Flyweight;
using DesignPattern.Interator;
using DesignPattern.Lazy;
using DesignPattern.MVP;
using DesignPattern.Proxy;
using DesignPattern.Rules;
using DesignPattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DesighPatternLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            InvokeAdapter();
            InvokeBridge();
            InvokeBuilder();
            InvokeChain();
            InvokeNull();
            InvokeSingleton();
            InvokeCommand();
            InvokeComposite();
            InvokeDecorator();
            InvokeFacade();
            InvokeFactory();
            InvokeInterpreter();
            InvokeMediator();
            InvokeMemento();
            InvokePrototype();
            InvokeRepository();
            InvokeState();
            InvokeTemplate(); //18
            InvokeObserve();
            InvokeStrategy();
            InvokeLazy();
            InvokeMVP();
            InvokeEvent();
            InvokeFlyweight();
            InvokeIterator();
            InvokeProxy();
            InvokeService();
            InvokeRules();
            InvokeSpecification();

        }

        public static void InvokeAdapter()
        {
            ConnectDatabase instance = ConnectDatabase.getInstance();
            PocketMonster newOne = new PocketMonster("New One", "Fuego", "Vento", 7.8);
            Console.WriteLine("Name: " + newOne.nome + " HP: " + newOne.hp);

            AdapterMega megaForm = new AdapterMega(true);
            newOne.transform(megaForm);
            Console.WriteLine("Name: " + newOne.nome + " HP: " + newOne.hp + "Mega Form");
            newOne.baseform(megaForm);

            AdapterReve reveForm = new AdapterReve();
            newOne.transform(reveForm);
            Console.WriteLine("Name: " + newOne.nome + " HP: " + newOne.hp + "Revest Form");
            newOne.baseform(reveForm);

            Console.WriteLine("Name: " + newOne.nome + " HP: " + newOne.hp);

            Console.ReadLine();
        }
        public static void InvokeBridge()
        {
            IAbstractBridge bridge = new AbstractBridge();
            bridge.CallMethod1();
            bridge.CallMethod2();
        }
        public static void InvokeBuilder()
        {
            List<string> salad = new List<string>();
            salad.Add("Alface"); salad.Add("Picles");
            List<string> sauce = new List<string>();
            sauce.Add("Azeite"); sauce.Add("MolhoVegan");
            OrderVegan buildBegan = new OrderVegan(true, salad, sauce);
            Sandwish veganSandwish = buildBegan.takeSandwish();
            Console.WriteLine("My Sandwish: " + veganSandwish.Bread + " " + veganSandwish.Meat + " " + veganSandwish.Cheese.FirstOrDefault());

            List<string> salad2 = new List<string>();
            salad2.Add("Alface"); salad2.Add("Picles");
            List<string> sauce2 = new List<string>();
            sauce2.Add("Azeite"); sauce2.Add("MolhoVegan");
            List<string> cheese = new List<string>();
            cheese.Add("Branco"); cheese.Add("prato");
            OrderTeryak buildTery = new OrderTeryak("9 graos",true, salad, sauce,cheese);
            Sandwish terySandwish = buildTery.takeSandwish();
            Console.WriteLine("Your Sandwish: " + terySandwish.Bread + " " + terySandwish.Meat + " " + terySandwish.Cheese.FirstOrDefault());
            Console.ReadLine();
        }   
        public static void InvokeChain()
        {
            ConnectDatabase instance = ConnectDatabase.getInstance();
            Dictionary<string, IEmployee> employees = (new Company()).GetEmployees();
            employees["Tina"].RequestMoney(10000001);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void InvokeNull()
        {
            IQueue queue = (new Queue()).GetQueue();
            Console.WriteLine("Valor total da fila: "+queue.GetValue());
            Console.ReadLine();
        }
        public static void InvokeSingleton()
        {
            ConnectDatabase instance = ConnectDatabase.getInstance();
        }
        public static void InvokeCommand()
        {
            IAccessible file = new Archive();

            ICommand fileClose = new CloseFileCommand(file);
            ICommand fileOpen = new OpenFileCommand(file);
            ICommand fileCopy = new CopyFileCommand(file);
            ICommand filePaste = new PasteFileCommand(file);

            Access command = new Access(fileClose, fileOpen, fileCopy, filePaste);

            string []orders = {"close","open","close","close","copy","paste","paste","batata"};
            foreach (string ordem in orders)
            {
                switch (ordem)
                {
                    case "open":
                        Console.Write("Comando "+ordem+": ");
                        command.Open();
                        break;
                    case "close":
                        Console.Write("Comando " + ordem + ": ");
                        command.Close();
                        break;
                    case "copy":
                        Console.Write("Comando " + ordem + ": ");
                        command.Copy();
                        break;
                    case "paste":
                        Console.Write("Comando " + ordem + ": ");
                        command.Paste();
                        break;
                    default:
                        Console.WriteLine("Comando " + ordem + ": Comando Inválido");
                        break;
                }
            }

            Console.ReadLine();
        }
        public static void InvokeComposite()
        {
            IMercenary clanSupreme = new Clan("Supreme Masters");
            IMercenary clanPotato = new Clan("Potato Killers");
            IMercenary clanTrain = new Clan("Trains Likers");
            IMercenary Andy = new Mercenary("Andiosvaldo");
            IMercenary Bob = new Mercenary("Bobsnaldo");
            IMercenary Caio = new Mercenary("Caiosvaldo");
            IMercenary Edu = new Mercenary("Ediscleison");

            clanPotato.NewMember(Andy);
            clanPotato.NewMember(Bob);
            clanTrain.NewMember(Caio);

            clanSupreme.NewMember(clanPotato);
            clanSupreme.NewMember(clanTrain);
            clanSupreme.NewMember(Edu);

            int newPayment = 6000;

            clanSupreme.payment(newPayment);
            clanSupreme.data();

            newPayment = 999;
            Console.WriteLine();

            clanSupreme.payment(newPayment);
            clanSupreme.data();
            

            Console.ReadLine();

        }
        public static void InvokeDecorator()
        {
            IHero hero = new Link();
            Challenger challenge = new Challenger();

            Console.WriteLine("Normal Hero");
            challenge.Quests(hero);

            IHero heroBlue = new BlueTunic(hero);
            Console.WriteLine("Blue Hero");
            challenge.Quests(heroBlue);

            IHero heroRed = new RedTunic(hero);
            Console.WriteLine("Red Hero");
            challenge.Quests(heroRed);

            IHero heroHeavy = new IronBoot(hero);
            Console.WriteLine("Heavy Hero");
            challenge.Quests(heroHeavy);

            IHero heroAquatic = new WaterArmor(hero);
            Console.WriteLine("Aquatic Hero");
            challenge.Quests(heroAquatic);
            
        }
        public static void InvokeFacade()
        {
            Facadex fachada = new Facadex();
            Console.WriteLine(fachada.concat("Esquerda ","Direita"));
            Console.WriteLine(fachada.sum(8,7));

            Console.ReadLine();
        }
        public static void InvokeFactory()
        {
            IFactory cheapFactory = new CheapFactory();
            IFactory richFactory = new ExpensiveFactory();
            Console.WriteLine("Criar carro versão barato");
            IProduct dirtCheapCar = cheapFactory.createProduct("Sport Car", 2, true);
            Console.WriteLine("Criar moto versão caro");
            IProduct expensiveMoto = richFactory.createProduct("Yamaha", false);
            Console.WriteLine("Criar carro versão cara");
            IProduct expensiveCar = richFactory.createProduct("Sport Car", 4, true);

            Console.WriteLine("Carro Barato Km/l:" + dirtCheapCar.efficiency() + " duracaoTank(h):" + dirtCheapCar.time());
            Console.WriteLine("Carro Caro Km/l:" + expensiveCar.efficiency() + " duracaoTank(h):" + expensiveCar.time());
            Console.WriteLine("Moto Cara Km/l:" + expensiveMoto.efficiency() + " duracaoTank(h):" + expensiveMoto.time());

            Console.ReadLine();
        }
        public static void InvokeInterpreter()
        {
            string textLeet = "T3xt0 n4 l1ngu4g3m l33t";
            string textP = "PTexpto pna plinpguapgem pdo ppê";
            Interpreter.Client cli = new Interpreter.Client("Franciscleison",77,"Congo");

            Console.WriteLine("Leet Original: " + textLeet);
            Console.WriteLine("Leet > Portuguese: "+ Translator.LeetToPortuguese(textLeet));

            Console.WriteLine("Pê Original: " + textP);
            Console.WriteLine("Pê > Portuguese: " + Translator.PeToPortuguese(textP));
            Console.WriteLine();

            Console.WriteLine("Criando classe Client... ");
            Console.WriteLine("Client > CSV: " + Translator.ClientToCsv(cli));
            Console.WriteLine();

            Console.ReadLine();
        }
        public static void InvokeMediator()
        {
            IPostman postman = new Postman();
            Worker cleber = new Worker("Cthulhu", postman);
            Worker koba = new Worker("Kobayashi", postman);

            postman.add(1234,cleber);
            postman.add(8765,koba);

            cleber.sendMessage(8765,"Batata Frita");
            koba.sendMessage(1234, "Primeira");
            koba.sendMessage(1234, "Segunda");

            Console.WriteLine(cleber.name+" "+cleber.lastMessage[0]+" "+ cleber.lastMessage[1]);
            Console.WriteLine(koba.name + " " + koba.lastMessage[0] + " " + koba.lastMessage[1]);

            Console.ReadLine();
        }
        public static void InvokeMemento()
        {
            GenericClass memento = new GenericClass("Class Generic","First");
            Console.WriteLine("Nome: "+memento.getName()+" Status: "+memento.getStatus()+" Version: "+memento.getVersion());
            Backup backup = new Backup();
            backup.addBackup(memento.Clone());

            memento.setStatus("Second");
            Console.WriteLine("Nome: " + memento.getName() + " Status: " + memento.getStatus() + " Version: " + memento.getVersion());
            backup.addBackup(memento.Clone());

            memento.setStatus("Terceiro");
            Console.WriteLine("Nome: " + memento.getName() + " Status: " + memento.getStatus() + " Version: " + memento.getVersion());
            backup.addBackup(memento.Clone());

            if (backup.containsVersion(2))
                memento = backup.recoverVersion(2);
            Console.WriteLine("Nome: " + memento.getName() + " Status: " + memento.getStatus() + " Version: " + memento.getVersion());

            Console.ReadLine();
        }
        public static void InvokePrototype()
        {
            IRobot caseiro = new Homy("Afonso", 10, true);
            IRobot guerreira = new Battle("Francisca", 3, false);
            Console.WriteLine(caseiro.info());
            Console.WriteLine(guerreira.info());
            IRobot clone = caseiro.Clone();
            Console.WriteLine(clone.info());
            Console.ReadLine();
        }
        public static void InvokeRepository()
        {
            IClientRepository cliRepo = new ClientRepository();
            DesighPatternLibrary.Repository.Client client = cliRepo.GetClient(1);
            Console.WriteLine(client.name + " " + client.fruit);
            cliRepo.UpdateClient(1, "Goiaba");
            client = cliRepo.GetClient(1);
            Console.WriteLine(client.name + " " + client.fruit);
            Console.ReadLine();
        }
        public static void InvokeState()
        {
            Genesect genesect = new Genesect("Astolfinho");
            genesect.attack();
            genesect.setDrive(new Burn("Flamejante","Vermelha"));
            genesect.attack();
            genesect.setDrive(new Shock("Chocante", "Azul"));
            genesect.attack();

            Console.ReadLine();
        }
        public static void InvokeTemplate()
        {
            IRecipe boloFuba = new SimpleCakeRecipe();
            IRecipe boloCenouraCoberturaCholata = new CakeRecipe();

            Console.WriteLine(boloFuba.fazerBolo("Bolo de Fubá"));
            Console.WriteLine(boloCenouraCoberturaCholata.fazerBolo("Bolo de Cenoura com Cobertura de Chocolate"));


            Console.ReadLine();
        }
        public static void InvokeObserve()
        {
            IObservador observer = new Observador();
            Apostador cleber = new Apostador("Cthulhu", observer,10000);
            Apostador koba = new Apostador("Kobayashi", observer, 10000);
            Apostador jimmy = new Apostador("Jimmy", observer, 10000);

            observer.add(cleber);
            observer.add(koba);
            observer.add(jimmy);

            int max = 0;
            Random rnd = new Random();
            while (max < 3)
            {
                max = 0;
                
                int bet = rnd.Next(11000);
                if (bet > cleber.lastBet)
                    cleber.sendMessage(bet);


                bet = rnd.Next(11000);
                if (bet > koba.lastBet)
                    koba.sendMessage(bet);

                bet = rnd.Next(11000);
                if (bet > jimmy.lastBet)
                    jimmy.sendMessage(bet);

                if (cleber.maxBet <= cleber.lastBet)
                    max++;
                if (koba.maxBet <= bet)
                    max++;
                if (jimmy.maxBet <= bet)
                    max++;
            }

            Console.WriteLine(jimmy.lastPutter + " " + cleber.lastBet);
            Console.WriteLine(koba.lastPutter + " " + cleber.lastBet);

            Console.ReadLine();
        }
        public static void InvokeStrategy()
        {
            IStrategi straBike = new StrateegiaBIke();
            IStrategi straCar = new StrategyCar();
            IStrategi straBus = new EstrategiaBus();

            int discante = 90;
            bool pico = false;

            Console.WriteLine("Indo de Bicicleta: " + straBike.timeTravel(discante, pico) + " horas. Horário de pico: " + pico);
            Console.WriteLine("Indo de Carro: " + straCar.timeTravel(discante, pico) + " horas. Horário de pico: " + pico);
            Console.WriteLine("Indo de Ônibus: " + straBus.timeTravel(discante, pico) + " horas. Horário de pico: " + pico);
            Console.WriteLine();
            pico = true;
            Console.WriteLine("Indo de Bicicleta: " + straBike.timeTravel(discante, pico) + " horas. Horário de pico: " + pico);
            Console.WriteLine("Indo de Carro: " + straCar.timeTravel(discante, pico) + " horas. Horário de pico: " + pico);
            Console.WriteLine("Indo de Ônibus: " + straBus.timeTravel(discante, pico) + " horas. Horário de pico: " + pico);


            Console.ReadLine();
        }
        public static void InvokeLazy()
        {
            DatabaseLoader dbLoader = new DatabaseLoader();
            dbLoader.loadTuples(333);
            foreach (DatabaseTable table in dbLoader.takeTuples(1))
            {
                Console.WriteLine(table.id + " " + table.column1);
            }
            foreach (DatabaseTable table in dbLoader.takeTuples(2))
            {
                Console.WriteLine(table.id + " " + table.column1);
            }
            Console.ReadLine();
        }
        public static void InvokeMVP()
        {
            View view = new View("Chinchila");
            view.update();
            Console.ReadLine();
        }
        public static void InvokeEvent()
        {
            IEventAggregator aggregator = new EventAggregator();
            CustomerEvent customer = new CustomerEvent();
            aggregator.Subscribe(customer);
            ClientEvent client = new ClientEvent();
            Publisher publisher = customer.createPublisher(aggregator);
            aggregator.Subscribe(client);
            publisher.updateInfo(2);

            Console.ReadLine();
        }
        public static void InvokeFlyweight()
        {
            Random random = new Random();

            List<Bird> birds = new List<Bird>();
            Birdweight birdW;

            int info = random.Next(20);
            int info2 = random.Next(30);
            int potato = 50;
            birds.Add(new Bird(info, info2, potato));
            birdW = new Birdweight(info, info2, potato);
            for (int i = 0; i < 100; i++)
            {
                info = random.Next(20);
                info2 = random.Next(30);
                birds.Add(new Bird(info, info2, potato));
                birdW.addInfo(info, info2);
            }
            int sizeBird = 0;

            foreach (Bird bird in birds)
            {
                sizeBird = sizeBird + bird.size();
            }

            Console.WriteLine("Sem Flyweight: " + sizeBird);
            Console.WriteLine("Com Flyweight: " + birdW.size());

            Console.ReadLine();
        }
        public static void InvokeIterator()
        {
            UserInfo[] uInfo = new UserInfo[3]{
                new UserInfo(1, "Aaaa", "zzzZ"),
                new UserInfo(2, "Bbbb", "yyyY"),
                new UserInfo(3, "Cccc", "xxxX")
            };

            Users users = new Users(uInfo);

            foreach (var user in users)
            {
                Console.WriteLine(user.Id + " " + user.Name + " " + user.lastname);

            }

            Console.ReadLine();
        }
        public static void InvokeProxy()
        {
            IImage image = new ProxyImage("imagemTeste.jpg");
            image.display();
            Console.WriteLine("");
            image.display();
            Console.ReadLine();
        }
        public static void InvokeService()
        {
            IService service = ServiceLocator.getService("ServiceOne");
            service.execute();

            service = ServiceLocator.getService("ServiceTwo");
            service.execute();

            service = ServiceLocator.getService("ServiceOne");
            service.execute();

            service = ServiceLocator.getService("ServiceTwo");
            service.execute();
            Console.ReadLine();
        }
        public static void InvokeRules()
        {
            Lead lead = new Lead(1994, 05, 11, 2000, false);
            RulesDiscountCalculator rules = new RulesDiscountCalculator();
            Console.WriteLine("Desconto: " + OldDiscountCalculator.CalculateDiscountPercentage(lead));
            Console.WriteLine("Desconto: " + rules.CalculateDiscountPercentage(lead));
            Console.ReadLine();
        }
        public static void InvokeSpecification()
        {

            Console.ReadLine();
        }
        public static void Invoke()
        {

            Console.ReadLine();
        }

    }
}
