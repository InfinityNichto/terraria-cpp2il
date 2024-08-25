using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	[global::Cpp2ILInjected.Token(Token = "0x200036B")]
	public sealed class InheritanceAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49100", Offset = "0x1E49100", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InheritanceAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49170", Offset = "0x1E49170", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InheritanceAttribute(InheritanceLevel inheritanceLevel)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700052E")]
		public InheritanceLevel InheritanceLevel
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E49198", Offset = "0x1E49198", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E491A0", Offset = "0x1E491A0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49220", Offset = "0x1E49220", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49228", Offset = "0x1E49228", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49290", Offset = "0x1E49290", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string ToString()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49380", Offset = "0x1E49380", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static InheritanceAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011FF")]
		public static readonly InheritanceAttribute Inherited;

		[global::Cpp2ILInjected.Token(Token = "0x4001200")]
		public static readonly InheritanceAttribute InheritedReadOnly;

		[global::Cpp2ILInjected.Token(Token = "0x4001201")]
		public static readonly InheritanceAttribute NotInherited;

		[global::Cpp2ILInjected.Token(Token = "0x4001202")]
		public static readonly InheritanceAttribute Default;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001203")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly InheritanceLevel <InheritanceLevel>k__BackingField;
	}
}
