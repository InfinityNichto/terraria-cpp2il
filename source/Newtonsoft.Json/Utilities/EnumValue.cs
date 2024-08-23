using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000053 RID: 83
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000068")]
	internal class EnumValue<T> where T : struct
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00002AF5 File Offset: 0x00000CF5
		[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x164228C", Offset = "0x164228C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002AF8 File Offset: 0x00000CF8
		[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
		public T Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1642294", Offset = "0x1642294", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002AFB File Offset: 0x00000CFB
		[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x164229C", Offset = "0x164229C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EnumValue(string name, T value)
		{
			throw null;
		}

		// Token: 0x040001B6 RID: 438
		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _name;

		// Token: 0x040001B7 RID: 439
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T _value;
	}
}
