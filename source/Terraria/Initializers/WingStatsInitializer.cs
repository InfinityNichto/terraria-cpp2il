using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.Initializers
{
	// Token: 0x020003DA RID: 986
	[global::Cpp2ILInjected.Token(Token = "0x2000590")]
	public class WingStatsInitializer
	{
		// Token: 0x06003031 RID: 12337 RVA: 0x0002A9DD File Offset: 0x00028BDD
		[global::Cpp2ILInjected.Token(Token = "0x60034C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1380CA4", Offset = "0x1380CA4", Length = "0x9D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WingStats), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Load()
		{
			throw null;
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x0002A9E0 File Offset: 0x00028BE0
		[global::Cpp2ILInjected.Token(Token = "0x60034C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1381678", Offset = "0x1381678", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WingStatsInitializer()
		{
			throw null;
		}
	}
}
