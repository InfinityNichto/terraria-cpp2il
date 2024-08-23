using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Pool;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000065 RID: 101
	[global::Cpp2ILInjected.Token(Token = "0x20000AF")]
	public static class ExecuteEvents
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00003058 File Offset: 0x00001258
		[global::Cpp2ILInjected.Token(Token = "0x600061B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1589184", Offset = "0x1589184", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IPointerMoveHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IPointerEnterHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IPointerExitHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IPointerDownHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IPointerUpHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IPointerClickHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IInitializePotentialDragHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IBeginDragHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IDragHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IEndDragHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IDropHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IScrollHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new object[]
		{
			typeof(IMoveHandler),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			throw null;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000305B File Offset: 0x0000125B
		[global::Cpp2ILInjected.Token(Token = "0x600061C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE62C0", Offset = "0x1FE62C0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IPointerMoveHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000305E File Offset: 0x0000125E
		[global::Cpp2ILInjected.Token(Token = "0x600061D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE63AC", Offset = "0x1FE63AC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00003061 File Offset: 0x00001261
		[global::Cpp2ILInjected.Token(Token = "0x600061E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6498", Offset = "0x1FE6498", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IPointerExitHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00003064 File Offset: 0x00001264
		[global::Cpp2ILInjected.Token(Token = "0x600061F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6584", Offset = "0x1FE6584", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IPointerDownHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00003067 File Offset: 0x00001267
		[global::Cpp2ILInjected.Token(Token = "0x6000620")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6670", Offset = "0x1FE6670", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IPointerUpHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000306A File Offset: 0x0000126A
		[global::Cpp2ILInjected.Token(Token = "0x6000621")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE675C", Offset = "0x1FE675C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IPointerClickHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000306D File Offset: 0x0000126D
		[global::Cpp2ILInjected.Token(Token = "0x6000622")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6848", Offset = "0x1FE6848", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00003070 File Offset: 0x00001270
		[global::Cpp2ILInjected.Token(Token = "0x6000623")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6934", Offset = "0x1FE6934", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IBeginDragHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00003073 File Offset: 0x00001273
		[global::Cpp2ILInjected.Token(Token = "0x6000624")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6A20", Offset = "0x1FE6A20", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IDragHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00003076 File Offset: 0x00001276
		[global::Cpp2ILInjected.Token(Token = "0x6000625")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6B0C", Offset = "0x1FE6B0C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IEndDragHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00003079 File Offset: 0x00001279
		[global::Cpp2ILInjected.Token(Token = "0x6000626")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6BF8", Offset = "0x1FE6BF8", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IDropHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000307C File Offset: 0x0000127C
		[global::Cpp2ILInjected.Token(Token = "0x6000627")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6CE4", Offset = "0x1FE6CE4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IScrollHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000307F File Offset: 0x0000127F
		[global::Cpp2ILInjected.Token(Token = "0x6000628")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6DD0", Offset = "0x1FE6DD0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00003082 File Offset: 0x00001282
		[global::Cpp2ILInjected.Token(Token = "0x6000629")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6E74", Offset = "0x1FE6E74", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void Execute(ISelectHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00003085 File Offset: 0x00001285
		[global::Cpp2ILInjected.Token(Token = "0x600062A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6F18", Offset = "0x1FE6F18", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void Execute(IDeselectHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00003088 File Offset: 0x00001288
		[global::Cpp2ILInjected.Token(Token = "0x600062B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6FBC", Offset = "0x1FE6FBC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Execute(IMoveHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000308B File Offset: 0x0000128B
		[global::Cpp2ILInjected.Token(Token = "0x600062C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE70A8", Offset = "0x1FE70A8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void Execute(ISubmitHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000308E File Offset: 0x0000128E
		[global::Cpp2ILInjected.Token(Token = "0x600062D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE714C", Offset = "0x1FE714C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void Execute(ICancelHandler handler, BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00003091 File Offset: 0x00001291
		[global::Cpp2ILInjected.Token(Token = "0x1700019A")]
		public static ExecuteEvents.EventFunction<IPointerMoveHandler> pointerMoveHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE71F0", Offset = "0x1FE71F0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00003094 File Offset: 0x00001294
		[global::Cpp2ILInjected.Token(Token = "0x1700019B")]
		public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7248", Offset = "0x1FE7248", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00003097 File Offset: 0x00001297
		[global::Cpp2ILInjected.Token(Token = "0x1700019C")]
		public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000630")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE72A0", Offset = "0x1FE72A0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0000309A File Offset: 0x0000129A
		[global::Cpp2ILInjected.Token(Token = "0x1700019D")]
		public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000631")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE72F8", Offset = "0x1FE72F8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0000309D File Offset: 0x0000129D
		[global::Cpp2ILInjected.Token(Token = "0x1700019E")]
		public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000632")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7350", Offset = "0x1FE7350", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000030A0 File Offset: 0x000012A0
		[global::Cpp2ILInjected.Token(Token = "0x1700019F")]
		public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000633")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE73A8", Offset = "0x1FE73A8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000030A3 File Offset: 0x000012A3
		[global::Cpp2ILInjected.Token(Token = "0x170001A0")]
		public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000634")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7400", Offset = "0x1FE7400", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x000030A6 File Offset: 0x000012A6
		[global::Cpp2ILInjected.Token(Token = "0x170001A1")]
		public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000635")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7458", Offset = "0x1FE7458", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000030A9 File Offset: 0x000012A9
		[global::Cpp2ILInjected.Token(Token = "0x170001A2")]
		public static ExecuteEvents.EventFunction<IDragHandler> dragHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000636")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE74B0", Offset = "0x1FE74B0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000030AC File Offset: 0x000012AC
		[global::Cpp2ILInjected.Token(Token = "0x170001A3")]
		public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000637")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7508", Offset = "0x1FE7508", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000030AF File Offset: 0x000012AF
		[global::Cpp2ILInjected.Token(Token = "0x170001A4")]
		public static ExecuteEvents.EventFunction<IDropHandler> dropHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000638")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7560", Offset = "0x1FE7560", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x000030B2 File Offset: 0x000012B2
		[global::Cpp2ILInjected.Token(Token = "0x170001A5")]
		public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000639")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE75B8", Offset = "0x1FE75B8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x000030B5 File Offset: 0x000012B5
		[global::Cpp2ILInjected.Token(Token = "0x170001A6")]
		public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600063A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7610", Offset = "0x1FE7610", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x000030B8 File Offset: 0x000012B8
		[global::Cpp2ILInjected.Token(Token = "0x170001A7")]
		public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600063B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7668", Offset = "0x1FE7668", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000030BB File Offset: 0x000012BB
		[global::Cpp2ILInjected.Token(Token = "0x170001A8")]
		public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600063C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE76C0", Offset = "0x1FE76C0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000030BE File Offset: 0x000012BE
		[global::Cpp2ILInjected.Token(Token = "0x170001A9")]
		public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600063D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7718", Offset = "0x1FE7718", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x000030C1 File Offset: 0x000012C1
		[global::Cpp2ILInjected.Token(Token = "0x170001AA")]
		public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600063E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7770", Offset = "0x1FE7770", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000030C4 File Offset: 0x000012C4
		[global::Cpp2ILInjected.Token(Token = "0x170001AB")]
		public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600063F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE77C8", Offset = "0x1FE77C8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000030C7 File Offset: 0x000012C7
		[global::Cpp2ILInjected.Token(Token = "0x6000640")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE7820", Offset = "0x1FE7820", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
			throw null;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000030CA File Offset: 0x000012CA
		[global::Cpp2ILInjected.Token(Token = "0x6000641")]
		[global::Cpp2ILInjected.Address(RVA = "0x1588794", Offset = "0x1588794", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "SendButtonEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "SendVectorEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "SendUpdateEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "ProcessDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "SendSubmitEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "SendMoveEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "SendUpdateEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "UpdateModule", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) where T : IEventSystemHandler
		{
			throw null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000030CD File Offset: 0x000012CD
		[global::Cpp2ILInjected.Token(Token = "0x6000642")]
		[global::Cpp2ILInjected.Address(RVA = "0x1588B38", Offset = "0x1588B38", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventChain", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(IList<Transform>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) where T : IEventSystemHandler
		{
			throw null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000030D0 File Offset: 0x000012D0
		[global::Cpp2ILInjected.Token(Token = "0x6000643")]
		[global::Cpp2ILInjected.Address(RVA = "0x1589090", Offset = "0x1589090", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool ShouldSendToComponent<T>(Component component) where T : IEventSystemHandler
		{
			throw null;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000030D3 File Offset: 0x000012D3
		[global::Cpp2ILInjected.Token(Token = "0x6000644")]
		[global::Cpp2ILInjected.Address(RVA = "0x1588DA4", Offset = "0x1588DA4", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) where T : IEventSystemHandler
		{
			throw null;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000030D6 File Offset: 0x000012D6
		[global::Cpp2ILInjected.Token(Token = "0x6000645")]
		[global::Cpp2ILInjected.Address(RVA = "0x15886A0", Offset = "0x15886A0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool CanHandleEvent<T>(GameObject go) where T : IEventSystemHandler
		{
			throw null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000030D9 File Offset: 0x000012D9
		[global::Cpp2ILInjected.Token(Token = "0x6000646")]
		[global::Cpp2ILInjected.Address(RVA = "0x1588C84", Offset = "0x1588C84", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMove", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler
		{
			throw null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000030DC File Offset: 0x000012DC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000647")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE79A4", Offset = "0x1FE79A4", Length = "0x648")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents.EventFunction<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		static ExecuteEvents()
		{
			throw null;
		}

		// Token: 0x040001EA RID: 490
		[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
		private static readonly ExecuteEvents.EventFunction<IPointerMoveHandler> s_PointerMoveHandler;

		// Token: 0x040001EB RID: 491
		[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
		private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler;

		// Token: 0x040001EC RID: 492
		[global::Cpp2ILInjected.Token(Token = "0x40002D8")]
		private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler;

		// Token: 0x040001ED RID: 493
		[global::Cpp2ILInjected.Token(Token = "0x40002D9")]
		private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler;

		// Token: 0x040001EE RID: 494
		[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
		private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler;

		// Token: 0x040001EF RID: 495
		[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
		private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler;

		// Token: 0x040001F0 RID: 496
		[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
		private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler;

		// Token: 0x040001F1 RID: 497
		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler;

		// Token: 0x040001F2 RID: 498
		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler;

		// Token: 0x040001F3 RID: 499
		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler;

		// Token: 0x040001F4 RID: 500
		[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
		private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler;

		// Token: 0x040001F5 RID: 501
		[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
		private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler;

		// Token: 0x040001F6 RID: 502
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler;

		// Token: 0x040001F7 RID: 503
		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler;

		// Token: 0x040001F8 RID: 504
		[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
		private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler;

		// Token: 0x040001F9 RID: 505
		[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
		private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler;

		// Token: 0x040001FA RID: 506
		[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
		private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler;

		// Token: 0x040001FB RID: 507
		[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
		private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler;

		// Token: 0x040001FC RID: 508
		[global::Cpp2ILInjected.Token(Token = "0x40002E8")]
		private static readonly List<Transform> s_InternalTransformList;

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x060006F0 RID: 1776
		[global::Cpp2ILInjected.Token(Token = "0x20000B0")]
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData);
	}
}
