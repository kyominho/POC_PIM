﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    class Usuario
    {
        int codCliente;
        string nomeUsuario;
        int nivelAcesso;
        string login;
        string senha;


        public int CodCliente { get => codCliente; set => codCliente = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public int NivelAcesso { get => nivelAcesso; set => nivelAcesso = value; }
        public string Login { get => login; set => login = value; }
        public string  Senha { get => senha; set => senha = value; }


    }
}