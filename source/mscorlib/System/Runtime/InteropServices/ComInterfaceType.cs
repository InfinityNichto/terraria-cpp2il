using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000439")]
	[global::System.Serializable]
	public enum ComInterfaceType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40011FD")]
		InterfaceIsDual,
		[global::Cpp2ILInjected.Token(Token = "0x40011FE")]
		InterfaceIsIUnknown,
		[global::Cpp2ILInjected.Token(Token = "0x40011FF")]
		InterfaceIsIDispatch,
		[ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x4001200")]
		InterfaceIsIInspectable
	}
}
