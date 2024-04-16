// DESAFIO EMPRESA TECH
//Crie uma hierarquia de classes representando funcionários de uma empresa.
//Utilize herança para criar classes como Gerente, Programador e Analista.
//Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.

using ScreenSound.Desafios.EmpresaTech;

List<string> linguagensGui = new()
{
   "JAVA",
   "C#"
};
List<string> frameworksAna = new()
{
    "React",
    "Vue",
};
Programador gui = new("Guilherme", linguagensGui, null, "Junior");
gui.DescricaoTecnicaProgramador();

Programador ana = new("Ana", linguagensGui, frameworksAna, "Senior");
ana.DescricaoTecnicaProgramador();

List<string> certificacoesCamila = new()
{
    "Plus Scrum Cuba",
    "Oscar Scrum Master",
};
ScrumMaster camila = new("Camila", certificacoesCamila, "Foco no Desempenho da Equipe");
camila.DescricaoScrumMaster();
Console.WriteLine();

List<string> areasResponsaveisAnderson = new()
{
    "TI",
    "RH",
    "Segurança"
};
Gerente marcos = new("Marcos", "Financeiro e Resseguros", areasResponsaveisAnderson, "Executivo");
marcos.DescricaoGerente();