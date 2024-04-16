using System;
using System.Collections.Generic;

namespace ScreenSound.Desafios.EmpresaTech;

internal class Gerente : Funcionario
{
    public List<string> AreasResponsaveis { get; }
    public string NivelHierarquico { get; }

    public Gerente(string nome, string setor, List<string> areasResponsaveis, string nivelHierarquico)
    {
        Nome = nome;
        Setor = setor;
        AreasResponsaveis = areasResponsaveis;
        NivelHierarquico = nivelHierarquico;
    }

    public void DescricaoGerente()
    {
        Console.WriteLine($"O Gerente {Nome} do setor {Setor}");
        Console.WriteLine("É responsável pelas seguintes áreas:");
        foreach (var area in AreasResponsaveis)
        {
            Console.WriteLine("- " + area);
        }
        Console.WriteLine($"Está no nível hierárquico {NivelHierarquico}");
    }
}
