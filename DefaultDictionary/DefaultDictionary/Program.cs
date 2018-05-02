using System;


namespace DiegoNunesCom {
	class Program {
		static void Main(string[] args) {
			DefaultDictionary<string, string> parametros = new DefaultDictionary<string, string>();

			parametros["usuario"] = "diego@diego-nunes.com";

			Console.WriteLine("Usuario: " + parametros["usuario"]);
			Console.WriteLine("Senha  : " + parametros["senha"]);

			Console.ReadKey();
		}
	}
}
