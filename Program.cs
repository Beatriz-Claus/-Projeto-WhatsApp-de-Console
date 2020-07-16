using System;

namespace WhatsAppConsole {
    class Program {

        static void Main (string[] args) {
            Contato _contato = new Contato ();
            Agenda agd = new Agenda ();
            _contato.Nome = "Pai Lindo";
            _contato.Telefone = "(00)00000-0000";
            agd.Cadastrar (_contato);
            agd.Listar ();
        }
    }
}