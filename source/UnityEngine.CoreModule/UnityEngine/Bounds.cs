using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000079 RID: 121
	[NativeHeader("Runtime/Geometry/AABB.h")]
	[NativeClass("AABB")]
	[NativeType(Header = "Runtime/Geometry/AABB.h")]
	[NativeHeader("Runtime/Geometry/Ray.h")]
	[NativeHeader("Runtime/Geometry/Intersection.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000086")]
	public struct Bounds : IEquatable<Bounds>, IFormattable
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0000247C File Offset: 0x0000067C
		[global::Cpp2ILInjected.Token(Token = "0x6000240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77B00", Offset = "0x1F77B00", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<Vector3>",
			"System.Collections.Generic.List`1<Vector2>",
			"System.Collections.Generic.List`1<Vector4>",
			"System.Collections.Generic.List`1<Color32>",
			"System.Collections.Generic.List`1<Int32>",
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector3",
			"Microsoft.Xna.Framework.Vector3",
			"System.Collections.Generic.List`1<Material>",
			"System.Collections.Generic.List`1<SubMeshDescriptor>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetLayoutVertical", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "InternalGetBounds", MemberParameters = new object[]
		{
			"UnityEngine.Vector3[]",
			typeof(ref Matrix4x4)
		}, ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public Bounds(Vector3 center, Vector3 size)
		{
			throw null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000247F File Offset: 0x0000067F
		[global::Cpp2ILInjected.Token(Token = "0x6000241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77B20", Offset = "0x1F77B20", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002482 File Offset: 0x00000682
		[global::Cpp2ILInjected.Token(Token = "0x6000242")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77C08", Offset = "0x1F77C08", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002485 File Offset: 0x00000685
		[global::Cpp2ILInjected.Token(Token = "0x6000243")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77CD8", Offset = "0x1F77CD8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Bounds other)
		{
			throw null;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002488 File Offset: 0x00000688
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0000248B File Offset: 0x0000068B
		[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
		public Vector3 center
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000244")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77BF0", Offset = "0x1F77BF0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000245")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77D44", Offset = "0x1F77D44", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000248E File Offset: 0x0000068E
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002491 File Offset: 0x00000691
		[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
		public Vector3 size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000246")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77D50", Offset = "0x1F77D50", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "ScaleSpriteInPixels", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "ScaleSpriteInPercent", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "OnDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbars", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetNormalizedPosition", MemberParameters = new object[]
			{
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "AdjustBounds", MemberParameters = new object[]
			{
				typeof(ref Bounds),
				typeof(ref Vector2),
				typeof(ref Vector3),
				typeof(ref Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000247")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77D68", Offset = "0x1F77D68", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002494 File Offset: 0x00000694
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002497 File Offset: 0x00000697
		[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
		public Vector3 extents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000248")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77BFC", Offset = "0x1F77BFC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000249")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77D84", Offset = "0x1F77D84", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000249A File Offset: 0x0000069A
		[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
		public Vector3 min
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77D90", Offset = "0x1F77D90", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetNormalizedPosition", MemberParameters = new object[]
			{
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "InternalCalculateOffset", MemberParameters = new object[]
			{
				typeof(ref Bounds),
				typeof(ref Bounds),
				typeof(bool),
				typeof(bool),
				"UnityEngine.UI.ScrollRect.MovementType",
				typeof(ref Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000249D File Offset: 0x0000069D
		[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
		public Vector3 max
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77DB0", Offset = "0x1F77DB0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "InternalCalculateOffset", MemberParameters = new object[]
			{
				typeof(ref Bounds),
				typeof(ref Bounds),
				typeof(bool),
				typeof(bool),
				"UnityEngine.UI.ScrollRect.MovementType",
				typeof(ref Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000024A0 File Offset: 0x000006A0
		[global::Cpp2ILInjected.Token(Token = "0x600024C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77DD0", Offset = "0x1F77DD0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bounds), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Bounds),
			typeof(Bounds)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			throw null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000024A3 File Offset: 0x000006A3
		[global::Cpp2ILInjected.Token(Token = "0x600024D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77E4C", Offset = "0x1F77E4C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Bounds),
			typeof(Bounds)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			throw null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000024A6 File Offset: 0x000006A6
		[global::Cpp2ILInjected.Token(Token = "0x600024E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77E94", Offset = "0x1F77E94", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetMinMax(Vector3 min, Vector3 max)
		{
			throw null;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000024A9 File Offset: 0x000006A9
		[global::Cpp2ILInjected.Token(Token = "0x600024F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77ECC", Offset = "0x1F77ECC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "InternalGetBounds", MemberParameters = new object[]
		{
			"UnityEngine.Vector3[]",
			typeof(ref Matrix4x4)
		}, ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Encapsulate(Vector3 point)
		{
			throw null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000024AC File Offset: 0x000006AC
		[global::Cpp2ILInjected.Token(Token = "0x6000250")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77F44", Offset = "0x1F77F44", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000024AF File Offset: 0x000006AF
		[global::Cpp2ILInjected.Token(Token = "0x6000251")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77F50", Offset = "0x1F77F50", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x040002EE RID: 750
		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Vector3 m_Center;

		// Token: 0x040002EF RID: 751
		[NativeName("m_Extent")]
		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private Vector3 m_Extents;
	}
}
