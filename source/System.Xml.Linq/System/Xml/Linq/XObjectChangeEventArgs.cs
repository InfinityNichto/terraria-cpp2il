using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	public class XObjectChangeEventArgs : EventArgs
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XObjectChange _objectChange;

		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		public static readonly XObjectChangeEventArgs Add;

		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		public static readonly XObjectChangeEventArgs Remove;

		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		public static readonly XObjectChangeEventArgs Name;

		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		public static readonly XObjectChangeEventArgs Value;
	}
}
