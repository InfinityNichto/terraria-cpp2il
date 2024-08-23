using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000091 RID: 145
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
	public class JsonMergeSettings
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00003362 File Offset: 0x00001562
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00003365 File Offset: 0x00001565
		[global::Cpp2ILInjected.Token(Token = "0x17000154")]
		public MergeArrayHandling MergeArrayHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D044E4", Offset = "0x1D044E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D044EC", Offset = "0x1D044EC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00003368 File Offset: 0x00001568
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x0000336B File Offset: 0x0000156B
		[global::Cpp2ILInjected.Token(Token = "0x17000155")]
		public MergeNullValueHandling MergeNullValueHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0454C", Offset = "0x1D0454C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04554", Offset = "0x1D04554", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000336E File Offset: 0x0000156E
		[global::Cpp2ILInjected.Token(Token = "0x60006EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D045B4", Offset = "0x1D045B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public JsonMergeSettings()
		{
			throw null;
		}

		// Token: 0x04000280 RID: 640
		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private MergeArrayHandling _mergeArrayHandling;

		// Token: 0x04000281 RID: 641
		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private MergeNullValueHandling _mergeNullValueHandling;
	}
}
