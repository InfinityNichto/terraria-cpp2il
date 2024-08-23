using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.ObjectInteractions;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Renderers;
using UnityEngine;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000269 RID: 617
	[global::Cpp2ILInjected.Token(Token = "0x200032A")]
	[Serializable]
	public struct Matrix : IEquatable<Matrix>
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00024EB1 File Offset: 0x000230B1
		[global::Cpp2ILInjected.Token(Token = "0x170001D7")]
		public static Matrix Identity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012A9")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7BFE4", Offset = "0xA7BFE4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00024EB4 File Offset: 0x000230B4
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x00024EB7 File Offset: 0x000230B7
		[global::Cpp2ILInjected.Token(Token = "0x170001D8")]
		public Vector3 Backward
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012AA")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C04C", Offset = "0xA7C04C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60012AB")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C084", Offset = "0xA7C084", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00024EBA File Offset: 0x000230BA
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00024EBD File Offset: 0x000230BD
		[global::Cpp2ILInjected.Token(Token = "0x170001D9")]
		public Vector3 Down
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012AC")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C090", Offset = "0xA7C090", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60012AD")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C0D4", Offset = "0xA7C0D4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00024EC0 File Offset: 0x000230C0
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x00024EC3 File Offset: 0x000230C3
		[global::Cpp2ILInjected.Token(Token = "0x170001DA")]
		public Vector3 Forward
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012AE")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C0EC", Offset = "0xA7C0EC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ExtractRotationFromMatrix", MemberParameters = new object[] { typeof(ref Matrix) }, ReturnType = typeof(Quaternion))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60012AF")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C130", Offset = "0xA7C130", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00024EC6 File Offset: 0x000230C6
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x00024EC9 File Offset: 0x000230C9
		[global::Cpp2ILInjected.Token(Token = "0x170001DB")]
		public Vector3 Left
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012B0")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C148", Offset = "0xA7C148", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60012B1")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C18C", Offset = "0xA7C18C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x00024ECC File Offset: 0x000230CC
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x00024ECF File Offset: 0x000230CF
		[global::Cpp2ILInjected.Token(Token = "0x170001DC")]
		public Vector3 Right
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012B2")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C1A4", Offset = "0xA7C1A4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60012B3")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C1DC", Offset = "0xA7C1DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x00024ED2 File Offset: 0x000230D2
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x00024ED5 File Offset: 0x000230D5
		[global::Cpp2ILInjected.Token(Token = "0x170001DD")]
		public Vector3 Translation
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012B4")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C1E8", Offset = "0xA7C1E8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ExtractTranslationFromMatrix", MemberParameters = new object[] { typeof(ref Matrix) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "SetTransformFromMatrix", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(ref Matrix)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(CaptureSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60012B5")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C220", Offset = "0xA7C220", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(CaptureSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00024ED8 File Offset: 0x000230D8
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x00024EDB File Offset: 0x000230DB
		[global::Cpp2ILInjected.Token(Token = "0x170001DE")]
		public Vector3 Up
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012B6")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C22C", Offset = "0xA7C22C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ExtractRotationFromMatrix", MemberParameters = new object[] { typeof(ref Matrix) }, ReturnType = typeof(Quaternion))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60012B7")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7C264", Offset = "0xA7C264", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00024EDE File Offset: 0x000230DE
		[global::Cpp2ILInjected.Token(Token = "0x60012B8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C270", Offset = "0xA7C270", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
		{
			throw null;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00024EE1 File Offset: 0x000230E1
		[global::Cpp2ILInjected.Token(Token = "0x60012B9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C2B4", Offset = "0xA7C2B4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateWorld", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
		{
			throw null;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00024EE4 File Offset: 0x000230E4
		[global::Cpp2ILInjected.Token(Token = "0x60012BA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C35C", Offset = "0xA7C35C", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateWorld", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Cross", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CreateWorld(ref Vector3 position, ref Vector3 forward, ref Vector3 up, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00024EE7 File Offset: 0x000230E7
		[global::Cpp2ILInjected.Token(Token = "0x60012BB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C498", Offset = "0xA7C498", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateShadow", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Plane),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateShadow(Vector3 lightDirection, Plane plane)
		{
			throw null;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00024EEA File Offset: 0x000230EA
		[global::Cpp2ILInjected.Token(Token = "0x60012BC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C52C", Offset = "0xA7C52C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateShadow", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Plane)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = "Normalize", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(Plane))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Dot", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00024EED File Offset: 0x000230ED
		[global::Cpp2ILInjected.Token(Token = "0x60012BD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C67C", Offset = "0xA7C67C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateReflection", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = "Normalize", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(Plane))]
		public static void CreateReflection(ref Plane value, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00024EF0 File Offset: 0x000230F0
		[global::Cpp2ILInjected.Token(Token = "0x60012BE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C724", Offset = "0xA7C724", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateReflection", MemberParameters = new object[]
		{
			typeof(ref Plane),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateReflection(Plane value)
		{
			throw null;
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00024EF3 File Offset: 0x000230F3
		[global::Cpp2ILInjected.Token(Token = "0x60012BF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C7AC", Offset = "0xA7C7AC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "CreateFromYawPitchRoll", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Quaternion)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateFromQuaternion", MemberParameters = new object[]
		{
			typeof(ref Quaternion),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			throw null;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00024EF6 File Offset: 0x000230F6
		[global::Cpp2ILInjected.Token(Token = "0x60012C0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C9CC", Offset = "0xA7C9CC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "CreateFromYawPitchRoll", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Quaternion)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateFromQuaternion", MemberParameters = new object[]
		{
			typeof(ref Quaternion),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00024EF9 File Offset: 0x000230F9
		[global::Cpp2ILInjected.Token(Token = "0x60012C1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7CA8C", Offset = "0xA7CA8C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Matrix),
			typeof(Quaternion)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateFromQuaternion", MemberParameters = new object[] { typeof(Quaternion) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(ref Matrix),
			typeof(ref Matrix),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Transform(ref Matrix value, ref Quaternion rotation, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00024EFC File Offset: 0x000230FC
		[global::Cpp2ILInjected.Token(Token = "0x60012C2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7CE8C", Offset = "0xA7CE8C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Matrix),
			typeof(ref Quaternion),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix Transform(Matrix value, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00024EFF File Offset: 0x000230FF
		[global::Cpp2ILInjected.Token(Token = "0x60012C3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7CF24", Offset = "0xA7CF24", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "CreateFromRotationMatrix", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public bool Decompose(out Vector3 scale, out Quaternion rotation, out Vector3 translation)
		{
			throw null;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00024F02 File Offset: 0x00023102
		[global::Cpp2ILInjected.Token(Token = "0x60012C4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D1FC", Offset = "0xA7D1FC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Add(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00024F05 File Offset: 0x00023105
		[global::Cpp2ILInjected.Token(Token = "0x60012C5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D2F0", Offset = "0xA7D2F0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00024F08 File Offset: 0x00023108
		[global::Cpp2ILInjected.Token(Token = "0x60012C6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D334", Offset = "0xA7D334", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateBillboard", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(Vector3?),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector)
		{
			throw null;
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00024F0B File Offset: 0x0002310B
		[global::Cpp2ILInjected.Token(Token = "0x60012C7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D3DC", Offset = "0xA7D3DC", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateBillboard", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3),
			typeof(Vector3),
			typeof(Vector3?)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Cross", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void CreateBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 cameraUpVector, Vector3? cameraForwardVector, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00024F0E File Offset: 0x0002310E
		[global::Cpp2ILInjected.Token(Token = "0x60012C8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D5B4", Offset = "0xA7D5B4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector)
		{
			throw null;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00024F11 File Offset: 0x00023111
		[global::Cpp2ILInjected.Token(Token = "0x60012C9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D5EC", Offset = "0xA7D5EC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00024F14 File Offset: 0x00023114
		[global::Cpp2ILInjected.Token(Token = "0x60012CA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D624", Offset = "0xA7D624", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateFromAxisAngle(Vector3 axis, float angle)
		{
			throw null;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00024F17 File Offset: 0x00023117
		[global::Cpp2ILInjected.Token(Token = "0x60012CB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D65C", Offset = "0xA7D65C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00024F1A File Offset: 0x0002311A
		[global::Cpp2ILInjected.Token(Token = "0x60012CC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7CB40", Offset = "0xA7CB40", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Matrix),
			typeof(ref Quaternion),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateFromQuaternion", MemberParameters = new object[]
		{
			typeof(ref Quaternion),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateFromQuaternion(Quaternion quaternion)
		{
			throw null;
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00024F1D File Offset: 0x0002311D
		[global::Cpp2ILInjected.Token(Token = "0x60012CD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C888", Offset = "0xA7C888", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateFromYawPitchRoll", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateFromYawPitchRoll", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateFromQuaternion", MemberParameters = new object[] { typeof(Quaternion) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00024F20 File Offset: 0x00023120
		[global::Cpp2ILInjected.Token(Token = "0x60012CE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D694", Offset = "0xA7D694", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
		{
			throw null;
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00024F23 File Offset: 0x00023123
		[global::Cpp2ILInjected.Token(Token = "0x60012CF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D73C", Offset = "0xA7D73C", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Cross", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Dot", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void CreateLookAt(ref Vector3 cameraPosition, ref Vector3 cameraTarget, ref Vector3 cameraUpVector, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00024F26 File Offset: 0x00023126
		[global::Cpp2ILInjected.Token(Token = "0x60012D0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D97C", Offset = "0xA7D97C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
		{
			throw null;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00024F29 File Offset: 0x00023129
		[global::Cpp2ILInjected.Token(Token = "0x60012D1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DA34", Offset = "0xA7DA34", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00024F2C File Offset: 0x0002312C
		[global::Cpp2ILInjected.Token(Token = "0x60012D2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DA80", Offset = "0xA7DA80", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
		{
			throw null;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00024F2F File Offset: 0x0002312F
		[global::Cpp2ILInjected.Token(Token = "0x60012D3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DB6C", Offset = "0xA7DB6C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00024F32 File Offset: 0x00023132
		[global::Cpp2ILInjected.Token(Token = "0x60012D4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DBD4", Offset = "0xA7DBD4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreatePerspective(float width, float height, float zNearPlane, float zFarPlane)
		{
			throw null;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00024F35 File Offset: 0x00023135
		[global::Cpp2ILInjected.Token(Token = "0x60012D5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DC0C", Offset = "0xA7DC0C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreatePerspective(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00024F38 File Offset: 0x00023138
		[global::Cpp2ILInjected.Token(Token = "0x60012D6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DC44", Offset = "0xA7DC44", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreatePerspectiveFieldOfView", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
		{
			throw null;
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00024F3B File Offset: 0x0002313B
		[global::Cpp2ILInjected.Token(Token = "0x60012D7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DCF0", Offset = "0xA7DCF0", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreatePerspectiveFieldOfView", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00024F3E File Offset: 0x0002313E
		[global::Cpp2ILInjected.Token(Token = "0x60012D8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DED0", Offset = "0xA7DED0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
		{
			throw null;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00024F41 File Offset: 0x00023141
		[global::Cpp2ILInjected.Token(Token = "0x60012D9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DF08", Offset = "0xA7DF08", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00024F44 File Offset: 0x00023144
		[global::Cpp2ILInjected.Token(Token = "0x60012DA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DF40", Offset = "0xA7DF40", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Matrix CreateRotationX(float radians)
		{
			throw null;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00024F47 File Offset: 0x00023147
		[global::Cpp2ILInjected.Token(Token = "0x60012DB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E090", Offset = "0xA7E090", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CreateRotationX(float radians, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00024F4A File Offset: 0x0002314A
		[global::Cpp2ILInjected.Token(Token = "0x60012DC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E188", Offset = "0xA7E188", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Matrix CreateRotationY(float radians)
		{
			throw null;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00024F4D File Offset: 0x0002314D
		[global::Cpp2ILInjected.Token(Token = "0x60012DD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E300", Offset = "0xA7E300", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CreateRotationY(float radians, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00024F50 File Offset: 0x00023150
		[global::Cpp2ILInjected.Token(Token = "0x60012DE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E400", Offset = "0xA7E400", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_TransformDrawData", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Matrix CreateRotationZ(float radians)
		{
			throw null;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00024F53 File Offset: 0x00023153
		[global::Cpp2ILInjected.Token(Token = "0x60012DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E534", Offset = "0xA7E534", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CreateRotationZ(float radians, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00024F56 File Offset: 0x00023156
		[global::Cpp2ILInjected.Token(Token = "0x60012E0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E62C", Offset = "0xA7E62C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateScale(float scale)
		{
			throw null;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00024F59 File Offset: 0x00023159
		[global::Cpp2ILInjected.Token(Token = "0x60012E1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E72C", Offset = "0xA7E72C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateScale(float scale, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00024F5C File Offset: 0x0002315C
		[global::Cpp2ILInjected.Token(Token = "0x60012E2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E7DC", Offset = "0xA7E7DC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "set_UIScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateScale(float xScale, float yScale, float zScale)
		{
			throw null;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00024F5F File Offset: 0x0002315F
		[global::Cpp2ILInjected.Token(Token = "0x60012E3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E8EC", Offset = "0xA7E8EC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00024F62 File Offset: 0x00023162
		[global::Cpp2ILInjected.Token(Token = "0x60012E4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E9AC", Offset = "0xA7E9AC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateScale(Vector3 scales)
		{
			throw null;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00024F65 File Offset: 0x00023165
		[global::Cpp2ILInjected.Token(Token = "0x60012E5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EABC", Offset = "0xA7EABC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateScale(ref Vector3 scales, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00024F68 File Offset: 0x00023168
		[global::Cpp2ILInjected.Token(Token = "0x60012E6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EB78", Offset = "0xA7EB78", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition)
		{
			throw null;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00024F6B File Offset: 0x0002316B
		[global::Cpp2ILInjected.Token(Token = "0x60012E7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EC3C", Offset = "0xA7EC3C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateTranslation(float xPosition, float yPosition, float zPosition, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00024F6E File Offset: 0x0002316E
		[global::Cpp2ILInjected.Token(Token = "0x60012E8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7ECF8", Offset = "0xA7ECF8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateTranslation(Vector3 position)
		{
			throw null;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00024F71 File Offset: 0x00023171
		[global::Cpp2ILInjected.Token(Token = "0x60012E9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EDBC", Offset = "0xA7EDBC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateTranslation(ref Vector3 position, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00024F74 File Offset: 0x00023174
		[global::Cpp2ILInjected.Token(Token = "0x60012EA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EE70", Offset = "0xA7EE70", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix Divide(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00024F77 File Offset: 0x00023177
		[global::Cpp2ILInjected.Token(Token = "0x60012EB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F0CC", Offset = "0xA7F0CC", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00024F7A File Offset: 0x0002317A
		[global::Cpp2ILInjected.Token(Token = "0x60012EC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F3D8", Offset = "0xA7F3D8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Divide(Matrix matrix1, float divider)
		{
			throw null;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00024F7D File Offset: 0x0002317D
		[global::Cpp2ILInjected.Token(Token = "0x60012ED")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F414", Offset = "0xA7F414", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Matrix matrix1, float divider, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00024F80 File Offset: 0x00023180
		[global::Cpp2ILInjected.Token(Token = "0x60012EE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F054", Offset = "0xA7F054", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Divide", MemberParameters = new object[]
		{
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Divide", MemberParameters = new object[]
		{
			typeof(ref Matrix),
			typeof(ref Matrix),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Viewport), Member = "Unproject", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix),
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithVoidLens", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithMoneyTrough", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "OverReturnGateInWorld", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "EndCapture", MemberParameters = new object[]
		{
			typeof(RenderTarget2D),
			typeof(RenderTarget2D),
			typeof(RenderTarget2D),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AHoverInteractionChecker), Member = "AttemptInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Rectangle)
		}, ReturnType = typeof(AHoverInteractionChecker.HoverStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[]
		{
			typeof(ref Matrix),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix Invert(Matrix matrix)
		{
			throw null;
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00024F83 File Offset: 0x00023183
		[global::Cpp2ILInjected.Token(Token = "0x60012EF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F450", Offset = "0xA7F450", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Invert(ref Matrix matrix, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00024F86 File Offset: 0x00023186
		[global::Cpp2ILInjected.Token(Token = "0x60012F0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F7F4", Offset = "0xA7F7F4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount)
		{
			throw null;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00024F89 File Offset: 0x00023189
		[global::Cpp2ILInjected.Token(Token = "0x60012F1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F82C", Offset = "0xA7F82C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Lerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00024F8C File Offset: 0x0002318C
		[global::Cpp2ILInjected.Token(Token = "0x60012F2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F864", Offset = "0xA7F864", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00024F8F File Offset: 0x0002318F
		[global::Cpp2ILInjected.Token(Token = "0x60012F3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7CBC8", Offset = "0xA7CBC8", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Matrix),
			typeof(ref Quaternion),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Multiply(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00024F92 File Offset: 0x00023192
		[global::Cpp2ILInjected.Token(Token = "0x60012F4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F970", Offset = "0xA7F970", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Multiply(Matrix matrix1, float factor)
		{
			throw null;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00024F95 File Offset: 0x00023195
		[global::Cpp2ILInjected.Token(Token = "0x60012F5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F9A4", Offset = "0xA7F9A4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Matrix matrix1, float factor, out Matrix result)
		{
			throw null;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00024F98 File Offset: 0x00023198
		[global::Cpp2ILInjected.Token(Token = "0x60012F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F9D8", Offset = "0xA7F9D8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Negate(Matrix matrix)
		{
			throw null;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00024F9B File Offset: 0x0002319B
		[global::Cpp2ILInjected.Token(Token = "0x60012F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FA0C", Offset = "0xA7FA0C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Matrix matrix, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00024F9E File Offset: 0x0002319E
		[global::Cpp2ILInjected.Token(Token = "0x60012F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FA30", Offset = "0xA7FA30", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00024FA1 File Offset: 0x000231A1
		[global::Cpp2ILInjected.Token(Token = "0x60012F9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FB24", Offset = "0xA7FB24", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00024FA4 File Offset: 0x000231A4
		[global::Cpp2ILInjected.Token(Token = "0x60012FA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FB68", Offset = "0xA7FB68", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Transpose(Matrix matrix)
		{
			throw null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00024FA7 File Offset: 0x000231A7
		[global::Cpp2ILInjected.Token(Token = "0x60012FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FBAC", Offset = "0xA7FBAC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Transpose(ref Matrix matrix, out Matrix result)
		{
			throw null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00024FAA File Offset: 0x000231AA
		[global::Cpp2ILInjected.Token(Token = "0x60012FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FC30", Offset = "0xA7FC30", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float Determinant()
		{
			throw null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00024FAD File Offset: 0x000231AD
		[global::Cpp2ILInjected.Token(Token = "0x60012FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FCF0", Offset = "0xA7FCF0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Matrix other)
		{
			throw null;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00024FB0 File Offset: 0x000231B0
		[global::Cpp2ILInjected.Token(Token = "0x60012FE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FDFC", Offset = "0xA7FDFC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator +(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00024FB3 File Offset: 0x000231B3
		[global::Cpp2ILInjected.Token(Token = "0x60012FF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FEF0", Offset = "0xA7FEF0", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix operator /(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00024FB6 File Offset: 0x000231B6
		[global::Cpp2ILInjected.Token(Token = "0x6001300")]
		[global::Cpp2ILInjected.Address(RVA = "0xA800D4", Offset = "0xA800D4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator /(Matrix matrix1, float divider)
		{
			throw null;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00024FB9 File Offset: 0x000231B9
		[global::Cpp2ILInjected.Token(Token = "0x6001301")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80110", Offset = "0xA80110", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00024FBC File Offset: 0x000231BC
		[global::Cpp2ILInjected.Token(Token = "0x6001302")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8021C", Offset = "0xA8021C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00024FBF File Offset: 0x000231BF
		[global::Cpp2ILInjected.Token(Token = "0x6001303")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80328", Offset = "0xA80328", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public static Matrix operator *(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00024FC2 File Offset: 0x000231C2
		[global::Cpp2ILInjected.Token(Token = "0x6001304")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80434", Offset = "0xA80434", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator *(Matrix matrix, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00024FC5 File Offset: 0x000231C5
		[global::Cpp2ILInjected.Token(Token = "0x6001305")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80468", Offset = "0xA80468", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator *(float scaleFactor, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00024FC8 File Offset: 0x000231C8
		[global::Cpp2ILInjected.Token(Token = "0x6001306")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8049C", Offset = "0xA8049C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator -(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00024FCB File Offset: 0x000231CB
		[global::Cpp2ILInjected.Token(Token = "0x6001307")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80590", Offset = "0xA80590", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator -(Matrix matrix)
		{
			throw null;
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00024FCE File Offset: 0x000231CE
		[global::Cpp2ILInjected.Token(Token = "0x6001308")]
		[global::Cpp2ILInjected.Address(RVA = "0xA805C4", Offset = "0xA805C4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00024FD1 File Offset: 0x000231D1
		[global::Cpp2ILInjected.Token(Token = "0x6001309")]
		[global::Cpp2ILInjected.Address(RVA = "0xA806AC", Offset = "0xA806AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00024FD4 File Offset: 0x000231D4
		[global::Cpp2ILInjected.Token(Token = "0x600130A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA806E4", Offset = "0xA806E4", Length = "0x6A4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00024FD7 File Offset: 0x000231D7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600130B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80D88", Offset = "0xA80D88", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Matrix()
		{
			throw null;
		}

		// Token: 0x04001C78 RID: 7288
		[global::Cpp2ILInjected.Token(Token = "0x4002252")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float M11;

		// Token: 0x04001C79 RID: 7289
		[global::Cpp2ILInjected.Token(Token = "0x4002253")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float M12;

		// Token: 0x04001C7A RID: 7290
		[global::Cpp2ILInjected.Token(Token = "0x4002254")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float M13;

		// Token: 0x04001C7B RID: 7291
		[global::Cpp2ILInjected.Token(Token = "0x4002255")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float M14;

		// Token: 0x04001C7C RID: 7292
		[global::Cpp2ILInjected.Token(Token = "0x4002256")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float M21;

		// Token: 0x04001C7D RID: 7293
		[global::Cpp2ILInjected.Token(Token = "0x4002257")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float M22;

		// Token: 0x04001C7E RID: 7294
		[global::Cpp2ILInjected.Token(Token = "0x4002258")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float M23;

		// Token: 0x04001C7F RID: 7295
		[global::Cpp2ILInjected.Token(Token = "0x4002259")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float M24;

		// Token: 0x04001C80 RID: 7296
		[global::Cpp2ILInjected.Token(Token = "0x400225A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float M31;

		// Token: 0x04001C81 RID: 7297
		[global::Cpp2ILInjected.Token(Token = "0x400225B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float M32;

		// Token: 0x04001C82 RID: 7298
		[global::Cpp2ILInjected.Token(Token = "0x400225C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float M33;

		// Token: 0x04001C83 RID: 7299
		[global::Cpp2ILInjected.Token(Token = "0x400225D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float M34;

		// Token: 0x04001C84 RID: 7300
		[global::Cpp2ILInjected.Token(Token = "0x400225E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float M41;

		// Token: 0x04001C85 RID: 7301
		[global::Cpp2ILInjected.Token(Token = "0x400225F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float M42;

		// Token: 0x04001C86 RID: 7302
		[global::Cpp2ILInjected.Token(Token = "0x4002260")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public float M43;

		// Token: 0x04001C87 RID: 7303
		[global::Cpp2ILInjected.Token(Token = "0x4002261")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float M44;

		// Token: 0x04001C88 RID: 7304
		[global::Cpp2ILInjected.Token(Token = "0x4002262")]
		private static Matrix identity;
	}
}
