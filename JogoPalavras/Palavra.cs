using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavras
{
    internal class Palavra
    {
        private string palavraSecreta;
        public string PalavraSecretaStr 
        {
            get
            {
                return palavraSecreta;
            }
        } 

        public Palavra()
        {
            palavraSecreta = PalavraSecreta();
        }

        public bool JogadorAcertou(string palavraLetras)
        {
            if(palavraLetras == palavraSecreta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string VerificadorDePalavra(char letra, int indiceBtn)
        {
            string cor = TipoDeCor.Preto.ToString();

            for(int i = 0; i < 5; i++)
            {
                if (letra == palavraSecreta[i] && indiceBtn == i)
                {
                    cor = TipoDeCor.Verde.ToString();
                }
                else if(letra == palavraSecreta[i] && indiceBtn != i)
                {
                    cor = TipoDeCor.Amarelo.ToString();
                }
            }

            return cor;
        }

        private enum TipoDeCor
        {
            Preto, Verde, Amarelo
        }

        public string PalavraSecreta()
        {
            string[] palavras = new string[] {

                "acido", "adiar", "impar", "algar", "amado", "amigo", "anexo", "anuir", "aonde", "apelo",
                "aquém", "argil", "arroz", "assar", "atras", "avido", "azeri", "babar", "bagre", "banho",
                "barco", "bicho", "bolor", "brasa", "brava", "brisa", "bruto", "bulir", "caixa", "cansa",
                "chato", "chave", "chefe", "choro", "chulo", "claro", "cobre", "corte", "curar", "deixo",
                "dizer", "dogma", "dores", "duque", "enfim", "estou", "exame", "falar", "fardo", "farto",
                "fatal", "feliz", "ficar", "fogue", "força", "forno", "fraco", "fugir", "fundo", "furia",
                "gaita", "gasto", "geada", "gelar", "gosto", "grito", "gueto", "honra", "humor", "idade",
                "ideia", "ídolo", "igual", "imune", "índio", "íngua", "irado", "isola", "janta", "jovem",
                "juizo", "largo", "laser", "leite", "lento", "lerdo", "levar", "lidar", "lindo", "lírio",
                "longe", "luzes", "magro", "maior", "malte", "mamar", "manto", "marca", "matar", "meigo",
                "meios", "melão", "mesmo", "metro", "mimos", "moeda", "moita", "molho", "morno", "morro",
                "motim", "muito", "mural", "naipe", "nasci", "natal", "naval", "ninar", "nivel", "nobre",
                "noite", "norte", "nuvem", "oeste", "ombro", "ordem", "orgao", "ósseo", "ossos", "outro",
                "ouvir", "palma", "pardo", "passe", "patio", "peito", "pelos", "perdo", "períl", "perto",
                "pezar", "piano", "picar", "pilar", "pingo", "pione", "pista", "poder", "porém", "prado",
                "prato", "prazo", "preço", "prima", "primo", "pular", "quero", "quota", "raiva", "rampa",
                "rango", "reais", "reino", "rezar", "risco", "roçar", "rosto", "roubo", "russo", "saber",
                "sacar", "salto", "samba", "santo", "selar", "selos", "senso", "serão", "serra", "servo",
                "sexta", "sinal", "sobra", "sobre", "socio", "sorte", "subir", "sujei", "sujos", "talao",
                "talha", "tanga", "tarde", "tempo", "tenho", "terço", "terra", "tesão", "tocar", "lacre",
                "laico", "lamba", "lambo", "largo", "larva", "lasca", "laser", "laura", "lavra", "leigo",
                "leite", "leito", "leiva", "lenho", "lento", "leque", "lerdo", "lesão", "lesma", "levar",
                "libra", "limbo", "lindo", "lineo", "lírio", "lisar", "lista", "livro", "logar", "lombo",
                "lotes", "louca", "louco", "louro", "lugar", "luzes", "macio", "maçom", "maior", "malha",
                "malte", "mamar", "mamãe", "manto", "março", "maria", "marra", "marta", "matar", "medir",
                "meigo", "meios", "melão", "menta", "menti", "mesmo", "metro", "miado", "mídia", "mielo",
                "mielo", "milho", "mimos", "minar", "minha", "miolo", "mirar", "missa", "mitos", "moeda",
                "moído", "moita", "molde", "molho", "monar", "monja", "moral", "morar", "morda", "morfo",
                "morte", "mosca", "mosco", "motim", "motor", "mudar", "muito", "mular", "mulas", "múmia",
                "mural", "extra", "falar", "falta", "fardo", "farol", "farto", "fatal", "feixe", "festa",
                "feudo", "fezes", "fiapo", "fibra", "ficha", "fidel", "filão", "filho", "firma", "fisco",
                "fisga", "fluir", "força", "forma", "forte", "fraco", "frade", "friso", "frito", "fugaz",
                "fugir", "fundo", "furor", "furto", "fuzil", "gabar", "gaita", "galho", "ganho", "garoa",
                "garra", "garro", "garvo", "gasto", "gaupe", "gazua", "geada", "gemer", "germe", "gigas",
                "girar", "gizar", "globo", "gosto", "grãos", "graça", "grava", "grito", "grude", "haver",
                "haver", "hiato", "hidra", "hífen", "hímel", "horas", "hotel", "humor", "ideal", "ídolo",
                "igual", "ileso", "imune", "irado", "isola", "jarra", "jaula", "jegue", "jeito", "jogar",
                "jovem", "juíza", "juizo", "julho", "junho", "jurar", "justa"
            };

            int i = new Random().Next(0, palavras.Length - 1);
            return palavras[i].ToUpper();
        }

    }
}
