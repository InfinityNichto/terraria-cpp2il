using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020005E5 RID: 1509
	[global::Cpp2ILInjected.Token(Token = "0x20008D2")]
	public class ActionStalagtite : GenAction
	{
		// Token: 0x06003D25 RID: 15653 RVA: 0x0002CEAF File Offset: 0x0002B0AF
		[global::Cpp2ILInjected.Token(Token = "0x6004597")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC700", Offset = "0x7BC700", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x0002CEB2 File Offset: 0x0002B0B2
		[global::Cpp2ILInjected.Token(Token = "0x6004598")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC79C", Offset = "0x7BC79C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = "AgeRoom", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = ".ctor", ReturnType = typeof(void))]
		public ActionStalagtite()
		{
			throw null;
		}
	}
}
