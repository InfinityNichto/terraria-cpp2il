using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x02000042 RID: 66
	[AddComponentMenu("UI/Effects/Outline", 81)]
	[global::Cpp2ILInjected.Token(Token = "0x2000084")]
	public class Outline : Shadow
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x00002DF1 File Offset: 0x00000FF1
		[global::Cpp2ILInjected.Token(Token = "0x600052E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1E18", Offset = "0x1FE1E18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shadow), Member = ".ctor", ReturnType = typeof(void))]
		protected Outline()
		{
			throw null;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002DF4 File Offset: 0x00000FF4
		[global::Cpp2ILInjected.Token(Token = "0x600052F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1E20", Offset = "0x1FE1E20", Length = "0xC34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, UIVertex>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "GetUIVertexStream", MemberParameters = new object[] { typeof(List<UIVertex>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UIVertex>), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UIVertex>), Member = "set_Capacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override void ModifyMesh(VertexHelper vh)
		{
			throw null;
		}
	}
}
