using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000378")]
	public sealed class ExtenderProvidedPropertyAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600174B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C170", Offset = "0x1E4C170", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ReflectPropertyDescriptor),
			typeof(Type),
			typeof(IExtenderProvider),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600174C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C670", Offset = "0x1E4C670", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ExtenderProvidedPropertyAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700054B")]
		public PropertyDescriptor ExtenderProperty
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600174D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C678", Offset = "0x1E4C678", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600174E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C680", Offset = "0x1E4C680", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700054C")]
		public IExtenderProvider Provider
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600174F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C688", Offset = "0x1E4C688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001750")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C690", Offset = "0x1E4C690", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700054D")]
		public Type ReceiverType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001751")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C698", Offset = "0x1E4C698", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001752")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C6A0", Offset = "0x1E4C6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001753")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C6A8", Offset = "0x1E4C6A8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001754")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C768", Offset = "0x1E4C768", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001755")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C770", Offset = "0x1E4C770", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001228")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private PropertyDescriptor <ExtenderProperty>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001229")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IExtenderProvider <Provider>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400122A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Type <ReceiverType>k__BackingField;
	}
}
