using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200004C RID: 76
	[global::Cpp2ILInjected.Token(Token = "0x2000056")]
	public class TouchPool
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00002C27 File Offset: 0x00000E27
		[global::Cpp2ILInjected.Token(Token = "0x600040C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A42F4", Offset = "0x19A42F4", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "CreateTouches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchPool), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public TouchPool(int capacity)
		{
			throw null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002C2A File Offset: 0x00000E2A
		[global::Cpp2ILInjected.Token(Token = "0x600040D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A30D8", Offset = "0x19A30D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchPool), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public TouchPool()
		{
			throw null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002C2D File Offset: 0x00000E2D
		[global::Cpp2ILInjected.Token(Token = "0x600040E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A3198", Offset = "0x19A3198", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "UpdateTouches", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchPool), Member = "NewTouch", ReturnType = typeof(Touch))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Touch FindOrCreateTouch(int fingerId)
		{
			throw null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002C30 File Offset: 0x00000E30
		[global::Cpp2ILInjected.Token(Token = "0x600040F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A3A48", Offset = "0x19A3A48", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Touch FindTouch(int fingerId)
		{
			throw null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002C33 File Offset: 0x00000E33
		[global::Cpp2ILInjected.Token(Token = "0x6000410")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A44B0", Offset = "0x19A44B0", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchPool), Member = "FindOrCreateTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Touch))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Touch NewTouch()
		{
			throw null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002C36 File Offset: 0x00000E36
		[global::Cpp2ILInjected.Token(Token = "0x6000411")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A4584", Offset = "0x19A4584", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void FreeTouch(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002C39 File Offset: 0x00000E39
		[global::Cpp2ILInjected.Token(Token = "0x6000412")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A30E0", Offset = "0x19A30E0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "UpdateTouches", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void FreeEndedTouches()
		{
			throw null;
		}

		// Token: 0x04000365 RID: 869
		[global::Cpp2ILInjected.Token(Token = "0x40003B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly ReadOnlyCollection<Touch> Touches;

		// Token: 0x04000366 RID: 870
		[global::Cpp2ILInjected.Token(Token = "0x40003B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<Touch> usedTouches;

		// Token: 0x04000367 RID: 871
		[global::Cpp2ILInjected.Token(Token = "0x40003B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Touch> freeTouches;
	}
}
