using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000016 RID: 22
	[Preserve]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	public class JsonExtensionDataAttribute : Attribute
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000215C File Offset: 0x0000035C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000215F File Offset: 0x0000035F
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public bool WriteData
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000037")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB6A24", Offset = "0x1CB6A24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000038")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB6A2C", Offset = "0x1CB6A2C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002162 File Offset: 0x00000362
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002165 File Offset: 0x00000365
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public bool ReadData
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000039")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB6A38", Offset = "0x1CB6A38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB6A40", Offset = "0x1CB6A40", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002168 File Offset: 0x00000368
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB6A4C", Offset = "0x1CB6A4C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public JsonExtensionDataAttribute()
		{
			throw null;
		}

		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <WriteData>k__BackingField;

		// Token: 0x04000028 RID: 40
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool <ReadData>k__BackingField;
	}
}
