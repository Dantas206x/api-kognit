using API.Repositories;
using API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace API.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
    }
}