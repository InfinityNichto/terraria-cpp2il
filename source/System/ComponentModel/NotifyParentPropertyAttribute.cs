using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x2000401")]
	public sealed class NotifyParentPropertyAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001BDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A5C8", Offset = "0x1E8A5C8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NotifyParentPropertyAttribute(bool notifyParent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000638")]
		public bool NotifyParent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8A5F0", Offset = "0x1E8A5F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A5F8", Offset = "0x1E8A5F8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A678", Offset = "0x1E8A678", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A680", Offset = "0x1E8A680", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A6E8", Offset = "0x1E8A6E8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static NotifyParentPropertyAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001379")]
		public static readonly NotifyParentPropertyAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x400137A")]
		public static readonly NotifyParentPropertyAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x400137B")]
		public static readonly NotifyParentPropertyAttribute Default;

		[global::Cpp2ILInjected.Token(Token = "0x400137C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool notifyParent;
	}
}
