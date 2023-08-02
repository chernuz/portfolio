import java.util.*;
import java.io.*;

public class Main {
    public static void chooseShow(ArrayList<pictureShow> shows, ArrayList<Client> clients, ArrayList<Movie> movies, ArrayList<CinemaTheatre> theatres) throws IOException
    {
        //boolean showsFound=false; ArrayList<pictureShow> foundShows=new ArrayList<pictureShow>();
        while(true) {
            System.out.println("Введите ваши ФИО, номер телефона, эл. почту и бюджет (каждый параметр в отдельной строке) или 0 для выхода в начальное меню:");
            Scanner sc = new Scanner(System.in);
            String name = "", phone = "", email = "";
            int budget = 0;
            try {
                name = sc.nextLine();
                phone = sc.nextLine();
                email = sc.nextLine();
                budget = sc.nextInt();
            } catch (Exception e) {
                System.out.println("Вероятно, вы ввели бюджет в неверном формате");
                return;
            }

            //Проверяем выход в меню
            if(name.equals("0"))
                return;

            //Проверяем наличие данного клиента
            int clientInd = clients.size();
            for (int i = 0; i < clients.size(); i++) {
                if (clients.get(i).Equals(name, phone, email))
                    clientInd = i;
            }
            if (clientInd == clients.size())
                clients.add(new Client(name, phone, email, budget));
            else
                clients.get(clientInd).setBudget(budget);

            //сессия покупки билета
            clients.get(clientInd).BuyTicket(shows, movies, theatres);

            //запись измененного списка клиентов в базу
            SerializeClient.serialize(clients);
        }
    }
    public static String readFromFile(String fileName)
    {
        String strRes="";
        try(FileReader reader = new FileReader(fileName))
        {
            // читаем посимвольно
            int a;
            while((a=reader.read())!=-1){

                strRes+=(char)a;
            }
        }
        catch(IOException ex){

            System.out.println(ex.getMessage());
        }
        return strRes;
    }
    public static void printToFile(String fileName, boolean append, String text)//append: true = дописать новые данные в конец файла, false = перезаписать содержимое файла
    {
        try(FileWriter writer = new FileWriter(fileName, append))
        {
            writer.write(text);
            writer.flush();
            writer.close();
        }
        catch(IOException ex)
        {
            System.out.println(ex.getMessage());
        }
    }
    public static void AddClientToBase(Client c, char sep) throws IOException
    {
        FileWriter fw = new FileWriter ("admin/Clients.csv", true);
        fw.write(c.getName()+sep+c.getPhoneNumber()+sep+c.getEmail()+sep+c.getBudget()+sep+c.getStatus()+sep+c.getTotalTickets());
        fw.close();
    }
    public Client ReadClient(String sep) throws IOException
    {
        File file = new File("admin/Clients.csv");
        BufferedReader br = new BufferedReader(new FileReader((file)));
        String[] params = br.readLine().split(sep);
        Client c = new Client(params[0], params[1], params[2], Integer.parseInt(params[3]), params[4], Integer.parseInt(params[5]));
        return c;
    }
    public static void AdvMode(ArrayList<CinemaTheatre> theatres, ArrayList<Advertiser> ads)
    {
        System.out.println("Введите ваши ФИО, номер телефона, эл. почту и бюджет (каждый параметр в отдельной строке) или 0 для выхода в начальное меню:");
        Scanner sc = new Scanner(System.in);
        String name = "", phone = "", email = "", product="", text="";
        int budget = 0, money = 0;
        try {
            name = sc.nextLine();
            phone = sc.nextLine();
            email = sc.nextLine();
            budget = sc.nextInt();
            if(name.equals("0"))
                return;
            System.out.println("Введите название продукта, текст рекламы и стоимость предложения:");
            sc.nextLine();
            product = sc.nextLine();
            text = sc.nextLine();
            money = sc.nextInt();
            System.out.println("Выберите кинотеатр:");
            for(int i=0; i<theatres.size(); i++) {
                System.out.println(i+1 + " - " + theatres.get(i).output());
            }
            int ind = sc.nextInt()-1;
            int adsInd = ads.size();
            for (int i = 0; i < ads.size(); i++) {
                if (ads.get(i).Equals(new Advertiser(name, phone, email, budget, theatres.get(ind), product, text, money)))
                    adsInd = i;
            }
            if (adsInd == ads.size())
                ads.add(new Advertiser(name, phone, email, budget, theatres.get(ind), product, text, money));
            else
                ads.get(adsInd).setBudget(budget);
            //System.out.println("Индекс типа "+ adsInd);
            System.out.println("Эффективность по вышему предложению составляет "+ads.get(adsInd).getEfficiency());
        }
        catch(Exception e)
        {
            System.out.println("Вы ввели бюджет в неверном формате или неверный индекс кинотеатра");
        }
    }
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ArrayList<Client> clients = SerializeClient.deserialize();
        ArrayList<Movie> movies = Movie.getMovies(";");

        //создаем кинотеатры
        CinemaTheatre KaroOktyabr1 = new CinemaTheatre("Каро 1 Октябрьская", "Октябрьская, 36", new String[]{"2D", "3D"});
        KaroOktyabr1.addHall(new CinemaHall(1, 10, 20, 300, 1));
        KaroOktyabr1.addHall(new CinemaHall(2, 10, 10, 500, 3));
        CinemaTheatre CinemaStar = new CinemaTheatre("Синема Стар", "Большая Черемушкинская, 1", new String[]{"2D", "3D"});
        CinemaStar.addHall(new CinemaHall(1, 15, 25, 300, 1));
        CinemaStar.addHall((new CinemaHall(2, 10, 12, 500, 2)));
        CinemaTheatre PushkaBrateevo = new CinemaTheatre("Пушка Братеево", "Братеевская, 24", new String[]{"2D", "3D"});
        PushkaBrateevo.addHall(new CinemaHall(1, 15, 15, 300, 2));

        ArrayList<CinemaTheatre> theatres = new ArrayList<CinemaTheatre>();
        theatres.add(KaroOktyabr1);
        theatres.add(CinemaStar);
        theatres.add(PushkaBrateevo);
        ArrayList<CinemaTheatre> theatresFromFile = CinemaTheatre.getTheatres(";");
        for(int i=0; i<theatres.size(); i++)
        {
            for(int j=0; j<theatresFromFile.size(); j++)
            {
                if(theatres.get(i).Equals(theatresFromFile.get(j))) {
                    theatres.get(i).setTotalRevenue(theatresFromFile.get(j).getTotalRevenue());
                    theatres.get(i).setTotalTickets(theatresFromFile.get(j).getTotalTickets());
                }
            }
        }

        //создаем сеансы
        ArrayList<pictureShow> shows=new ArrayList<pictureShow>();
        shows.add(new pictureShow(KaroOktyabr1, movies.get(0), new Date(123, 0, 1, 18, 0), 2));
        shows.add(new pictureShow(CinemaStar, movies.get(0), new Date(123, 0, 2, 15, 0), 2));
        shows.add(new pictureShow(KaroOktyabr1, movies.get(1), new Date(123, 0, 1, 12, 0), 1));
        shows.add(new pictureShow(PushkaBrateevo, movies.get(1), new Date(123, 0, 1, 18, 0), 1));
        shows.add(new pictureShow(KaroOktyabr1, movies.get(2), new Date(123, 0, 2, 15, 0), 0));
        shows.add(new pictureShow(CinemaStar, movies.get(2), new Date(123, 0, 1, 18, 0), 2));
        shows.add(new pictureShow(PushkaBrateevo, movies.get(2), new Date(123, 0, 2, 13, 0), 0));
        for(int i=0; i<shows.size(); i++)
        {
            shows.get(i).AddShowToBase(';', true);
        }
        ArrayList<Advertiser> ads = new ArrayList<Advertiser>();
        while (true)
        {
            System.out.println("Введите на английской раскладке c, чтобы войти как клиент; a, чтобы войти как администратор; v, чтобы войти как рекламодатель.");
            Scanner sc = new Scanner(System.in);
            String identifier = sc.nextLine();
            if(identifier.equals("c")) {
                chooseShow(shows, clients, movies, theatres);
            }
            else
            {
                if(identifier.equals("a"))
                {
                    Admin.AdminAccess(theatres, shows, ads);
                }
                else
                    if(identifier.equals("v"))
                    {
                        AdvMode(theatres, ads);
                    }
                    else
                        System.out.println("Введен неизвестный идентификатор, Попробуйте снова");
            }
            System.out.println("\n");
        }
    }
}