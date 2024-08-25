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
	[global::Cpp2ILInjected.Token(Token = "0x200032A")]
	[Serializable]
	public struct Matrix : IEquatable<Matrix>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60012B8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C270", Offset = "0xA7C270", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012BD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7C67C", Offset = "0xA7C67C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateReflection", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = "Normalize", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(Plane))]
		public static void CreateReflection(ref Plane value, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012C4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D1FC", Offset = "0xA7D1FC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Add(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012C5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D2F0", Offset = "0xA7D2F0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012C8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D5B4", Offset = "0xA7D5B4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012C9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D5EC", Offset = "0xA7D5EC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012CA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D624", Offset = "0xA7D624", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateFromAxisAngle(Vector3 axis, float angle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012CB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D65C", Offset = "0xA7D65C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012D0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7D97C", Offset = "0xA7D97C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012D1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DA34", Offset = "0xA7DA34", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012D3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DB6C", Offset = "0xA7DB6C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012D4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DBD4", Offset = "0xA7DBD4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreatePerspective(float width, float height, float zNearPlane, float zFarPlane)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012D5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DC0C", Offset = "0xA7DC0C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreatePerspective(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012D8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DED0", Offset = "0xA7DED0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012D9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7DF08", Offset = "0xA7DF08", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012DB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E090", Offset = "0xA7E090", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CreateRotationX(float radians, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012DD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E300", Offset = "0xA7E300", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CreateRotationY(float radians, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E534", Offset = "0xA7E534", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CreateRotationZ(float radians, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012E1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E72C", Offset = "0xA7E72C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateScale(float scale, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012E3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E8EC", Offset = "0xA7E8EC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012E4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7E9AC", Offset = "0xA7E9AC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateScale(Vector3 scales)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012E5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EABC", Offset = "0xA7EABC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateScale(ref Vector3 scales, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012E6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EB78", Offset = "0xA7EB78", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012E7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EC3C", Offset = "0xA7EC3C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateTranslation(float xPosition, float yPosition, float zPosition, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012E8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7ECF8", Offset = "0xA7ECF8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix CreateTranslation(Vector3 position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012E9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7EDBC", Offset = "0xA7EDBC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CreateTranslation(ref Vector3 position, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012EB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F0CC", Offset = "0xA7F0CC", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012EC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F3D8", Offset = "0xA7F3D8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Divide(Matrix matrix1, float divider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012ED")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F414", Offset = "0xA7F414", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Matrix matrix1, float divider, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012EF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F450", Offset = "0xA7F450", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Invert(ref Matrix matrix, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F7F4", Offset = "0xA7F7F4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F82C", Offset = "0xA7F82C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Lerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012F4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F970", Offset = "0xA7F970", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Multiply(Matrix matrix1, float factor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F9A4", Offset = "0xA7F9A4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Matrix matrix1, float factor, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7F9D8", Offset = "0xA7F9D8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Negate(Matrix matrix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FA0C", Offset = "0xA7FA0C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Matrix matrix, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FA30", Offset = "0xA7FA30", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FB24", Offset = "0xA7FB24", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012FA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FB68", Offset = "0xA7FB68", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix Transpose(Matrix matrix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FBAC", Offset = "0xA7FBAC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Transpose(ref Matrix matrix, out Matrix result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FC30", Offset = "0xA7FC30", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float Determinant()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FCF0", Offset = "0xA7FCF0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Matrix other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012FE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7FDFC", Offset = "0xA7FDFC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator +(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001300")]
		[global::Cpp2ILInjected.Address(RVA = "0xA800D4", Offset = "0xA800D4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator /(Matrix matrix1, float divider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001301")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80110", Offset = "0xA80110", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001302")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8021C", Offset = "0xA8021C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001304")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80434", Offset = "0xA80434", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator *(Matrix matrix, float scaleFactor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001305")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80468", Offset = "0xA80468", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator *(float scaleFactor, Matrix matrix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001306")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8049C", Offset = "0xA8049C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator -(Matrix matrix1, Matrix matrix2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001307")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80590", Offset = "0xA80590", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Matrix operator -(Matrix matrix)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001309")]
		[global::Cpp2ILInjected.Address(RVA = "0xA806AC", Offset = "0xA806AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int GetHashCode()
		{
			throw null;
		}

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

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600130B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA80D88", Offset = "0xA80D88", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Matrix()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002252")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float M11;

		[global::Cpp2ILInjected.Token(Token = "0x4002253")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float M12;

		[global::Cpp2ILInjected.Token(Token = "0x4002254")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float M13;

		[global::Cpp2ILInjected.Token(Token = "0x4002255")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float M14;

		[global::Cpp2ILInjected.Token(Token = "0x4002256")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float M21;

		[global::Cpp2ILInjected.Token(Token = "0x4002257")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float M22;

		[global::Cpp2ILInjected.Token(Token = "0x4002258")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float M23;

		[global::Cpp2ILInjected.Token(Token = "0x4002259")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float M24;

		[global::Cpp2ILInjected.Token(Token = "0x400225A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float M31;

		[global::Cpp2ILInjected.Token(Token = "0x400225B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float M32;

		[global::Cpp2ILInjected.Token(Token = "0x400225C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float M33;

		[global::Cpp2ILInjected.Token(Token = "0x400225D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float M34;

		[global::Cpp2ILInjected.Token(Token = "0x400225E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float M41;

		[global::Cpp2ILInjected.Token(Token = "0x400225F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float M42;

		[global::Cpp2ILInjected.Token(Token = "0x4002260")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public float M43;

		[global::Cpp2ILInjected.Token(Token = "0x4002261")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float M44;

		[global::Cpp2ILInjected.Token(Token = "0x4002262")]
		private static Matrix identity;
	}
}
