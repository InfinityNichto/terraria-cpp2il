using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x200068C")]
public interface ICreativePower
{
	[Cpp2IlInjected.Token(Token = "0x1700079A")]
	ushort PowerId
	{
		[Cpp2IlInjected.Token(Token = "0x60041E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60041E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700079B")]
	string ServerConfigName
	{
		[Cpp2IlInjected.Token(Token = "0x60041E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60041EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700079C")]
	PowerPermissionLevel CurrentPermissionLevel
	{
		[Cpp2IlInjected.Token(Token = "0x60041EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60041EC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700079D")]
	PowerPermissionLevel DefaultPermissionLevel
	{
		[Cpp2IlInjected.Token(Token = "0x60041ED")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60041EE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60041EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DeserializeNetMessage(BinaryReader reader, int userId);

	[Cpp2IlInjected.Token(Token = "0x60041F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements);

	[Cpp2IlInjected.Token(Token = "0x60041F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GetIsUnlocked();
}
