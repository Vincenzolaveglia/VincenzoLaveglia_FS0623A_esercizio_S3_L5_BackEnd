using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce
{
    public static class Product
    {
        private static List<ProductItem> products = new List<ProductItem>
    {
        new ProductItem
        {
            Id = 1,
            Name = "MSI Modern 15 B12M-089IT",
            Description = "Notebook 15.6 Full-HD 60Hz, Intel I5-1235U, Intel Iris Xe, 8GB RAM DDR4 3200MHz, 512GB SSD M.2 PCIe 3, WiFi 6, Win 11 Home",
            MoreDescription= "Il Modern 15 B7M è dotato di tutto ciò di cui hai bisogno per perseguire le tue passioni sia nel lavoro che nel tempo libero. <br/> Gli ultimi processori AMD Ryzen serie 7730 sono qui. <br/> La serie Modern è dotata di processori fino a AMD Ryzen 7. <br/> La funzione 180° lay-flat e Flip-n-Share ti consente di condividere lo schermo con un clic per uno spazio di lavoro più efficace.",
            Price = 599.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/718AiQQtJBL._AC_SL1500_.jpg"
        },
        new ProductItem
        {
            Id = 2,
            Name = "NiPoGi Mini PC",
            Description = "Intel Alder Lake-N95 (Beats N5095, fino a 3.4GHz),16GB RAM+512GB M.2 SSD Mini Computer Desktop, supporto 2.5\" SATA SSD, WiFi 5,Bluetooth4.2, Dual HDMI Display",
            MoreDescription ="NiPoGi aggiorna il mini pc AK1 Plus dotato della più recente CPU Intel Alder Lake N95 di 12a generazione (fino a 3,4 GHz, 4C/4T, 15 W a basso consumo energetico) , il che significa che le sue prestazioni sono aumentate del 30% rispetto a Gemini Lake (N5105/N5095/N5100). <br/>Un perfetto mini PC desktop offre un'esperienza fluida per l'intrattenimento visivo domestico, lo streaming video, la navigazione web, il lavoro.",
            Price = 279.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/617NoeXQfGL._AC_SX679_.jpg"
        },
        new ProductItem
        {
            Id = 3,
            Name = "Caricabatterie USB Amazon PowerFast",
            Description = "Caricabatterie USB Amazon da 9W per e-reader Kindle, tablet Fire - compatibile con la maggior parte dei dispositivi (inclusi smartphone, tablet, e-reader e altri)",
            MoreDescription = "Caribatterie originale Amazon PowerFast da 9W - 1.8A compatibile con la maggior parte dei dispositivi USB (richiede cavo USB, non incluso con il caricabatterie). Ingresso: 100-240 V, 0,3 A, 50/60 Hz - Uscita : 5,2 V, 1,8 A",
            Price = 729.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/41Zkgt0i64L._AC_SX679_.jpg"
        },
        new ProductItem
        {
            Id = 4,
            Name = "Salora Televisore SMART32TV",
            Description = "Televisore da 32 pollici HD Smart TV HDR 10+ Android 11 con Chromecast integrato Dolby Vision & Atmos 3x HDMI USB Recording Prime Video Apple TV Disney+ Nero",
            MoreDescription= "Televisione HD da 32 pollici (81,3 cm) immergiti in un'esperienza visiva cristallina con il nostro schermo HD da 32 pollici (81,3 cm). <br/>Supporta tutti i formati HDR, inclusi Dolby Vision, HDR10+, HDR10, HLG Vivi un'esperienza visiva eccezionale con il supporto completo a tutti i formati HDR, tra cui Dolby Vision, HDR10+, HDR10 e HLG. ",
            Price = 199.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/81QlvcWyP2L._AC_SX679_.jpg"
        },
        new ProductItem
        {
            Id = 5,
            Name = "Samsung Galaxy Tab A9+",
            Description = "Display 11.0\" TFT LCD PLS, Wi-Fi, RAM 4GB, 64GB, 7.040 mAh, Qualcomm SM6375, Android 13, Navy, [Versione italiana] 2023",
            MoreDescription="Stile moderno, display raffinato: Samsung Galaxy Tab A9+ presenta un elegante corpo in metallo, Graphite o Navy; è dotato di display ampio e brillante per un intrattenimento coinvolgente, in tutte le condizioni di luce. <br/>Conserva tutto ciò che ami: il tablet Samsung Galaxy Tab A9+ offre fino a 8GB di RAM per ottimizzare le prestazioni durante il multitasking e una capacità di archiviazione di 128 GB (ampliabile fino a 1TB); salva tutti i tuoi file in alta risoluzione, conserva di più ed elimina di meno",
            Price = 249.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/61cK+nxkVgL._AC_SX679_.jpg"
        },
        new ProductItem
        {
            Id = 6,
            Name = "Acer Aspire 3 A315-58-76W1",
            Description = "PC Portatile, Notebook, Processore Intel Core i7-1165G7, RAM 8 GB DDR4, 512 GB PCIe NVMe SSD, Display 15.6\" FHD LED, Scheda Grafica Intel Iris Xe, Windows 11 Home, Silver",
            MoreDescription=" PRESTAZIONI POTENZIATE: il PC portatile Acer Aspire 3 ha un potente processore Intel Core i7 di 11a generazione, display 15.6\" FHD, scheda grafica Intel Iris Xe, 8 GB di RAM DDR4 e 512 GB di memoria SSD per svolgere qualsiasi attività. <br/>SCHERMO AMPIO: il notebook con display 15.6\" Full HD LED LCD regala immagini brillanti, mentre il design a bordi sottili offre un ampio spazio di visualizzazione; la tecnologia Acer BlueLightShield protegge la vista dalla luce blu nociva",          
            Price = 499.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/81+QYJUb5uL._AC_SX300_SY300_.jpg"
        },
        new ProductItem
        {
            Id = 7,
            Name = "EMPIRE GAMING - WarCry P-W11",
            Description = "Cuffie Gamer Senza fili con Microfono -PC/PS4/PS5/Xbox/Switch/Mac -Wireless 2,4 GHz -Suono Surround Stereo -LED Rosso",
            MoreDescription="SUONO IMMERSIVO : I driver da 50 mm con retroilluminazione rossa producono un campo sonoro immersivo a 360 gradi. <br /> COMFORT E DURATA : Archetto rinforzato e auricolari in memory foam",
            Price = 49.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/71ergEEg1SS._AC_SX679_.jpg"
        },
        new ProductItem
        {
            Id = 8,
            Name = "Logitech G402 Mouse Gaming",
            Description = "Hyperion Fury, 4.000 Dpi, Design Leggero, 8 Pulsanti Programmabili, Compatibile Con Pc/Mac/Laptop, Nero, 13.6 x 7.2 x 4.1 cm, 144 grammi",
            MoreDescription="Tracciamento ad Alta Velocità: il Fusion Engine offre una delle velocità più elevate di tracciamento tra i mouse gaming ottici, fino a 500 IPS. <br/>Otto Pulsanti Programmabili: personalizza il tuo mouse gaming Logitech G cablato e imposta i pulsanti sul tuo stile di gioco e salvandoli sul Gaming mouse USB G402",
            Price = 27.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/71jRUA8nxzL._AC_SX679_.jpg"
        },
         new ProductItem
        {
            Id = 9,
            Name = "THE G-LAB K-Pad Thorium",
            Description = "Controller di Gioco PC e Ps3 USB con Cavo - Vibrazione Integrata, Gamepad Game Controller con Cavo Elettrico - Joystick per PC Windows Xp-7-8-10, Ps3, Android (Nero)",
            MoreDescription="Vibrazione,Vibrazioni. Controller ad alta sensibilità",
            Price = 19.99m,
            ImageUrl = "https://m.media-amazon.com/images/I/61SXuz2OIYL._AC_SX679_.jpg"
        },
         new ProductItem {
             Id = 10,
             Name = "Bose SoundLink Micro",
             Description = "Diffusore Bluetooth Portatile Impermeabile con Microfono, Nero",
             MoreDescription = "Diffusore Bose impermeabile: compatto ma potente, SoundLink Micro Bluetooth produce un suono forte e chiaro con bassi incredibilmente profondi. Dotato di trasduttore appositamente progettato e radiatori passivi, per un suono nitido e bilanciato.<br/>Batteria a lunga durata: questo diffusore compatto per esterni è dotato di una potente batteria agli ioni di litio. Puoi ascoltare fino a 6 ore di musica e caricare il diffusore in qualsiasi momento tramite il cavo micro-USB incluso.",
             Price = 79.00m,
             ImageUrl = "https://m.media-amazon.com/images/I/71DyBp9pQZL._AC_SX679_.jpg"
         },
         new ProductItem
         {
             Id = 11,
             Name = "Logitech G213 Prodigy",
             Description = "Tastiera Gaming Cablata, LIGHTSYNC RGB, Tasti Retroilluminati, Resistente Agli Schizzi, Tasti Personalizzabili, Controlli Dedicati Multimediali, QWERTY Layout Italiano, Nero",
             MoreDescription = "Illuminazione RGB: tastiera gaming con cinque aree di illuminazione RGB separate con selezione dei colori da uno spettro di oltre 16,8 milioni di colori su questa tastiera da gioco con cavo USB. <br/>Tasti Alte Prestazioni: Tasti Mech-Dome progettati per una risposta tattile superiore e prestazioni simili a quelli delle tastiere meccaniche, sono adattati all'esperienza di gioco dei gamer ",
             Price = 49.99m,
             ImageUrl = "https://m.media-amazon.com/images/I/61I52zZ-7qL._AC_SX679_.jpg",
         },
         new ProductItem
         { 
             Id = 12,
             Name = "Totò Piccinni Sedia GAMING",
             Description = "Ergonomica Reclinabile Girevole con cuscini in similpelle con rotelle e poggiatesta (Blue)",
             MoreDescription = "Sedia Gaming creata per la massima esperienza dell utente, dal design sportivo ed ergonomico. <br/> Dimensioni: Altezza Totale 123 - Profondità 60 - Larghezza 65. <br/>Altezza Seduta 43/52 - Seduta 41x48 - Altezza Schienale 73 Altezza Braccioli 75",
             Price = 89.99m,
             ImageUrl = "https://m.media-amazon.com/images/I/71xhjxa-ynL._AC_SX679_.jpg",
         }

    };

        public static List<ProductItem> GetProducts()
        {
            return products;
        }

        public static ProductItem GetProductById(int id)
        {
            return products.Find(Product => Product.Id == id);
        }
    }

    public class ProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MoreDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}