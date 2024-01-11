using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program {
    static void Main() {
        Nokia nokiaPhone = new Nokia("12345", "ModelX", "IMEI001", 32);
        nokiaPhone.InstalarAplicativo("WhatsApp");

        Iphone iphone = new Iphone("67890", "ModelY", "IMEI002", 64);
        iphone.InstalarAplicativo("Instagram");
    }
}