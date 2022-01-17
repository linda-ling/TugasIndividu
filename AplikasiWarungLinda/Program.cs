using System;


namespace ProgramBioskop
{
    class ProgramBioskop
    {
        //LIST
        private static List<int> id_film = new List<int>();
        private static List<int> id_booking = new List<int>();
        private static List<int> id_booking_tiket = new List<int>();
        private static List<string> judul_film = new List<string>();
        private static List<string> nama = new List<string>();
        private static List<string> nomor_kursi = new List<string>();
        private static List<int> harga_tiket = new List<int>();
        //private static List<Film> film = new List<Film>();
        private static int harga_tiket;
        private static int jumlah_bayar;
        private static int jumlah_kembalian;
        
        


        public static void Main(string[] args)
        {

            Film spiderman = new Film();
            Film residen = new Film(); 
            Film venow = new Film();

            spiderman.Kode = 101;
            spiderman.JudulFilm = "SPIDERMAN : NO-WAY HOME";
            spiderman.Harga = 45000;
            //_ = spiderman.studio;

            residen.Kode = 102;
            residen.JudulFilm = "RESIDEN EVIL";
            residen.Harga = 40000;
            //_ = residen.studio;

            venom.Harga = 103;
            venom.JudulFilm = "VENOM";
            venom.Harga = 55000;
            //_ = venom.studio;

            spiderman.Intro();
            residen.Intro();
            venom.Intro();

            menu();
        }
        static void menu()
        {
            //ARRAY
            string[] menu = { "TICKET", "BOOKING", "EXIT" };
            int pmenu;

            //JUDUL
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("                                                 ");
            Console.WriteLine("        APLIKASI PEMESANAN TIKET BIOSKOP         ");
            Console.WriteLine("            Jl. Mangga No. 29 Kebumen            ");
            Console.WriteLine("                                                 ");
            Console.WriteLine("=================================================");


            while (true) //Syarat LOOPING
            {
                // transaksi;
                Console.WriteLine();
                Console.WriteLine("——————————————————————————————————————————————————");
                Console.WriteLine("                   PILIHAN MENU                   ");
                Console.WriteLine("——————————————————————————————————————————————————");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + menu[i]);
                }
                Console.WriteLine("——————————————————————————————————————————————————");
                try
                {
                    pmenu = pilihmenu();
                    switch (pmenu)
                    {
                        case 1:
                            menuFilm();
                            break;

                        case 2:
                            menuBooking();
                            break;

                        case 3:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Karakter yang Anda masukkan salah!");
                }

            }
        }

            static int pilihmenu() //METHOD
            {
                Console.WriteLine("Masukkan pilihan menu : ");
                string input = Console.ReadLine();
                return Int32.Parse(input);
            }


            static void tampilmenu() //METHOD
            {
                Console.WriteLine("——————————————————————————————————————————————————");
                Console.WriteLine("NO." + "     " + "KODE" + "     " + "JUDUL FILM" + "     " + "HARGA TIKET");
                Console.WriteLine("——————————————————————————————————————————————————");

                for (int i = 0; i < id_film.Count; i++)
                {
                    Console.WriteLine((i + 1) + ".\t" + id_film[i] + "     \t" + judul_film[i] + "     \t" + harga_tiket[i]);
                }
            }


            static void menuFilm()
            {
                string[] menutiket = { "TAMBAH FILM", "EDIT FILM", "HAPUS FILM", "KEMBALI" };
                int pmenutiket;

                Console.Clear();
                tampilmenu();
                Console.WriteLine("——————————————————————————————————————————————————");
                Console.WriteLine("                   PILIHAN AKSI                   ");
                Console.WriteLine("——————————————————————————————————————————————————");
                for (int i = 0; i < menutiket.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + menutiket[i]);
                }
                Console.WriteLine("——————————————————————————————————————————————————");
                try
                {
                    pmenutiket = pilihmenut();
                    switch (pmenutiket)
                    {
                        case 1:
                            tambahfilm();
                            break;

                        case 2:
                            editfilm();
                            break;

                        case 3:
                            hapusfilm();
                            break;
                        case 4:
                            menu();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Karakter yang Anda masukkan salah!");
                }

            }


        static int pilihmenut() //METHOD
        {
            Console.WriteLine("Masukkan pilihan aksi : ");
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }


        static void tambahFilm() //METHOD
            {
                while (true)
                {
                    Film film = new Film();

                    string getdata = "";
                    Console.Write("Masukkan kode tiket  : ");
                    film.Kode = int.Parse(Console.ReadLine());
                    
                    Console.Write("Masukkan judul film  : ");
                    film.JudulFilm = Console.ReadLine();
                    
                    Console.Write("Masukkan harga tiket : ");
                    film.Harga = int.Parse(Console.ReadLine());

                    id_booking.Add(film);
                    Console.WriteLine();
                    tampilmenu();

                    Console.Write(" ");
                    Console.Write("Masukkan film lagi (Y/N) ? ");
                    getdata = Console.ReadLine();
                    Console.Write(" ");
                    if (cekdata(getdata)){break;}
                }
            }


        public static void editFilm()
        {
            string getdata = "";
            Console.Write("Masukkan kode tiket  : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Masukkan judul film  : ");
            string judul = Console.ReadLine();

            Console.Write("Masukkan harga tiket : ");
            int harga = int.Parse(Console.ReadLine());

            Console.Clear();
            tampilmenu();
        }


            static void tampildatabooking() //METHOD
            {
                Console.WriteLine("——————————————————————————————————————————————————");
                Console.WriteLine("NO." + "     " + "KODE" + "     " + "NAMA" + "     " + "JUDUL FILM" + "     " + "NOMOR KURSI" + "     " + "HARGA" + "     " + "BAYAR" + "     " + "KEMBALIAN");
                Console.WriteLine("——————————————————————————————————————————————————");
                int no = 0;
                for (int i = 0; i < id_booking.Count; i++)
                {
                    int harga = harga_tiket[id_booking_tiket[i] - 1];
                    int bayar = jumlah_bayar[id_booking_tiket[i] - 1];

                    int jumlah_kembalian = bayar - harga;

                    Console.WriteLine((i+1) + ".\t" + id_booking[i] + "     \t" + nama[i] + "     \t" + judul_film[id_booking_tiket[i] - 1] + "     \t" + harga_tiket[id_booking_tiket[i] - 1] + "     \t" + jumlah_bayar + "     \t" + "     \t" + jumlah_kembalian);
                }
            }


            static void booking() //METHOD
            {
                while (true)
                {
                    string getdata = "";
                    Console.Write("Masukkan kode booking: ");
                    getdata = Console.ReadLine();
                    if (cekdata(getdata)){break;}
                    id_booking.Add(Int32.Parse(getdata));

                    Console.Write("Masukkan nama pemesan : ");
                    getdata = Console.ReadLine();
                    if (cekdata(getdata)){break;}
                    nama.Add(getdata);

                    Console.Write("Masukkan kode booking tiket : ");
                    getdata = Console.ReadLine();
                    if (cekdata(getdata)) {break;}
                    id_booking_tiket.Add(Int32.Parse(getdata));

                    Console.Write("Masukkan nomor kursi  : ");
                    getdata = Console.ReadLine();
                    if (cekdata(getdata)) {break;}
                    nomor_kursi.Add(getdata);

                    Console.Write("");
                    Console.Write("Masukkan jumlah bayar : ");
                    getdata = Console.ReadLine();
                    if (cekdata(getdata)) {break;}
                    jumlah_bayar.Add(Int32.Parse(getdata));
                    Console.Write("");

                    Console.Write(" ");
                    Console.Write("Masukkan tiket lagi (Y/N) ? ");
                    getdata = Console.ReadLine();
                    Console.Write(" ");
                    if (cekdata(getdata)) {break;}

                    //jumlah_kembalian = jumlah_bayar + harga_tiket;
                }



                tampilmenu();
                tampildatabooking();

                
            }


            static bool cekdata(string data) //METHOD
            {
                if (data == "N" || data == "n")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
