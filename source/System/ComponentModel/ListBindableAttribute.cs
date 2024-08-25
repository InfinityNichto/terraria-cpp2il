using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000399")]
	public sealed class ListBindableAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F678", Offset = "0x1E4F678", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ListBindableAttribute(bool listBindable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F6A0", Offset = "0x1E4F6A0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ListBindableAttribute(BindableSupport flags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000573")]
		public bool ListBindable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4F6DC", Offset = "0x1E4F6DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F6E4", Offset = "0x1E4F6E4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F770", Offset = "0x1E4F770", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F778", Offset = "0x1E4F778", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60017F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F7FC", Offset = "0x1E4F7FC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ListBindableAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400123B")]
		public static readonly ListBindableAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x400123C")]
		public static readonly ListBindableAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x400123D")]
		public static readonly ListBindableAttribute Default;

		[global::Cpp2ILInjected.Token(Token = "0x400123E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _isDefault;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400123F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private readonly bool <ListBindable>k__BackingField;
	}
}
