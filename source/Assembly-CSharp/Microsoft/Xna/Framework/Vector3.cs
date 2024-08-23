using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Terraria;
using Terraria.Cinematics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.Events;
using Terraria.GameContent.Shaders;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using UnityEngine;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000270 RID: 624
	[global::Cpp2ILInjected.Token(Token = "0x2000331")]
	[Serializable]
	public struct Vector3 : IEquatable<Vector3>
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x0002521D File Offset: 0x0002341D
		[global::Cpp2ILInjected.Token(Token = "0x170001ED")]
		public static Vector3 Zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013CD")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91300", Offset = "0xA91300", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00025220 File Offset: 0x00023420
		[global::Cpp2ILInjected.Token(Token = "0x170001EE")]
		public static Vector3 One
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013CE")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9135C", Offset = "0xA9135C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00025223 File Offset: 0x00023423
		[global::Cpp2ILInjected.Token(Token = "0x170001EF")]
		public static Vector3 UnitX
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013CF")]
			[global::Cpp2ILInjected.Address(RVA = "0xA913B8", Offset = "0xA913B8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00025226 File Offset: 0x00023426
		[global::Cpp2ILInjected.Token(Token = "0x170001F0")]
		public static Vector3 UnitY
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D0")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91414", Offset = "0xA91414", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00025229 File Offset: 0x00023429
		[global::Cpp2ILInjected.Token(Token = "0x170001F1")]
		public static Vector3 UnitZ
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D1")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91470", Offset = "0xA91470", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0002522C File Offset: 0x0002342C
		[global::Cpp2ILInjected.Token(Token = "0x170001F2")]
		public static Vector3 Up
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D2")]
			[global::Cpp2ILInjected.Address(RVA = "0xA914CC", Offset = "0xA914CC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x0002522F File Offset: 0x0002342F
		[global::Cpp2ILInjected.Token(Token = "0x170001F3")]
		public static Vector3 Down
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D3")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91528", Offset = "0xA91528", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00025232 File Offset: 0x00023432
		[global::Cpp2ILInjected.Token(Token = "0x170001F4")]
		public static Vector3 Right
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D4")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91584", Offset = "0xA91584", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00025235 File Offset: 0x00023435
		[global::Cpp2ILInjected.Token(Token = "0x170001F5")]
		public static Vector3 Left
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D5")]
			[global::Cpp2ILInjected.Address(RVA = "0xA915E0", Offset = "0xA915E0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00025238 File Offset: 0x00023438
		[global::Cpp2ILInjected.Token(Token = "0x170001F6")]
		public static Vector3 Forward
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D6")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9163C", Offset = "0xA9163C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x0002523B File Offset: 0x0002343B
		[global::Cpp2ILInjected.Token(Token = "0x170001F7")]
		public static Vector3 Backward
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D7")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91698", Offset = "0xA91698", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0002523E File Offset: 0x0002343E
		[global::Cpp2ILInjected.Token(Token = "0x60013D8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CC00", Offset = "0xA8CC00", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 119)]
		public Vector3(float x, float y, float z)
		{
			throw null;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00025241 File Offset: 0x00023441
		[global::Cpp2ILInjected.Token(Token = "0x60013D9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA916F4", Offset = "0xA916F4", Length = "0xC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		public Vector3(float value)
		{
			throw null;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00025244 File Offset: 0x00023444
		[global::Cpp2ILInjected.Token(Token = "0x60013DA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91700", Offset = "0xA91700", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Vector3(Vector2 value, float z)
		{
			throw null;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00025247 File Offset: 0x00023447
		[global::Cpp2ILInjected.Token(Token = "0x60013DB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9170C", Offset = "0xA9170C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Add(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0002524A File Offset: 0x0002344A
		[global::Cpp2ILInjected.Token(Token = "0x60013DC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9171C", Offset = "0xA9171C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0002524D File Offset: 0x0002344D
		[global::Cpp2ILInjected.Token(Token = "0x60013DD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91740", Offset = "0xA91740", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Barycentric", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2)
		{
			throw null;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00025250 File Offset: 0x00023450
		[global::Cpp2ILInjected.Token(Token = "0x60013DE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA917EC", Offset = "0xA917EC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Barycentric", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Barycentric(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, float amount1, float amount2, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00025253 File Offset: 0x00023453
		[global::Cpp2ILInjected.Token(Token = "0x60013DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA918A0", Offset = "0xA918A0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount)
		{
			throw null;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00025256 File Offset: 0x00023456
		[global::Cpp2ILInjected.Token(Token = "0x60013E0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91948", Offset = "0xA91948", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void CatmullRom(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, ref Vector3 value4, float amount, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00025259 File Offset: 0x00023459
		[global::Cpp2ILInjected.Token(Token = "0x60013E1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA919FC", Offset = "0xA919FC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max)
		{
			throw null;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0002525C File Offset: 0x0002345C
		[global::Cpp2ILInjected.Token(Token = "0x60013E2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91A88", Offset = "0xA91A88", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Clamp(ref Vector3 value1, ref Vector3 min, ref Vector3 max, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0002525F File Offset: 0x0002345F
		[global::Cpp2ILInjected.Token(Token = "0x60013E3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CD38", Offset = "0xA8CD38", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector3 Cross(Vector3 vector1, Vector3 vector2)
		{
			throw null;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00025262 File Offset: 0x00023462
		[global::Cpp2ILInjected.Token(Token = "0x60013E4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91B10", Offset = "0xA91B10", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateWorld", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateBillboard", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(Vector3?),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static void Cross(ref Vector3 vector1, ref Vector3 vector2, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00025265 File Offset: 0x00023465
		[global::Cpp2ILInjected.Token(Token = "0x60013E5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91B5C", Offset = "0xA91B5C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Distance(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00025268 File Offset: 0x00023468
		[global::Cpp2ILInjected.Token(Token = "0x60013E6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91BFC", Offset = "0xA91BFC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Distance(ref Vector3 value1, ref Vector3 value2, out float result)
		{
			throw null;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0002526B File Offset: 0x0002346B
		[global::Cpp2ILInjected.Token(Token = "0x60013E7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91CAC", Offset = "0xA91CAC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float DistanceSquared(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0002526E File Offset: 0x0002346E
		[global::Cpp2ILInjected.Token(Token = "0x60013E8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91CD0", Offset = "0xA91CD0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void DistanceSquared(ref Vector3 value1, ref Vector3 value2, out float result)
		{
			throw null;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00025271 File Offset: 0x00023471
		[global::Cpp2ILInjected.Token(Token = "0x60013E9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D08", Offset = "0xA91D08", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Divide(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00025274 File Offset: 0x00023474
		[global::Cpp2ILInjected.Token(Token = "0x60013EA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D18", Offset = "0xA91D18", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Divide(Vector3 value1, float value2)
		{
			throw null;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00025277 File Offset: 0x00023477
		[global::Cpp2ILInjected.Token(Token = "0x60013EB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D30", Offset = "0xA91D30", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector3 value1, float divisor, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0002527A File Offset: 0x0002347A
		[global::Cpp2ILInjected.Token(Token = "0x60013EC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D54", Offset = "0xA91D54", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0002527D File Offset: 0x0002347D
		[global::Cpp2ILInjected.Token(Token = "0x60013ED")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CDF4", Offset = "0xA8CDF4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateShadow", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Plane),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static float Dot(Vector3 vector1, Vector3 vector2)
		{
			throw null;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00025280 File Offset: 0x00023480
		[global::Cpp2ILInjected.Token(Token = "0x60013EE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D78", Offset = "0xA91D78", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result)
		{
			throw null;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00025283 File Offset: 0x00023483
		[global::Cpp2ILInjected.Token(Token = "0x60013EF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91DA4", Offset = "0xA91DA4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00025286 File Offset: 0x00023486
		[global::Cpp2ILInjected.Token(Token = "0x60013F0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91E78", Offset = "0xA91E78", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(Vector3 other)
		{
			throw null;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00025289 File Offset: 0x00023489
		[global::Cpp2ILInjected.Token(Token = "0x60013F1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D43C", Offset = "0xA8D43C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0002528C File Offset: 0x0002348C
		[global::Cpp2ILInjected.Token(Token = "0x60013F2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91F18", Offset = "0xA91F18", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
		{
			throw null;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0002528F File Offset: 0x0002348F
		[global::Cpp2ILInjected.Token(Token = "0x60013F3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91FC0", Offset = "0xA91FC0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2, float amount, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00025292 File Offset: 0x00023492
		[global::Cpp2ILInjected.Token(Token = "0x60013F4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92060", Offset = "0xA92060", Length = "0x80")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_NightsEdge", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_Excalibur", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TheHorsemansBlade", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TrueExcalibur", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TrueNightsEdge", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TerraBlade2", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TerraBlade2Shot", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_067_FreakingPirates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "IsPlayerSafe", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float Length()
		{
			throw null;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00025295 File Offset: 0x00023495
		[global::Cpp2ILInjected.Token(Token = "0x60013F5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA920E0", Offset = "0xA920E0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float LengthSquared()
		{
			throw null;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00025298 File Offset: 0x00023498
		[global::Cpp2ILInjected.Token(Token = "0x60013F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92100", Offset = "0xA92100", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetSubLight", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_182_FinalFractal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_075", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "DryadPortalFade", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
		{
			throw null;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0002529B File Offset: 0x0002349B
		[global::Cpp2ILInjected.Token(Token = "0x60013F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92184", Offset = "0xA92184", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Lerp(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0002529E File Offset: 0x0002349E
		[global::Cpp2ILInjected.Token(Token = "0x60013F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92210", Offset = "0xA92210", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Max(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000252A1 File Offset: 0x000234A1
		[global::Cpp2ILInjected.Token(Token = "0x60013F9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92284", Offset = "0xA92284", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Max(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000252A4 File Offset: 0x000234A4
		[global::Cpp2ILInjected.Token(Token = "0x60013FA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA922F4", Offset = "0xA922F4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColorClamped", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Min(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000252A7 File Offset: 0x000234A7
		[global::Cpp2ILInjected.Token(Token = "0x60013FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92368", Offset = "0xA92368", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Min(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000252AA File Offset: 0x000234AA
		[global::Cpp2ILInjected.Token(Token = "0x60013FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA923D8", Offset = "0xA923D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Multiply(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000252AD File Offset: 0x000234AD
		[global::Cpp2ILInjected.Token(Token = "0x60013FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA923E8", Offset = "0xA923E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Multiply(Vector3 value1, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000252B0 File Offset: 0x000234B0
		[global::Cpp2ILInjected.Token(Token = "0x60013FE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA923F8", Offset = "0xA923F8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector3 value1, float scaleFactor, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000252B3 File Offset: 0x000234B3
		[global::Cpp2ILInjected.Token(Token = "0x60013FF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92414", Offset = "0xA92414", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000252B6 File Offset: 0x000234B6
		[global::Cpp2ILInjected.Token(Token = "0x6001400")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92438", Offset = "0xA92438", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Negate(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000252B9 File Offset: 0x000234B9
		[global::Cpp2ILInjected.Token(Token = "0x6001401")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92448", Offset = "0xA92448", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Vector3 value, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000252BC File Offset: 0x000234BC
		[global::Cpp2ILInjected.Token(Token = "0x6001402")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92464", Offset = "0xA92464", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateWorld", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Normalize()
		{
			throw null;
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000252BF File Offset: 0x000234BF
		[global::Cpp2ILInjected.Token(Token = "0x6001403")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CD60", Offset = "0xA8CD60", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "Normalize", MemberParameters = new object[]
		{
			typeof(ref Plane),
			typeof(ref Plane)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector3 Normalize(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x000252C2 File Offset: 0x000234C2
		[global::Cpp2ILInjected.Token(Token = "0x6001404")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92518", Offset = "0xA92518", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateWorld", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateBillboard", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(Vector3?),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Normalize(ref Vector3 value, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000252C5 File Offset: 0x000234C5
		[global::Cpp2ILInjected.Token(Token = "0x6001405")]
		[global::Cpp2ILInjected.Address(RVA = "0xA925D8", Offset = "0xA925D8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector3 Reflect(Vector3 vector, Vector3 normal)
		{
			throw null;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x000252C8 File Offset: 0x000234C8
		[global::Cpp2ILInjected.Token(Token = "0x6001406")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92684", Offset = "0xA92684", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Reflect(ref Vector3 vector, ref Vector3 normal, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000252CB File Offset: 0x000234CB
		[global::Cpp2ILInjected.Token(Token = "0x6001407")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92760", Offset = "0xA92760", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount)
		{
			throw null;
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000252CE File Offset: 0x000234CE
		[global::Cpp2ILInjected.Token(Token = "0x6001408")]
		[global::Cpp2ILInjected.Address(RVA = "0xA927E4", Offset = "0xA927E4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void SmoothStep(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x000252D1 File Offset: 0x000234D1
		[global::Cpp2ILInjected.Token(Token = "0x6001409")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92870", Offset = "0xA92870", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Subtract(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x000252D4 File Offset: 0x000234D4
		[global::Cpp2ILInjected.Token(Token = "0x600140A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92880", Offset = "0xA92880", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000252D7 File Offset: 0x000234D7
		[global::Cpp2ILInjected.Token(Token = "0x600140B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA928A4", Offset = "0xA928A4", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgr565), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000252DA File Offset: 0x000234DA
		[global::Cpp2ILInjected.Token(Token = "0x600140C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA929D8", Offset = "0xA929D8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Viewport), Member = "Project", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix),
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Viewport), Member = "Unproject", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix),
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect_HallowBoss", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(ref Vector2),
			typeof(int),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref Vector2),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Matrix),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector3 Transform(Vector3 position, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000252DD File Offset: 0x000234DD
		[global::Cpp2ILInjected.Token(Token = "0x600140D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92A50", Offset = "0xA92A50", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector3), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000252E0 File Offset: 0x000234E0
		[global::Cpp2ILInjected.Token(Token = "0x600140E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92AB4", Offset = "0xA92AB4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "SetPosition", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public Vector3 UnityVec3()
		{
			throw null;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000252E3 File Offset: 0x000234E3
		[global::Cpp2ILInjected.Token(Token = "0x600140F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92AC0", Offset = "0xA92AC0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector3 Transform(Vector3 value, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000252E6 File Offset: 0x000234E6
		[global::Cpp2ILInjected.Token(Token = "0x6001410")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92AF8", Offset = "0xA92AF8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
		{
			throw null;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000252E9 File Offset: 0x000234E9
		[global::Cpp2ILInjected.Token(Token = "0x6001411")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92B30", Offset = "0xA92B30", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector3[] sourceArray, ref Quaternion rotation, Vector3[] destinationArray)
		{
			throw null;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000252EC File Offset: 0x000234EC
		[global::Cpp2ILInjected.Token(Token = "0x6001412")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92B68", Offset = "0xA92B68", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000252EF File Offset: 0x000234EF
		[global::Cpp2ILInjected.Token(Token = "0x6001413")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92BA0", Offset = "0xA92BA0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000252F2 File Offset: 0x000234F2
		[global::Cpp2ILInjected.Token(Token = "0x6001414")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92BD8", Offset = "0xA92BD8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000252F5 File Offset: 0x000234F5
		[global::Cpp2ILInjected.Token(Token = "0x6001415")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92C10", Offset = "0xA92C10", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TransformNormal(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
		{
			throw null;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000252F8 File Offset: 0x000234F8
		[global::Cpp2ILInjected.Token(Token = "0x6001416")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92C48", Offset = "0xA92C48", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TransformNormal(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000252FB File Offset: 0x000234FB
		[global::Cpp2ILInjected.Token(Token = "0x6001417")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92C80", Offset = "0xA92C80", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector3 TransformNormal(Vector3 normal, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000252FE File Offset: 0x000234FE
		[global::Cpp2ILInjected.Token(Token = "0x6001418")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92D3C", Offset = "0xA92D3C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void TransformNormal(ref Vector3 normal, ref Matrix matrix, out Vector3 result)
		{
			throw null;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00025301 File Offset: 0x00023501
		[global::Cpp2ILInjected.Token(Token = "0x6001419")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D3D4", Offset = "0xA8D3D4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00025304 File Offset: 0x00023504
		[global::Cpp2ILInjected.Token(Token = "0x600141A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92D90", Offset = "0xA92D90", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static bool operator !=(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00025307 File Offset: 0x00023507
		[global::Cpp2ILInjected.Token(Token = "0x600141B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DB8", Offset = "0xA92DB8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_065_Butterflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "GetLight", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static Vector3 operator +(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0002530A File Offset: 0x0002350A
		[global::Cpp2ILInjected.Token(Token = "0x600141C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DC8", Offset = "0xA92DC8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 operator -(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0002530D File Offset: 0x0002350D
		[global::Cpp2ILInjected.Token(Token = "0x600141D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CD28", Offset = "0xA8CD28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateBillboard", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(Vector3?),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		public static Vector3 operator -(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00025310 File Offset: 0x00023510
		[global::Cpp2ILInjected.Token(Token = "0x600141E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DD8", Offset = "0xA92DD8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "GetAlpha", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColorClamped", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public static Vector3 operator *(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00025313 File Offset: 0x00023513
		[global::Cpp2ILInjected.Token(Token = "0x600141F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DE8", Offset = "0xA92DE8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 93)]
		public static Vector3 operator *(Vector3 value, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00025316 File Offset: 0x00023516
		[global::Cpp2ILInjected.Token(Token = "0x6001420")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DF8", Offset = "0xA92DF8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 operator *(float scaleFactor, Vector3 value)
		{
			throw null;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00025319 File Offset: 0x00023519
		[global::Cpp2ILInjected.Token(Token = "0x6001421")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92E0C", Offset = "0xA92E0C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static Vector3 operator /(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0002531C File Offset: 0x0002351C
		[global::Cpp2ILInjected.Token(Token = "0x6001422")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92E1C", Offset = "0xA92E1C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "GetLight", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector3 operator /(Vector3 value, float divider)
		{
			throw null;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0002531F File Offset: 0x0002351F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001423")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92E34", Offset = "0xA92E34", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Vector3()
		{
			throw null;
		}

		// Token: 0x04001C9E RID: 7326
		[global::Cpp2ILInjected.Token(Token = "0x4002278")]
		private static Vector3 zero;

		// Token: 0x04001C9F RID: 7327
		[global::Cpp2ILInjected.Token(Token = "0x4002279")]
		private static Vector3 one;

		// Token: 0x04001CA0 RID: 7328
		[global::Cpp2ILInjected.Token(Token = "0x400227A")]
		private static Vector3 unitX;

		// Token: 0x04001CA1 RID: 7329
		[global::Cpp2ILInjected.Token(Token = "0x400227B")]
		private static Vector3 unitY;

		// Token: 0x04001CA2 RID: 7330
		[global::Cpp2ILInjected.Token(Token = "0x400227C")]
		private static Vector3 unitZ;

		// Token: 0x04001CA3 RID: 7331
		[global::Cpp2ILInjected.Token(Token = "0x400227D")]
		private static Vector3 up;

		// Token: 0x04001CA4 RID: 7332
		[global::Cpp2ILInjected.Token(Token = "0x400227E")]
		private static Vector3 down;

		// Token: 0x04001CA5 RID: 7333
		[global::Cpp2ILInjected.Token(Token = "0x400227F")]
		private static Vector3 right;

		// Token: 0x04001CA6 RID: 7334
		[global::Cpp2ILInjected.Token(Token = "0x4002280")]
		private static Vector3 left;

		// Token: 0x04001CA7 RID: 7335
		[global::Cpp2ILInjected.Token(Token = "0x4002281")]
		private static Vector3 forward;

		// Token: 0x04001CA8 RID: 7336
		[global::Cpp2ILInjected.Token(Token = "0x4002282")]
		private static Vector3 backward;

		// Token: 0x04001CA9 RID: 7337
		[global::Cpp2ILInjected.Token(Token = "0x4002283")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float X;

		// Token: 0x04001CAA RID: 7338
		[global::Cpp2ILInjected.Token(Token = "0x4002284")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float Y;

		// Token: 0x04001CAB RID: 7339
		[global::Cpp2ILInjected.Token(Token = "0x4002285")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float Z;
	}
}
