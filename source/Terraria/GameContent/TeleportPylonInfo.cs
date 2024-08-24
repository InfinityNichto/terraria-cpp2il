using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x02000569 RID: 1385
	[global::Cpp2ILInjected.Token(Token = "0x20007F6")]
	public struct TeleportPylonInfo : IEquatable<TeleportPylonInfo>
	{
		// Token: 0x06003A90 RID: 14992 RVA: 0x0002C753 File Offset: 0x0002A953
		[global::Cpp2ILInjected.Token(Token = "0x6004188")]
		[global::Cpp2ILInjected.Address(RVA = "0x77ED1C", Offset = "0x77ED1C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.TeleportPylonsSystem.<>c__DisplayClass13_0", Member = "<RemoveForClient>b__0", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Point16),
			typeof(Point16)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(TeleportPylonInfo other)
		{
			throw null;
		}

		// Token: 0x04006959 RID: 26969
		[global::Cpp2ILInjected.Token(Token = "0x4007F0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Point16 PositionInTiles;

		// Token: 0x0400695A RID: 26970
		[global::Cpp2ILInjected.Token(Token = "0x4007F0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public TeleportPylonType TypeOfPylon;
	}
}
