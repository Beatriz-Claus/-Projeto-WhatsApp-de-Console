namespace WhatsAppConsole
{
   public class Mensagem {
       
        public string Texto { get; set; }
        public string Destinatário { get; set; }
        public string Enviar (string contato) {

            return "Mensagem Enviada";

        }
    }
}