using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone CelularCintia = new Nokia("19987896325","NK45", "45699878544785im", 256 );
CelularCintia.Ligar();
Smartphone CelularAbe = new Iphone("19789632558", "14", "ip1458796587", 128);
CelularAbe.ReceberLigacao();
CelularAbe.InstalarAplicativo("Whatsapp");
