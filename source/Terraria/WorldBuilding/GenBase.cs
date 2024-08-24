using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000356 RID: 854
	[global::Cpp2ILInjected.Token(Token = "0x20004A5")]
	public class GenBase
	{
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002C2B RID: 11307 RVA: 0x00029EB5 File Offset: 0x000280B5
		[global::Cpp2ILInjected.Token(Token = "0x17000600")]
		protected static UnifiedRandom _random
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5BD0", Offset = "0x12F5BD0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 174)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002C2C RID: 11308 RVA: 0x00029EB8 File Offset: 0x000280B8
		[global::Cpp2ILInjected.Token(Token = "0x17000601")]
		protected static TileData _tiles
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5C20", Offset = "0x12F5C20", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x00029EBB File Offset: 0x000280BB
		[global::Cpp2ILInjected.Token(Token = "0x17000602")]
		protected static int _worldWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5C78", Offset = "0x12F5C78", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x00029EBE File Offset: 0x000280BE
		[global::Cpp2ILInjected.Token(Token = "0x17000603")]
		protected static int _worldHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F5CD0", Offset = "0x12F5CD0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00029EC1 File Offset: 0x000280C1
		[global::Cpp2ILInjected.Token(Token = "0x6002FC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3F38", Offset = "0x12F3F38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GenBase()
		{
			throw null;
		}

		// Token: 0x020008A2 RID: 2210
		// (Invoke) Token: 0x06004B4C RID: 19276
		[global::Cpp2ILInjected.Token(Token = "0x20004A6")]
		public delegate bool CustomPerUnitAction(int x, int y, params object[] args);
	}
}
