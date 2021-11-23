using System;

namespace BlazorAnimation
{
	public class CssClass : IEquatable<CssClass>
	{
		public string Name { get; }

		public CssClass(string name)
		{
			Name = name;
		}

		public bool Equals(CssClass other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Name == other.Name;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((CssClass) obj);
		}

		public override int GetHashCode()
		{
			return (Name != null ? Name.GetHashCode() : 0);
		}

		public static bool operator ==(CssClass left, CssClass right) {
			if (left is null)
				return right is null;
			return left.Equals(right);
		}

		public static bool operator !=(CssClass left, CssClass right) => !(left == right);
	}
}