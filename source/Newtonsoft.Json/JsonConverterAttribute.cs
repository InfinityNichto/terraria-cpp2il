using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000022")]
	public sealed class JsonConverterAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public Type ConverterType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000060")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB73C0", Offset = "0x1CB73C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public object[] ConverterParameters
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000061")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB73C8", Offset = "0x1CB73C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000062")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB73D0", Offset = "0x1CB73D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB73D8", Offset = "0x1CB73D8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConverterAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public JsonConverterAttribute(Type converterType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB744C", Offset = "0x1CB744C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverterAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		public JsonConverterAttribute(Type converterType, params object[] converterParameters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Type _converterType;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object[] <ConverterParameters>k__BackingField;
	}
}
