using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000090 RID: 144
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
	public class JsonLoadSettings
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00003353 File Offset: 0x00001553
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00003356 File Offset: 0x00001556
		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public CommentHandling CommentHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0440C", Offset = "0x1D0440C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04414", Offset = "0x1D04414", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00003359 File Offset: 0x00001559
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x0000335C File Offset: 0x0000155C
		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public LineInfoHandling LineInfoHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04474", Offset = "0x1D04474", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0447C", Offset = "0x1D0447C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0000335F File Offset: 0x0000155F
		[global::Cpp2ILInjected.Token(Token = "0x60006E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D044DC", Offset = "0x1D044DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public JsonLoadSettings()
		{
			throw null;
		}

		// Token: 0x0400027E RID: 638
		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CommentHandling _commentHandling;

		// Token: 0x0400027F RID: 639
		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private LineInfoHandling _lineInfoHandling;
	}
}
