using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000023")]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000021DD File Offset: 0x000003DD
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000021E0 File Offset: 0x000003E0
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public MemberSerialization MemberSerialization
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000065")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7470", Offset = "0x1CB7470", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000066")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7478", Offset = "0x1CB7478", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000021E3 File Offset: 0x000003E3
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000021E6 File Offset: 0x000003E6
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public Required ItemRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000067")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7480", Offset = "0x1CB7480", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000068")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB74D0", Offset = "0x1CB74D0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000021E9 File Offset: 0x000003E9
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB7538", Offset = "0x1CB7538", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public JsonObjectAttribute()
		{
			throw null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000021EC File Offset: 0x000003EC
		[global::Cpp2ILInjected.Token(Token = "0x600006A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB7540", Offset = "0x1CB7540", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public JsonObjectAttribute(MemberSerialization memberSerialization)
		{
			throw null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000021EF File Offset: 0x000003EF
		[global::Cpp2ILInjected.Token(Token = "0x600006B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB7568", Offset = "0x1CB7568", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public JsonObjectAttribute(string id)
		{
			throw null;
		}

		// Token: 0x04000056 RID: 86
		[global::Cpp2ILInjected.Token(Token = "0x4000056")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private MemberSerialization _memberSerialization;

		// Token: 0x04000057 RID: 87
		[global::Cpp2ILInjected.Token(Token = "0x4000057")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal Required? _itemRequired;
	}
}
