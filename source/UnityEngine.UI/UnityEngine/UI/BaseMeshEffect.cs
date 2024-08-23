using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003F RID: 63
	[ExecuteAlways]
	[global::Cpp2ILInjected.Token(Token = "0x2000081")]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00002DDF File Offset: 0x00000FDF
		[global::Cpp2ILInjected.Token(Token = "0x17000154")]
		protected Graphic graphic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000524")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE1A08", Offset = "0x1FE1A08", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseMeshEffect), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseMeshEffect), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseMeshEffect), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = "set_effectColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = "set_effectDistance", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = "set_useGraphicAlpha", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002DE2 File Offset: 0x00000FE2
		[global::Cpp2ILInjected.Token(Token = "0x6000525")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1A9C", Offset = "0x1FE1A9C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002DE5 File Offset: 0x00000FE5
		[global::Cpp2ILInjected.Token(Token = "0x6000526")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1B3C", Offset = "0x1FE1B3C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002DE8 File Offset: 0x00000FE8
		[global::Cpp2ILInjected.Token(Token = "0x6000527")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1BD0", Offset = "0x1FE1BD0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002DEB File Offset: 0x00000FEB
		[global::Cpp2ILInjected.Token(Token = "0x6000528")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1C64", Offset = "0x1FE1C64", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = ".ctor", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual void ModifyMesh(Mesh mesh)
		{
			throw null;
		}

		// Token: 0x060004A8 RID: 1192
		[global::Cpp2ILInjected.Token(Token = "0x6000529")]
		public abstract void ModifyMesh(VertexHelper vh);

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002DEE File Offset: 0x00000FEE
		[global::Cpp2ILInjected.Token(Token = "0x600052A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1E10", Offset = "0x1FE1E10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PositionAsUV1), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected BaseMeshEffect()
		{
			throw null;
		}

		// Token: 0x04000191 RID: 401
		[global::Cpp2ILInjected.Token(Token = "0x400026A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private Graphic m_Graphic;
	}
}
