using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework.Input;
using ReLogic.Utilities;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Events;
using Terraria.GameContent.Golf;
using Terraria.GameContent.ObjectInteractions;
using Terraria.GameContent.Shaders;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Renderers;
using Terraria.Physics;
using Terraria.UI;
using Terraria.Utilities;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200026F RID: 623
	[global::Cpp2ILInjected.Token(Token = "0x2000330")]
	[Serializable]
	public struct Vector2 : IEquatable<Vector2>
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00025139 File Offset: 0x00023339
		[global::Cpp2ILInjected.Token(Token = "0x170001E9")]
		public static Vector2 Zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001381")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8FEEC", Offset = "0xA8FEEC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0002513C File Offset: 0x0002333C
		[global::Cpp2ILInjected.Token(Token = "0x170001EA")]
		public static Vector2 One
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001382")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8FF44", Offset = "0xA8FF44", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x0002513F File Offset: 0x0002333F
		[global::Cpp2ILInjected.Token(Token = "0x170001EB")]
		public static Vector2 UnitX
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001383")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8FF9C", Offset = "0xA8FF9C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00025142 File Offset: 0x00023342
		[global::Cpp2ILInjected.Token(Token = "0x170001EC")]
		public static Vector2 UnitY
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001384")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8FFF4", Offset = "0xA8FFF4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00025145 File Offset: 0x00023345
		[global::Cpp2ILInjected.Token(Token = "0x6001385")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9004C", Offset = "0xA9004C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7343)]
		public Vector2(float x, float y)
		{
			throw null;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00025148 File Offset: 0x00023348
		[global::Cpp2ILInjected.Token(Token = "0x6001386")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90054", Offset = "0xA90054", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 233)]
		public Vector2(float value)
		{
			throw null;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0002514B File Offset: 0x0002334B
		[global::Cpp2ILInjected.Token(Token = "0x6001387")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9005C", Offset = "0xA9005C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2), Member = "Reflect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Reflect(ref Vector2 vector, ref Vector2 normal, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0002514E File Offset: 0x0002334E
		[global::Cpp2ILInjected.Token(Token = "0x6001388")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90114", Offset = "0xA90114", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "LightDisc_Bounce", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "Step", MemberParameters = new object[]
		{
			typeof(PhysicsProperties),
			typeof(Entity),
			typeof(ref float),
			typeof(IBallContactListener)
		}, ReturnType = typeof(BallStepResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Reflect", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 Reflect(Vector2 vector, Vector2 normal)
		{
			throw null;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00025151 File Offset: 0x00023351
		[global::Cpp2ILInjected.Token(Token = "0x6001389")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90188", Offset = "0xA90188", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2 Add(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00025154 File Offset: 0x00023354
		[global::Cpp2ILInjected.Token(Token = "0x600138A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90194", Offset = "0xA90194", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00025157 File Offset: 0x00023357
		[global::Cpp2ILInjected.Token(Token = "0x600138B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA901A8", Offset = "0xA901A8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Barycentric", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2)
		{
			throw null;
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0002515A File Offset: 0x0002335A
		[global::Cpp2ILInjected.Token(Token = "0x600138C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90220", Offset = "0xA90220", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Barycentric", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Barycentric(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, float amount1, float amount2, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0002515D File Offset: 0x0002335D
		[global::Cpp2ILInjected.Token(Token = "0x600138D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA902AC", Offset = "0xA902AC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_167_SparkleGuitar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_162_TigerPounce", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(ref Vector2Array_10),
			typeof(ref FloatArray_10),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(float[]),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector2 CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount)
		{
			throw null;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00025160 File Offset: 0x00023360
		[global::Cpp2ILInjected.Token(Token = "0x600138E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90324", Offset = "0xA90324", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void CatmullRom(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, ref Vector2 value4, float amount, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00025163 File Offset: 0x00023363
		[global::Cpp2ILInjected.Token(Token = "0x600138F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA903A8", Offset = "0xA903A8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_GolfBallIndicator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClampScreenPositionToWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeEdgeSelection", Member = "DrawCursors", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "ChasePlayerTop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
		{
			throw null;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00025166 File Offset: 0x00023366
		[global::Cpp2ILInjected.Token(Token = "0x6001390")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90400", Offset = "0xA90400", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Clamp(ref Vector2 value1, ref Vector2 min, ref Vector2 max, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00025169 File Offset: 0x00023369
		[global::Cpp2ILInjected.Token(Token = "0x6001391")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90468", Offset = "0xA90468", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 197)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Distance(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0002516C File Offset: 0x0002336C
		[global::Cpp2ILInjected.Token(Token = "0x6001392")]
		[global::Cpp2ILInjected.Address(RVA = "0xA904EC", Offset = "0xA904EC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Distance(ref Vector2 value1, ref Vector2 value2, out float result)
		{
			throw null;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0002516F File Offset: 0x0002336F
		[global::Cpp2ILInjected.Token(Token = "0x6001393")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90580", Offset = "0xA90580", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "FindClosestPlayer", MemberParameters = new object[] { typeof(ref float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Entity), Member = "DistanceSQ", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Entity), Member = "WithinRange", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DistanceSQ", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "WithinRange", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCUtils), Member = "SearchForTarget", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(Vector2),
			typeof(NPCUtils.TargetSearchFlag),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(NPCUtils.TargetSearchResults))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "GetCollisionPointForTile", MemberParameters = new object[]
		{
			"Terraria.Physics.BallCollision.TileEdges",
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(ref Vector2),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Play", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "PlayLooped", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2),
			typeof(ActiveSound.LoopedPlayCondition)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "CanRaiseGoblinsHere", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "RaiseGoblins", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		public static float DistanceSquared(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00025172 File Offset: 0x00023372
		[global::Cpp2ILInjected.Token(Token = "0x6001394")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90598", Offset = "0xA90598", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void DistanceSquared(ref Vector2 value1, ref Vector2 value2, out float result)
		{
			throw null;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00025175 File Offset: 0x00023375
		[global::Cpp2ILInjected.Token(Token = "0x6001395")]
		[global::Cpp2ILInjected.Address(RVA = "0xA905BC", Offset = "0xA905BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2 Divide(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00025178 File Offset: 0x00023378
		[global::Cpp2ILInjected.Token(Token = "0x6001396")]
		[global::Cpp2ILInjected.Address(RVA = "0xA905C8", Offset = "0xA905C8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0002517B File Offset: 0x0002337B
		[global::Cpp2ILInjected.Token(Token = "0x6001397")]
		[global::Cpp2ILInjected.Address(RVA = "0xA905DC", Offset = "0xA905DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2 Divide(Vector2 value1, float divider)
		{
			throw null;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0002517E File Offset: 0x0002337E
		[global::Cpp2ILInjected.Token(Token = "0x6001398")]
		[global::Cpp2ILInjected.Address(RVA = "0xA905F0", Offset = "0xA905F0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector2 value1, float divider, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00025181 File Offset: 0x00023381
		[global::Cpp2ILInjected.Token(Token = "0x6001399")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90104", Offset = "0xA90104", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		public static float Dot(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00025184 File Offset: 0x00023384
		[global::Cpp2ILInjected.Token(Token = "0x600139A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90608", Offset = "0xA90608", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dot(ref Vector2 value1, ref Vector2 value2, out float result)
		{
			throw null;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00025187 File Offset: 0x00023387
		[global::Cpp2ILInjected.Token(Token = "0x600139B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90624", Offset = "0xA90624", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0002518A File Offset: 0x0002338A
		[global::Cpp2ILInjected.Token(Token = "0x600139C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA906F8", Offset = "0xA906F8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "CheckLinevLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(Vector2 other)
		{
			throw null;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0002518D File Offset: 0x0002338D
		[global::Cpp2ILInjected.Token(Token = "0x600139D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90778", Offset = "0xA90778", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00025190 File Offset: 0x00023390
		[global::Cpp2ILInjected.Token(Token = "0x600139E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9079C", Offset = "0xA9079C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector2 Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount)
		{
			throw null;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00025193 File Offset: 0x00023393
		[global::Cpp2ILInjected.Token(Token = "0x600139F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90814", Offset = "0xA90814", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTransferParticle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref ParticleRendererSettings),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Hermite(ref Vector2 value1, ref Vector2 tangent1, ref Vector2 value2, ref Vector2 tangent2, float amount, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00025196 File Offset: 0x00023396
		[global::Cpp2ILInjected.Token(Token = "0x60013A0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90894", Offset = "0xA90894", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 690)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float Length()
		{
			throw null;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00025199 File Offset: 0x00023399
		[global::Cpp2ILInjected.Token(Token = "0x60013A1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90900", Offset = "0xA90900", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = "ApplyDeadZone", MemberParameters = new object[]
		{
			typeof(GamePadDeadZone),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "ClosestPointOnLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BallCollision), Member = "ClosestPointOnLineSegment", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(LineSegment)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public float LengthSquared()
		{
			throw null;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0002519C File Offset: 0x0002339C
		[global::Cpp2ILInjected.Token(Token = "0x60013A2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90914", Offset = "0xA90914", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 127)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
		{
			throw null;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0002519F File Offset: 0x0002339F
		[global::Cpp2ILInjected.Token(Token = "0x60013A3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9096C", Offset = "0xA9096C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Lerp(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000251A2 File Offset: 0x000233A2
		[global::Cpp2ILInjected.Token(Token = "0x60013A4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA909D0", Offset = "0xA909D0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteRenderTargetHelper), Member = "GetHighsAndLowsOf", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref DrawData),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Minimap.MinimapFrame.Button", Member = "IsTouchingPoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector2 Max(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000251A5 File Offset: 0x000233A5
		[global::Cpp2ILInjected.Token(Token = "0x60013A5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90A1C", Offset = "0xA90A1C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Max(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000251A8 File Offset: 0x000233A8
		[global::Cpp2ILInjected.Token(Token = "0x60013A6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90A70", Offset = "0xA90A70", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteRenderTargetHelper), Member = "GetHighsAndLowsOf", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref DrawData),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector2 Min(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000251AB File Offset: 0x000233AB
		[global::Cpp2ILInjected.Token(Token = "0x60013A7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90ABC", Offset = "0xA90ABC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Min(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x000251AE File Offset: 0x000233AE
		[global::Cpp2ILInjected.Token(Token = "0x60013A8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90B10", Offset = "0xA90B10", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2 Multiply(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x000251B1 File Offset: 0x000233B1
		[global::Cpp2ILInjected.Token(Token = "0x60013A9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90B1C", Offset = "0xA90B1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2 Multiply(Vector2 value1, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x000251B4 File Offset: 0x000233B4
		[global::Cpp2ILInjected.Token(Token = "0x60013AA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90B28", Offset = "0xA90B28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector2 value1, float scaleFactor, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x000251B7 File Offset: 0x000233B7
		[global::Cpp2ILInjected.Token(Token = "0x60013AB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90B38", Offset = "0xA90B38", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x000251BA File Offset: 0x000233BA
		[global::Cpp2ILInjected.Token(Token = "0x60013AC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90B4C", Offset = "0xA90B4C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2 Negate(Vector2 value)
		{
			throw null;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x000251BD File Offset: 0x000233BD
		[global::Cpp2ILInjected.Token(Token = "0x60013AD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90B58", Offset = "0xA90B58", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Vector2 value, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x000251C0 File Offset: 0x000233C0
		[global::Cpp2ILInjected.Token(Token = "0x60013AE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90B68", Offset = "0xA90B68", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 260)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Normalize()
		{
			throw null;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000251C3 File Offset: 0x000233C3
		[global::Cpp2ILInjected.Token(Token = "0x60013AF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90BF8", Offset = "0xA90BF8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 165)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 Normalize(Vector2 value)
		{
			throw null;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000251C6 File Offset: 0x000233C6
		[global::Cpp2ILInjected.Token(Token = "0x60013B0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90C74", Offset = "0xA90C74", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Normalize(ref Vector2 value, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000251C9 File Offset: 0x000233C9
		[global::Cpp2ILInjected.Token(Token = "0x60013B1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90D10", Offset = "0xA90D10", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_171_HallowBossRainbowStreak", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_156_Think", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)
		{
			throw null;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000251CC File Offset: 0x000233CC
		[global::Cpp2ILInjected.Token(Token = "0x60013B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90D68", Offset = "0xA90D68", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void SmoothStep(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000251CF File Offset: 0x000233CF
		[global::Cpp2ILInjected.Token(Token = "0x60013B3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90DCC", Offset = "0xA90DCC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2 Subtract(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000251D2 File Offset: 0x000233D2
		[global::Cpp2ILInjected.Token(Token = "0x60013B4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90DD8", Offset = "0xA90DD8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000251D5 File Offset: 0x000233D5
		[global::Cpp2ILInjected.Token(Token = "0x60013B5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90DEC", Offset = "0xA90DEC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithVoidLens", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithMoneyTrough", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "RotatedRelativePointOld", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "TrackCollision", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(Mount.MountDelegatesData)
		}, ReturnType = typeof(BitsByte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "DoSpawnDust", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "ToScreenPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_TransformDrawData", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "GetClippingRectangle", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "OverReturnGateInWorld", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AHoverInteractionChecker), Member = "AttemptInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Rectangle)
		}, ReturnType = typeof(AHoverInteractionChecker.HoverStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 Transform(Vector2 position, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000251D8 File Offset: 0x000233D8
		[global::Cpp2ILInjected.Token(Token = "0x60013B6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90E74", Offset = "0xA90E74", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineRight", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineCentre", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_TransformDrawData", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000251DB File Offset: 0x000233DB
		[global::Cpp2ILInjected.Token(Token = "0x60013B7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90EA0", Offset = "0xA90EA0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 Transform(Vector2 value, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000251DE File Offset: 0x000233DE
		[global::Cpp2ILInjected.Token(Token = "0x60013B8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90ED8", Offset = "0xA90ED8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000251E1 File Offset: 0x000233E1
		[global::Cpp2ILInjected.Token(Token = "0x60013B9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90F10", Offset = "0xA90F10", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
		{
			throw null;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000251E4 File Offset: 0x000233E4
		[global::Cpp2ILInjected.Token(Token = "0x60013BA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90F48", Offset = "0xA90F48", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector2[] sourceArray, ref Quaternion rotation, Vector2[] destinationArray)
		{
			throw null;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000251E7 File Offset: 0x000233E7
		[global::Cpp2ILInjected.Token(Token = "0x60013BB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90F80", Offset = "0xA90F80", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000251EA File Offset: 0x000233EA
		[global::Cpp2ILInjected.Token(Token = "0x60013BC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90FB8", Offset = "0xA90FB8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000251ED File Offset: 0x000233ED
		[global::Cpp2ILInjected.Token(Token = "0x60013BD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA90FF0", Offset = "0xA90FF0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 TransformNormal(Vector2 normal, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000251F0 File Offset: 0x000233F0
		[global::Cpp2ILInjected.Token(Token = "0x60013BE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91070", Offset = "0xA91070", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void TransformNormal(ref Vector2 normal, ref Matrix matrix, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000251F3 File Offset: 0x000233F3
		[global::Cpp2ILInjected.Token(Token = "0x60013BF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91094", Offset = "0xA91094", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TransformNormal(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
		{
			throw null;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000251F6 File Offset: 0x000233F6
		[global::Cpp2ILInjected.Token(Token = "0x60013C0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA910CC", Offset = "0xA910CC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TransformNormal(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000251F9 File Offset: 0x000233F9
		[global::Cpp2ILInjected.Token(Token = "0x60013C1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91104", Offset = "0xA91104", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector2), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rg32), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000251FC File Offset: 0x000233FC
		[global::Cpp2ILInjected.Token(Token = "0x60013C2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91204", Offset = "0xA91204", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 191)]
		public static Vector2 operator -(Vector2 value)
		{
			throw null;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000251FF File Offset: 0x000233FF
		[global::Cpp2ILInjected.Token(Token = "0x60013C3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA906E0", Offset = "0xA906E0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 75)]
		public static bool operator ==(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00025202 File Offset: 0x00023402
		[global::Cpp2ILInjected.Token(Token = "0x60013C4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91210", Offset = "0xA91210", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 143)]
		public static bool operator !=(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00025205 File Offset: 0x00023405
		[global::Cpp2ILInjected.Token(Token = "0x60013C5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91228", Offset = "0xA91228", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4774)]
		public static Vector2 operator +(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00025208 File Offset: 0x00023408
		[global::Cpp2ILInjected.Token(Token = "0x60013C6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91234", Offset = "0xA91234", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2253)]
		public static Vector2 operator -(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0002520B File Offset: 0x0002340B
		[global::Cpp2ILInjected.Token(Token = "0x60013C7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91240", Offset = "0xA91240", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 443)]
		public static Vector2 operator *(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0002520E File Offset: 0x0002340E
		[global::Cpp2ILInjected.Token(Token = "0x60013C8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9124C", Offset = "0xA9124C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5704)]
		public static Vector2 operator *(Vector2 value, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00025211 File Offset: 0x00023411
		[global::Cpp2ILInjected.Token(Token = "0x60013C9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91258", Offset = "0xA91258", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
		public static Vector2 operator *(float scaleFactor, Vector2 value)
		{
			throw null;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00025214 File Offset: 0x00023414
		[global::Cpp2ILInjected.Token(Token = "0x60013CA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91268", Offset = "0xA91268", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_ViewSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawStar", MemberParameters = new object[]
		{
			typeof(ref Main.SceneArea),
			typeof(float),
			typeof(Color),
			typeof(int),
			typeof(Star),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "Vector2FromElipse", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartSelectGamepadPointer), Member = "GetPointerPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "FindVectorOnOval", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public static Vector2 operator /(Vector2 value1, Vector2 value2)
		{
			throw null;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00025217 File Offset: 0x00023417
		[global::Cpp2ILInjected.Token(Token = "0x60013CB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91274", Offset = "0xA91274", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1038)]
		public static Vector2 operator /(Vector2 value1, float divider)
		{
			throw null;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0002521A File Offset: 0x0002341A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60013CC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91288", Offset = "0xA91288", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Vector2()
		{
			throw null;
		}

		// Token: 0x04001C98 RID: 7320
		[global::Cpp2ILInjected.Token(Token = "0x4002272")]
		private static Vector2 zeroVector;

		// Token: 0x04001C99 RID: 7321
		[global::Cpp2ILInjected.Token(Token = "0x4002273")]
		private static Vector2 unitVector;

		// Token: 0x04001C9A RID: 7322
		[global::Cpp2ILInjected.Token(Token = "0x4002274")]
		private static Vector2 unitXVector;

		// Token: 0x04001C9B RID: 7323
		[global::Cpp2ILInjected.Token(Token = "0x4002275")]
		private static Vector2 unitYVector;

		// Token: 0x04001C9C RID: 7324
		[global::Cpp2ILInjected.Token(Token = "0x4002276")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float X;

		// Token: 0x04001C9D RID: 7325
		[global::Cpp2ILInjected.Token(Token = "0x4002277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float Y;
	}
}
