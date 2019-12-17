using NextSI.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class CalendarioTrabalho: BaseEntity
    {
        public CalendarioTrabalho()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public string Nome { get; set; }
        public TimeSpan? DomManhaInicio { get; set; }
        public TimeSpan? DomManhaFim { get; set; }
        public TimeSpan? DomTardeInicio { get; set; }
        public TimeSpan? DomTardeFim { get; set; }
        public TimeSpan? SegManhaInicio { get; set; }
        public TimeSpan? SegManhaFim { get; set; }
        public TimeSpan? SegTardeInicio { get; set; }
        public TimeSpan? SegTardeFim { get; set; }
        public TimeSpan? TerManhaInicio { get; set; }
        public TimeSpan? TerManhaFim { get; set; }
        public TimeSpan? TerTardeInicio { get; set; }
        public TimeSpan? TerTardeFim { get; set; }
        public TimeSpan? QuaManhaInicio { get; set; }
        public TimeSpan? QuaManhaFim { get; set; }
        public TimeSpan? QuaTardeInicio { get; set; }
        public TimeSpan? QuaTardeFim { get; set; }
        public TimeSpan? QuiManhaInicio { get; set; }
        public TimeSpan? QuiManhaFim { get; set; }
        public TimeSpan? QuiTardeInicio { get; set; }
        public TimeSpan? QuiTardeFim { get; set; }
        public TimeSpan? SexManhaInicio { get; set; }
        public TimeSpan? SexManhaFim { get; set; }
        public TimeSpan? SexTardeInicio { get; set; }
        public TimeSpan? SexTardeFim { get; set; }
        public TimeSpan? SabManhaInicio { get; set; }
        public TimeSpan? SabManhaFim { get; set; }
        public TimeSpan? SabTardeInicio { get; set; }
        public TimeSpan? SabTardeFim { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
