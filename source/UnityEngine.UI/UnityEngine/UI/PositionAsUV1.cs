using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI
{
	// Token: 0x02000043 RID: 67
	[AddComponentMenu("UI/Effects/Position As UV1", 82)]
	[global::Cpp2ILInjected.Token(Token = "0x2000085")]
	public class PositionAsUV1 : BaseMeshEffect
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00002DF7 File Offset: 0x00000FF7
		[global::Cpp2ILInjected.Token(Token = "0x6000530")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE2A54", Offset = "0x1FE2A54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseMeshEffect), Member = ".ctor", ReturnType = typeof(void))]
		protected PositionAsUV1()
		{
			throw null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002DFA File Offset: 0x00000FFA
		[global::Cpp2ILInjected.Token(Token = "0x6000531")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE2A5C", Offset = "0x1FE2A5C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "PopulateUIVertex", MemberParameters = new object[]
		{
			typeof(ref UIVertex),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "SetUIVertex", MemberParameters = new object[]
		{
			typeof(UIVertex),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void ModifyMesh(VertexHelper vh)
		{
			throw null;
		}
	}
}
