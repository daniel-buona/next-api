using System;

namespace NextSI.Application.Dto.Models
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public char Excluido { get; set; }
        public DateTime? InsertHora { get; set; }
        public DateTime? UpdateHora { get; set; }
        public DateTime? DeleteHora { get; set; }
        public int? InsertUsuarioId { get; set; }
        public int? UpdateUsuarioId { get; set; }
        public int? DeleteUsuarioId { get; set; }

    }
}
