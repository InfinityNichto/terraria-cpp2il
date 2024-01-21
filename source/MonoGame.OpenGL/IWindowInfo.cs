using System;
using Cpp2IlInjected;

namespace MonoGame.OpenGL;

[Cpp2IlInjected.Token(Token = "0x200025F")]
public interface IWindowInfo
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	IntPtr Handle
	{
		[Cpp2IlInjected.Token(Token = "0x6001168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
