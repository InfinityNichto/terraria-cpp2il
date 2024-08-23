using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004A RID: 74
	[global::Cpp2ILInjected.Token(Token = "0x2000090")]
	public class AxisEventData : BaseEventData
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00002EC3 File Offset: 0x000010C3
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00002EC6 File Offset: 0x000010C6
		[global::Cpp2ILInjected.Token(Token = "0x17000169")]
		public Vector2 moveVector
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000580")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE3894", Offset = "0x1FE3894", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000581")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE389C", Offset = "0x1FE389C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00002EC9 File Offset: 0x000010C9
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00002ECC File Offset: 0x000010CC
		[global::Cpp2ILInjected.Token(Token = "0x1700016A")]
		public MoveDirection moveDir
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000582")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE38A4", Offset = "0x1FE38A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000583")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE38AC", Offset = "0x1FE38AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002ECF File Offset: 0x000010CF
		[global::Cpp2ILInjected.Token(Token = "0x6000584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE38B4", Offset = "0x1FE38B4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseInputModule), Member = "GetAxisEventData", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(AxisEventData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AxisEventData(EventSystem eventSystem)
		{
			throw null;
		}

		// Token: 0x040001A6 RID: 422
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000287")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Vector2 <moveVector>k__BackingField;

		// Token: 0x040001A7 RID: 423
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000288")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private MoveDirection <moveDir>k__BackingField;
	}
}
