using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000070 RID: 112
	[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
	public struct RaycastResult
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0000326E File Offset: 0x0000146E
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00003271 File Offset: 0x00001471
		[global::Cpp2ILInjected.Token(Token = "0x170001CF")]
		public GameObject gameObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE724", Offset = "0x1FEE724", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE72C", Offset = "0x1FEE72C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00003274 File Offset: 0x00001474
		[global::Cpp2ILInjected.Token(Token = "0x170001D0")]
		public bool isValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE734", Offset = "0x1FEE734", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RaycastResult), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00003277 File Offset: 0x00001477
		[global::Cpp2ILInjected.Token(Token = "0x60006E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEE7CC", Offset = "0x1FEE7CC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000327A File Offset: 0x0000147A
		[global::Cpp2ILInjected.Token(Token = "0x60006E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE46C8", Offset = "0x1FE46C8", Length = "0x5AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerEventData), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycastResult), Member = "get_isValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400022B RID: 555
		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private GameObject m_GameObject;

		// Token: 0x0400022C RID: 556
		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public BaseRaycaster module;

		// Token: 0x0400022D RID: 557
		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float distance;

		// Token: 0x0400022E RID: 558
		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float index;

		// Token: 0x0400022F RID: 559
		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int depth;

		// Token: 0x04000230 RID: 560
		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int sortingLayer;

		// Token: 0x04000231 RID: 561
		[global::Cpp2ILInjected.Token(Token = "0x4000326")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int sortingOrder;

		// Token: 0x04000232 RID: 562
		[global::Cpp2ILInjected.Token(Token = "0x4000327")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Vector3 worldPosition;

		// Token: 0x04000233 RID: 563
		[global::Cpp2ILInjected.Token(Token = "0x4000328")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Vector3 worldNormal;

		// Token: 0x04000234 RID: 564
		[global::Cpp2ILInjected.Token(Token = "0x4000329")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public Vector2 screenPosition;

		// Token: 0x04000235 RID: 565
		[global::Cpp2ILInjected.Token(Token = "0x400032A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int displayIndex;
	}
}
