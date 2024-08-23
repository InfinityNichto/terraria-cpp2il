using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Sprites;

namespace UnityEngine
{
	// Token: 0x020000D2 RID: 210
	[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
	[ExcludeFromPreset]
	[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[NativeType("Runtime/Graphics/SpriteFrame.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000E9")]
	public sealed class Sprite : Object
	{
		// Token: 0x060004D4 RID: 1236 RVA: 0x00002A9D File Offset: 0x00000C9D
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86ED4", Offset = "0x1F86ED4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Sprite()
		{
			throw null;
		}

		// Token: 0x060004D5 RID: 1237
		[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86F2C", Offset = "0x1F86F2C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal extern int GetPackingMode();

		// Token: 0x060004D6 RID: 1238
		[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86F68", Offset = "0x1F86F68", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal extern int GetPacked();

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002AA0 File Offset: 0x00000CA0
		[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86FA4", Offset = "0x1F86FA4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Sprite), Member = "get_textureRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Rect GetTextureRect()
		{
			throw null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002AA3 File Offset: 0x00000CA3
		[global::Cpp2ILInjected.Token(Token = "0x60004F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87040", Offset = "0x1F87040", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Vector4 GetInnerUVs()
		{
			throw null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002AA6 File Offset: 0x00000CA6
		[global::Cpp2ILInjected.Token(Token = "0x60004F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F870DC", Offset = "0x1F870DC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Vector4 GetOuterUVs()
		{
			throw null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002AA9 File Offset: 0x00000CA9
		[global::Cpp2ILInjected.Token(Token = "0x60004F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87178", Offset = "0x1F87178", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Vector4 GetPadding()
		{
			throw null;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00002AAC File Offset: 0x00000CAC
		[global::Cpp2ILInjected.Token(Token = "0x17000102")]
		public Bounds bounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F87214", Offset = "0x1F87214", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00002AAF File Offset: 0x00000CAF
		[global::Cpp2ILInjected.Token(Token = "0x17000103")]
		public Rect rect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F872C0", Offset = "0x1F872C0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "ScaleSpriteInPixels", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "SetNativeSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredWidth", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredHeight", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Rect)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00002AB2 File Offset: 0x00000CB2
		[global::Cpp2ILInjected.Token(Token = "0x17000104")]
		public Vector4 border
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8735C", Offset = "0x1F8735C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_hasBorder", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Rect)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004DE RID: 1246
		[global::Cpp2ILInjected.Token(Token = "0x17000105")]
		public extern Texture2D texture
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F873F8", Offset = "0x1F873F8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackSprite", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004DF RID: 1247
		[global::Cpp2ILInjected.Token(Token = "0x17000106")]
		public extern float pixelsPerUnit
		{
			[NativeMethod("GetPixelsToUnits")]
			[global::Cpp2ILInjected.Token(Token = "0x60004FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F87434", Offset = "0x1F87434", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004E0 RID: 1248
		[global::Cpp2ILInjected.Token(Token = "0x17000107")]
		public extern Texture2D associatedAlphaSplitTexture
		{
			[NativeMethod("GetAlphaTexture")]
			[global::Cpp2ILInjected.Token(Token = "0x60004FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F87470", Offset = "0x1F87470", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_material", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00002AB5 File Offset: 0x00000CB5
		[global::Cpp2ILInjected.Token(Token = "0x17000108")]
		public Vector2 pivot
		{
			[NativeMethod("GetPivotInPixels")]
			[global::Cpp2ILInjected.Token(Token = "0x60004FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F874AC", Offset = "0x1F874AC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00002AB8 File Offset: 0x00000CB8
		[global::Cpp2ILInjected.Token(Token = "0x17000109")]
		public bool packed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000500")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8753C", Offset = "0x1F8753C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00002ABB File Offset: 0x00000CBB
		[global::Cpp2ILInjected.Token(Token = "0x1700010A")]
		public SpritePackingMode packingMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000501")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F87584", Offset = "0x1F87584", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00002ABE File Offset: 0x00000CBE
		[global::Cpp2ILInjected.Token(Token = "0x1700010B")]
		public Rect textureRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000502")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F875C0", Offset = "0x1F875C0", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "GetTextureRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_zero", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004E5 RID: 1253
		[global::Cpp2ILInjected.Token(Token = "0x1700010C")]
		public extern Vector2[] vertices
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x6000503")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8764C", Offset = "0x1F8764C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004E6 RID: 1254
		[global::Cpp2ILInjected.Token(Token = "0x1700010D")]
		public extern ushort[] triangles
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x6000504")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F87688", Offset = "0x1F87688", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004E7 RID: 1255
		[global::Cpp2ILInjected.Token(Token = "0x1700010E")]
		public extern Vector2[] uv
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x6000505")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F876C4", Offset = "0x1F876C4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x060004E8 RID: 1256
		[global::Cpp2ILInjected.Token(Token = "0x6000506")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86FFC", Offset = "0x1F86FFC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetTextureRect_Injected(out Rect ret);

		// Token: 0x060004E9 RID: 1257
		[global::Cpp2ILInjected.Token(Token = "0x6000507")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87098", Offset = "0x1F87098", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetInnerUVs_Injected(out Vector4 ret);

		// Token: 0x060004EA RID: 1258
		[global::Cpp2ILInjected.Token(Token = "0x6000508")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87134", Offset = "0x1F87134", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetOuterUVs_Injected(out Vector4 ret);

		// Token: 0x060004EB RID: 1259
		[global::Cpp2ILInjected.Token(Token = "0x6000509")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F871D0", Offset = "0x1F871D0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetPadding_Injected(out Vector4 ret);

		// Token: 0x060004EC RID: 1260
		[global::Cpp2ILInjected.Token(Token = "0x600050A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8727C", Offset = "0x1F8727C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_bounds_Injected(out Bounds ret);

		// Token: 0x060004ED RID: 1261
		[global::Cpp2ILInjected.Token(Token = "0x600050B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87318", Offset = "0x1F87318", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_rect_Injected(out Rect ret);

		// Token: 0x060004EE RID: 1262
		[global::Cpp2ILInjected.Token(Token = "0x600050C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F873B4", Offset = "0x1F873B4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_border_Injected(out Vector4 ret);

		// Token: 0x060004EF RID: 1263
		[global::Cpp2ILInjected.Token(Token = "0x600050D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F874F8", Offset = "0x1F874F8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_pivot_Injected(out Vector2 ret);
	}
}
