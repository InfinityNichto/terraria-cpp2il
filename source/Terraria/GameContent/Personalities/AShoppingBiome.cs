using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000593 RID: 1427
	[global::Cpp2ILInjected.Token(Token = "0x2000831")]
	public abstract class AShoppingBiome
	{
		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06003BCD RID: 15309 RVA: 0x0002CAFE File Offset: 0x0002ACFE
		// (set) Token: 0x06003BCE RID: 15310 RVA: 0x0002CB01 File Offset: 0x0002AD01
		[global::Cpp2ILInjected.Token(Token = "0x170007C5")]
		public string NameKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60042F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x79D238", Offset = "0x79D238", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60042F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x79D240", Offset = "0x79D240", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06003BCF RID: 15311
		[global::Cpp2ILInjected.Token(Token = "0x60042F2")]
		public abstract bool IsInBiome(Player player);

		// Token: 0x06003BD0 RID: 15312 RVA: 0x0002CB04 File Offset: 0x0002AD04
		[global::Cpp2ILInjected.Token(Token = "0x60042F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D248", Offset = "0x79D248", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AShoppingBiome()
		{
			throw null;
		}

		// Token: 0x04006B37 RID: 27447
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008134")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <NameKey>k__BackingField;
	}
}
