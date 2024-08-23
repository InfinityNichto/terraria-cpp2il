using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000022 RID: 34
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000022")]
	public sealed class JsonConverterAttribute : Attribute
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000021CE File Offset: 0x000003CE
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

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000021D1 File Offset: 0x000003D1
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000021D4 File Offset: 0x000003D4
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

		// Token: 0x06000063 RID: 99 RVA: 0x000021D7 File Offset: 0x000003D7
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

		// Token: 0x06000064 RID: 100 RVA: 0x000021DA File Offset: 0x000003DA
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB744C", Offset = "0x1CB744C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverterAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		public JsonConverterAttribute(Type converterType, params object[] converterParameters)
		{
			throw null;
		}

		// Token: 0x04000054 RID: 84
		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Type _converterType;

		// Token: 0x04000055 RID: 85
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object[] <ConverterParameters>k__BackingField;
	}
}
