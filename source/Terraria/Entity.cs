using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Cinematics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.GameInput;
using Terraria.Graphics.Light;

namespace Terraria
{
	// Token: 0x02000328 RID: 808
	[global::Cpp2ILInjected.Token(Token = "0x200042C")]
	public abstract class Entity
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x00028BCB File Offset: 0x00026DCB
		[global::Cpp2ILInjected.Token(Token = "0x1700055D")]
		public virtual Vector2 VisualPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0184", Offset = "0x10D0184", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00028BCE File Offset: 0x00026DCE
		[global::Cpp2ILInjected.Token(Token = "0x60027E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D018C", Offset = "0x10D018C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_115_LadyBugs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_174_MultisegmentPet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public float AngleTo(Vector2 Destination)
		{
			throw null;
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00028BD1 File Offset: 0x00026DD1
		[global::Cpp2ILInjected.Token(Token = "0x60027EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0274", Offset = "0x10D0274", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "CastSuperCartLaser", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public float AngleFrom(Vector2 Source)
		{
			throw null;
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00028BD4 File Offset: 0x00026DD4
		[global::Cpp2ILInjected.Token(Token = "0x60027EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D030C", Offset = "0x10D030C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 168)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float Distance(Vector2 Other)
		{
			throw null;
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00028BD7 File Offset: 0x00026DD7
		[global::Cpp2ILInjected.Token(Token = "0x60027EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0398", Offset = "0x10D0398", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float DistanceSQ(Vector2 Other)
		{
			throw null;
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00028BDA File Offset: 0x00026DDA
		[global::Cpp2ILInjected.Token(Token = "0x60027ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0424", Offset = "0x10D0424", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 87)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Vector2 DirectionTo(Vector2 Destination)
		{
			throw null;
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00028BDD File Offset: 0x00026DDD
		[global::Cpp2ILInjected.Token(Token = "0x60027EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D04B8", Offset = "0x10D04B8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_065_Butterflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_120_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_114_Dragonflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_112_FairyCritter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_003_Fighters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_189_Volcano", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_009_MagicMissiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_015_Flails", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "GetClosestTarget", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Vector2 DirectionFrom(Vector2 Source)
		{
			throw null;
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00028BE0 File Offset: 0x00026DE0
		[global::Cpp2ILInjected.Token(Token = "0x60027EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D054C", Offset = "0x10D054C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool WithinRange(Vector2 Target, float MaxRange)
		{
			throw null;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x00028BE3 File Offset: 0x00026DE3
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x00028BE6 File Offset: 0x00026DE6
		[global::Cpp2ILInjected.Token(Token = "0x1700055E")]
		public Vector2 Center
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0224", Offset = "0x10D0224", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4788)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60027F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D05F4", Offset = "0x10D05F4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 111)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x00028BE9 File Offset: 0x00026DE9
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x00028BEC File Offset: 0x00026DEC
		[global::Cpp2ILInjected.Token(Token = "0x1700055F")]
		public Vector2 Left
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0650", Offset = "0x10D0650", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Yoraiz0rEye", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyEquipFunctional", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_026", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_144_DD2Pet", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60027F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D068C", Offset = "0x10D068C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x00028BEF File Offset: 0x00026DEF
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x00028BF2 File Offset: 0x00026DF2
		[global::Cpp2ILInjected.Token(Token = "0x17000560")]
		public Vector2 Right
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D06D4", Offset = "0x10D06D4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
			{
				typeof(int),
				typeof(double)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Yoraiz0rEye", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyEquipFunctional", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "JumpMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_026", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_144_DD2Pet", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "GetEntityEdgeTilesExtents", MemberParameters = new object[]
			{
				typeof(Entity),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "GetEntityEdgeTiles", MemberParameters = new object[]
			{
				typeof(List<Point>),
				typeof(Entity),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "DryadPortalFade", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60027F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D071C", Offset = "0x10D071C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x00028BF5 File Offset: 0x00026DF5
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x00028BF8 File Offset: 0x00026DF8
		[global::Cpp2ILInjected.Token(Token = "0x17000561")]
		public Vector2 Top
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0770", Offset = "0x10D0770", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 103)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60027F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D07AC", Offset = "0x10D07AC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_155_MysticSnakeCoil", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x00028BFB File Offset: 0x00026DFB
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x00028BFE File Offset: 0x00026DFE
		[global::Cpp2ILInjected.Token(Token = "0x17000562")]
		public Vector2 TopLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D07F4", Offset = "0x10D07F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60027F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D07FC", Offset = "0x10D07FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x00028C01 File Offset: 0x00026E01
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x00028C04 File Offset: 0x00026E04
		[global::Cpp2ILInjected.Token(Token = "0x17000563")]
		public Vector2 TopRight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0804", Offset = "0x10D0804", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60027FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0834", Offset = "0x10D0834", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x00028C07 File Offset: 0x00026E07
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x00028C0A File Offset: 0x00026E0A
		[global::Cpp2ILInjected.Token(Token = "0x17000564")]
		public Vector2 Bottom
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0870", Offset = "0x10D0870", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 290)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60027FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D08B8", Offset = "0x10D08B8", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(NPC),
				typeof(bool),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(NPC),
				typeof(bool),
				typeof(Vector2),
				typeof(LightMap),
				typeof(ref Rectangle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_124_DeerclopsLeg", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_121_QueenSlime", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TryForcingSitting", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PetAnimal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSittingHelper), Member = "SitDown", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSleepingHelper), Member = "StartSleeping", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockableNPCEntryIcon), Member = "UpdatePosition", MemberParameters = new object[] { typeof(EntryIconDrawSettings) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x00028C0D File Offset: 0x00026E0D
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x00028C10 File Offset: 0x00026E10
		[global::Cpp2ILInjected.Token(Token = "0x17000565")]
		public Vector2 BottomLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D090C", Offset = "0x10D090C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CheckCrackedBrickBreak", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateFrame", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60027FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D093C", Offset = "0x10D093C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "ControlPlayer", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x00028C13 File Offset: 0x00026E13
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x00028C16 File Offset: 0x00026E16
		[global::Cpp2ILInjected.Token(Token = "0x17000566")]
		public Vector2 BottomRight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002800")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0978", Offset = "0x10D0978", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UseQuickMineCartSnapHook", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickMinecartSnap", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CheckCrackedBrickBreak", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InInteractionRange", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(TileReachCheckSettings)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "IsTileTypeInInteractionRange", MemberParameters = new object[]
			{
				typeof(int),
				typeof(TileReachCheckSettings)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_015_HandleMovementCollision", MemberParameters = new object[]
			{
				typeof(ref Vector2),
				typeof(ref Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "CreateGroundExplosion", MemberParameters = new object[]
			{
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_135_OgreStomp", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_141_MonkStaffT1Explosion", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "UpdatePlayerPosition", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WindGrid), Member = "ScanPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "FindArenaHitbox", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002801")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D09B0", Offset = "0x10D09B0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x00028C19 File Offset: 0x00026E19
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x00028C1C File Offset: 0x00026E1C
		[global::Cpp2ILInjected.Token(Token = "0x17000567")]
		public Vector2 Size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002802")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D09F4", Offset = "0x10D09F4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 109)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002803")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0A20", Offset = "0x10D0A20", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_113_WindyBalloon", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_135_OgreStomp", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_137_LightningAura", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x00028C1F File Offset: 0x00026E1F
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x00028C22 File Offset: 0x00026E22
		[global::Cpp2ILInjected.Token(Token = "0x17000568")]
		public Rectangle Hitbox
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002804")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0A4C", Offset = "0x10D0A4C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 156)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002805")]
			[global::Cpp2ILInjected.Address(RVA = "0x10D0AA0", Offset = "0x10D0AA0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00028C25 File Offset: 0x00026E25
		[global::Cpp2ILInjected.Token(Token = "0x6002806")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0AE8", Offset = "0x10D0AE8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Golf.FancyGolfPredictionLine.PredictionEntity", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Entity()
		{
			throw null;
		}

		// Token: 0x04002CC0 RID: 11456
		[global::Cpp2ILInjected.Token(Token = "0x40033E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int whoAmI;

		// Token: 0x04002CC1 RID: 11457
		[global::Cpp2ILInjected.Token(Token = "0x40033E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public bool active;

		// Token: 0x04002CC2 RID: 11458
		[global::Cpp2ILInjected.Token(Token = "0x40033E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal long entityId;

		// Token: 0x04002CC3 RID: 11459
		[global::Cpp2ILInjected.Token(Token = "0x40033E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Vector2 position;

		// Token: 0x04002CC4 RID: 11460
		[global::Cpp2ILInjected.Token(Token = "0x40033E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Vector2 velocity;

		// Token: 0x04002CC5 RID: 11461
		[global::Cpp2ILInjected.Token(Token = "0x40033E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Vector2 oldPosition;

		// Token: 0x04002CC6 RID: 11462
		[global::Cpp2ILInjected.Token(Token = "0x40033E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Vector2 oldVelocity;

		// Token: 0x04002CC7 RID: 11463
		[global::Cpp2ILInjected.Token(Token = "0x40033E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int oldDirection;

		// Token: 0x04002CC8 RID: 11464
		[global::Cpp2ILInjected.Token(Token = "0x40033E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int direction;

		// Token: 0x04002CC9 RID: 11465
		[global::Cpp2ILInjected.Token(Token = "0x40033EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int width;

		// Token: 0x04002CCA RID: 11466
		[global::Cpp2ILInjected.Token(Token = "0x40033EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public int height;

		// Token: 0x04002CCB RID: 11467
		[global::Cpp2ILInjected.Token(Token = "0x40033EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public bool wet;

		// Token: 0x04002CCC RID: 11468
		[global::Cpp2ILInjected.Token(Token = "0x40033ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		public bool shimmerWet;

		// Token: 0x04002CCD RID: 11469
		[global::Cpp2ILInjected.Token(Token = "0x40033EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x52")]
		public bool honeyWet;

		// Token: 0x04002CCE RID: 11470
		[global::Cpp2ILInjected.Token(Token = "0x40033EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x53")]
		public byte wetCount;

		// Token: 0x04002CCF RID: 11471
		[global::Cpp2ILInjected.Token(Token = "0x40033F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public bool lavaWet;
	}
}
