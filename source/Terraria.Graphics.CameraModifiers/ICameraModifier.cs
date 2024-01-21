using Cpp2IlInjected;

namespace Terraria.Graphics.CameraModifiers;

[Cpp2IlInjected.Token(Token = "0x200050D")]
public interface ICameraModifier
{
	[Cpp2IlInjected.Token(Token = "0x170006F9")]
	string UniqueIdentity
	{
		[Cpp2IlInjected.Token(Token = "0x600380C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170006FA")]
	bool Finished
	{
		[Cpp2IlInjected.Token(Token = "0x600380E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600380D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Update(ref CameraInfo cameraPosition);
}
