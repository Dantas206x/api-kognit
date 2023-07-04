using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class WalletModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal ValorAtual { get; set; }
        public string Banco { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}