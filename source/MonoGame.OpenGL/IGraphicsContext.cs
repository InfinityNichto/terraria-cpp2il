using Cpp2IlInjected;

namespace MonoGame.OpenGL;

[Cpp2IlInjected.Token(Token = "0x200025E")]
internal interface IGraphicsContext
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	int SwapInterval
	{
		[Cpp2IlInjected.Token(Token = "0x6001162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6001163")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	bool IsDisposed
	{
		[Cpp2IlInjected.Token(Token = "0x6001164")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	bool IsCurrent
	{
		[Cpp2IlInjected.Token(Token = "0x6001167")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6001165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MakeCurrent(IWindowInfo info);

	[Cpp2IlInjected.Token(Token = "0x6001166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SwapBuffers();
}
