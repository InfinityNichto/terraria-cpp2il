using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007F6")]
	public struct TeleportPylonInfo : IEquatable<TeleportPylonInfo>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4007F0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Point16 PositionInTiles;

		[global::Cpp2ILInjected.Token(Token = "0x4007F0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public TeleportPylonType TypeOfPylon;
	}
}
