using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200001F RID: 31
	[Preserve]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002183 File Offset: 0x00000383
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002186 File Offset: 0x00000386
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public bool AllowNullItems
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000047")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB700C", Offset = "0x1CB700C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000048")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7014", Offset = "0x1CB7014", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002189 File Offset: 0x00000389
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB7020", Offset = "0x1CB7020", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public JsonArrayAttribute()
		{
			throw null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000218C File Offset: 0x0000038C
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB7028", Offset = "0x1CB7028", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public JsonArrayAttribute(bool allowNullItems)
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000218F File Offset: 0x0000038F
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB7050", Offset = "0x1CB7050", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public JsonArrayAttribute(string id)
		{
			throw null;
		}

		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private bool _allowNullItems;
	}
}
