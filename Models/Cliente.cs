using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente : Pessoa
    {
            public int Id { get; set; }
            public string Nome { get; set; }
            public double RendaMensal { get; set; }
            public string DocumentoPdf { get; set; }

            //public static readonly string INSERT_SQL = "INSERT INTO Cliente (Documento, RendaMensal, DocumentoPDF, Nome, DataNascimento, EnderecoId, Telefone, Email) VALUES (@Documento, @Renda, @DocumentoPDF, @Nome, @DataNascimento, @EnderecoId, @Telefone, @Email); SELECT SCOPE_IDENTITY();";
    }
}