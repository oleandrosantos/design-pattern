using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationPatterns.Builder
{
  public class Computador
  {
    public string PlacaMae { get; set; }
    public string Processador { get; set; }
    public string MemoriaRam { get; set; }
    public string Fonte { get; set; }
    public string DiscoRigido { get; set; }
    public string PlacaDeVideo { get; set; }
    public string Gabinete { get; set; }
    public string SistemaOperacional { get; set; }
    public string ModeloComputador { get; set; } = "Computador";

    public override string ToString()
    {
      StringBuilder pc = new StringBuilder();
      pc.AppendLine($"** {ModeloComputador} **");
      if (!string.IsNullOrEmpty(Processador))
        pc.AppendLine($"Processador: {Processador}");
      if (!string.IsNullOrEmpty(PlacaMae))
        pc.AppendLine($"Placa Mãe: {PlacaMae}");
      if (!string.IsNullOrEmpty(MemoriaRam))
        pc.AppendLine($"Memoria RAM: {MemoriaRam}");
      if (!string.IsNullOrEmpty(PlacaDeVideo))
        pc.AppendLine($"Placa De Video: {PlacaDeVideo}");
      if (!string.IsNullOrEmpty(DiscoRigido))
        pc.AppendLine($"Disco Rigido: {DiscoRigido}");
      if (!string.IsNullOrEmpty(SistemaOperacional))
        pc.AppendLine($"Sistema Operacional: {SistemaOperacional}");
      if (!string.IsNullOrEmpty(Gabinete))
        pc.AppendLine($"Gabinete: {Gabinete}");
      if (!string.IsNullOrEmpty(Fonte))
        pc.AppendLine($"Fonte: {Fonte}");

      return pc.ToString();
    }
  }
}