using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A33")]
	public interface ICreativePower
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000877")]
		ushort PowerId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C9C")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6004C9D")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000878")]
		string ServerConfigName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C9E")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6004C9F")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000879")]
		PowerPermissionLevel CurrentPermissionLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004CA0")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6004CA1")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700087A")]
		PowerPermissionLevel DefaultPermissionLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004CA2")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6004CA3")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004CA4")]
		void DeserializeNetMessage(BinaryReader reader, int userId);

		[global::Cpp2ILInjected.Token(Token = "0x6004CA5")]
		void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements);

		[global::Cpp2ILInjected.Token(Token = "0x6004CA6")]
		bool GetIsUnlocked();
	}
}
