using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x02000044 RID: 68
	[AddComponentMenu("UI/Effects/Shadow", 80)]
	[global::Cpp2ILInjected.Token(Token = "0x2000086")]
	public class Shadow : BaseMeshEffect
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x00002DFD File Offset: 0x00000FFD
		[global::Cpp2ILInjected.Token(Token = "0x6000532")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE2B10", Offset = "0x1FE2B10", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Outline), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseMeshEffect), Member = ".ctor", ReturnType = typeof(void))]
		protected Shadow()
		{
			throw null;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00002E00 File Offset: 0x00001000
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00002E03 File Offset: 0x00001003
		[global::Cpp2ILInjected.Token(Token = "0x17000155")]
		public Color effectColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000533")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE2B38", Offset = "0x1FE2B38", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000534")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE2B44", Offset = "0x1FE2B44", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00002E06 File Offset: 0x00001006
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00002E09 File Offset: 0x00001009
		[global::Cpp2ILInjected.Token(Token = "0x17000156")]
		public Vector2 effectDistance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000535")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE2C10", Offset = "0x1FE2C10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000536")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE2C18", Offset = "0x1FE2C18", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00002E0C File Offset: 0x0000100C
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00002E0F File Offset: 0x0000100F
		[global::Cpp2ILInjected.Token(Token = "0x17000157")]
		public bool useGraphicAlpha
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000537")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE2D14", Offset = "0x1FE2D14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000538")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE2D1C", Offset = "0x1FE2D1C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002E12 File Offset: 0x00001012
		[global::Cpp2ILInjected.Token(Token = "0x6000539")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE2DCC", Offset = "0x1FE2DCC", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = "ApplyShadow", MemberParameters = new object[]
		{
			typeof(List<UIVertex>),
			typeof(Color32),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UIVertex>), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UIVertex>), Member = "set_Capacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UIVertex>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UIVertex>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(UIVertex)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			throw null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002E15 File Offset: 0x00001015
		[global::Cpp2ILInjected.Token(Token = "0x600053A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE30CC", Offset = "0x1FE30CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shadow), Member = "ApplyShadowZeroAlloc", MemberParameters = new object[]
		{
			typeof(List<UIVertex>),
			typeof(Color32),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			throw null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002E18 File Offset: 0x00001018
		[global::Cpp2ILInjected.Token(Token = "0x600053B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE30D4", Offset = "0x1FE30D4", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, UIVertex>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "GetUIVertexStream", MemberParameters = new object[] { typeof(List<UIVertex>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shadow), Member = "ApplyShadowZeroAlloc", MemberParameters = new object[]
		{
			typeof(List<UIVertex>),
			typeof(Color32),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddUIVertexTriangleStream", MemberParameters = new object[] { typeof(List<UIVertex>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, UIVertex>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void ModifyMesh(VertexHelper vh)
		{
			throw null;
		}

		// Token: 0x04000192 RID: 402
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400026B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Color m_EffectColor;

		// Token: 0x04000193 RID: 403
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400026C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Vector2 m_EffectDistance;

		// Token: 0x04000194 RID: 404
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool m_UseGraphicAlpha;

		// Token: 0x04000195 RID: 405
		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		private const float kMaxEffectDistance = 600f;
	}
}
