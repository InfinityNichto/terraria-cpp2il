using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000015 RID: 21
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	public class XObjectChangeEventArgs : EventArgs
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000222D File Offset: 0x0000042D
		[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6EE54", Offset = "0x1D6EE54", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XObjectChangeEventArgs), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XObjectChangeEventArgs(XObjectChange objectChange)
		{
			throw null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002230 File Offset: 0x00000430
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6EEC0", Offset = "0x1D6EEC0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObjectChangeEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(XObjectChange) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static XObjectChangeEventArgs()
		{
			throw null;
		}

		// Token: 0x0400002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XObjectChange _objectChange;

		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		public static readonly XObjectChangeEventArgs Add;

		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		public static readonly XObjectChangeEventArgs Remove;

		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		public static readonly XObjectChangeEventArgs Name;

		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		public static readonly XObjectChangeEventArgs Value;
	}
}
