using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x02000027 RID: 39
	[global::Cpp2ILInjected.Token(Token = "0x200002D")]
	public class ReadOptions
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000548E File Offset: 0x0000368E
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00005491 File Offset: 0x00003691
		[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
		public EventHandler<ReadProgressEventArgs> ReadProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E678", Offset = "0x1A5E678", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600021C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E680", Offset = "0x1A5E680", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00005494 File Offset: 0x00003694
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00005497 File Offset: 0x00003697
		[global::Cpp2ILInjected.Token(Token = "0x17000080")]
		public TextWriter StatusMessageWriter
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E688", Offset = "0x1A5E688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600021E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E690", Offset = "0x1A5E690", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000549A File Offset: 0x0000369A
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000549D File Offset: 0x0000369D
		[global::Cpp2ILInjected.Token(Token = "0x17000081")]
		public Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E698", Offset = "0x1A5E698", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000220")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E6A0", Offset = "0x1A5E6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000054A0 File Offset: 0x000036A0
		[global::Cpp2ILInjected.Token(Token = "0x6000221")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5E6A8", Offset = "0x1A5E6A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ReadOptions()
		{
			throw null;
		}

		// Token: 0x040000FB RID: 251
		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private EventHandler<ReadProgressEventArgs> <ReadProgress>k__BackingField;

		// Token: 0x040000FC RID: 252
		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TextWriter <StatusMessageWriter>k__BackingField;

		// Token: 0x040000FD RID: 253
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Encoding <Encoding>k__BackingField;
	}
}
