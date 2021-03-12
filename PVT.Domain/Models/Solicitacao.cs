using System;
using System.Collections.Generic;
using System.Text;

namespace PVT.Domain.Models
{
    public class Solicitacao : Entity
    {
        public int ID_ALUNO { get; set; }
        public int ID_MODULO { get; set; }
        public StatusSolicitacao STATUS_SOLICITACAO { get; set; }
    }
}
