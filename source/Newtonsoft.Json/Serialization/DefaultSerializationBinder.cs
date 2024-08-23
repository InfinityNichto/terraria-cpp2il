using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000072 RID: 114
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000093")]
	public class DefaultSerializationBinder : SerializationBinder
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00002EB2 File Offset: 0x000010B2
		[global::Cpp2ILInjected.Token(Token = "0x6000524")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEBC4C", Offset = "0x1CEBC4C", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey)
		{
			throw null;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002EB5 File Offset: 0x000010B5
		[global::Cpp2ILInjected.Token(Token = "0x6000525")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEBE50", Offset = "0x1CEBE50", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, object>), Member = "Get", MemberParameters = new object[] { typeof(DefaultSerializationBinder.TypeNameKey) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Type BindToType(string assemblyName, string typeName)
		{
			throw null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002EB8 File Offset: 0x000010B8
		[global::Cpp2ILInjected.Token(Token = "0x6000526")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEBEB8", Offset = "0x1CEBEB8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultSerializationBinder), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<DefaultSerializationBinder.TypeNameKey, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, object>), Member = ".ctor", MemberParameters = new object[] { typeof(Func<DefaultSerializationBinder.TypeNameKey, object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationBinder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public DefaultSerializationBinder()
		{
			throw null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002EBB File Offset: 0x000010BB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000527")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEBF84", Offset = "0x1CEBF84", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultSerializationBinder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static DefaultSerializationBinder()
		{
			throw null;
		}

		// Token: 0x040001EC RID: 492
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		internal static readonly DefaultSerializationBinder Instance;

		// Token: 0x040001ED RID: 493
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache;

		// Token: 0x02000112 RID: 274
		[global::Cpp2ILInjected.Token(Token = "0x2000094")]
		internal struct TypeNameKey
		{
			// Token: 0x06000ADD RID: 2781 RVA: 0x00004013 File Offset: 0x00002213
			[global::Cpp2ILInjected.Token(Token = "0x6000528")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEBEB0", Offset = "0x1CEBEB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TypeNameKey(string assemblyName, string typeName)
			{
				throw null;
			}

			// Token: 0x06000ADE RID: 2782 RVA: 0x00004016 File Offset: 0x00002216
			[global::Cpp2ILInjected.Token(Token = "0x6000529")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEBFDC", Offset = "0x1CEBFDC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x06000ADF RID: 2783 RVA: 0x00004019 File Offset: 0x00002219
			[global::Cpp2ILInjected.Token(Token = "0x600052A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC02C", Offset = "0x1CEC02C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			// Token: 0x06000AE0 RID: 2784 RVA: 0x0000401C File Offset: 0x0000221C
			[global::Cpp2ILInjected.Token(Token = "0x600052B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC0A4", Offset = "0x1CEC0A4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			public bool Equals(DefaultSerializationBinder.TypeNameKey other)
			{
				throw null;
			}

			// Token: 0x040003BB RID: 955
			[global::Cpp2ILInjected.Token(Token = "0x4000249")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal readonly string AssemblyName;

			// Token: 0x040003BC RID: 956
			[global::Cpp2ILInjected.Token(Token = "0x400024A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal readonly string TypeName;
		}
	}
}
