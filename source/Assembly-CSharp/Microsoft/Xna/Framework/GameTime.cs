using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000274 RID: 628
	[global::Cpp2ILInjected.Token(Token = "0x2000335")]
	public class GameTime
	{
		// Token: 0x06001339 RID: 4921 RVA: 0x00025478 File Offset: 0x00023678
		[global::Cpp2ILInjected.Token(Token = "0x6001496")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95EE8", Offset = "0xA95EE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameTime()
		{
			throw null;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0002547B File Offset: 0x0002367B
		[global::Cpp2ILInjected.Token(Token = "0x6001497")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94F80", Offset = "0xA94F80", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime)
		{
			throw null;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0002547E File Offset: 0x0002367E
		[global::Cpp2ILInjected.Token(Token = "0x6001498")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96018", Offset = "0xA96018", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly)
		{
			throw null;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x00025481 File Offset: 0x00023681
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x00025484 File Offset: 0x00023684
		[global::Cpp2ILInjected.Token(Token = "0x17000204")]
		public TimeSpan ElapsedGameTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001499")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96068", Offset = "0xA96068", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600149A")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96070", Offset = "0xA96070", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x00025487 File Offset: 0x00023687
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x0002548A File Offset: 0x0002368A
		[global::Cpp2ILInjected.Token(Token = "0x17000205")]
		public TimeSpan ElapsedRealTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600149B")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96078", Offset = "0xA96078", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600149C")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96080", Offset = "0xA96080", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x0002548D File Offset: 0x0002368D
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x00025490 File Offset: 0x00023690
		[global::Cpp2ILInjected.Token(Token = "0x17000206")]
		public bool IsRunningSlowly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600149D")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96088", Offset = "0xA96088", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600149E")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96090", Offset = "0xA96090", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x00025493 File Offset: 0x00023693
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x00025496 File Offset: 0x00023696
		[global::Cpp2ILInjected.Token(Token = "0x17000207")]
		public TimeSpan TotalGameTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600149F")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9609C", Offset = "0xA9609C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014A0")]
			[global::Cpp2ILInjected.Address(RVA = "0xA960A4", Offset = "0xA960A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x00025499 File Offset: 0x00023699
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x0002549C File Offset: 0x0002369C
		[global::Cpp2ILInjected.Token(Token = "0x17000208")]
		public TimeSpan TotalRealTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A1")]
			[global::Cpp2ILInjected.Address(RVA = "0xA960AC", Offset = "0xA960AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014A2")]
			[global::Cpp2ILInjected.Address(RVA = "0xA960B4", Offset = "0xA960B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x04001CD4 RID: 7380
		[global::Cpp2ILInjected.Token(Token = "0x40022AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TimeSpan elapsedGameTime;

		// Token: 0x04001CD5 RID: 7381
		[global::Cpp2ILInjected.Token(Token = "0x40022AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TimeSpan elapsedRealTime;

		// Token: 0x04001CD6 RID: 7382
		[global::Cpp2ILInjected.Token(Token = "0x40022B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool isRunningSlowly;

		// Token: 0x04001CD7 RID: 7383
		[global::Cpp2ILInjected.Token(Token = "0x40022B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private TimeSpan totalGameTime;

		// Token: 0x04001CD8 RID: 7384
		[global::Cpp2ILInjected.Token(Token = "0x40022B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private TimeSpan totalRealTime;
	}
}
