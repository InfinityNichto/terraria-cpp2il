using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.Liquid;
using Terraria.GameContent.Shaders;
using Terraria.GameContent.Skies;
using Terraria.Graphics.Light;
using Terraria.Graphics.Shaders;
using Terraria.UI;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000271 RID: 625
	[global::Cpp2ILInjected.Token(Token = "0x2000332")]
	[Serializable]
	public struct Vector4 : IEquatable<Vector4>
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00025322 File Offset: 0x00023522
		[global::Cpp2ILInjected.Token(Token = "0x170001F8")]
		public static Vector4 Zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001424")]
			[global::Cpp2ILInjected.Address(RVA = "0xA92F2C", Offset = "0xA92F2C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00025325 File Offset: 0x00023525
		[global::Cpp2ILInjected.Token(Token = "0x170001F9")]
		public static Vector4 One
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001425")]
			[global::Cpp2ILInjected.Address(RVA = "0xA92F88", Offset = "0xA92F88", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00025328 File Offset: 0x00023528
		[global::Cpp2ILInjected.Token(Token = "0x170001FA")]
		public static Vector4 UnitX
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001426")]
			[global::Cpp2ILInjected.Address(RVA = "0xA92FE4", Offset = "0xA92FE4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x0002532B File Offset: 0x0002352B
		[global::Cpp2ILInjected.Token(Token = "0x170001FB")]
		public static Vector4 UnitY
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001427")]
			[global::Cpp2ILInjected.Address(RVA = "0xA93040", Offset = "0xA93040", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x0002532E File Offset: 0x0002352E
		[global::Cpp2ILInjected.Token(Token = "0x170001FC")]
		public static Vector4 UnitZ
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001428")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9309C", Offset = "0xA9309C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x00025331 File Offset: 0x00023531
		[global::Cpp2ILInjected.Token(Token = "0x170001FD")]
		public static Vector4 UnitW
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001429")]
			[global::Cpp2ILInjected.Address(RVA = "0xA930F8", Offset = "0xA930F8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00025334 File Offset: 0x00023534
		[global::Cpp2ILInjected.Token(Token = "0x600142A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93154", Offset = "0xA93154", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		public Vector4(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00025337 File Offset: 0x00023537
		[global::Cpp2ILInjected.Token(Token = "0x600142B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93160", Offset = "0xA93160", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NormalizedByte2), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rg32), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "WalkDownSlope", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "SlopeCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "IsClearSpotTest", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "FindCollisionTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(List<Point>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public Vector4(Vector2 value, float z, float w)
		{
			throw null;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0002533A File Offset: 0x0002353A
		[global::Cpp2ILInjected.Token(Token = "0x600142C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9316C", Offset = "0xA9316C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgr565), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Vector4(Vector3 value, float w)
		{
			throw null;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0002533D File Offset: 0x0002353D
		[global::Cpp2ILInjected.Token(Token = "0x600142D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93178", Offset = "0xA93178", Length = "0xC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public Vector4(float value)
		{
			throw null;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00025340 File Offset: 0x00023540
		[global::Cpp2ILInjected.Token(Token = "0x600142E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93184", Offset = "0xA93184", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 Add(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00025343 File Offset: 0x00023543
		[global::Cpp2ILInjected.Token(Token = "0x600142F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93198", Offset = "0xA93198", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00025346 File Offset: 0x00023546
		[global::Cpp2ILInjected.Token(Token = "0x6001430")]
		[global::Cpp2ILInjected.Address(RVA = "0xA931AC", Offset = "0xA931AC", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Barycentric", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)
		{
			throw null;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00025349 File Offset: 0x00023549
		[global::Cpp2ILInjected.Token(Token = "0x6001431")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93284", Offset = "0xA93284", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Barycentric", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0002534C File Offset: 0x0002354C
		[global::Cpp2ILInjected.Token(Token = "0x6001432")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93364", Offset = "0xA93364", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount)
		{
			throw null;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0002534F File Offset: 0x0002354F
		[global::Cpp2ILInjected.Token(Token = "0x6001433")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93438", Offset = "0xA93438", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float amount, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00025352 File Offset: 0x00023552
		[global::Cpp2ILInjected.Token(Token = "0x6001434")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93510", Offset = "0xA93510", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)
		{
			throw null;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00025355 File Offset: 0x00023555
		[global::Cpp2ILInjected.Token(Token = "0x6001435")]
		[global::Cpp2ILInjected.Address(RVA = "0xA935B8", Offset = "0xA935B8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Clamp(ref Vector4 value1, ref Vector4 min, ref Vector4 max, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00025358 File Offset: 0x00023558
		[global::Cpp2ILInjected.Token(Token = "0x6001436")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93664", Offset = "0xA93664", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Distance(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0002535B File Offset: 0x0002355B
		[global::Cpp2ILInjected.Token(Token = "0x6001437")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93720", Offset = "0xA93720", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Distance(ref Vector4 value1, ref Vector4 value2, out float result)
		{
			throw null;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0002535E File Offset: 0x0002355E
		[global::Cpp2ILInjected.Token(Token = "0x6001438")]
		[global::Cpp2ILInjected.Address(RVA = "0xA937E4", Offset = "0xA937E4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float DistanceSquared(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00025361 File Offset: 0x00023561
		[global::Cpp2ILInjected.Token(Token = "0x6001439")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93814", Offset = "0xA93814", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void DistanceSquared(ref Vector4 value1, ref Vector4 value2, out float result)
		{
			throw null;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00025364 File Offset: 0x00023564
		[global::Cpp2ILInjected.Token(Token = "0x600143A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93858", Offset = "0xA93858", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 Divide(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00025367 File Offset: 0x00023567
		[global::Cpp2ILInjected.Token(Token = "0x600143B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9386C", Offset = "0xA9386C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 Divide(Vector4 value1, float divider)
		{
			throw null;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0002536A File Offset: 0x0002356A
		[global::Cpp2ILInjected.Token(Token = "0x600143C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93888", Offset = "0xA93888", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector4 value1, float divider, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0002536D File Offset: 0x0002356D
		[global::Cpp2ILInjected.Token(Token = "0x600143D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA938A0", Offset = "0xA938A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00025370 File Offset: 0x00023570
		[global::Cpp2ILInjected.Token(Token = "0x600143E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA938B4", Offset = "0xA938B4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float Dot(Vector4 vector1, Vector4 vector2)
		{
			throw null;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00025373 File Offset: 0x00023573
		[global::Cpp2ILInjected.Token(Token = "0x600143F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA938D4", Offset = "0xA938D4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dot(ref Vector4 vector1, ref Vector4 vector2, out float result)
		{
			throw null;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00025376 File Offset: 0x00023576
		[global::Cpp2ILInjected.Token(Token = "0x6001440")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93908", Offset = "0xA93908", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00025379 File Offset: 0x00023579
		[global::Cpp2ILInjected.Token(Token = "0x6001441")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93A20", Offset = "0xA93A20", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Vector4 other)
		{
			throw null;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0002537C File Offset: 0x0002357C
		[global::Cpp2ILInjected.Token(Token = "0x6001442")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93A5C", Offset = "0xA93A5C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0002537F File Offset: 0x0002357F
		[global::Cpp2ILInjected.Token(Token = "0x6001443")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93A8C", Offset = "0xA93A8C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount)
		{
			throw null;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00025382 File Offset: 0x00023582
		[global::Cpp2ILInjected.Token(Token = "0x6001444")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93B6C", Offset = "0xA93B6C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2, float amount, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00025385 File Offset: 0x00023585
		[global::Cpp2ILInjected.Token(Token = "0x6001445")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93C2C", Offset = "0xA93C2C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float Length()
		{
			throw null;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00025388 File Offset: 0x00023588
		[global::Cpp2ILInjected.Token(Token = "0x6001446")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93CB4", Offset = "0xA93CB4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float LengthSquared()
		{
			throw null;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0002538B File Offset: 0x0002358B
		[global::Cpp2ILInjected.Token(Token = "0x6001447")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93CDC", Offset = "0xA93CDC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSimpleSurfaceBackground", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordSky), Member = "OnTileColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NebulaSky), Member = "OnTileColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SolarSky), Member = "OnTileColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardustSky), Member = "OnTileColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VortexSky), Member = "OnTileColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "GetShimmerBaseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
		{
			throw null;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0002538E File Offset: 0x0002358E
		[global::Cpp2ILInjected.Token(Token = "0x6001448")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93D8C", Offset = "0xA93D8C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Lerp(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00025391 File Offset: 0x00023591
		[global::Cpp2ILInjected.Token(Token = "0x6001449")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93E34", Offset = "0xA93E34", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector4 Max(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00025394 File Offset: 0x00023594
		[global::Cpp2ILInjected.Token(Token = "0x600144A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93ED0", Offset = "0xA93ED0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Max(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00025397 File Offset: 0x00023597
		[global::Cpp2ILInjected.Token(Token = "0x600144B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93F60", Offset = "0xA93F60", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector4 Min(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0002539A File Offset: 0x0002359A
		[global::Cpp2ILInjected.Token(Token = "0x600144C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA93FFC", Offset = "0xA93FFC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Min(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0002539D File Offset: 0x0002359D
		[global::Cpp2ILInjected.Token(Token = "0x600144D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9408C", Offset = "0xA9408C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 Multiply(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000253A0 File Offset: 0x000235A0
		[global::Cpp2ILInjected.Token(Token = "0x600144E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA940A0", Offset = "0xA940A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 Multiply(Vector4 value1, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000253A3 File Offset: 0x000235A3
		[global::Cpp2ILInjected.Token(Token = "0x600144F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA940B4", Offset = "0xA940B4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector4 value1, float scaleFactor, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x000253A6 File Offset: 0x000235A6
		[global::Cpp2ILInjected.Token(Token = "0x6001450")]
		[global::Cpp2ILInjected.Address(RVA = "0xA940C4", Offset = "0xA940C4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000253A9 File Offset: 0x000235A9
		[global::Cpp2ILInjected.Token(Token = "0x6001451")]
		[global::Cpp2ILInjected.Address(RVA = "0xA940D8", Offset = "0xA940D8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 Negate(Vector4 value)
		{
			throw null;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x000253AC File Offset: 0x000235AC
		[global::Cpp2ILInjected.Token(Token = "0x6001452")]
		[global::Cpp2ILInjected.Address(RVA = "0xA940EC", Offset = "0xA940EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Vector4 value, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000253AF File Offset: 0x000235AF
		[global::Cpp2ILInjected.Token(Token = "0x6001453")]
		[global::Cpp2ILInjected.Address(RVA = "0xA940FC", Offset = "0xA940FC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Normalize()
		{
			throw null;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000253B2 File Offset: 0x000235B2
		[global::Cpp2ILInjected.Token(Token = "0x6001454")]
		[global::Cpp2ILInjected.Address(RVA = "0xA941A4", Offset = "0xA941A4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector4 Normalize(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000253B5 File Offset: 0x000235B5
		[global::Cpp2ILInjected.Token(Token = "0x6001455")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94248", Offset = "0xA94248", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Normalize(ref Vector4 vector, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000253B8 File Offset: 0x000235B8
		[global::Cpp2ILInjected.Token(Token = "0x6001456")]
		[global::Cpp2ILInjected.Address(RVA = "0xA942FC", Offset = "0xA942FC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
		{
			throw null;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x000253BB File Offset: 0x000235BB
		[global::Cpp2ILInjected.Token(Token = "0x6001457")]
		[global::Cpp2ILInjected.Address(RVA = "0xA943AC", Offset = "0xA943AC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000253BE File Offset: 0x000235BE
		[global::Cpp2ILInjected.Token(Token = "0x6001458")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94454", Offset = "0xA94454", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 Subtract(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000253C1 File Offset: 0x000235C1
		[global::Cpp2ILInjected.Token(Token = "0x6001459")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94468", Offset = "0xA94468", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000253C4 File Offset: 0x000235C4
		[global::Cpp2ILInjected.Token(Token = "0x600145A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9447C", Offset = "0xA9447C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Matrix),
			typeof(ref Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector4 Transform(Vector2 position, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000253C7 File Offset: 0x000235C7
		[global::Cpp2ILInjected.Token(Token = "0x600145B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9451C", Offset = "0xA9451C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector4 Transform(Vector2 value, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x000253CA File Offset: 0x000235CA
		[global::Cpp2ILInjected.Token(Token = "0x600145C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94554", Offset = "0xA94554", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector4 Transform(Vector3 value, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000253CD File Offset: 0x000235CD
		[global::Cpp2ILInjected.Token(Token = "0x600145D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9458C", Offset = "0xA9458C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector4 Transform(Vector4 value, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000253D0 File Offset: 0x000235D0
		[global::Cpp2ILInjected.Token(Token = "0x600145E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA945C4", Offset = "0xA945C4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000253D3 File Offset: 0x000235D3
		[global::Cpp2ILInjected.Token(Token = "0x600145F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA945FC", Offset = "0xA945FC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000253D6 File Offset: 0x000235D6
		[global::Cpp2ILInjected.Token(Token = "0x6001460")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94634", Offset = "0xA94634", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000253D9 File Offset: 0x000235D9
		[global::Cpp2ILInjected.Token(Token = "0x6001461")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9466C", Offset = "0xA9466C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray)
		{
			throw null;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000253DC File Offset: 0x000235DC
		[global::Cpp2ILInjected.Token(Token = "0x6001462")]
		[global::Cpp2ILInjected.Address(RVA = "0xA946A4", Offset = "0xA946A4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector4[] sourceArray, ref Matrix matrix, Vector4[] destinationArray)
		{
			throw null;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000253DF File Offset: 0x000235DF
		[global::Cpp2ILInjected.Token(Token = "0x6001463")]
		[global::Cpp2ILInjected.Address(RVA = "0xA946DC", Offset = "0xA946DC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000253E2 File Offset: 0x000235E2
		[global::Cpp2ILInjected.Token(Token = "0x6001464")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94714", Offset = "0xA94714", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000253E5 File Offset: 0x000235E5
		[global::Cpp2ILInjected.Token(Token = "0x6001465")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9474C", Offset = "0xA9474C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Matrix),
			typeof(ref Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector4 Transform(Vector3 position, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x000253E8 File Offset: 0x000235E8
		[global::Cpp2ILInjected.Token(Token = "0x6001466")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94800", Offset = "0xA94800", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector4),
			typeof(ref Matrix),
			typeof(ref Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector4 Transform(Vector4 vector, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000253EB File Offset: 0x000235EB
		[global::Cpp2ILInjected.Token(Token = "0x6001467")]
		[global::Cpp2ILInjected.Address(RVA = "0xA944F4", Offset = "0xA944F4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector4), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Matrix)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000253EE File Offset: 0x000235EE
		[global::Cpp2ILInjected.Token(Token = "0x6001468")]
		[global::Cpp2ILInjected.Address(RVA = "0xA947C8", Offset = "0xA947C8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector4), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000253F1 File Offset: 0x000235F1
		[global::Cpp2ILInjected.Token(Token = "0x6001469")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94878", Offset = "0xA94878", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector4), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Matrix)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result)
		{
			throw null;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000253F4 File Offset: 0x000235F4
		[global::Cpp2ILInjected.Token(Token = "0x600146A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA948B4", Offset = "0xA948B4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra4444), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra5551), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector4), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba1010102), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba64), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000253F7 File Offset: 0x000235F7
		[global::Cpp2ILInjected.Token(Token = "0x600146B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94A24", Offset = "0xA94A24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 operator -(Vector4 value)
		{
			throw null;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000253FA File Offset: 0x000235FA
		[global::Cpp2ILInjected.Token(Token = "0x600146C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA939F0", Offset = "0xA939F0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000253FD File Offset: 0x000235FD
		[global::Cpp2ILInjected.Token(Token = "0x600146D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94A38", Offset = "0xA94A38", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "IsClearSpotTest", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static bool operator !=(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00025400 File Offset: 0x00023600
		[global::Cpp2ILInjected.Token(Token = "0x600146E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94A68", Offset = "0xA94A68", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static Vector4 operator +(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00025403 File Offset: 0x00023603
		[global::Cpp2ILInjected.Token(Token = "0x600146F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94A7C", Offset = "0xA94A7C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 operator -(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00025406 File Offset: 0x00023606
		[global::Cpp2ILInjected.Token(Token = "0x6001470")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94A90", Offset = "0xA94A90", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "DrawLabel", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(string),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "GetAlpha", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSimpleSurfaceBackground", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "oldDrawWater", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "GetColorByLoadout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderDataSet), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(short),
			typeof(Player),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyHairShaderData), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandstormSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		public static Vector4 operator *(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00025409 File Offset: 0x00023609
		[global::Cpp2ILInjected.Token(Token = "0x6001471")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94AA4", Offset = "0xA94AA4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandstormSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "GetShimmerGlitterColor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static Vector4 operator *(Vector4 value1, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0002540C File Offset: 0x0002360C
		[global::Cpp2ILInjected.Token(Token = "0x6001472")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94AB8", Offset = "0xA94AB8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 operator *(float scaleFactor, Vector4 value1)
		{
			throw null;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0002540F File Offset: 0x0002360F
		[global::Cpp2ILInjected.Token(Token = "0x6001473")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94AD4", Offset = "0xA94AD4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 operator /(Vector4 value1, Vector4 value2)
		{
			throw null;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00025412 File Offset: 0x00023612
		[global::Cpp2ILInjected.Token(Token = "0x6001474")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94AE8", Offset = "0xA94AE8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector4 operator /(Vector4 value1, float divider)
		{
			throw null;
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00025415 File Offset: 0x00023615
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001475")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94B04", Offset = "0xA94B04", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Vector4()
		{
			throw null;
		}

		// Token: 0x04001CAC RID: 7340
		[global::Cpp2ILInjected.Token(Token = "0x4002286")]
		private static Vector4 zeroVector;

		// Token: 0x04001CAD RID: 7341
		[global::Cpp2ILInjected.Token(Token = "0x4002287")]
		private static Vector4 unitVector;

		// Token: 0x04001CAE RID: 7342
		[global::Cpp2ILInjected.Token(Token = "0x4002288")]
		private static Vector4 unitXVector;

		// Token: 0x04001CAF RID: 7343
		[global::Cpp2ILInjected.Token(Token = "0x4002289")]
		private static Vector4 unitYVector;

		// Token: 0x04001CB0 RID: 7344
		[global::Cpp2ILInjected.Token(Token = "0x400228A")]
		private static Vector4 unitZVector;

		// Token: 0x04001CB1 RID: 7345
		[global::Cpp2ILInjected.Token(Token = "0x400228B")]
		private static Vector4 unitWVector;

		// Token: 0x04001CB2 RID: 7346
		[global::Cpp2ILInjected.Token(Token = "0x400228C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float X;

		// Token: 0x04001CB3 RID: 7347
		[global::Cpp2ILInjected.Token(Token = "0x400228D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float Y;

		// Token: 0x04001CB4 RID: 7348
		[global::Cpp2ILInjected.Token(Token = "0x400228E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float Z;

		// Token: 0x04001CB5 RID: 7349
		[global::Cpp2ILInjected.Token(Token = "0x400228F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float W;
	}
}
