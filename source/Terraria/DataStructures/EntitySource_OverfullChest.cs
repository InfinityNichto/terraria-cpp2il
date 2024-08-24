using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000458 RID: 1112
	[global::Cpp2ILInjected.Token(Token = "0x2000654")]
	public class EntitySource_OverfullChest : AEntitySource_Tile
	{
		// Token: 0x060031D5 RID: 12757 RVA: 0x0002AEB1 File Offset: 0x000290B1
		[global::Cpp2ILInjected.Token(Token = "0x60036F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D510", Offset = "0x141D510", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "UseGasTrapInChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Chest),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public EntitySource_OverfullChest(int tileCoordsX, int tileCoordsY, Chest chest)
		{
			throw null;
		}

		// Token: 0x04006414 RID: 25620
		[global::Cpp2ILInjected.Token(Token = "0x4007804")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Chest Chest;
	}
}
