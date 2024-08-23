using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x020003B0 RID: 944
	[global::Cpp2ILInjected.Token(Token = "0x200054F")]
	public class TileObjectSubTilesModule
	{
		// Token: 0x06002E93 RID: 11923 RVA: 0x0002A524 File Offset: 0x00028724
		[global::Cpp2ILInjected.Token(Token = "0x60032F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E6D0", Offset = "0x132E6D0", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "FullCopyFrom", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_SubTiles", MemberParameters = new object[] { typeof(List<TileObjectData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public TileObjectSubTilesModule(TileObjectSubTilesModule copyFrom = null, List<TileObjectData> newData = null)
		{
			throw null;
		}

		// Token: 0x04003261 RID: 12897
		[global::Cpp2ILInjected.Token(Token = "0x4003C00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<TileObjectData> data;
	}
}
