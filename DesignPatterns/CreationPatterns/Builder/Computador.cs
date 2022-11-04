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
      pc.Append($"** {ModeloComputador} **");
      if (!string.IsNullOrEmpty(Processador))
        pc.Append($"Processador: {Processador}");
      if (!string.IsNullOrEmpty(PlacaMae))
        pc.Append($"Placa Mãe: {PlacaMae}");
      if (!string.IsNullOrEmpty(MemoriaRam))
        pc.Append($"Memoria RAM: {MemoriaRam}");
      if (!string.IsNullOrEmpty(PlacaDeVideo))
        pc.Append($"Placa De Video: {PlacaDeVideo}");
      if (!string.IsNullOrEmpty(DiscoRigido))
        pc.Append($"Disco Rigido: {DiscoRigido}");
      if (!string.IsNullOrEmpty(SistemaOperacional))
        pc.Append($"Sistema Operacional: {SistemaOperacional}");
      if (!string.IsNullOrEmpty(Gabinete))
        pc.Append($"Gabinete: {Gabinete}");
      if (!string.IsNullOrEmpty(Fonte))
        pc.Append($"Fonte: {Fonte}");

      return pc.ToString();
    }
  }
}