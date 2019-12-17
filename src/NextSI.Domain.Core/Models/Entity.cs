using System;

namespace NextSI.Domain.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public char Excluido { get; set; }
        public DateTime? InsertHora { get; set; }
        public DateTime? UpdateHora { get; set; }
        public DateTime? DeleteHora { get; set; }
        public int? InsertUsuarioId { get; set; }
        public int? UpdateUsuarioId { get; set; }
        public int? DeleteUsuarioId { get; set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as BaseEntity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(BaseEntity a, BaseEntity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity a, BaseEntity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }
}