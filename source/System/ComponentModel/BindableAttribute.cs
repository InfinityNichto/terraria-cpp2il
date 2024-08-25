using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x200034F")]
	public sealed class BindableAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001606")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F8C0", Offset = "0x1E3F8C0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public BindableAttribute(bool bindable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001607")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F8EC", Offset = "0x1E3F8EC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public BindableAttribute(bool bindable, BindingDirection direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001608")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F91C", Offset = "0x1E3F91C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public BindableAttribute(BindableSupport flags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001609")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F95C", Offset = "0x1E3F95C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public BindableAttribute(BindableSupport flags, BindingDirection direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000502")]
		public bool Bindable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600160A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3F9A0", Offset = "0x1E3F9A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000503")]
		public BindingDirection Direction
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600160B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3F9A8", Offset = "0x1E3F9A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600160C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F9B0", Offset = "0x1E3F9B0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600160D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FA3C", Offset = "0x1E3FA3C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600160E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FA5C", Offset = "0x1E3FA5C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600160F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FAE0", Offset = "0x1E3FAE0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static BindableAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011BE")]
		public static readonly BindableAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x40011BF")]
		public static readonly BindableAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x40011C0")]
		public static readonly BindableAttribute Default;

		[global::Cpp2ILInjected.Token(Token = "0x40011C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _isDefault;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private readonly bool <Bindable>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly BindingDirection <Direction>k__BackingField;
	}
}
