using GS2Engine.Enums;

namespace GS2Engine.Models
{
	public interface IStackEntry
	{
		public StackEntryType Type { get; }
		public object?        GetValue();
		public T?             GetValue<T>();
		void                  SetValue(object? getValue);
	}
}