using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000030 RID: 48
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/Raw Image", 12)]
	[global::Cpp2ILInjected.Token(Token = "0x200005C")]
	public class RawImage : MaskableGraphic
	{
		// Token: 0x06000314 RID: 788 RVA: 0x00002935 File Offset: 0x00000B35
		[global::Cpp2ILInjected.Token(Token = "0x600036E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD0340", Offset = "0x1FD0340", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
		protected RawImage()
		{
			throw null;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00002938 File Offset: 0x00000B38
		[global::Cpp2ILInjected.Token(Token = "0x170000E3")]
		public override Texture mainTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x600036F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD0390", Offset = "0x1FD0390", Length = "0x14C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000293B File Offset: 0x00000B3B
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0000293E File Offset: 0x00000B3E
		[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
		public Texture texture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000370")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD04DC", Offset = "0x1FD04DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000371")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD04E4", Offset = "0x1FD04E4", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00002941 File Offset: 0x00000B41
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00002944 File Offset: 0x00000B44
		[global::Cpp2ILInjected.Token(Token = "0x170000E5")]
		public Rect uvRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000372")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD0590", Offset = "0x1FD0590", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000373")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD059C", Offset = "0x1FD059C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Rect)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002947 File Offset: 0x00000B47
		[global::Cpp2ILInjected.Token(Token = "0x6000374")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD061C", Offset = "0x1FD061C", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void SetNativeSize()
		{
			throw null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000294A File Offset: 0x00000B4A
		[global::Cpp2ILInjected.Token(Token = "0x6000375")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD08E8", Offset = "0x1FD08E8", Length = "0xCEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "get_texelSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			throw null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000294D File Offset: 0x00000B4D
		[global::Cpp2ILInjected.Token(Token = "0x6000376")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD1964", Offset = "0x1FD1964", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x0400010C RID: 268
		[SerializeField]
		[FormerlySerializedAs("m_Tex")]
		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Texture m_Texture;

		// Token: 0x0400010D RID: 269
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private Rect m_UVRect;
	}
}
