using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x2000362")]
	public sealed class DataObjectFieldAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001699")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47994", Offset = "0x1E47994", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectFieldAttribute(bool primaryKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600169A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47A10", Offset = "0x1E47A10", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600169B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47A4C", Offset = "0x1E47A4C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600169C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E479C8", Offset = "0x1E479C8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000522")]
		public bool IsIdentity
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600169D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E47A94", Offset = "0x1E47A94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000523")]
		public bool IsNullable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600169E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E47A9C", Offset = "0x1E47A9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000524")]
		public int Length
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600169F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E47AA4", Offset = "0x1E47AA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000525")]
		public bool PrimaryKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E47AAC", Offset = "0x1E47AAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47AB4", Offset = "0x1E47AB4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47B94", Offset = "0x1E47B94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsIdentity>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private readonly bool <IsNullable>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly int <Length>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool <PrimaryKey>k__BackingField;
	}
}
